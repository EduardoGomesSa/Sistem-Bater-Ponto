using MediatR;

namespace BaterPonto.Application.Commands
{
    public class AtualizarEstadoCargo : IRequest<bool>
    {
        public Int64 Id { get; set; }
        public bool Ativo { get; set; }
    }
}
