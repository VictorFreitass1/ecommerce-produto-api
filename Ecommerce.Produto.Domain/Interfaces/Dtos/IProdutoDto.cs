namespace Ecommerce.Produto.Domain.Interfaces.Dtos
{
    public interface IProdutoDto
    {
        string Nome { get; set; }
        string Descricao { get; set; }
        int Quantidade { get; set; }
        int CategoriaId { get; set; }

        void Validation ();
    }
}
