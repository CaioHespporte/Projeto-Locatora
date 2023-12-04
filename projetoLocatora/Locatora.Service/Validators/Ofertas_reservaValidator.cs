
using FluentValidation;
using Locatora.Domain.Entities;

namespace Locatora.Service.Validators
{
    public class Ofertas_reservaValidator : AbstractValidator<Ofertas_reserva>
    {
        public Ofertas_reservaValidator()
        {
            RuleFor(c => c.Preco)
                .NotEmpty().WithMessage("Por favor informe o preço.")
                .NotNull().WithMessage("Por favor informe o preço.");
        }
    }

    public class OfertaValidator : AbstractValidator<Oferta>
    {
        public OfertaValidator()
        {
            RuleFor(c => c.Data)
                .NotEmpty().WithMessage("Por favor informe a data.")
                .NotNull().WithMessage("Por favor informe a data.");
            RuleFor(c => c.ValorTotal)
                .NotEmpty().WithMessage("Por favor informe o valor total.")
                .NotNull().WithMessage("Por favor informe o valor total.");
        }
    }
}
