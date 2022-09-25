using BaterPonto.Application.Commands;
using BaterPonto.Application.Interfaces;
using BaterPonto.Application.Validations;
using BaterPonto.Infra.Interfaces;
using FluentValidation.Results;
using MediatR;

namespace BaterPonto.Application.Handlers
{
    public class CadastroCargoHandler : IRequestHandler<AtualizarNomeCargo, bool>,
                                        IRequestHandler<AtualizarCargaHorariaCargo, bool>
    {
        private readonly ICadastroCargoService _cadastroCargoService;

        public CadastroCargoHandler(ICadastroCargoService cadastroCargoService)
        {
            _cadastroCargoService = cadastroCargoService;
        }

        public Task<bool> Handle(AtualizarNomeCargo request, CancellationToken cancellationToken)
        {
            if (!this.ObterResultadoValidacao(request).IsValid) return Task.FromResult(false);

            var nomeAtualizado = _cadastroCargoService.AtualizarNome(request.Id, request.Nome);

            return Task.FromResult(nomeAtualizado);
        }

        public Task<bool> Handle(AtualizarCargaHorariaCargo request, CancellationToken cancellationToken)
        {
            if (!this.ObterResultadoValidacao(request).IsValid) return Task.FromResult(false);

            var nomeAtualizado = _cadastroCargoService.AtualizarCargaHoraria(request.Id, request.CargaHoraria);

            return Task.FromResult(nomeAtualizado);
        }

        //Validações
        public ValidationResult ObterResultadoValidacao(AtualizarNomeCargo atualizarNomeCargo)
        {
            return new AtualizarNomeCargoValidation(_cadastroCargoService).Validate(atualizarNomeCargo);
        }

        public ValidationResult ObterResultadoValidacao(AtualizarCargaHorariaCargo atualizarCargaHorariaCargo)
        {
            return new AtualizarCargaHorariaCargoValidation(_cadastroCargoService).Validate(atualizarCargaHorariaCargo);
        }
    }
}
