using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using backendproject.Configuration;
using backendproject.Models;

namespace backendproject.DataContext
{
    public interface IMediaContext
    {
        DbSet<Media> Medias { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Entry> Entries { get; set; }
        DbSet<Actor> Actors { get; set; }
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }

    public class MediaContext : DbContext, IMediaContext
    {
        public DbSet<Media> Medias { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<Actor> Actors { get; set; }

        private ConnectionStrings _connectionStrings;

        public MediaContext(DbContextOptions<MediaContext> options, IOptions<ConnectionStrings> connectionStrings) : base(options)
        {
            _connectionStrings = connectionStrings.Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddDebug()));
            options.UseSqlServer(_connectionStrings.SQL);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entry>().HasKey(e => new { e.UserId, e.MediaId });

            modelBuilder.Entity<User>().HasData(new User()
            {
                UserId = Guid.NewGuid(),
                Name = "Bob",
                Email = "bob@email.com",
                Password = "1234",
                IsAdmin = false,
            });

            modelBuilder.Entity<Actor>().HasData(new Actor()
            {
                ActorId = Guid.NewGuid(),
                Name = "Rainn Wilson"
            });

            modelBuilder.Entity<Media>().HasData(new Media()
            {
                MediaId = Guid.NewGuid(),
                Name = "Shrek",
                Type = "Movie",
                Episodes = 1,
                Length = 90,
                ReleaseDate = new DateTime(2001, 4, 22)
            });

            modelBuilder.Entity<Media>().HasData(new Media()
            {
                MediaId = Guid.NewGuid(),
                Name = "The Office",
                Type = "Series",
                Episodes = 6,
                Length = 20,
                ReleaseDate = new DateTime(2005, 4, 22),
            });
        }
    }
}
