using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Music_Store.Models;
using Music_Store.ViewModels.MusiciansViewModel;

namespace Music_Store.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-DKIEF04\\SQLEXPRESS;Database=Music_Store;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MusicianMusic>().HasKey(pt => new { pt.ID, pt.MusicianID });

            modelBuilder.Entity<MusicianMusic>().
                HasOne(pt => pt.Music).WithMany(pt => pt.MusiciansMusics).HasForeignKey(p => p.ID);
            modelBuilder.Entity<MusicianMusic>().
                HasOne(pt => pt.Musician).WithMany(pt => pt.MusiciansMusics).HasForeignKey(p => p.MusicianID);
        }

        public DbSet<Music> Music { get; set; }
        public DbSet<Musician> Musician { get; set; }
        public DbSet<MusicianMusic> MusicianMusic { get; set; }
        public DbSet<MusicianViewModel> MusicianViewModel { get; set; }
        public DbSet<Music_Store.ViewModels.MusiciansViewModel.CreateMusicianViewModel> CreateMusicianViewModel { get; set; }
    }
}
