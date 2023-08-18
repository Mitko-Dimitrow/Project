using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using Zoro.Data.Model;
using Zoro.Models;

namespace Zoro.Data
{
    public class ZoroDbContext:IdentityDbContext
    {
        public ZoroDbContext(DbContextOptions<ZoroDbContext> options)
           : base(options)
        {
        }

        public DbSet<AnimeInfo> AnimeInfo { get; set; }
        public DbSet<AnimeDetails> AnimeDetails { get; set; }
        public DbSet<GogoAnimeInnfo> GogoAnimeInnfo { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AnimeDetails>()
                .Property(ad => ad.genres)
                .HasConversion(
                genre => string.Join(',', genre),
                genreString => genreString.Split(',', StringSplitOptions.RemoveEmptyEntries));

            builder.Entity<GogoAnimeInnfo>()
                .Property(gg => gg.Genres)
                .HasConversion(
                genre => string.Join(',', genre),
                genreString => genreString.Split(',', StringSplitOptions.RemoveEmptyEntries));

            base.OnModelCreating(builder);
        }
    }
}
