using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakBileti.Entity;

namespace UcakBileti.Data
{
    public class FlightDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=LAPTOP-JS6T7H4D;Database=FlightDB;uid=sa;pwd=Password1");
        }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<FlightDetail> FlightDetails { get; set; }
    }
}
