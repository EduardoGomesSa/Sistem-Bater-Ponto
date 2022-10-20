using BaterPonto.Application.Commands;
using BaterPonto.Application.Interfaces;
using FluentValidation;

namespace BaterPonto.Application.Validations
{
    public class AdicionarFuncionarioValidation : AbstractValidator<AdicionarFuncionario>
    {
        public AdicionarFuncionarioValidation(ICadastroFuncionarioService _cadastroFuncionarioService)
        {
            RuleFor(f => f).Must(e => !_cadastroFuncionarioService.FuncionarioExiste(e.Cpf)).WithMessage("Funcionario já está cadastrado");
            RuleFor(f => f.Nome).NotEmpty().NotNull().WithMessage("O campo nome do funcionario não pode ser vazio ou nulo");
            RuleFor(f => f.Nome).MinimumLength(10).MaximumLength(50).WithMessage("O campo nome deve conter entre 10 e 50 caracteres");
            RuleFor(f => f.Cpf).NotEmpty().NotNull().WithMessage("O campo cpf não pode ser vazio ou nulo");
            RuleFor(f => f.Cpf).MinimumLength(11).MaximumLength(11).WithMessage("O campo cpf deve ter 11 caracteres");
            RuleFor(f => f.DataInicioContratacao).NotEmpty().NotNull().WithMessage("O campo data contratção não pode ser nulo ou vazio");
        }
    }
}
