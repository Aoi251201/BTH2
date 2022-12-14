using TranThanhTungBTH2.Models;
using Microsoft.EntityFrameworkCore;

namespace TranThanhTungBTH2.Data{
    public class ApplicationDbContext:DbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Person> People { get; set; }

    }
}