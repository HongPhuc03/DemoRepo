using DemoModel.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DemoModel
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "John Doe",
                    Age = 30,
                    Position = "Software Engineer",
                    CompanyId =  SeedIds.Company1Id,

                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Jane Smith",
                    Age = 28,
                    Position = "Product Manager",
                    CompanyId = SeedIds.Company2Id,

                }
            );
        }
    }
}
