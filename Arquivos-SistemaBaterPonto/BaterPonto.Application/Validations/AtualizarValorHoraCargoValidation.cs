using BaterPonto.Application.Commands;
using BaterPonto.Infra.Interfaces;
using FluentValidation;

namespace BaterPonto.Application.Validations
{
    public class AtualizarValorHoraCargoValidation : AbstractValidator<AtualizarValorHoraCargo>
    {
        public AtualizarValorHoraCargoValidation(ICadastroCargoService _cadastroCargoService)
        {
            RuleFor(c => c).Must(a => _cadastroCargoService.CargoExiste(a.Id)).WithMessage("O funcionário não existe");
            RuleFor(c => c.Id).NotEmpty().NotNull().WithMessage("O campo id não pode ser vazio ou nulo");
            RuleFor(c => c.Id).GreaterThan(0).WithMessage("O campo id deve ter um valor maior que 0");
            RuleFor(c => c.ValorHora).NotEmpty().NotNull().WithMessage("O campo valor hora não pode ser vazio ou nulo");
            RuleFor(c => c.ValorHora).GreaterThan(0).WithMessage("O campo valor hora deve ser maior que 0");
        }
    }
}
