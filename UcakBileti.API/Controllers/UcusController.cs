using Microsoft.AspNetCore.Mvc;
using UcakBileti.Business.Abstract;
using UcakBileti.Entity;

namespace UcakBileti.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UcusController : ControllerBase
    {
        private IUcusService ucusService;

        public UcusController(IUcusService ucusService)
        {
            this.ucusService = ucusService;
        }

        [HttpGet]
        [Route("[action]")]
        public List<Ucus> GetAll()
        {
            return ucusService.GetAll();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult> CreateUcus([FromBody] Ucus ucus)
        {
            var _ucus = await ucusService.CreateUcus(ucus);
            return CreatedAtAction("Get", new {id = ucus.Id},ucus);
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<ActionResult> UpdateUcus([FromBody] Ucus ucus)
        {
            if(await ucusService.GetUcusById(ucus.Id) != null)
            {
                await ucusService.UpdateUcus(ucus);
                return Ok(ucus);
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<ActionResult> DeleteUcus(int Id)
        {
            if(await ucusService.GetUcusById(Id) != null)
            {
                await ucusService.DeleteUcus(Id);
                return Ok();
            }
            return NotFound();
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult> GetUcusGidisDonus(Search s)
        {
            var u = await ucusService.GetUcusGidisDonus(s.GidisTarihi, s.DonusTarihi, s.Nereden, s.Nereye);
            if(u!=null)
            {
                return Ok(u);
            }
            return NotFound();
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult> GetUcusTekYon(Search s)
        {
            var u = await ucusService.GetUcusTekYon(s.GidisTarihi, s.Nereden, s.Nereye);
            if (u != null)
            {
                return Ok(u);
            }
            return NotFound();
        }
    }
}
