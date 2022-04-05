using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;
using ProvaMed.DomainModel.Interfaces.Repositories;
using ProvaMed.DomainModel.Interfaces.Services;
using ProvaMed.DomainModel.Interfaces.UoW;
using ProvaMed.DomainService;
using ProvaMed.Infra.Context;
using ProvaMed.Infra.Repository;
using ProvaMed.Infra.UoW;

namespace ProvaMed.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ProvaMedContext>();

            // Unit Of Work
            services.AddScoped<IUnitOfWork, EntityFrameworkUnitOfWork>();


            //Swagger
            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

         
            // Contato
            services.AddScoped<IContatoRepository, ContatoRepository>();
            services.AddScoped<IContatoService, ContatoService>();
            
            return services;
        }
    }
}

