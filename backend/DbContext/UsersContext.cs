using System;
using Microsoft.EntityFrameworkCore;
using MovieScore.Models;


namespace MovieScore;

public class UsersContext : DbContext
{
    public DbSet<PrivateUsers> users { get; set; }

    public UsersContext()
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source=users.db");
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed data for PrivateUsers
        modelBuilder.Entity<PrivateUsers>().HasData(
            new PrivateUsers 
            { 
                Id = 1, 
                Username = "user1", 
                base64Creds = "dXNlcjE6cGFzc3dvcmQ=", 
                hash = "hash_of_password", 
                Password = "password1" 
            },
            new PrivateUsers 
            { 
                Id = 2, 
                Username = "user2", 
                base64Creds = "dXNlcjI6cGFzc3dvcmQ=", 
                hash = "hash_of_password", 
                Password = "password2" 
            }
        );
    }
}