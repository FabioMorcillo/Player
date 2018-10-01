using Microsoft.AspNetCore.Mvc;
using Softplayer.Application.ApplicationContracts;
using Softplayer.Application.ViewModels;
using System.Text;

namespace Softplayer.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoftplayerController : ControllerBase
    {
        private readonly ICalculaJurosApplication _calculaJurosApplication;

        public SoftplayerController(
            ICalculaJurosApplication calculaJurosApplication
        )
        {
            _calculaJurosApplication = calculaJurosApplication;
        }
        
        [HttpGet("calculajuros")]
        public IActionResult CalculaJuros([FromQuery] CalculaJurosViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var valorFinal = _calculaJurosApplication.Calcular(viewModel);

                return Ok(valorFinal);
            } 
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("showmethecode")]
        public IActionResult ShowMeTheCode()
        {
            return Ok("https://github.com/FabioMorcillo/Player");
        }
    }
}