using M20240408.EntidadesDeNegocio;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M20240408.LogicaDeNegocio
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddBLDependecies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddBLDependecies(configuration);
            services.AddScoped<PersonaMBL>();
            return services;
        }
    }
}
