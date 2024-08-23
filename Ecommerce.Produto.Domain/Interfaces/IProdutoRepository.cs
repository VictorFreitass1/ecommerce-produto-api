using Ecommerce.Produto.Domain.Entities;

namespace Ecommerce.Produto.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        ProdutoEntity ObterPorId(int id);
        IEnumerable<ProdutoEntity> ObterTodos();
        ProdutoEntity Adicionar(ProdutoEntity entity);
        ProdutoEntity Editar(ProdutoEntity entity);
        ProdutoEntity Remover(ProdutoEntity entity);
    }
}
