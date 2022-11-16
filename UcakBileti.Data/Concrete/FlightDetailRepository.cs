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
    public class FlightDetailRepository : IFlightDetailRepository
    {
        public List<FlightDetail> GetAllFlightDetail()
        {
            using (var flightDbContext = new FlightDbContext())
            {
                return flightDbContext.FlightDetails.ToList();
            }
        }
        public async Task<FlightDetail> GetFlightDetailById(int Id)
        {
            using (var flightDbContext = new FlightDbContext())
            {
                return await flightDbContext.FlightDetails.FindAsync(Id);
            }
        }
        public async Task<FlightDetail> CreateFlightDetail(FlightDetail flightDetail)
        {
            flightDetail.TotalPrice = flightDetail.UnitPrice * flightDetail.PassengerCount;
            using (var flightDbContext = new FlightDbContext())
            {
                flightDbContext.FlightDetails.Add(flightDetail);
                await flightDbContext.SaveChangesAsync();
                return flightDetail;
            }
        }
        public async Task<FlightDetail> UpdateFlightDetail(FlightDetail flightDetail)
        {
            using (var flightDbContext = new FlightDbContext())
            {
                flightDbContext.FlightDetails.Update(flightDetail);
                await flightDbContext.SaveChangesAsync();
                return flightDetail;
            }
        }
        public async Task DeleteFlightDetail(int Id)
        {
            using (var flightDbContext = new FlightDbContext())
            {
                var flightDetail = await GetFlightDetailById(Id);
                flightDbContext.FlightDetails.Remove(flightDetail);
                await flightDbContext.SaveChangesAsync();
            }
        }
        public List<FlightDetail> GetFlightDetailByCustomerId(int CustomerId)
        {
            using (var flightDbContext = new FlightDbContext())
            {
                return flightDbContext.FlightDetails.Where(f => f.customer.Id == CustomerId).ToList();
            }
        }
        public List<FlightDetail> GetFlightDetailByFlightId(int FlightId)
        {
            using (var flightDbContext = new FlightDbContext())
            {
                return flightDbContext.FlightDetails.Where(f => f.flight.Id == FlightId).ToList();
            }
        }
    }
}
