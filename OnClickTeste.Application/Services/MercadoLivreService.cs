using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using OnClickTeste.Domain.Interfaces;
using OnClickTeste.Domain.Responses;

namespace OnClickTeste.Application.Services
{
    public class MercadoLivreService : IMercadoLivreService
    {
        IConfiguration _config;

        public MercadoLivreService(IConfiguration config)
        {
            _config = config;
        }

        public async Task<ProdutoMercadoLivreResponse?> ListarProdutos()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(_config["UrlApiMercadoLivre"]);
            var response = await client.GetAsync("");
            var responseContent = await response.Content.ReadAsStringAsync();
            var resultado = JsonConvert.DeserializeObject<ProdutoMercadoLivreResponse>(responseContent);

            var diretorio = new DirectoryInfo(_config["CaminhoLogs"]);
            if (!diretorio.Exists)
                diretorio.Create();

            using (StreamWriter sw = new StreamWriter(diretorio.FullName + _config["NomeArquivoLog"], true))
            {
                DateTime data = new DateTime();
                data = DateTime.Now;
                sw.WriteLine("Data requisição: "+((DateTimeOffset)response.Headers.Date).ToString("dd/MM/yyyy HH:mm:ss") + " | " + "Data local: "+data+ " | " +"Status Code: "+ (int)response.StatusCode + ":" + response.StatusCode.ToString());
            }

            return resultado;
        }
    }
}
