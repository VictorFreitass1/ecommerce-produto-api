using Ecommerce.Produto.Domain.Entities;
using Ecommerce.Produto.Domain.Interfaces;
using Ecommerce.Produto.Infrastructure.Data.AppContext;

namespace Ecommerce.Produto.Infrastructure.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationContext _context;

        public ProdutoRepository(ApplicationContext context)
        {
            _context = context;
        }

        public ProdutoEntity Adicionar(ProdutoEntity entity)
        {
            throw new NotImplementedException();
        }

        public ProdutoEntity Editar(ProdutoEntity entity)
        {
            throw new NotImplementedException();
        }

        public ProdutoEntity ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProdutoEntity> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public ProdutoEntity Remover(ProdutoEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
