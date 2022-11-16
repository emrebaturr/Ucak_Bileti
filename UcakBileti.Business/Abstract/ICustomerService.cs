using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakBileti.Entity;

namespace UcakBileti.Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomer();
        Task<Customer> GetCustomerById(int Id);
        Task<Customer> CreateCustomer(Customer customer);
        Task<Customer> UpdateCustomer(Customer customer);
        Task DeleteCustomer(int Id);
    }
}
