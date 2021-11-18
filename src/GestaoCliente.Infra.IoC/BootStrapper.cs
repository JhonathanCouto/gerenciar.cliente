using GestaoCliente.Application;
using GestaoCliente.Domain.Interfaces.Repository;
using GestaoCliente.Domain.Interfaces.Services;
using GestaoCliente.Domain.Interfaces.Servides;
using GestaoCliente.Infra.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCliente.Infra.IoC
{
    public static class BootStrapper
    {
        public static void RegisterServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IClienteService, ClienteService>();
            serviceCollection.AddTransient<IContatoService, ContatoService>();
            serviceCollection.AddTransient<IEnderecoService, EnderecoService>();

            serviceCollection.AddTransient<IClienteRepository, ClienteRepository>();
            serviceCollection.AddTransient<IContatoRepository, ContatoRepository>();
            serviceCollection.AddTransient<IEnderecoRepository, EnderecoRepository>();
        }
    }
}
