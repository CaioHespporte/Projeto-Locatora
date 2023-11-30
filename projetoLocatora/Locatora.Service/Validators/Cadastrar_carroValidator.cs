
using FluentValidation;
using Locatora.Domain.Entities;

namespace Locatora.Service.Validators
{
    public class Cadastrar_carroValidator : AbstractValidator<Cadastrar_carro>
    {
        public Cadastrar_carroValidator()
        {
            RuleFor(c => c.Modelo)
                .NotEmpty().WithMessage("Por favor informe o modelo.")
                .NotNull().WithMessage("Por favor informe o modelo.");
            RuleFor(c => c.Placa)
                .NotEmpty().WithMessage("Por favor informe a placa.")
                .NotNull().WithMessage("Por favor informe a placa.");
            RuleFor(c => c.Ano)
                .NotEmpty().WithMessage("Por favor informe o ano.")
                .NotNull().WithMessage("Por favor informe o ano.");
            RuleFor(c => c.Valor_dia)
                .NotEmpty().WithMessage("Por favor informe o valor diário.")
                .NotNull().WithMessage("Por favor informe o valor diário.");
        }
    }
}
