
using BaterPonto.Application.Commands;
using BaterPonto.Application.Handlers;
using BaterPonto.Application.Interfaces;
using BaterPonto.Domain.Entities;
using Moq;
using Xunit;

namespace BaterPonto.Testes.Handlers
{
    public class CadastroCargoHandlerTestes
    {
        private readonly Mock<ICadastroCargoService> _cargoServiceMock;

        public CadastroCargoHandlerTestes()
        {
            _cargoServiceMock = new Mock<ICadastroCargoService>();
        }

        [Fact(DisplayName = "Atualizar Nome Cargo Sucesso")]
        [Trait("Categoria", "Handler Cargo")]
        public async void Handler_AtualizarNomeCargo_Sucesso()
        {
            _cargoServiceMock.Setup(c => c.CargoExiste(It.IsAny<long>()))
                .Returns(true);

            _cargoServiceMock.Setup(c => c.AtualizarNome(It.IsAny<long>(), It.IsAny<string>()))
                .Returns(true);

            var cargo = new AtualizarNomeCargo
            {
                Id = 1,
                Nome = "Desenvolvedor Back End"
            };

            var cargoHandler = new CadastroCargoHandler(_cargoServiceMock.Object);

            var atualizou = await cargoHandler.Handle(cargo, CancellationToken.None);

            Assert.True(atualizou);
        }

        [Fact(DisplayName = "Atualizar Carga Horaria Cargo Sucesso")]
        [Trait("Categoria", "Handler Cargo")]
        public async void Handler_AtualizarCargaHorariaCargo_Sucesso()
        {
            _cargoServiceMock.Setup(c => c.CargoExiste(It.IsAny<long>()))
                .Returns(true);

            _cargoServiceMock.Setup(c => c.AtualizarCargaHoraria(It.IsAny<long>(), It.IsAny<int>()))
                .Returns(true);

            var cargo = new AtualizarCargaHorariaCargo
            {
                Id = 1,
                CargaHoraria = 1
            };

            var cargoHandler = new CadastroCargoHandler(_cargoServiceMock.Object);

            var atualizou = await cargoHandler.Handle(cargo, CancellationToken.None);

            Assert.True(atualizou);
        }

        [Fact(DisplayName = "Atualizar Valor Hora Cargo Sucesso")]
        [Trait("Categoria", "Handler Cargo")]
        public async void Handler_AtualizarValorHoraCargo_Sucesso()
        {
            _cargoServiceMock.Setup(c => c.CargoExiste(It.IsAny<long>()))
                .Returns(true);

            _cargoServiceMock.Setup(c => c.AtualizarValorHora(It.IsAny<long>(), It.IsAny<decimal>()))
                .Returns(true);

            var cargo = new AtualizarValorHoraCargo
            {
                Id = 1,
                ValorHora = 1
            };

            var cargoHandler = new CadastroCargoHandler(_cargoServiceMock.Object);

            var atualizou = await cargoHandler.Handle(cargo, CancellationToken.None);

            Assert.True(atualizou);
        }

        [Fact(DisplayName = "Atualizar Estado Cargo Sucesso")]
        [Trait("Categoria", "Handler Cargo")]
        public async void Handler_AtualizarEstadoCargo_Sucesso()
        {
            _cargoServiceMock.Setup(c => c.CargoExiste(It.IsAny<long>()))
                .Returns(true);

            _cargoServiceMock.Setup(c => c.AtualizarEstadoCargo(It.IsAny<long>(), It.IsAny<bool>()))
                .Returns(true);

            var cargo = new AtualizarEstadoCargo
            {
                Id = 1,
                Ativo = true
            };

            var cargoHandler = new CadastroCargoHandler(_cargoServiceMock.Object);

            var atualizou = await cargoHandler.Handle(cargo, CancellationToken.None);

            Assert.True(atualizou);
        }

        [Fact(DisplayName = "Adicionar Cargo Sucesso")]
        [Trait("Categoria", "Handler Cargo")]
        public async void Handler_AdicionarCargo_Sucesso()
        {
            _cargoServiceMock.Setup(c => c.CargoExiste(It.IsAny<string>()))
                .Returns(false);

            _cargoServiceMock.Setup(c => c.Adicionar(It.IsAny<Cargo>()))
                .Returns(true);

            var cargo = new AdicionarCargo
            {
                Nome = "Desenvolvedor Back End",
                ValorHora = 1,
                CargaHoraria = 1
            };

            var cargoHandler = new CadastroCargoHandler(_cargoServiceMock.Object);

            var atualizou = await cargoHandler.Handle(cargo, CancellationToken.None);

            Assert.True(atualizou);
        }
    }
}
