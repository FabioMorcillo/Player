using Microsoft.Extensions.DependencyInjection;
using Softplay.Domain.DomainContracts;
using Softplay.Domain.DomainServices;
using Softplayer.Application.ApplicationContracts;
using Softplayer.Application.ApplicationServices;

namespace Softplayer.Infrastructure.CrossCutting.IoC
{
    public class SoftplayerIoC
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services
                .AddScoped<ICalculaJurosApplication, CalculaJurosApplication>()
                .AddScoped<ICalculaJurosService, CalculaJurosService>();
        }
    }
}
