
using FluentValidation;
using Locatora.Domain.Entities;

namespace Locatora.Service.Validators
{
    public class ReservaValidator : AbstractValidator<Reserva>
    {
        public ReservaValidator()
        {
            RuleFor(c => c.Data_Inicio)
                .NotEmpty().WithMessage("Por favor informe a data de início.")
                .NotNull().WithMessage("Por favor informe a data de início.");
            RuleFor(c => c.Data_Fim)
                .NotEmpty().WithMessage("Por favor informe a data final.")
                .NotNull().WithMessage("Por favor informe a data final.");
            RuleFor(c => c.Valor_total)
                .NotEmpty().WithMessage("Por favor informe o valor total.")
                .NotNull().WithMessage("Por favor informe o valor total.");
        }
    }
}
