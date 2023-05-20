using _3_SahibindenUygulama.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_SahibindenUygulama.Context
{
    internal class CarDbContext:DbContext
    {
        public DbSet<Car> Cars { get; set;}
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
    }
}
