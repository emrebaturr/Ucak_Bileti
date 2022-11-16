using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakBileti.Entity;

namespace UcakBileti.Business.Abstract
{
    public interface IFlightDetailService
    {
        List<FlightDetail> GetAllFlightDetail();
        Task<FlightDetail> GetFlightDetailById(int Id);
        Task<FlightDetail> CreateFlightDetail(FlightDetail flightDetail);
        Task<FlightDetail> UpdateFlightDetail(FlightDetail flightDetail);
        Task DeleteFlightDetail(int Id);
        List<FlightDetail> GetFlightDetailByCustomerId(int CustomerId);
        List<FlightDetail> GetFlightDetailByFlightId(int FlightId);
    }
}
