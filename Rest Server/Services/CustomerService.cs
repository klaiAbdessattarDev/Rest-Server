using Newtonsoft.Json;
using Rest_Server.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Rest_Server.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly List<Customer> _customers;

        public CustomerService()
        {
            _customers = new List<Customer>();
            if (File.Exists("customers.json"))
            {
                string json = File.ReadAllText("customers.json");
                _customers = JsonConvert.DeserializeObject<List<Customer>>(json);
            }
        }

        public void AddCustomers(List<Customer> customers)
        {
            foreach (var customer in customers)
            {
                // Check if the customer's age is below 18
                if (customer.Age < 18)
                {
                    throw new ArgumentException("Age must be above 18.");
                }

                // Check if a customer with the same ID already exists in the list
                if (_customers.Any(c => c.Id == customer.Id))
                {
                    throw new ArgumentException("ID must be unique.");
                }


                // Find the insertion point for the new customer
                int i = _customers.BinarySearch(customer, new CustomerComparer());

                // If the insertion point is negative, make it positive
                if (i < 0)
                {
                    i = ~i;
                }

                // Insert the new customer at the correct position in the list
                _customers.Insert(i, customer);
            }

            // Serialize the updated list of customers to a JSON file
            string json = JsonConvert.SerializeObject(_customers);
            File.WriteAllText("customers.json", json);
        }

        private class CustomerComparer : IComparer<Customer>
        {
            public int Compare(Customer x, Customer y)
            {
                int lastNameComparison = x.LastName.CompareTo(y.LastName);

                if (lastNameComparison != 0)
                {
                    return lastNameComparison;
                }

                return x.FirstName.CompareTo(y.FirstName);
            }
        }

        public List<Customer> GetCustomers()
        {
            return _customers;
        }
    }
}
