using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakBileti.Entity;

namespace UcakBileti.Data.Abstract
{
    public interface IFlightRepository
    {
        List<Flight> GetAllFlight();
        Task<Flight> GetFlightById(int Id);
        Task<Flight> CreateFlight(Flight Flight);
        Task<Flight> UpdateFlight(Flight Flight);
        Task DeleteFlight(int Id);
        List<Flight> GetFlightOneDirection(DateTime DepartureDate,string WhereFrom,string ToWhere);
    }
}
