using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using ProjetoModelo.Application.Interface;
using ProjetoModelo.Application;
using ProjetoModelo.Domain.Interfaces.Repositories;
using ProjetoModelo.Infra.Data.Repository;
using ProjetoModelo.Infra.Data.Context;
using ProjetoModelo.Domain.Interfaces.Services;
using ProjetoModelo.Domain.Services;

namespace ProjetoModelo.Infra.CrossCutting.IoC
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application
            services.AddSingleton(Mapper.Configuration);
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));
            services.AddScoped<ITipoMaoObraAppService, TipoMaoObraAppService>();

            // Domain
            services.AddScoped<ITipoMaoObraService, TipoMaoObraService>();

            // Infra - Data Repository
            services.AddScoped<ITipoMaoObraRepository, TipoMaoObraRepository>();
            
            services.AddScoped<ProjetoModeloContext>();

            
        }
    }
}
