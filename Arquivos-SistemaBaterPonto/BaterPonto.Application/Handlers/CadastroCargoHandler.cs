using BaterPonto.Application.Commands;
using BaterPonto.Infra.Interfaces;
using MediatR;

namespace BaterPonto.Application.Handlers
{
    public class CadastroCargoHandler : IRequestHandler<AtualizarNomeCargo, bool>
    {
        private readonly ICadastroCargoService _cadastroCargoService;

        public CadastroCargoHandler(ICadastroCargoService cadastroCargoService)
        {
            _cadastroCargoService = cadastroCargoService;
        }

        public Task<bool> Handle(AtualizarNomeCargo request, CancellationToken cancellationToken)
        {
            var nomeAtualizado = _cadastroCargoService.AtualizarNome(request.Id, request.Nome);

            return Task.FromResult(nomeAtualizado);
        }
    }
}
