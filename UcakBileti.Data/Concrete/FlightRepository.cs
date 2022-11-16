using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakBileti.Data.Abstract;
using UcakBileti.Entity;

namespace UcakBileti.Data.Concrete
{
    public class FlightRepository : IFlightRepository
    {
        public List<Flight> GetAllFlight()
        {
            using (var flightDbContext = new FlightDbContext())
            {
                return flightDbContext.Flights.ToList();
            }
        }

        public async Task<Flight> GetFlightById(int Id)
        {
            using (var flightDbContext = new FlightDbContext())
            {
                return await flightDbContext.Flights.FindAsync(Id);
            }
        }

        public async Task<Flight> CreateFlight(Flight flight)
        {
            using (var flightDbContext = new FlightDbContext())
            {
                flightDbContext.Flights.Add(flight);
                await flightDbContext.SaveChangesAsync();
                return flight;
            }
        }

        public async Task<Flight> UpdateFlight(Flight flight)
        {
            using (var flightDbContext = new FlightDbContext())
            {
                flightDbContext.Flights.Update(flight);
                await flightDbContext.SaveChangesAsync();
                return flight;
            }
        }

        public async Task DeleteFlight(int Id)
        {
            using (var flightDbContext = new FlightDbContext())
            {
                var flight = await GetFlightById(Id);
                flightDbContext.Flights.Remove(flight);
                await flightDbContext.SaveChangesAsync();
            }
        }

        public List<Flight> GetFlightOneDirection(DateTime DepartureDate, string WhereFrom, string ToWhere)
        {
            using (var flightDbContext = new FlightDbContext())
            {
                return flightDbContext.Flights.Where(u => u.DepartureDate == DepartureDate && u.WhereFrom == WhereFrom && u.ToWhere == ToWhere).ToList();
            }
        }
    }
}
