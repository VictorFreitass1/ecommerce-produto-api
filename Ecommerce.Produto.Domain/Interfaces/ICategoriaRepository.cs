using Ecommerce.Produto.Domain.Entities;

namespace Ecommerce.Produto.Domain.Interfaces
{
    public interface ICategoriaRepository
    {
        CategoriaEntity ObterPorId(int id);
        IEnumerable<CategoriaEntity> ObterTodos();
        CategoriaEntity Adicionar(CategoriaEntity entity);
        CategoriaEntity Editar(CategoriaEntity entity);
        CategoriaEntity Remover(CategoriaEntity entity);
    }
}
