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

        public DbSet<Parking> Parkings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserParking> UserParkings { get; set; }
    }
}
