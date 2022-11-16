using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakBileti.Entity;

namespace UcakBileti.Data.Abstract
{
    public interface ICustomerRepository
    {
        List<Customer> GetAllCustomer();
        Task<Customer> GetCustomerById(int Id);
        Task<Customer> CreateCustomer(Customer customer);
        Task<Customer> UpdateCustomer(Customer customer);
        Task DeleteCustomer(int Id);
    }
}
