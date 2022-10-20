using MediatR;

namespace BaterPonto.Application.Commands
{
    public class AtualizarValorHoraCargo : IRequest<bool>
    {
        public Int64 Id { get; set; }
        public decimal ValorHora { get; set; }
    }
}
