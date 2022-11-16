using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakBileti.Business.Abstract;
using UcakBileti.Data.Abstract;
using UcakBileti.Entity;

namespace UcakBileti.Business.Concrete
{
    public class FlightManager : IFlightService
    {
        private IFlightRepository _flightRepository;

        public FlightManager(IFlightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }

        public List<Flight> GetAllFlight()
        {
            return _flightRepository.GetAllFlight();
        }

        public async Task<Flight> GetFlightById(int Id)
        {
            return await _flightRepository.GetFlightById(Id);
        }

        public async Task<Flight> CreateFlight(Flight flight)
        {
            return await _flightRepository.CreateFlight(flight);
        }

        public async Task<Flight> UpdateFlight(Flight flight)
        {
            return await _flightRepository.UpdateFlight(flight);
        }

        public async Task DeleteFlight(int Id)
        {
            await _flightRepository.DeleteFlight(Id);
        }

        public List<Flight> GetFlightOneDirection(DateTime DepartureDate, string WhereFrom, string ToWhere)
        {
            return _flightRepository.GetFlightOneDirection(DepartureDate, WhereFrom, ToWhere);
        }
    }
}
