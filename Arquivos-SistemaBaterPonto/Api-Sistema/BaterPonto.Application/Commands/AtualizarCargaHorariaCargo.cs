using MediatR;

namespace BaterPonto.Application.Commands
{
    public class AtualizarCargaHorariaCargo : IRequest<bool>
    {
        public Int64 Id { get; set; }
        public int CargaHoraria { get; set; }
    }
}
