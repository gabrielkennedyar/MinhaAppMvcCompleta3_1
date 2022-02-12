using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;
using MinhaApp.Business.Interfaces;
using MinhaApp.Business.Notificacoes;
using MinhaApp.Business.Services;
using MinhaApp.Data.Context;
using MinhaApp.Data.Repository;
using MinhaApp.Site.Extensions;

namespace MinhaApp.Site.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolverDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();


            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddSingleton<IValidationAttributeAdapterProvider, MoedaValidationAttributeAdapterProvider>();

            return services;
        }
    }
}
