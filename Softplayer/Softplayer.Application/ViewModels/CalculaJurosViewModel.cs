using System.ComponentModel.DataAnnotations;

namespace Softplayer.Application.ViewModels
{
    public class CalculaJurosViewModel
    {
        [Required(ErrorMessage = "Necessário informar o valor inicial.")]
        [Range(1, double.MaxValue, ErrorMessage = "Necessário informar o valor inicial.")]
        public double ValorInicial { get; set; }

        [Required(ErrorMessage = "Necessário informar a quantidade de meses.")]
        [Range(1, int.MaxValue, ErrorMessage = "Necessário informar a quantidade de meses.")]
        public int Meses { get; set; }
    }
}
