using MovieScore;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text;
using MovieScore.Models;
using MovieScore;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MSContext>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
    builder =>
    {
        builder
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();
app.UseCors("AllowAllOrigins");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/Reset", () =>
{
    using(DbContext movies = new MSContext())
    {
        movies.Database.EnsureDeleted();
        movies.Database.EnsureCreated();

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        using (StreamReader r = new StreamReader("movieData.json"))  
        {  
            string? json = r.ReadToEnd();  
            List<Movie>? source = JsonSerializer.Deserialize<List<Movie>>(json, options); 
            foreach(var item in source)
            {
                movies.Add<Movie>(item);  
            }
            
        }  
        movies.SaveChanges();
        movies.Database.ExecuteSqlRaw("PRAGMA wal_checkpoint;"); 
    }

    using(DbContext users = new UsersContext())
    {
        users.Database.EnsureDeleted();
        users.Database.EnsureCreated();

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        using (StreamReader r = new StreamReader("userData.json"))  
        {  
            string? json = r.ReadToEnd();  
            List<PrivateUsers>? source = JsonSerializer.Deserialize<List<PrivateUsers>>(json, options); 
            foreach(var item in source)
            {
                users.Add<PrivateUsers>(item);  
            }
            
        }  
        users.SaveChanges();
        users.Database.ExecuteSqlRaw("PRAGMA wal_checkpoint;");  
    }

})
.WithName("Reset Data")
.WithOpenApi();

app.MapGet("/movies", () =>
{
    var options = new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    };
    using(MSContext movie = new MSContext())
    {          
        // List<Movie>? source = movie.Movies
        //                            .Where(m => m.Tag.ToLower() == tag.ToLower()) 
        //                            .ToList();
        List<Movie>? source = movie.Movies.ToList();
        return source;
    }  
})
.WithName("Get Movies")
.WithOpenApi();

app.MapGet("/movies/{id}", async (int id) =>
{
    var options = new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    };

    using (MSContext movieContext = new MSContext())
    {
        // Find the movie with the given id
        var movie = await movieContext.Movies
                                      .FirstOrDefaultAsync(m => m.Id == id);
        
        if (movie == null)
        {
            return Results.NotFound(new { message = "Movie not found" });
        }

        return Results.Ok(movie);
    }
})
.WithName("Get Movie By Id")
.WithOpenApi();


app.MapPut("/movies/rate/{id}/{newRating}", async (int id,int newRating) =>
{
    using (var movieContext = new MSContext())
    {
        // Find the movie by ID
        var movie = await movieContext.Movies.FindAsync(id);
        
        if (movie == null)
        {
            return Results.NotFound(new { message = "Movie not found" });
        }

        // Update rating and rating count (average rating calculation)
        movie.RatingCount += 1;
        movie.Rating = (movie.Rating * (movie.RatingCount - 1) + newRating) / movie.RatingCount;

        // Save changes to the database
        await movieContext.SaveChangesAsync();

        return Results.Ok(movie);  // Return the updated movie object
    }
})
.WithName("Update Movie Rating")
.WithOpenApi();




app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
