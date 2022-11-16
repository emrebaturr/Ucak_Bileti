using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakBileti.Data.Abstract;
using UcakBileti.Entity;

namespace UcakBileti.Data.Concrete
{
    public class CustomerRepository : ICustomerRepository
    {
        public List<Customer> GetAllCustomer()
        {
            using (var flightDbContext = new FlightDbContext())
            {
                return flightDbContext.Customers.ToList();
            }
        }

        public async Task<Customer> GetCustomerById(int Id)
        {
            using (var flightDbContext = new FlightDbContext())
            {
                return await flightDbContext.Customers.FindAsync(Id);
            }
        }

        public async Task<Customer> CreateCustomer(Customer customer)
        {
            using (var flightDbContext = new FlightDbContext())
            {
                flightDbContext.Customers.Add(customer);
                await flightDbContext.SaveChangesAsync();
                return customer;
            }
        }

        public async Task<Customer> UpdateCustomer(Customer customer)
        {
            using (var flightDbContext = new FlightDbContext())
            {
                flightDbContext.Customers.Update(customer);
                await flightDbContext.SaveChangesAsync();
                return customer;
            }
        }

        public async Task DeleteCustomer(int Id)
        {
            using (var flightDbContext = new FlightDbContext())
            {
                var customer = await GetCustomerById(Id);
                flightDbContext.Customers.Remove(customer);
                await flightDbContext.SaveChangesAsync();
            }
        }
    }
}
