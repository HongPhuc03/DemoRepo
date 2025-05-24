using DemoModel.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoModel
{
    public class RepositoryContext : DbContext
    {
public RepositoryContext(DbContextOptions<RepositoryContext> options): base(options) { } 
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> companies { get; set; }
protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        }
        
    }
}
