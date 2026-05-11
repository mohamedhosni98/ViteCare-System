using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViteCare.Infrastructure.Presistence.Context;

namespace ViteCare.Infrastructure
{
    public static class DependecyInjections
    {
        public static IServiceCollection AddInfraStructure(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<ApplicationDbContext>(options=>
                options.UseSqlServer(configuration.GetConnectionString("defaultconnection")
                    , b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName))
            );
            return services;
        }
        
    }
}
