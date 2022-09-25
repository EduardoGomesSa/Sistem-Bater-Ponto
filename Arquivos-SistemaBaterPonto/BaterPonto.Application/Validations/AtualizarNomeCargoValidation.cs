
using BaterPonto.Application.Commands;
using BaterPonto.Infra.Interfaces;
using FluentValidation;

namespace BaterPonto.Application.Validations
{
    public class AtualizarNomeCargoValidation : AbstractValidator<AtualizarNomeCargo>
    {
        public AtualizarNomeCargoValidation(ICadastroCargoService _cadastroCargoService)
        {
            RuleFor(c => c).Must(a => _cadastroCargoService.CargoExiste(a.Id)).WithMessage("O funcionário não existe");
            RuleFor(c => c.Id).NotEmpty().NotNull().WithMessage("O campo id não pode ser vazio ou nulo");
            RuleFor(c => c.Id).GreaterThan(0).WithMessage("O campo id deve ter um valor maior que 0");
            RuleFor(c => c.Nome).NotEmpty().NotNull().WithMessage("O campo nome do funcionario não pode ser vazio ou nulo");
            RuleFor(c => c.Nome).MinimumLength(10).MaximumLength(50).WithMessage("O campo nome deve conter entre 10 e 50 caracteres");
        }
    }
}
