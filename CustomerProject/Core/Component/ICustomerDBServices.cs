using System;
using System.Collections.Generic;
using CustomerProject.Core.Component;
using Microsoft.AspNetCore.Mvc;

namespace CustomerProject
{
    public interface ICustomerDBServices
    {
        Customer Save(Customer customer);
        List<Customer> Get();
        Customer GetById(int id);
        Customer Update(Customer customer);
        void Delete(int id);
    }
}
