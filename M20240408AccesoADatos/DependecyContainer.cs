using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace M20240408AccesoADatos
{
    public static class DependecyContainer
    {
        public static IServiceCollection AddDalDependecies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("conn")));
            services.AddScoped<PersonaMDAL>();
            return services;
        }
    }
}
