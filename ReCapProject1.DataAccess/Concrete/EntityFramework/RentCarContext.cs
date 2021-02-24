using Microsoft.EntityFrameworkCore;
using ReCapProject1.Entities;
using ReCapProject1.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject1.DataAccess.Concrete.EntityFramework
{
    public class RentCarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database = RentCar;Trusted_Connection = true");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Rentals> Rentals { get; set; }
        public DbSet<Customers> Customers { get; set; }
    }
}
