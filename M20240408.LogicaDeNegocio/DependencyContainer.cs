using M20240408.EntidadesDeNegocio;
using M20240408.LogicaDeNegocio;
using M20240408AccesoADatos;
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
            services.AddDalDependecies(configuration);
            services.AddScoped<PersonaMBL>();
            return services;
        }
    }
}
