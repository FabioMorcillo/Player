namespace Softplay.Domain.DomainContracts
{
    public interface ICalculaJurosService
    {
        double Calcular(double valorInicial, int meses);
    }
}
