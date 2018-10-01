using Softplay.Domain.DomainContracts;
using Softplayer.Application.ApplicationContracts;
using Softplayer.Application.ViewModels;

namespace Softplayer.Application.ApplicationServices
{
    public class CalculaJurosApplication : ICalculaJurosApplication
    {
        private readonly ICalculaJurosService _calculaJurosService;

        public CalculaJurosApplication(
            ICalculaJurosService calculaJurosService
        )
        {
            _calculaJurosService = calculaJurosService;
        }

        public double Calcular(CalculaJurosViewModel viewModel)
        {
            return _calculaJurosService.Calcular(viewModel.ValorInicial, viewModel.Meses);
        }
    }
}
