using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnClickTeste.Mvc.Models.Responses;

namespace OnClickTeste.Mvc.Controllers
{
    public class HomeController : Controller
    {
        IConfiguration _config;
        public HomeController(IConfiguration config)
        {
            _config = config;
        }

        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(_config["UrlApi"]);
            var response = await client.GetAsync("");
            var responseContent = await response.Content.ReadAsStringAsync();
            var resultado = JsonConvert.DeserializeObject<ProdutoMercadoLivreResponse>(responseContent);
            return View(resultado);
        }
    }
}
