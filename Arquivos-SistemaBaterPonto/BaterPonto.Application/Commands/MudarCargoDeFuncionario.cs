using MediatR;

namespace BaterPonto.Application.Commands
{
    public class MudarCargoDeFuncionario : IRequest<bool>
    {
        public Int64 IdFuncionario { get; set; }
        public Int64 IdCargo { get; set; }
    }
}
