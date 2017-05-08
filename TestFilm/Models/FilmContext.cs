﻿using Microsoft.EntityFrameworkCore;

namespace TestFilm.Models
{
    public class FilmContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public FilmContext(DbContextOptions<FilmContext> options)
            : base(options)
        {
        }
    }
}
