using Ecommerce.Produto.Domain.Dtos;

namespace Ecommerce.Produto.Domain.Interfaces
{
    public interface ICategoriaApplicationService
    {
        CategoriaDto ObterCategoriaPorId(int id);
        IEnumerable<CategoriaDto> ObterTodasCategorias();
        CategoriaDto AdicionarCategoria(CategoriaDto entity);
        CategoriaDto EditarCategoria(CategoriaDto entity);
        CategoriaDto RemoverCategoria(CategoriaDto entity);
    }
}
