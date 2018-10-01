using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Softplay.Domain.DomainContracts;

namespace Softplay.Domain.Tests.DomainServices
{
    [TestFixture]
    public class CalculaJurosServiceTests
    {
        private readonly ICalculaJurosService _calculaJurosService;

        public CalculaJurosServiceTests()
        {
            var serviceCollection = new ServiceCollection();

            Softplayer.Infrastructure.CrossCutting.IoC.SoftplayerIoC.RegisterServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            _calculaJurosService = serviceProvider.GetService<ICalculaJurosService>();
        }

        [SetUp]
        public void SetUp()
        {
        }

        [TearDown]
        public void TearDown()
        {
        }

        [TestCase(100, 5, 105.10)]
        public void CalculaJuros(double valorInicial, int meses, double valorEsperado)
        {
            var valorFinal = _calculaJurosService.Calcular(valorInicial, meses);

            Assert.AreEqual(valorFinal, valorEsperado);
        }
    }
}
