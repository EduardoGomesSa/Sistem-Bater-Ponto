using BaterPonto.Application.Commands;
using BaterPonto.Application.Interfaces;
using FluentValidation;

namespace BaterPonto.Application.Validations
{
    public class AtualizarDataFimContratacaoFuncionarioValidation : AbstractValidator<AtualizarDataFimContratacaoFuncionario>
    {
        public AtualizarDataFimContratacaoFuncionarioValidation(ICadastroFuncionarioService _cadastroFuncionarioService)
        {
            RuleFor(f => f).Must(a => _cadastroFuncionarioService.FuncionarioExiste(a.Id)).WithMessage("O funcionário não existe");
            RuleFor(f => f).Must(a => !_cadastroFuncionarioService.FuncionarioAindaTrabalha(a.Id)).WithMessage("O funcionario já está desligado");
            RuleFor(f => f.Id).NotEmpty().NotNull().WithMessage("O campo id não pode ser vazio ou nulo");
            RuleFor(f => f.Id).GreaterThan(0).WithMessage("O campo id deve ter um valor maior que 0");
            RuleFor(f => f.DataFimContratacao).NotEmpty().NotNull().WithMessage("O campo data não pode ser vazio ou nulo");
        }
    }
}
