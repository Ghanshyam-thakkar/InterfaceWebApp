using InterfaceWebApp.models;
using InterfaceWebApp.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceWebApp.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class CustomerController : ControllerBase
    {
        private ICustomer _customer;
        public CustomerController(ICustomer customer)
        {
            _customer = customer;
        }

        [HttpGet]
        public List<Customer> GetAllCustomers()
        {
            return _customer.GetAllCustomers();
        }
        [HttpGet]
        public List<Customer> GetCustomerByName(string customerName)
        {
            return _customer.GetCustomersByName(customerName);
        }
        [HttpGet]
        public List<Customer> GetCustomerByEmail(string email)
        {
            return _customer.GetCustomersByEmail(email);
        }
        
    }
}
