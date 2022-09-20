using BaterPonto.Application.Commands;
using BaterPonto.Application.Interfaces;
using BaterPonto.Domain.Entities;
using MediatR;

namespace BaterPonto.Application.CadastroFuncionarioHandler
{
    public class CadastroFuncionarioHandler : IRequestHandler<AdicionarFuncionario, bool>
    {
        readonly private ICadastroFuncionarioService _cadastroFuncionarioService;
        public CadastroFuncionarioHandler(ICadastroFuncionarioService cadastroFuncionarioService)
        {
            _cadastroFuncionarioService = cadastroFuncionarioService;
        }

        public Task<bool> Handle(AdicionarFuncionario request, CancellationToken cancellationToken)
        {
            var funcionario = ConverterParaFuncionario(request);

            var funcionarioAdicionado = _cadastroFuncionarioService.Adicionar(funcionario);

            return Task.FromResult(funcionarioAdicionado);
        }

        private Funcionario ConverterParaFuncionario(AdicionarFuncionario adicionarFuncionario)
        {
            var cargoFuncionario = new Cargo(
                    id: 0,
                    nome: adicionarFuncionario.AdicionarCargo.Nome,
                    valorHora: adicionarFuncionario.AdicionarCargo.ValorHora,
                    cargaHoraria: adicionarFuncionario.AdicionarCargo.CargaHoraria
                );

            return new Funcionario(
                id: 0,
                nome: adicionarFuncionario.Nome,
                cpf: adicionarFuncionario.Cpf,
                dataInicioContratacao: adicionarFuncionario.DataInicioContratacao,
                dataFimContratacao: null,
                idCargo: 0,
                cargo: cargoFuncionario
                );
        }
    }
}
