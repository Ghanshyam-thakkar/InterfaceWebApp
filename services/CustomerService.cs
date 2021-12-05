using InterfaceWebApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceWebApp.services
{
    public class CustomerService : ICustomer
    {
        private List<Customer> lstCustomer;

        public CustomerService()
        {
            lstCustomer = new List<Customer>();

            Customer customer = new Customer();
            customer.FirstName = "Ghanshyam";
            customer.LastName = "Thakkar";
            customer.Email = "ghanshyam.skipper@gmail.com";
            lstCustomer.Add(customer);

            customer = new Customer();
            customer.FirstName = "Prasant";
            customer.LastName = "Patel";
            customer.Email = "parashant.patel@gmail.com";
            lstCustomer.Add(customer);

            customer = new Customer();
            customer.FirstName = "Vishal";
            customer.LastName = "Yadav";
            customer.Email = "vishal.yadav@gmail.com";
            lstCustomer.Add(customer);

            customer = new Customer();
            customer.FirstName = "Gaurav";
            customer.LastName = "Patil";
            customer.Email = "gaurav.patil@gmail.com";
            lstCustomer.Add(customer);

            customer = new Customer();
            customer.FirstName = "Nilesh";
            customer.LastName = "Patil";
            customer.Email = "nilesh.patil@gmail.com";
            lstCustomer.Add(customer);

        }

        public List<Customer> GetAllCustomers()
        {
            return lstCustomer.ToList();
        }

        public List<Customer> GetCustomersByEmail(string email)
        {
            var result = lstCustomer.Where(cust => cust.Email.Contains(email)).ToList();
            return result;
        }

        public List<Customer> GetCustomersByName(string customerName)
        {
            var result = lstCustomer.Where(cust => cust.FirstName.Contains(customerName) || cust.LastName.Contains(customerName)).ToList();
            return result;
        }
    }
}
