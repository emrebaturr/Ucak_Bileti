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
    public class CustomerManager : ICustomerService
    {
        private ICustomerRepository _customerRepository;
        public CustomerManager(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<Customer> CreateCustomer(Customer customer)
        {
            return await _customerRepository.CreateCustomer(customer);
        }

        public async Task DeleteCustomer(int Id)
        {
            await _customerRepository.DeleteCustomer(Id);
        }

        public List<Customer> GetAllCustomer()
        {
            return _customerRepository.GetAllCustomer();
        }

        public async Task<Customer> GetCustomerById(int Id)
        {
            return await _customerRepository.GetCustomerById(Id);
        }

        public async Task<Customer> UpdateCustomer(Customer customer)
        {
            return await _customerRepository.UpdateCustomer(customer);
        }
    }
}
