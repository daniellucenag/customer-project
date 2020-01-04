using System.Collections.Generic;

namespace CustomerProject.Core.Component
{
    public class CustomerServices : ICustomerServices
    {
        private readonly Dictionary<string, Customer> _customer;

        public CustomerServices()
        {
            _customer = new Dictionary<string, Customer>();
        }

        public Customer Save(Customer customer)
        {
            _customer.Add(customer.Name, customer);

            return customer;
        }

        public Dictionary<string, Customer> Get()
        {
            return _customer;
        }
    }
}