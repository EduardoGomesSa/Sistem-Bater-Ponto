using BaterPonto.Application.Commands;
using BaterPonto.Application.Interfaces;
using FluentValidation;

namespace BaterPonto.Application.Validations
{
    public class AtualizarEstadoCargoValidation : AbstractValidator<AtualizarEstadoCargo>
    {
        public AtualizarEstadoCargoValidation(ICadastroCargoService _cadastroCargoService)
        {
            RuleFor(c => c).Must(a => _cadastroCargoService.CargoExiste(a.Id)).WithMessage("O cargo não existe");
            RuleFor(c => c).Must(a => !_cadastroCargoService.CargoTemFuncionarioAtivo(a.Id)).WithMessage("Não pode desativar cargo que tenha funcionário empregado");
            RuleFor(c => c.Id).NotEmpty().NotNull().WithMessage("O campo id não pode ser vazio ou nulo");
            RuleFor(c => c.Id).GreaterThan(0).WithMessage("O campo id deve ter um valor maior que 0");
            RuleFor(c => c.Ativo).NotNull().WithMessage("O estado não pode ser nulo");
        }
    }
}
