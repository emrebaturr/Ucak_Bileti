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
    public class CustomerController : ControllerBase
    {
        private ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet]
        [Route("[action]")]
        public List<Customer> GetAllCustomer()
        {
            return customerService.GetAllCustomer();
        }

        [HttpGet]
        [Route("[action]/{Id}")]
        public Task<Customer> GetCustomerById(int Id)
        {
            return customerService.GetCustomerById(Id);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult> CreateCustomer([FromBody] Customer customer)
        {
            if (await customerService.GetCustomerById(customer.Id) == null)
            {
                await customerService.CreateCustomer(customer);
                return Ok();
            }
            return NotFound();
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<ActionResult> UpdateCustomer([FromBody] Customer customer)
        {
            if (await customerService.GetCustomerById(customer.Id) != null)
            {
                await customerService.UpdateCustomer(customer);
                return Ok();
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("[action]/{Id}")]
        public async Task<ActionResult> DeleteCustomer(int Id)
        {
            if (await customerService.GetCustomerById(Id) != null)
            {
                await customerService.DeleteCustomer(Id);
                return Ok();
            }
            return NotFound();
        }
    }
}
