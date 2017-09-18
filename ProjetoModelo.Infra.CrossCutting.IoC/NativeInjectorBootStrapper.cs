using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using ProjetoModelo.Application.Interface.Gestao;
using ProjetoModelo.Application.ApplicationServices.Gestao;
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
            services.AddScoped<IDisciplinaAppService, DisciplinaAppService>();
            services.AddScoped<ICommodityAppService, CommodityAppService>();

            // Domain
            services.AddScoped<ITipoMaoObraService, TipoMaoObraService>();
            services.AddScoped<IDisciplinaService, DisciplinaService>();
            services.AddScoped<ICommodityService, CommodityService>();

            // Infra - Data Repository
            services.AddScoped<ITipoMaoObraRepository, TipoMaoObraRepository>();
            services.AddScoped<IDisciplinaRepository, DisciplinaRepository>();
            services.AddScoped<ICommodityRepository, CommodityRepository>();

            services.AddScoped<ProjetoModeloContext>();

            
        }
    }
}
