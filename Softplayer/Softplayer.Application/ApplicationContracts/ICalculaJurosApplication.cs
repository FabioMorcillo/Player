using Softplayer.Application.ViewModels;

namespace Softplayer.Application.ApplicationContracts
{
    public interface ICalculaJurosApplication
    {
        double Calcular(CalculaJurosViewModel viewModel);
    }
}
