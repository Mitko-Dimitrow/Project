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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
