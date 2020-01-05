using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CustomerProject.Core.Component.Customer;

namespace CustomerProject.UserInterface.API.Rest
{
    [Route("/UserInterface/API/Rest/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerDBServices _services;

        public CustomerController(ICustomerDBServices services)
        {
            _services = services;
        }

        [HttpPost]
        public ActionResult<Customer> Post([FromBody]Customer customer)
        {
            return _services.Save(customer);
        }

        [HttpGet]
        public ActionResult<List<Customer>> Get()
        {
            return _services.Get();
        }

        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            return _services.GetById(id);
        }

        [HttpPut("{id}")]
        public ActionResult<Customer> Put(int id, [FromBody] Customer customer)
        {
            customer.Id = id;
            return _services.Update(customer);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _services.Delete(id);
            return Ok();
        } 
    }
}