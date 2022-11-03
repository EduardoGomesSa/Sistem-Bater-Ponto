using BaterPonto.Application.Commands;
using BaterPonto.Application.Interfaces;
using FluentValidation;

namespace BaterPonto.Application.Validations
{
    public class MudarCargoDeFuncionarioValidation : AbstractValidator<MudarCargoDeFuncionario>
    {
        public MudarCargoDeFuncionarioValidation(ICadastroFuncionarioService _funcionarioService, ICadastroCargoService _cargoService)
        {
            RuleFor(f => f).Must(e => _funcionarioService.FuncionarioExiste(e.IdFuncionario)).WithMessage("O funcionário não existe");
            RuleFor(f => f).Must(e => _funcionarioService.FuncionarioAindaTrabalha(e.IdFuncionario)).WithMessage("Funcionão não está mais trabalhando na empresa");
            RuleFor(f => f.IdFuncionario).NotEmpty().NotNull().WithMessage("O campo id funcionário não pode ser nulo ou vazio");
            RuleFor(f => f.IdFuncionario).GreaterThan(0).WithMessage("O campo id funcionário deve ser maior que 0");
            RuleFor(f => f).Must(e => _cargoService.CargoExiste(e.IdCargo)).WithMessage("O cargo não existe");
            RuleFor(f => f).Must(e => _cargoService.CargoEstaAtivo(e.IdCargo)).WithMessage("O cargo não está mais ativo");
            RuleFor(f => f.IdCargo).NotEmpty().NotNull().WithMessage("O campo id cargo não pode ser nulo ou vazio");
            RuleFor(f => f.IdCargo).GreaterThan(0).WithMessage("O campo id cargo deve ser maior que 0");
        }
    }
}
