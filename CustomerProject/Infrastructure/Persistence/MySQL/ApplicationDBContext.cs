using System;
using Microsoft.EntityFrameworkCore;
namespace CustomerProject.Infrastructure.Persistence.MySQL
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options){}
    }
}
