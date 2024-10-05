using Ecommerce.Produto.Domain.Entities;
using Ecommerce.Produto.Domain.Interfaces;
using Ecommerce.Produto.Domain.Interfaces.Dtos;

namespace Ecommerce.Produto.Application.Services
{
    public class ProdutoApplicationService: IProdutoApplicationService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoApplicationService(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public ProdutoEntity? DeletarDadosProduto(int id)
        {
            return _repository.DeletarDados(id);
        }

        public ProdutoEntity? EditarDadosProduto(int id, IProdutoDto entity)
        {
            entity.Validation();

            return _repository.EditarDados(new ProdutoEntity
            {
               Id = id,
               Nome = entity.Nome,
               Descricao = entity.Descricao,
               Quantidade = entity.Quantidade,
               CategoriaId = entity.CategoriaId,
            });
        }

        public ProdutoEntity? ObterProdutoPorId(int id)
        {
            return _repository.ObterPorId(id);  
        }

        public IEnumerable<ProdutoEntity> ObterTodosProdutos()
        {
            return _repository.ObterTodos();
        }

        public ProdutoEntity? SalvarDadosProduto(IProdutoDto entity)
        {
            entity.Validation();

            return _repository.SalvarDados(new ProdutoEntity
            {
                Nome = entity.Nome,
                Descricao = entity.Descricao,
                Quantidade = entity.Quantidade,
                CategoriaId = entity.CategoriaId,
            });
        }
    }
}
