using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakBileti.Entity;

namespace UcakBileti.Business.Abstract
{
    public interface IFlightService
    {
        List<Flight> GetAllFlight();
        Task<Flight> GetFlightById(int Id);
        Task<Flight> CreateFlight(Flight flight);
        Task<Flight> UpdateFlight(Flight flight);
        Task DeleteFlight(int Id);
        List<Flight> GetFlightOneDirection(DateTime DepartureDate, string WhereFrom, string ToWhere);
    }
}
