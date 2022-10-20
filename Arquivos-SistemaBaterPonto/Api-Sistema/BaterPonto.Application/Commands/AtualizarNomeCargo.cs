using MediatR;

namespace BaterPonto.Application.Commands
{
    public class AtualizarNomeCargo : IRequest<bool>
    {
        public Int64 Id { get; set; }
        public string? Nome { get; set; }
    }
}
