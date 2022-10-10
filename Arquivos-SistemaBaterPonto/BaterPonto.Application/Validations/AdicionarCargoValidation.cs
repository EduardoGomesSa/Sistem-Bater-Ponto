using BaterPonto.Application.Commands;
using BaterPonto.Infra.Interfaces;
using FluentValidation;

namespace BaterPonto.Application.Validations
{
    public class AdicionarCargoValidation : AbstractValidator<AdicionarCargo>
    {
        public AdicionarCargoValidation(ICadastroCargoService _cargoService)
        {
            RuleFor(c => c).Must(v => !_cargoService.CargoExiste(v.Nome)).WithMessage("Cargo já está cadastrado");
            RuleFor(c => c.Nome).NotEmpty().NotNull().WithMessage("O campo nome do cargo não pode ser vazio ou nulo");
            RuleFor(c => c.Nome).MinimumLength(10).MaximumLength(50).WithMessage("O campo nome do cargo deve conter entre 2 e 50 caracteres");
            RuleFor(c => c.CargaHoraria).NotEmpty().NotNull().WithMessage("O campo carga horaria não pode ser vazio ou nulo");
            RuleFor(c => c.CargaHoraria).GreaterThan(0).WithMessage("O campo carga horaria não pode ser 0");
            RuleFor(c => c.ValorHora).NotEmpty().NotNull().WithMessage("O campo valor hora não pode ser vazio ou nulo");
            RuleFor(c => c.ValorHora).GreaterThan(0).WithMessage("O campo valor hora não pode ser 0");
        }
    }
}
