using Ecommerce.Produto.Domain.Dtos.Common;
using FluentValidation;

namespace Ecommerce.Produto.Domain.Dtos
{
    public class ProdutoDto : CommonDto
    {
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }

        public void Validate()
        {
            var validateResult = new ProdutoDtoValidation().Validate(this);

            if (!validateResult.IsValid)
                throw new ArgumentException(string.Join(" e ", validateResult.Errors.Select(x => x.ErrorMessage)));
        }
    }

    internal class ProdutoDtoValidation : AbstractValidator<ProdutoDto>
    {
        public ProdutoDtoValidation()
        {
            RuleFor(x => x.Nome)
                .MinimumLength(5).WithMessage(x => $"O campo {nameof(x.Nome)} dever conter no minimo 5 caracteres")
                .NotEmpty().WithMessage(x => $"O campo {nameof(x.Nome)} não pode ser vazio");

            RuleFor(x => x.Preco)
                .GreaterThan(0).WithMessage(x => $"O campo {nameof(x.Preco)} dever conter um valor acima de zero");

            RuleFor(x => x.Quantidade)
                .GreaterThan(0).WithMessage(x => $"O campo {nameof(x.Quantidade)} deve conter pelo menos 1 item");

            RuleFor(x => x.CategoriaId)
                .GreaterThan(0).WithMessage(x => $"O campo {nameof(x.Quantidade)} deve ser preenchido");
        }
    }
}
