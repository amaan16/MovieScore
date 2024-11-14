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
}