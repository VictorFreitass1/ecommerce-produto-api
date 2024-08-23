using Ecommerce.Produto.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Produto.Domain.Entities
{
    [Table("tb_prd_produto")]
    public class ProdutoEntity : CommonEntity
    {
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }

        public CategoriaEntity Categoria { get; set; } = new();
    }
}
