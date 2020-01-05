using System.Collections.Generic;
using System.Linq;
using CustomerProject.Infrastructure.Persistence.MySQL;

namespace CustomerProject.Core.Component.Customer
{
    public class CustomerDBServices : ICustomerDBServices
    {
        private readonly ApplicationDBContext _dbContext;

        public CustomerDBServices(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Customer Save(Customer customer)
        {   
            _dbContext.Customer.Add(customer);
            _dbContext.SaveChanges();

            return customer;
        }

        public List<Customer> Get()
        {
            return _dbContext.Customer.ToList();
        }

        public Customer GetById(int id)
        {
            return _dbContext.Customer.Where(c => c.Id == id).FirstOrDefault();
        }

        public Customer Update(Customer customer)
        {
            var _customer = GetById((int)customer.Id);

            if (!_customer.Equals(null))
            {
                _customer.Name = customer.Name;
                _customer.Email = customer.Email;
                _dbContext.SaveChanges();
            }

            return customer;
        }

        public void Delete(int id)
        {
            var _customer = GetById(id);

            if (!_customer.Equals(null))
            {
                _dbContext.Customer.Remove(_customer);
                _dbContext.SaveChanges();
            }
        }
    }
}