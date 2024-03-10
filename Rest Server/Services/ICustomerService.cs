using Rest_Server.Models;
using System.Collections.Generic;

namespace Rest_Server.Services
{
    public interface ICustomerService
    {
        void AddCustomers(List<Customer> customers);
        List<Customer> GetCustomers();
    }
}
