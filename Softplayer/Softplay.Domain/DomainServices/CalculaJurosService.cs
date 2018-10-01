using Softplay.Domain.DomainContracts;
using System;

namespace Softplay.Domain.DomainServices
{
    public class CalculaJurosService : ICalculaJurosService
    {
        private const double _juros = 0.01;

        public double Calcular(double valorInicial, int meses)
        {
            var valorFinal = valorInicial * Math.Pow(1 + _juros, meses);

            var valorFinalSemArredondamento = Math.Truncate(valorFinal * 100) / 100;
            
            return valorFinalSemArredondamento;
        }
    }
}
