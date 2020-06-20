using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Models
{
    public class ArtistDbContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Event> Events { get; set; }

        public DbSet<Artist_Event> ArtistsEvents { get; set; }
        public DbSet<Event_Organizer> EventOrganizers { get; set; }

        public ArtistDbContext()
        {

        }

        public ArtistDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Artist_Event>()
                    .HasKey(z => new { z.IdArtist, z.IdEvent });

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Event_Organizer>()
                    .HasKey(z => new { z.IdEvent, z.IdOrganizer });
        }
    }
}
