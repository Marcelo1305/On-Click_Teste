using OnClickTeste.Domain.Responses;

namespace OnClickTeste.Domain.Interfaces
{
    public interface IMercadoLivreService
    {
        Task<ProdutoMercadoLivreResponse?> ListarProdutos();
    }
}
