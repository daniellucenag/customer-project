using System;
using System.Collections.Generic;

namespace CustomerProject.Core.Component.Customer
{
    public interface ICustomerServices
    {
        Customer Save(Customer customer);
        Dictionary<string, Customer> Get();
    }
}
