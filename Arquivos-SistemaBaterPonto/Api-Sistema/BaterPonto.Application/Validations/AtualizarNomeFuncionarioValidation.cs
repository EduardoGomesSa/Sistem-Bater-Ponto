
using BaterPonto.Application.Commands;
using BaterPonto.Application.Interfaces;
using FluentValidation;

namespace BaterPonto.Application.Validations
{
    public class AtualizarNomeFuncionarioValidation : AbstractValidator<AtualizarNomeFuncionario>
    {
        //public Int64 Id { get; set; }
        //public string? Nome { get; set; }
        public AtualizarNomeFuncionarioValidation(ICadastroFuncionarioService _cadastroFuncionarioService)
        {
            RuleFor(f => f).Must(a => _cadastroFuncionarioService.FuncionarioExiste(a.Id)).WithMessage("O funcionário não existe");
            RuleFor(f => f.Id).NotEmpty().NotNull().WithMessage("O campo id não pode ser vazio ou nulo");
            RuleFor(f => f.Id).GreaterThan(0).WithMessage("O campo id deve ter um valor maior que 0");
            RuleFor(f => f.Nome).NotEmpty().NotNull().WithMessage("O campo nome do funcionario não pode ser vazio ou nulo");
            RuleFor(f => f.Nome).MinimumLength(10).MaximumLength(50).WithMessage("O campo nome deve conter entre 10 e 50 caracteres");
        }
    }
}
