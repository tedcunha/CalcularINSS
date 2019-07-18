using Lab.Data.Context;
using Lab.Data.Repositories;
using Lab.Data.UoW;
using Lab.Domain.Entities.Interfaces.Repositories;
using Lab.Domain.Entities.Interfaces.Services;
using Lab.Domain.Entities.Services;
using Lab.Domain.Interfaces.UoW;
using Microsoft.Extensions.DependencyInjection;

namespace Lab.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Infra - Data
            services.AddScoped<ITabelaINSSRepository, TabelaINSSRepository>();
            services.AddScoped<ITabelaINSSService, TabelaINSSService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<LabContext>();
        }
    }
}