﻿using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class MvcMovieContext
    {
        public class MvcMovieContext : DbContext
        {
            public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
                : base(options)
            {
            }

            public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
        }
    }
}