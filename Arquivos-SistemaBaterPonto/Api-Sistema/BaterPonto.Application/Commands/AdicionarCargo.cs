using MediatR;

namespace BaterPonto.Application.Commands
{
    public class AdicionarCargo : IRequest<bool>
    {
        public string? Nome { get; set; }
        public decimal ValorHora { get; set; }
        public int CargaHoraria { get; set; }
    }
}
