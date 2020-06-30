using Microsoft.EntityFrameworkCore;
using System;

namespace Acme.Data
{
    public class AcmeContext : DbContext
    {
        public AcmeContext(DbContextOptions<AcmeContext> options)
                  : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
