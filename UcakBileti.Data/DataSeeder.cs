using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakBileti.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Bogus;

namespace UcakBileti.Data
{
    public class DataSeeder
    {
        private static List<Flight> _flights;
        private static List<Customer> _customers;

        public static void SeedData()
        {
            var flightDbContext = new FlightDbContext();

            if (!flightDbContext.Flights.Any())
            {
                _flights = new Faker<Flight>()
                    .RuleFor(f => f.WhereFrom, f => f.Address.City())
                    .RuleFor(f => f.ToWhere, f => f.Address.City())
                    .RuleFor(f => f.DepartureDate, f => f.Date.Recent())
                    .RuleFor(f => f.Price, f => f.Random.Decimal(40, 250))
                    .RuleFor(f => f.Company, f => f.Company.CompanyName())
                    .RuleFor(f => f.SeatCount, f => f.Random.Int(5,40))

                    .Generate(20);
                flightDbContext.AddRange(_flights);
            }
            if (!flightDbContext.Customers.Any())
            {
                _customers = new Faker<Customer>()
                    .RuleFor(f => f.FirstName, f => f.Name.FirstName())
                    .RuleFor(f => f.LastName, f => f.Name.LastName())
                    .RuleFor(f => f.Address, f => f.Address.FullAddress())
                    .RuleFor(f => f.EmailAddress, f => f.Internet.Email())
                    .RuleFor(f => f.PhoneNumber, f => f.Phone.PhoneNumber())
                    .Generate(20);
                flightDbContext.AddRange(_customers);
            }

            flightDbContext.SaveChanges();
        }
    }
}
