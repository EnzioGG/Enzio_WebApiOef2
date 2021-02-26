using Enzio_WebApiOef2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enzio_WebApiOef2.Db
{
    public class BikeDbContext : DbContext
    {
        public DbSet<Bike> Bikes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=bikes.db");
    }
}
