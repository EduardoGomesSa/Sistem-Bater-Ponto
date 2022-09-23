using MediatR;

namespace BaterPonto.Application.Commands
{
    public class AtualizarNomeFuncionario : IRequest<bool>
    {
        public Int64 Id { get; set; }
        public string Nome { get; set; }
    }
}
