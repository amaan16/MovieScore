using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using MovieScore.Models;

namespace MovieScore;

public class MSContext : DbContext
{
    public DbSet<Comments> Comments { get; set; }
    public DbSet<Movie> Movies { get; set; }

    public MSContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlite($"Data Source=msDB.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed data for PrivateUsers
        modelBuilder.Entity<Movie>().HasData(
            new Movie
            {
                Id = 1,
                Title = "My Old Ass",
                Director = "Greta Gerwig",
                Writers = "Greta Gerwig",
                Actors = "Florence Pugh, Saoirse Ronan",
                Release = DateTime.Parse("2024-09-13"),
                Description = "An 18th birthday mushroom trip brings free-spirited Elliott face-to-face with her wisecracking 39-year-old self...",
                Rating = 6.6,
                Tag = "trending",
                Type = "movie",
                Path = "/yUs4Sw9AyTg2sA1qWBkNpD2mGSj.jpg"
            },
            new Movie
            {
                Id = 2,
                Title = "Joker: Folie à Deux",
                Director = "Todd Phillips",
                Writers = "Todd Phillips, Scott Silver",
                Actors = "Joaquin Phoenix, Lady Gaga",
                Release = DateTime.Parse("2024-10-01"),
                Description = "While struggling with his dual identity, Arthur Fleck not only stumbles upon true love, but also finds the music that's always been inside him.",
                Rating = 5.651,
                Tag = "trending",
                Type = "movie",
                Path = "/if8QiqCI7WAGImKcJCfzp6VTyKA.jpg"
            },
            new Movie
            {
                Id = 3,
                Title = "Megalopolis",
                Director = "Francis Ford Coppola",
                Writers = "Francis Ford Coppola",
                Actors = "Adam Driver, Nathalie Emmanuel",
                Release = DateTime.Parse("2024-09-25"),
                Description = "Genius artist Cesar Catilina seeks to leap the City of New Rome into a utopian, idealistic future...",
                Rating = 5.6,
                Tag = "trending",
                Type = "movie",
                Path = "/8Sok3HNA3r1GHnK2lCytHyBz1A.jpg"
            },
            new Movie
            {
                Id = 4,
                Title = "The Day of the Jackal",
                Director = "Jean-Pierre Melville",
                Writers = "Frederick Forsyth",
                Actors = "Edward Fox, Michael Lonsdale",
                Release = DateTime.Parse("2024-11-07"),
                Description = "An unrivalled and highly elusive lone assassin, the Jackal, makes his living carrying out hits...",
                Rating = 7.9,
                Tag = "trending",
                Type = "tv",
                Path = "/tYLecM3WSEjlkKhkGiH5G68Dprm.jpg"
            },
            new Movie
            {
                Id = 5,
                Title = "Citadel Honey Bunny",
                Director = "Anthony Russo",
                Writers = "Josh Appelbaum, Bryan Oh",
                Actors = "Richard Madden, Priyanka Chopra",
                Release = DateTime.Parse("2024-11-06"),
                Description = "When stuntman Bunny recruits struggling actress Honey for a side gig, they are hurled into a high-stakes world...",
                Rating = 7.5,
                Tag = "trending",
                Type = "tv",
                Path = "/lzZ9J2FOsaq1DCuD7k2f4ogbXdD.jpg"
            },
            new Movie
            {
                Id = 6,
                Title = "The Wild Robot",
                Director = "Chris Sanders",
                Writers = "Peter Brown",
                Actors = "Voice of Roz, various animal voices",
                Release = DateTime.Parse("2024-09-12"),
                Description = "After a shipwreck, an intelligent robot called Roz is stranded on an uninhabited island...",
                Rating = 8.512,
                Tag = "trending",
                Type = "movie",
                Path = "/wTnV3PCVW5O92JMrFvvrRcV39RU.jpg"
            },
            new Movie
            {
                Id = 7,
                Title = "Arcane",
                Director = "John Doe",
                Release = DateTime.Parse("2021-11-06"),
                Description = "Amid the stark discord of twin cities Piltover and Zaun, two sisters fight on rival sides of a war between magic technologies and clashing convictions.",
                Writers = "Jane Smith",
                Actors = "Alex Johnson, Emma Williams",
                Rating = 8.8,
                Tag = "trending",
                Type = "tv",
                Path = "/abf8tHznhSvl9BAElD2cQeRr7do.jpg"
            },
    new Movie
    {
        Id = 8,
        Title = "The Substance",
        Director = "Michael Brown",
        Release = DateTime.Parse("2024-09-07"),
        Description = "A fading celebrity decides to use a black market drug, a cell-replicating substance that temporarily creates a younger, better version of herself.",
        Writers = "Linda Green",
        Actors = "John Smith, Lucy Lee",
        Rating = 7.295,
        Tag = "trending",
        Type = "movie",
        Path = "/lqoMzCcZYEFK729d6qzt349fB4o.jpg"
    },
    new Movie
    {
        Id = 9,
        Title = "The Penguin",
        Director = "Alice Cooper",
        Release = DateTime.Parse("2024-09-19"),
        Description = "With the city in peril following the seawall's collapse, Oswald \"Oz\" Cobb’s quest seeks to fill the power vacuum left by the death of Carmine Falcone and finally give his mother Francis the life he's always promised. But first, Oz must confront his enemies and his own demoralizing reputation as \"the Penguin.\"",
        Writers = "Martin King",
        Actors = "David Harris, Rachel Adams",
        Rating = 8.5,
        Tag = "trending",
        Type = "tv",
        Path = "/vOWcqC4oDQws1doDWLO7d3dh5qc.jpg"
    },
    new Movie
    {
        Id = 10,
        Title = "Red One",
        Director = "Robert Black",
        Release = DateTime.Parse("2024-10-31"),
        Description = "After Santa Claus (codename: Red One) is kidnapped, the North Pole's Head of Security must team up with the world's most infamous bounty hunter in a globe-trotting, action-packed mission to save Christmas.",
        Writers = "Chris White",
        Actors = "Tom Green, Olivia Brown",
        Rating = 6.6,
        Tag = "trending",
        Type = "movie",
        Path = "/cdqLnri3NEGcmfnqwk2TSIYtddg.jpg"
    },
    new Movie
    {
        Id = 11,
        Title = "Venom: The Last Dance",
        Director = "Tim Scott",
        Release = DateTime.Parse("2024-10-22"),
        Description = "Eddie and Venom are on the run. Hunted by both of their worlds and with the net closing in, the duo are forced into a devastating decision that will bring the curtains down on Venom and Eddie's last dance.",
        Writers = "David White",
        Actors = "Tom Hardy, Michelle Williams",
        Rating = 6.5,
        Tag = "action",
        Type = "movie",
        Path = "/aosm8NMQ3UyoBVpSxyimorCQykC.jpg"
    },
new Movie
{
    Id = 12,
    Title = "Apocalypse Z: The Beginning of the End",
    Director = "Carlos Muñoz",
    Release = DateTime.Parse("2024-10-04"),
    Description = "When a kind of rabies that transforms people into aggressive creatures spreads across the planet, Manel isolates himself at home with his cat, relying on his wits to survive; but soon they must go out in search of food, by land and by sea, dodging many dangers.",
    Writers = "Luis Hernández",
    Actors = "Raúl Jiménez, Ana María Rivas",
    Rating = 6.9,
    Tag = "action",
    Type = "movie",
    Path = "/wIGJnIFQlESkC2rLpfA8EDHqk4g.jpg"
},
new Movie
{
    Id = 13,
    Title = "Deadpool & Wolverine",
    Director = "David Leitch",
    Release = DateTime.Parse("2024-07-24"),
    Description = "A listless Wade Wilson toils away in civilian life with his days as the morally flexible mercenary, Deadpool, behind him. But when his homeworld faces an existential threat, Wade must reluctantly suit-up again with an even more reluctant Wolverine.",
    Writers = "Rhett Reese, Paul Wernick",
    Actors = "Ryan Reynolds, Hugh Jackman",
    Rating = 7.7,
    Tag = "action",
    Type = "movie",
    Path = "/8cdWjvZQUExUUTzyp4t6EDMubfO.jpg"
},
new Movie
{
    Id = 14,
    Title = "Arcadian",
    Director = "Mark Johnson",
    Release = DateTime.Parse("2024-04-12"),
    Description = "In the near future, on a decimated Earth, Paul and his twin sons face terror at night when ferocious creatures awaken. When Paul is nearly killed, the boys come up with a plan for survival, using everything their father taught them to keep him alive.",
    Writers = "Chris Davis",
    Actors = "Ethan Hawke, Jack Dylan Grazer",
    Rating = 6.0,
    Tag = "action",
    Type = "movie",
    Path = "/spWV1eRzlDxvai8LbxwAWR0Vst4.jpg"
},
new Movie
{
    Id = 16,
    Title = "Red One",
    Director = "Jake Kasdan",
    Release = DateTime.Parse("2024-10-31"),
    Description = "After Santa Claus (codename: Red One) is kidnapped, the North Pole's Head of Security must team up with the world's most infamous bounty hunter in a globe-trotting, action-packed mission to save Christmas.",
    Writers = "Chris Morgan",
    Actors = "Dwayne Johnson, Chris Evans",
    Rating = 6.9,
    Tag = "action",
    Type = "movie",
    Path = "/cdqLnri3NEGcmfnqwk2TSIYtddg1.jpg"
},
new Movie
{
    Id = 17,
    Title = "The Count of Monte-Cristo",
    Director = "Kevin Reynolds",
    Release = DateTime.Parse("2024-06-28"),
    Description = "Edmond Dantes becomes the target of a sinister plot and is arrested on his wedding day for a crime he did not commit. After 14 years in the island prison of Château d’If, he manages a daring escape. Now rich beyond his dreams, he assumes the identity of the Count of Monte-Cristo and exacts his revenge on the three men who betrayed him.",
    Writers = "Alexandre Dumas",
    Actors = "Jim Caviezel, Guy Pearce",
    Rating = 8.3,
    Tag = "action",
    Type = "movie",
    Path = "/zw4kV7npGtaqvUxvJE9IdqdFsNc.jpg"
},
new Movie
{
    Id = 18,
    Title = "Venom",
    Director = "Ruben Fleischer",
    Release = DateTime.Parse("2018-09-28"),
    Description = "Investigative journalist Eddie Brock attempts a comeback following a scandal, but accidentally becomes the host of Venom, a violent, super powerful alien symbiote. Soon, he must rely on his newfound powers to protect the world from a shadowy organization looking for a symbiote of their own.",
    Writers = "Jeff Pinkner, Scott Rosenberg",
    Actors = "Tom Hardy, Michelle Williams",
    Rating = 6.8,
    Tag = "action",
    Type = "movie",
    Path = "/2uNW4WbgBXL25BAbXGLnLqX71Sw.jpg"
},
new Movie
{
    Id = 19,
    Title = "Venom: Let There Be Carnage",
    Director = "Andy Serkis",
    Release = DateTime.Parse("2021-09-30"),
    Description = "After finding a host body in investigative reporter Eddie Brock, the alien symbiote must face a new enemy, Carnage, the alter ego of serial killer Cletus Kasady.",
    Writers = "Kelly Marcel",
    Actors = "Tom Hardy, Woody Harrelson",
    Rating = 6.8,
    Tag = "action",
    Type = "movie",
    Path = "/1MJNcPZy46hIy2CmSqOeru0yr5C.jpg"
},
new Movie
{
    Id = 20,
    Title = "Despicable Me 4",
    Director = "Kyle Balda",
    Release = DateTime.Parse("2024-06-20"),
    Description = "Gru and Lucy and their girls—Margo, Edith and Agnes—welcome a new member to the Gru family, Gru Jr., who is intent on tormenting his dad. Gru also faces a new nemesis in Maxime Le Mal and his femme fatale girlfriend Valentina, forcing the family to go on the run.",
    Writers = "Matthew Fogel",
    Actors = "Steve Carell, Taraji P. Henson",
    Rating = 7.1,
    Tag = "action",
    Type = "movie",
    Path = "/wWba3TaojhK7NdycRhoQpsG0FaH.jpg"
},
new Movie
{
    Id = 21,
    Title = "Survive",
    Director = "Éric Rochant",
    Release = DateTime.Parse("2024-06-19"),
    Description = "A couple celebrates their son’s birthday in the middle of the ocean on their boat. A violent storm hits and it brings up hungry creatures from the depths and they fight for their survival.",
    Writers = "Éric Rochant",
    Actors = "Nicolas Duvauchelle, Mélanie Thierry",
    Rating = 5.0,
    Tag = "action",
    Type = "movie",
    Path = "/7fR3KxswtY8OHHZuOUB9td58CRX.jpg"
},
new Movie
{
    Id = 22,
    Title = "Take Cover",
    Director = "Tom Paton",
    Release = DateTime.Parse("2024-10-04"),
    Description = "A burned-out professional sniper finds himself trapped in an all-glass penthouse by a lethal competitor and must find a way to survive and escape with little to no cover between him and the killer.",
    Writers = "Tom Paton",
    Actors = "Sophie Turner, Matthew Goode",
    Rating = 6.6,
    Tag = "action",
    Type = "movie",
    Path = "/xNLiMNyFzKTL9PVIEulG55Hei8j.jpg"
},
new Movie
{
    Id = 23,
    Title = "Canary Black",
    Director = "Mark Williams",
    Release = DateTime.Parse("2024-10-10"),
    Description = "Top level CIA agent Avery Graves is blackmailed by terrorists into betraying her own country to save her kidnapped husband. Cut off from her team, she turns to her underworld contacts to survive and help locate the coveted intelligence that the kidnappers want.",
    Writers = "Mark Williams",
    Actors = "Jessica Chastain, John Boyega",
    Rating = 6.3,
    Tag = "action",
    Type = "movie",
    Path = "/hhiR6uUbTYYvKoACkdAIQPS5c6f.jpg"
},
new Movie
{
    Id = 24,
    Title = "Arcane",
    Director = "Not Available",
    Release = DateTime.Parse("2021-11-06"),
    Description = "Amid the stark discord of twin cities Piltover and Zaun, two sisters fight on rival sides of a war between magic technologies and clashing convictions.",
    Writers = "Not Available",
    Actors = "Not Available",
    Rating = 8.8,
    Tag = "banner",
    Type = "tv",
    Path = "/q8eejQcg1bAqImEV8jh8RtBD4uH.jpg"
},
new Movie
{
    Id = 25,
    Title = "Red One",
    Director = "Not Available",
    Release = DateTime.Parse("2024-09-07"),
    Description = "After Santa Claus (codename: Red One) is kidnapped, the North Pole's Head of Security must team up with the world's most infamous bounty hunter in a globe-trotting, action-packed mission to save Christmas.",
    Writers = "Not Available",
    Actors = "Not Available",
    Rating = 6.6,
    Tag = "banner",
    Type = "movie",
    Path = "/rOmUuQEZfPXglwFs5ELLLUDKodL.jpg"
},
new Movie
{
    Id = 26,
    Title = "The Penguin",
    Director = "Not Available",
    Release = DateTime.Parse("2024-09-19"),
    Description = "With the city in peril following the seawall's collapse, Oswald \"Oz\" Cobb’s quest seeks to fill the power vacuum left by the death of Carmine Falcone and finally give his mother Francis the life he's always promised. But first, Oz must confront his enemies and his own demoralizing reputation as \"the Penguin.\"",
    Writers = "Not Available",
    Actors = "Not Available",
    Rating = 8.5,
    Tag = "banner",
    Type = "tv",
    Path = "/qq36sU5xH581RiNEkookMQ9D7yp.jpg"
}


        );
    }

}