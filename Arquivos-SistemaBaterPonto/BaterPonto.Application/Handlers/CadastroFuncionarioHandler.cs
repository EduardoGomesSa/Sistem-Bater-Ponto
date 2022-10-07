using BaterPonto.Application.Commands;
using BaterPonto.Application.Interfaces;
using BaterPonto.Application.Validations;
using BaterPonto.Domain.Entities;
using FluentValidation.Results;
using MediatR;

namespace BaterPonto.Application.CadastroFuncionarioHandler
{
    public class CadastroFuncionarioHandler : IRequestHandler<AdicionarFuncionario, bool>,
                                              IRequestHandler<AtualizarNomeFuncionario, bool>,
                                              IRequestHandler<AtualizarDataFimContratacaoFuncionario, bool>
    {
        readonly private ICadastroFuncionarioService _cadastroFuncionarioService;
        public CadastroFuncionarioHandler(ICadastroFuncionarioService cadastroFuncionarioService)
        {
            _cadastroFuncionarioService = cadastroFuncionarioService;
        }

        public Task<bool> Handle(AdicionarFuncionario request, CancellationToken cancellationToken)
        {
            if (!this.ObterResultadoValidacao(request).IsValid) return Task.FromResult(false);

            var funcionario = ConverterParaFuncionario(request);

            var funcionarioAdicionado = _cadastroFuncionarioService.Adicionar(funcionario);

            return Task.FromResult(funcionarioAdicionado);
        }

        public Task<bool> Handle(AtualizarNomeFuncionario request, CancellationToken cancellationToken)
        {
            if (!this.ObterResultadoValidacao(request).IsValid) return Task.FromResult(false);

            var nomeAtualizado = _cadastroFuncionarioService.AtualizarNome(request.Id, request?.Nome);

            return Task.FromResult(nomeAtualizado);
        }

        public Task<bool> Handle(AtualizarDataFimContratacaoFuncionario request, CancellationToken cancellationToken)
        {
            if (!this.ObterResultadoValidacao(request).IsValid) return Task.FromResult(false);

            var dataFimAtualizada = _cadastroFuncionarioService.AtualizarDataFimContratacao(request.Id, request.DataFimContratacao);

            return Task.FromResult(dataFimAtualizada);
        }

        private Funcionario ConverterParaFuncionario(AdicionarFuncionario adicionarFuncionario)
        {
            var cargoFuncionario = new Cargo(
                    id: 0,
                    nome: adicionarFuncionario?.AdicionarCargo?.Nome,
                    valorHora: adicionarFuncionario?.AdicionarCargo != null ? adicionarFuncionario.AdicionarCargo.ValorHora : 1,
                    cargaHoraria: adicionarFuncionario?.AdicionarCargo != null ? adicionarFuncionario.AdicionarCargo.CargaHoraria : 1,
                    ativo: true
                );

            return new Funcionario(
                id: 0,
                nome: adicionarFuncionario?.Nome,
                cpf: adicionarFuncionario?.Cpf,
                dataInicioContratacao: adicionarFuncionario != null ? adicionarFuncionario.DataInicioContratacao : DateTime.Now,
                dataFimContratacao: null,
                idCargo: 0,
                cargo: cargoFuncionario
                );
        }

        // Validações
        public ValidationResult ObterResultadoValidacao(AdicionarFuncionario adicionarFuncionario)
        {
            return new AdicionarFuncionarioValidation(_cadastroFuncionarioService).Validate(adicionarFuncionario);
        }

        public ValidationResult ObterResultadoValidacao(AtualizarDataFimContratacaoFuncionario atualizarDataFimContratacaoFuncionario)
        {
            return new AtualizarDataFimContratacaoFuncionarioValidation(_cadastroFuncionarioService).Validate(atualizarDataFimContratacaoFuncionario);
        }

        public ValidationResult ObterResultadoValidacao(AtualizarNomeFuncionario atualizarNomeFuncionario)
        {
            return new AtualizarNomeFuncionarioValidation(_cadastroFuncionarioService).Validate(atualizarNomeFuncionario);
        }
    }
}
