using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnClickTeste.Domain.Responses
{
    public class ProdutoMercadoLivreResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("title")]
        public string Nome { get; set; }
        [JsonProperty("price")]
        public decimal Preco { get; set; }
        [JsonProperty("sold_quantity")]
        public int Saldo { get; set; }
        [JsonProperty("pictures")]
        public List<ImagemProdutoMercadoLivre> Imagens { get; set; }
        [JsonProperty("attributes")]
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
        [JsonProperty("value_name")]
        public string Valor { get; set; }
    }
}
