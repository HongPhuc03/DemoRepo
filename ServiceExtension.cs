using Microsoft.EntityFrameworkCore;

namespace DemoModel
{
    public static class ServiceExtension
    {
        public static void ConfigureSqlContext(this IServiceCollection services,
IConfiguration configuration) =>
services.AddDbContext<RepositoryContext>(opts =>
opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")));
    }
}
