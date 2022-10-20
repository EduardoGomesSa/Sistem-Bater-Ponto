using BaterPonto.Application.Commands;
using BaterPonto.Application.Interfaces;
using BaterPonto.Application.Validations;
using BaterPonto.Domain.Entities;
using BaterPonto.Infra.Interfaces;
using FluentValidation.Results;
using MediatR;

namespace BaterPonto.Application.Handlers
{
    public class CadastroCargoHandler : IRequestHandler<AtualizarNomeCargo, bool>,
                                        IRequestHandler<AtualizarCargaHorariaCargo, bool>,
                                        IRequestHandler<AtualizarValorHoraCargo, bool>,
                                        IRequestHandler<AtualizarEstadoCargo, bool>,
                                        IRequestHandler<AdicionarCargo, bool>
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

        public Task<bool> Handle(AtualizarValorHoraCargo request, CancellationToken cancellationToken)
        {
            if (!this.ObterResultadoValidacao(request).IsValid) return Task.FromResult(false);

            var valorHoraAtualizado = _cadastroCargoService.AtualizarValorHora(request.Id, request.ValorHora);

            return Task.FromResult(valorHoraAtualizado);
        }

        public Task<bool> Handle(AtualizarEstadoCargo request, CancellationToken cancellationToken)
        {
            if (!this.ObterResultadoValidacao(request).IsValid) return Task.FromResult(false);

            var estadoAtualizado = _cadastroCargoService.AtualizarEstadoCargo(request.Id, request.Ativo);

            return Task.FromResult(estadoAtualizado);
        }

        public Task<bool> Handle(AdicionarCargo request, CancellationToken cancellationToken)
        {
            if (!this.ObterResultadoValidacao(request).IsValid) return Task.FromResult(false);

            var cargoAdicionado = _cadastroCargoService.Adicionar(this.ConverterParacargo(request));

            return Task.FromResult(cargoAdicionado);
        }

        // Converções
        public Cargo ConverterParacargo(AdicionarCargo adicionarCargo)
        {
            return new Cargo(
                    id: 0,
                    nome: adicionarCargo.Nome,
                    valorHora: adicionarCargo.ValorHora,
                    cargaHoraria: adicionarCargo.CargaHoraria,
                    ativo: true
                );
        }

        //Validações
        public ValidationResult ObterResultadoValidacao(AtualizarEstadoCargo atualizarEstadoCargo)
        {
            return new AtualizarEstadoCargoValidation(_cadastroCargoService).Validate(atualizarEstadoCargo);
        }

        public ValidationResult ObterResultadoValidacao(AtualizarNomeCargo atualizarNomeCargo)
        {
            return new AtualizarNomeCargoValidation(_cadastroCargoService).Validate(atualizarNomeCargo);
        }

        public ValidationResult ObterResultadoValidacao(AtualizarCargaHorariaCargo atualizarCargaHorariaCargo)
        {
            return new AtualizarCargaHorariaCargoValidation(_cadastroCargoService).Validate(atualizarCargaHorariaCargo);
        }

        public ValidationResult ObterResultadoValidacao(AtualizarValorHoraCargo atualizarValorHoraCargo)
        {
            return new AtualizarValorHoraCargoValidation(_cadastroCargoService).Validate(atualizarValorHoraCargo);
        }

        public ValidationResult ObterResultadoValidacao(AdicionarCargo adicionarCargo)
        {
            return new AdicionarCargoValidation(_cadastroCargoService).Validate(adicionarCargo);
        }
    }
}
