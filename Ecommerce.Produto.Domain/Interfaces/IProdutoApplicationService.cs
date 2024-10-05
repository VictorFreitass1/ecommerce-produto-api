using Ecommerce.Produto.Domain.Entities;
using Ecommerce.Produto.Domain.Interfaces.Dtos;

namespace Ecommerce.Produto.Domain.Interfaces
{
    public interface IProdutoApplicationService
    {
        IEnumerable<ProdutoEntity> ObterTodosProdutos();
        ProdutoEntity? ObterProdutoPorId(int id);
        ProdutoEntity? SalvarDadosProduto(IProdutoDto entity);
        ProdutoEntity? EditarDadosProduto(int id, IProdutoDto entity);
        ProdutoEntity? DeletarDadosProduto(int id);
    }
}