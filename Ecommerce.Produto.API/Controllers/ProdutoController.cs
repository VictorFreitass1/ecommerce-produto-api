using Ecommerce.Produto.Application.Dtos;
using Ecommerce.Produto.Domain.Entities;
using Ecommerce.Produto.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Ecommerce.Produto.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoApplicationService _produtoApplicationService;

        public ProdutoController(IProdutoApplicationService produtoApplicationService)
        {
            _produtoApplicationService = produtoApplicationService;
        }

        /// <summary>
        /// Metodo para obter todos os dados do produto
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces<IEnumerable<ProdutoEntity>>]
        public IActionResult Get()
        {
            var categorias = _produtoApplicationService.ObterTodosProdutos();

            if (categorias is not null)
                return Ok(categorias);

            return BadRequest("Não foi possivel obter os dados");
        }

        /// <summary>
        /// Metodo para obter um produto
        /// </summary>
        /// <param name="id"> Identificado do produto</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [Produces<ProdutoEntity>]
        public IActionResult GetPorId(int id)
        {
            var categorias = _produtoApplicationService.ObterProdutoPorId(id);

            if (categorias is not null)
                return Ok(categorias);

            return BadRequest("Não foi possivel obter os dados");
        }


        /// <summary>
        /// Metodos para salvar o produto
        /// </summary>
        /// <param name="entity"> Modelo de dados de produtos</param>
        /// <returns></returns>
        [HttpPost]
        [Produces<ProdutoEntity>]
        public IActionResult Post(ProdutoDto entity)
        {
            try
            {
                var categorias = _produtoApplicationService.SalvarDadosProduto(entity);

                if (categorias is not null)
                    return Ok(categorias);

                return BadRequest("Não foi possivel salvar os dados");
            }
            catch (Exception ex)
            {
                return BadRequest(new{
                    Error = ex.Message,
                    Status = HttpStatusCode.BadRequest,
                });
            }
        }

        /// <summary>
        /// Metodos para editar a produto
        /// </summary
        /// <param name="id"> Identificador do produto</param>
        /// <param name="entity"> Modelo de dados do produto</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [Produces<ProdutoEntity>]
        public IActionResult Put(int id, ProdutoDto entity)
        {
            try
            {
                var categorias = _produtoApplicationService.EditarDadosProduto(id, entity);

                if (categorias is not null)
                    return Ok(categorias);

                return BadRequest("Não foi possivel editar os dados");
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    Error = ex.Message,
                    Status = HttpStatusCode.BadRequest,
                });
            }
        }

        /// <summary>
        /// Metodo para deletar um produto
        /// </summary>
        /// <param name="id"> Identificado do produto</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [Produces<ProdutoEntity>]
        public IActionResult Delete(int id)
        {
            var categorias = _produtoApplicationService.DeletarDadosProduto(id);

            if (categorias is not null)
                return Ok(categorias);

            return BadRequest("Não foi possivel deletar os dados");
        }
    }
}
