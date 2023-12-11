
using FluentValidation;
using Locatora.Domain.Entities;

namespace Locatora.Service.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Por favor informe o email.")
                .NotNull().WithMessage("Por favor informe o email.");

            RuleFor(c => c.Senha)
                .NotEmpty().WithMessage("Por favor informe a senha.")
                .NotNull().WithMessage("Por favor informe a senha.");

            RuleFor(c => c.Rg)
                .NotEmpty().WithMessage("Por favor informe o RG.")
                .NotNull().WithMessage("Por favor informe o RG.");

            RuleFor(c => c.CPF)
                .NotEmpty().WithMessage("Por favor informe o CPF.")
                .NotNull().WithMessage("Por favor informe o CPF.");

            RuleFor(c => c.Telefone)
                .NotEmpty().WithMessage("Por favor informe um número de telefone.")
                .NotNull().WithMessage("Por favor informe um número de telefone.");

            RuleFor(c => c.DataNascimento)
                .NotEmpty().WithMessage("Por favor informe a data de nascimento.")
                .NotNull().WithMessage("Por favor informe a data de nascimento.");
        }
    }
}
