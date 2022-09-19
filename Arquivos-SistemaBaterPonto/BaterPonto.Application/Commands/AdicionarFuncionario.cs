using MediatR;

namespace BaterPonto.Application.Commands
{
    public class AdicionarFuncionario : IRequest<bool>
    {
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public AdicionarCargo? AdicionarCargo { get; set; }
        public DateTime DataInicioContratacao { get; set; }
    }
}
