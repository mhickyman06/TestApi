using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Model;

namespace TestApi.Data
{
    public class TestApiDbContext : DbContext
    {
        public TestApiDbContext(DbContextOptions<TestApiDbContext> options):base(options)
        {

        }
        public DbSet<Employee>  Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
