using System;
using Microsoft.EntityFrameworkCore;

namespace CustomerProject.Core.Component
{
    public class Customer
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}