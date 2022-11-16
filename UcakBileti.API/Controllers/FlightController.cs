using Microsoft.AspNetCore.Mvc;
using UcakBileti.Business.Abstract;
using UcakBileti.Entity;

namespace UcakBileti.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private IFlightService flightService;

        public FlightController(IFlightService flightService)
        {
            this.flightService = flightService;
        }

        [HttpGet]
        [Route("[action]/{Id}")]
        public Task<Flight> GetFlightById(int Id)
        {
            var f = flightService.GetFlightById(Id);
            return f;
        }

        [HttpGet]
        [Route("[action]")]
        public List<Flight> GetAllFlight()
        {
            var f = flightService.GetAllFlight();
            return f;
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult> CreateFlight(Flight flight)
        {
            var _ucus = await flightService.CreateFlight(flight);
            return Ok();
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<ActionResult> UpdateFlight([FromBody]Flight flight)
        {
            if(await flightService.GetFlightById(flight.Id) != null)
            {
                await flightService.UpdateFlight(flight);
                return Ok();
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("[action]/{Id}")]
        public async Task<ActionResult> DeleteFlight(int Id)
        {
            if(await flightService.GetFlightById(Id) != null)
            {
                await flightService.DeleteFlight(Id);
                return Ok();
            }
            return NotFound();
        }

        [HttpGet]
        [Route("[action]")]
        public List<Flight> GetFlightOneDirection(DateTime DepartureDate, string WhereFrom, string ToWhere)
        {
            return flightService.GetFlightOneDirection(DepartureDate, WhereFrom, ToWhere);
        }
    }
}
