using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyFavouriteMovies.Models;

namespace MyFavouriteMovies.Data
{
    public class TvShowsContext : DbContext
    {
        public TvShowsContext (DbContextOptions<TvShowsContext> options)
            : base(options)
        {
        }

        public DbSet<TvShow> TvShow { get; set; }
    }
}
