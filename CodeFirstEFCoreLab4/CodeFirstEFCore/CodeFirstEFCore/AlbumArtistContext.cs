using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstEFCore
{
    public class AlbumArtistContext : DbContext
    {

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }

        public DbSet<AlbumArtist> AlbumArtists { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\ProjectsV13;Database=CodeFirstEFCore;Trusted_Connection=True");
            //ChangeTracker.LazyLoadingEnabled = false;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasKey(A => A.AlbumId);
            modelBuilder.Entity<Artist>().HasKey(A => A.ArtistId);
            modelBuilder.Entity<AlbumArtist>().HasKey(aa => new { aa.ArtistId, aa.AlbumId });
            modelBuilder.Entity<AlbumArtist>()
                .HasOne(aa => aa.CorrespondentAlbum)
                .WithMany(a => a.Relations)
                .HasForeignKey(aa => aa.AlbumId);
            modelBuilder.Entity<AlbumArtist>()
                .HasOne(aa => aa.CorrespondentArtist)
                .WithMany(a => a.Relations)
                .HasForeignKey(aa => aa.ArtistId);
        }
    }
}
