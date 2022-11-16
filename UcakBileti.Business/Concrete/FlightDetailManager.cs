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
    public class FlightDetailManager : IFlightDetailService
    {
        private  IFlightDetailRepository flightDetailRepository;
        public FlightDetailManager(IFlightDetailRepository flightDetailRepository)
        {
            this.flightDetailRepository = flightDetailRepository;
        }
        public async Task<FlightDetail> CreateFlightDetail(FlightDetail flightDetail)
        {
            return await flightDetailRepository.CreateFlightDetail(flightDetail);
        }

        public async Task DeleteFlightDetail(int Id)
        {
            await flightDetailRepository.DeleteFlightDetail(Id);
        }

        public List<FlightDetail> GetAllFlightDetail()
        {
            return  flightDetailRepository.GetAllFlightDetail();
        }

        public List<FlightDetail> GetFlightDetailByCustomerId(int CustomerId)
        {
            return flightDetailRepository.GetFlightDetailByCustomerId(CustomerId);
        }

        public List<FlightDetail> GetFlightDetailByFlightId(int FlightId)
        {
            return flightDetailRepository.GetFlightDetailByFlightId(FlightId);
        }

        public async Task<FlightDetail> GetFlightDetailById(int Id)
        {
            return await flightDetailRepository.GetFlightDetailById(Id);
        }

        public async Task<FlightDetail> UpdateFlightDetail(FlightDetail flightDetail)
        {
            return await flightDetailRepository.UpdateFlightDetail(flightDetail);
        }
    }
}
