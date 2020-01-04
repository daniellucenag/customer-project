using System;
using System.Collections.Generic;

namespace CustomerProject.Core.Component
{
    public interface ICustomerServices
    {
        Customer Save(Customer customer);
        Dictionary<string, Customer> Get();
    }
}
