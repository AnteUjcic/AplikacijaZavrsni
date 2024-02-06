using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServisAplikacija.Models;

namespace AplikacijaZavrsni2
{
    public class MechanicContext : DbContext
    {
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<LoginInfo> LoginInfos { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Service> Services { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string workingDirectory = Environment.CurrentDirectory;
           string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            string databasePath = Path.Combine(projectDirectory, "MechanicDB.db");

            optionsBuilder.UseSqlite($"Data Source={databasePath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Worker>()
                .HasKey(w => w.OIB);

            modelBuilder.Entity<Vehicle>()
                .HasKey(v => v.IDVehicle);


            modelBuilder.Entity<LoginInfo>()
            .HasKey(li => new { li.OIB, li.IDLogin});
            
            
            modelBuilder.Entity<Worker>()
                .HasOne(li => li.LoginInfo)
                .WithOne(w=>w.Worker)
                .HasForeignKey<LoginInfo>(li => li.OIB)
                .IsRequired();

            modelBuilder.Entity<Service>(entity =>
            {

                entity.HasKey(s => new { s.OIB, s.IDVehicle });
                entity.HasOne(w => w.Worker)
                    .WithMany(v => v.Services)
                    .HasForeignKey(d => d.OIB)
                    .OnDelete(DeleteBehavior.ClientSetNull);
                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.IDVehicle)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Service>()
                    .HasOne(s => s.Vehicle)
                    .WithMany(v => v.Services)
                    .OnDelete(DeleteBehavior.Cascade);


            base.OnModelCreating(modelBuilder);
        }
    }
      


   

}
