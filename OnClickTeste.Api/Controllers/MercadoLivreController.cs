using Microsoft.AspNetCore.Mvc;
using OnClickTeste.Domain.Interfaces;

namespace OnClickTeste.Api.Controllers
{
    [Route("api/mercadolivre")]
    public class MercadoLivreController : Controller
    {
        private IMercadoLivreService _mercadoLivreService;
        public MercadoLivreController(IMercadoLivreService mercadoLivreService)
        {
            _mercadoLivreService = mercadoLivreService;
        }

        [Route(""),  HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _mercadoLivreService.ListarProdutos());
        }
    }
}
