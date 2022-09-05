using Newtonsoft.Json;

namespace OnClickTeste.Mvc.Models.Responses
{
    public class ProdutoMercadoLivreResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("nome")]
        public string Nome { get; set; }
        [JsonProperty("preco")]
        public decimal Preco { get; set; }
        [JsonProperty("saldo")]
        public int Saldo { get; set; }
        [JsonProperty("imagens")]
        public List<ImagemProdutoMercadoLivre> Imagens { get; set; }
        [JsonProperty("atributos")]
        public List<AtributoProdutoMercadoLivre> Atributos { get; set; }
    }

    public class ImagemProdutoMercadoLivre
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class AtributoProdutoMercadoLivre
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("valor")]
        public string Valor { get; set; }
    }
}
