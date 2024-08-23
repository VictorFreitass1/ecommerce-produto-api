using Ecommerce.Produto.Domain.Dtos;

namespace Ecommerce.Produto.Domain.Interfaces
{
    public interface IProdutoApplicationService
    {
        ProdutoDto ObterProdutoPorId(int id);
        IEnumerable<ProdutoDto> ObterTodosProdutos();
        ProdutoDto AdicionarProduto(ProdutoDto entity);
        ProdutoDto EditarProduto(ProdutoDto entity);
        ProdutoDto RemoverProduto(ProdutoDto entity);
    }
}
