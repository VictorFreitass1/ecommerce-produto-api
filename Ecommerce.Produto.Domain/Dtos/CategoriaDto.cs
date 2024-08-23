using Ecommerce.Produto.Domain.Dtos.Common;
using FluentValidation;

namespace Ecommerce.Produto.Domain.Dtos
{
    public class CategoriaDto : CommonDto
    {

        public void Validate()
        {
            var validateResult = new CategoriaDtoValidation().Validate(this);

            if (!validateResult.IsValid)
                throw new ArgumentException(string.Join(" e ", validateResult.Errors.Select(x => x.ErrorMessage)));
        }
    }

    internal class CategoriaDtoValidation : AbstractValidator<CategoriaDto>
    {
        public CategoriaDtoValidation()
        {
            RuleFor(x => x.Nome)
                .MinimumLength(5).WithMessage(x => $"O campo {nameof(x.Nome)} dever conter no minimo 5 caracteres")
                .NotEmpty().WithMessage(x => $"O campo {nameof(x.Nome)} não pode ser vazio");
        }
    }
}
