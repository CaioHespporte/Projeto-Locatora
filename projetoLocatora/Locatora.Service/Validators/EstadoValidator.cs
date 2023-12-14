
using FluentValidation;
using Locatora.Domain.Entities;

namespace Locatora.Service.Validators
{
    public class EstadoValidator : AbstractValidator<Estado>
    {
        public EstadoValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");
            RuleFor(c => c.Uf)
                .NotEmpty().WithMessage("Por favor informe o uf.")
                .NotNull().WithMessage("Por favor informe o uf.");

        }
    }
}
