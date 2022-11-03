using BaterPonto.Application.CadastroFuncionarioHandler;
using BaterPonto.Application.Commands;
using BaterPonto.Application.Interfaces;
using BaterPonto.Domain.Entities;
using Moq;
using Xunit;

namespace BaterPonto.Testes.Handlers
{
    public class CadastroFuncionarioHandlerTestes
    {
        private readonly Mock<ICadastroFuncionarioService> _serviceFuncionarioMock;
        private readonly Mock<ICadastroCargoService> _serviceCargoMock;

        public CadastroFuncionarioHandlerTestes()
        {
            _serviceFuncionarioMock = new Mock<ICadastroFuncionarioService>();
            _serviceCargoMock = new Mock<ICadastroCargoService>();
        }

        [Fact(DisplayName = "Adicionar Funcionario Sucesso")]
        [Trait("Categoria", "Handler Funcionario")]
        public async void Handler_AdicionarFuncionario_Sucesso()
        {
            _serviceFuncionarioMock.Setup(f => f.Adicionar(It.IsAny<Funcionario>()))
                .Returns(true);

            _serviceFuncionarioMock.Setup(f => f.FuncionarioExiste(It.IsAny<string>()))
                .Returns(false);

            var funcionario = new AdicionarFuncionario()
            {
                Nome = "Joao Dartanha",
                Cpf = "11122233344",
                AdicionarCargo = new AdicionarCargo { Nome = "Dev", CargaHoraria = 8, ValorHora = 100 },
                DataInicioContratacao = DateTime.Now
            };

            var handler = new CadastroFuncionarioHandler(_serviceFuncionarioMock.Object, _serviceCargoMock.Object);

            var adicionou = await handler.Handle(funcionario, CancellationToken.None);

            Assert.True(adicionou);
        }

        [Fact(DisplayName = "Atualizar Nome Funcionario Sucesso")]
        [Trait("Categoria", "Handler Funcionario")]
        public async Task Handler_AtualizarNomeFuncionario_SucessoAsync()
        {
            _serviceFuncionarioMock.Setup(f => f.AtualizarNome(It.IsAny<long>(), It.IsAny<string>()))
                .Returns(true);

            _serviceFuncionarioMock.Setup(f => f.FuncionarioExiste(It.IsAny<long>()))
                .Returns(true);

            var funcionario = new AtualizarNomeFuncionario
            {
                Id = 1,
                Nome = "Joao Dartanha"
            };

            var handler = new CadastroFuncionarioHandler(_serviceFuncionarioMock.Object, _serviceCargoMock.Object);

            var adicionou = await handler.Handle(funcionario, CancellationToken.None);

            Assert.True(adicionou);
        }

        [Fact(DisplayName = "Atualizar Data Fim ContratacaoFuncionario Funcionario Sucesso")]
        [Trait("Categoria", "Handler Funcionario")]
        public async Task Handler_AtualizarDataFimContratacaoFuncionario_SucessoAsync()
        {
            _serviceFuncionarioMock.Setup(f => f.AtualizarDataFimContratacao(It.IsAny<long>(), It.IsAny<DateTime>()))
                .Returns(true);

            _serviceFuncionarioMock.Setup(f => f.FuncionarioExiste(It.IsAny<long>()))
                .Returns(true);

            var funcionario = new AtualizarDataFimContratacaoFuncionario
            {
                Id = 1,
                DataFimContratacao = DateTime.Now
            };

            var handler = new CadastroFuncionarioHandler(_serviceFuncionarioMock.Object, _serviceCargoMock.Object);

            var adicionou = await handler.Handle(funcionario, CancellationToken.None);

            Assert.True(adicionou);
        }

        [Fact(DisplayName = "Mudar Cargo Funcionario Sucesso")]
        [Trait("Categoria", "Handler Funcionario")]
        public async Task Handler_MudarCargoDeFuncionario_SucessoAsync()
        {
            _serviceFuncionarioMock.Setup(f => f.MudarCargoFuncionario(It.IsAny<long>(), It.IsAny<long>()))
                .Returns(true);

            _serviceFuncionarioMock.Setup(f => f.FuncionarioExiste(It.IsAny<long>()))
                .Returns(true);

            _serviceFuncionarioMock.Setup(f => f.FuncionarioAindaTrabalha(It.IsAny<long>()))
                .Returns(true);

            _serviceCargoMock.Setup(c => c.CargoExiste(It.IsAny<long>()))
                .Returns(true);

            _serviceCargoMock.Setup(c => c.CargoEstaAtivo(It.IsAny<long>()))
                .Returns(true);

            var funcionario = new MudarCargoDeFuncionario
            {
                IdFuncionario = 1,
                IdCargo = 1
            };

            var handler = new CadastroFuncionarioHandler(_serviceFuncionarioMock.Object, _serviceCargoMock.Object);

            var adicionou = await handler.Handle(funcionario, CancellationToken.None);

            Assert.True(adicionou);
        }
    }
}
