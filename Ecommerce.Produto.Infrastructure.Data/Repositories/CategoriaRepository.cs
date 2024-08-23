using Ecommerce.Produto.Domain.Entities;
using Ecommerce.Produto.Domain.Interfaces;
using Ecommerce.Produto.Infrastructure.Data.AppContext;

namespace Ecommerce.Produto.Infrastructure.Data.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly ApplicationContext _context;

        public CategoriaRepository(ApplicationContext context)
        {
            _context = context;
        }

        public CategoriaEntity Adicionar(CategoriaEntity entity)
        {
            throw new NotImplementedException();
        }

        public CategoriaEntity Editar(CategoriaEntity entity)
        {
            throw new NotImplementedException();
        }

        public CategoriaEntity ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoriaEntity> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public CategoriaEntity Remover(CategoriaEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
