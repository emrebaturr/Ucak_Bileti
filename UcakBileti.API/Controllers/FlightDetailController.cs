using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UcakBileti.Business.Abstract;
using UcakBileti.Data;
using UcakBileti.Entity;

namespace UcakBileti.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightDetailController : ControllerBase
    {
        private IFlightDetailService flightDetailService;

        public FlightDetailController(IFlightDetailService flightDetailService)
        {
            this.flightDetailService = flightDetailService;
        }

        [HttpGet]
        public List<FlightDetail> GetAllFlightDetail()
        {
            return flightDetailService.GetAllFlightDetail();
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<FlightDetail> GetFlightDetailById(int Id)
        {
            return await flightDetailService.GetFlightDetailById(Id);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult> CreateFlightDetail([FromBody] FlightDetail flightDetail)
        {
            if (await flightDetailService.GetFlightDetailById(flightDetail.Id) == null)
            {
                await flightDetailService.CreateFlightDetail(flightDetail);
                return Ok();
            }
            return NotFound();
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<ActionResult> UpdateFlightDetail([FromBody] FlightDetail flightDetail)
        {
            if (await flightDetailService.GetFlightDetailById(flightDetail.Id) != null)
            {
                await flightDetailService.UpdateFlightDetail(flightDetail);
                return Ok();
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task DeleteFlightDetail(int Id)
        {
            if (await flightDetailService.GetFlightDetailById(Id) != null)
            {
                await flightDetailService.DeleteFlightDetail(Id);
            }
        }

        [HttpGet]
        [Route("[action]")]
        public List<FlightDetail> GetFlightDetailByCustomerId(int CustomerId)
        {
            return flightDetailService.GetFlightDetailByCustomerId(CustomerId);
        }

        [HttpGet]
        [Route("[action]")]
        public List<FlightDetail> GetFlightDetailByFlightId(int FlightId)
        {
            return flightDetailService.GetFlightDetailByFlightId(FlightId);
        }





        // GET: api/FlightDetail/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<FlightDetail>> GetFlightDetail(int id)
        //{
        //    var flightDetail = await _context.FlightDetails.FindAsync(id);

        //    if (flightDetail == null)
        //    {
        //        return NotFound();
        //    }

        //    return flightDetail;
        //}

        //// PUT: api/FlightDetail/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutFlightDetail(int id, FlightDetail flightDetail)
        //{
        //    if (id != flightDetail.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(flightDetail).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!FlightDetailExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/FlightDetail
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<FlightDetail>> PostFlightDetail(FlightDetail flightDetail)
        //{
        //    _context.FlightDetails.Add(flightDetail);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetFlightDetail", new { id = flightDetail.Id }, flightDetail);
        //}

        //// DELETE: api/FlightDetail/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteFlightDetail(int id)
        //{
        //    var flightDetail = await _context.FlightDetails.FindAsync(id);
        //    if (flightDetail == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.FlightDetails.Remove(flightDetail);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool FlightDetailExists(int id)
        //{
        //    return _context.FlightDetails.Any(e => e.Id == id);
        //}


        // GET: api/FlightDetail
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<FlightDetail>>> GetFlightDetails()
        //{
        //    return await _context.FlightDetails.ToListAsync();
        //}
    }
}
