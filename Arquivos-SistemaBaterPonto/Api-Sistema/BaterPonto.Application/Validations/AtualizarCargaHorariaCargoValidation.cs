using BaterPonto.Application.Commands;
using BaterPonto.Infra.Interfaces;
using FluentValidation;

namespace BaterPonto.Application.Validations
{
    public class AtualizarCargaHorariaCargoValidation : AbstractValidator<AtualizarCargaHorariaCargo>
    {
        public AtualizarCargaHorariaCargoValidation(ICadastroCargoService _cadastroCargoService)
        {
            RuleFor(c => c).Must(a => _cadastroCargoService.CargoExiste(a.Id)).WithMessage("O cargo não existe");
            RuleFor(c => c.Id).NotEmpty().NotNull().WithMessage("O campo id não pode ser vazio ou nulo");
            RuleFor(c => c.Id).GreaterThan(0).WithMessage("O campo id deve ter um valor maior que 0");
            RuleFor(c => c.CargaHoraria).NotEmpty().NotNull().WithMessage("O campo carga horária não pode ser vazio ou nulo");
            RuleFor(c => c.Id).GreaterThan(0).WithMessage("O campo carga horária deve ter um valor maior que 0");
        }
    }
}
