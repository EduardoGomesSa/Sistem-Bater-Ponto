using MediatR;

namespace BaterPonto.Application.Commands
{
    public class AtualizarDataFimContratacaoFuncionario : IRequest<bool>
    {
        public Int64 Id { get; set; }
        public DateTime DataFimContratacao { get; set; }
    }
}
