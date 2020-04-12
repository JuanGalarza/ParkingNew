using Microsoft.EntityFrameworkCore;
using ParkingNew.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingNew.Web.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Parking> Parkings { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ClientParking> ClientParkings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ClientParking>()
                .HasKey(t => new { t.Id_Parking, t.Id_Client });

            modelBuilder.Entity<ClientParking>()
               .HasOne(pt => pt.Client)
               .WithMany(p => p.ClientParkings)
               .HasForeignKey(pt => pt.Id_Client);

            modelBuilder.Entity<ClientParking>()
               .HasOne(pt => pt.Parking)
               .WithMany(p => p.ClientParkings)
               .HasForeignKey(pt => pt.Id_Parking);
        }
    }
}
