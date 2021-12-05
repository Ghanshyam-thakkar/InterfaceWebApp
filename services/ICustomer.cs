using InterfaceWebApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceWebApp.services
{
    public interface ICustomer
    {
        public List<Customer> GetAllCustomers();

        public List<Customer> GetCustomersByName(string customerName);

        public List<Customer> GetCustomersByEmail(string email);

    }
}
