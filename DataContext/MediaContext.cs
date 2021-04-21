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
    public class MediaContext : DbContext
    {
        public DbSet<Media> Medias { get; set; }
        // public DbSet<User> Users { get; set; }
        private ConnectionStrings _connectionStrings;

        public MediaContext(DbContextOptions<MediaContext> options, IOptions<ConnectionStrings> connectionStrings)
        {
            _connectionStrings = connectionStrings.Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_connectionStrings.SQL);
        }
    }
}
