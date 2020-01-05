using System;
using CustomerProject.Core.Component.Customer;
using Microsoft.EntityFrameworkCore;
namespace CustomerProject.Infrastructure.Persistence.MySQL
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options){}
    }
}
