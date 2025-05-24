using DemoModel.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DemoModel
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
                new Company
                {
                    Id = SeedIds.Company1Id,
                    Name = "ABC Corp",
                    Address = "123 Main St",
                    Country = "USA"
                },
                new Company
                {
                    Id = SeedIds.Company2Id,
                    Name = "XYZ Ltd",
                    Address = "456 Market St",
                    Country = "UK"
                }
            );
        }
    } 
}
