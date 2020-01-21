using Generico.Business.Interfaces;
using Generico.Data.Context;
using Generico.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAvaliacoes.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            //configurando o referência do IRepository com o Data Repository (Injeção de dependência)
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IAvaliacaoRepository, AvaliacaoRepository>();
            services.AddScoped<ICidadeRepository, CidadeRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IEstadoRepository, EstadoRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            return services;
        }

    }
}
