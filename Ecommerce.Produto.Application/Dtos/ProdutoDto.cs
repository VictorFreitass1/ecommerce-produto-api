using Ecommerce.Produto.Domain.Interfaces.Dtos;
using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Produto.Application.Dtos
{
    public class ProdutoDto : IProdutoDto
    {
        // [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; } = string.Empty;
        // [Required]
        public string Descricao { get; set; } = string.Empty;
        // [Required]
        public int Quantidade { get; set; }
        // [Required]
        public int CategoriaId { get; set; }

        public void Validation()
        {
            // FluentValidation
            var validateResult = new ProdutoDtoValidation().Validate(this);

            if (!validateResult.IsValid)
                throw new Exception(string.Join(" e ", validateResult.Errors));
        }
    }

    internal class ProdutoDtoValidation : AbstractValidator <ProdutoDto>
    {
        public ProdutoDtoValidation()
        {
            RuleFor(x => x.Nome)
                .MinimumLength(5).WithMessage(x => $"O campo {nameof(x.Nome)} deve ter no mínimo 5 caracteres")
                .NotEmpty().WithMessage(x => $"O campo {nameof(x.Nome)} não pode ser vazio");

            RuleFor(x => x.Descricao)
                .NotEmpty().WithMessage(x => $"O campo {nameof(x.Descricao)} não pode ser vazio");

            RuleFor(x => x.Quantidade)
                .GreaterThan(0).WithMessage(x => $"O campo {nameof(x.Quantidade)} deve ser maior que zero");

            RuleFor(x => x.CategoriaId)
                .GreaterThan(0).WithMessage(x => $"O campo {nameof(x.CategoriaId)} deve conter um ID existente");

        }
    }
}
