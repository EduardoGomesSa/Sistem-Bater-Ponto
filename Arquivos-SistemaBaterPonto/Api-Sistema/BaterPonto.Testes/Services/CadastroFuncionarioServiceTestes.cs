
using BaterPonto.Domain.Entities;
using BaterPonto.Infra.Interfaces;
using BaterPonto.Infra.Repositories;
using BaterPonto.Infra.Services;
using Moq;
using Xunit;
using static Slapper.AutoMapper;

namespace BaterPonto.Testes.Services
{
    public class CadastroFuncionarioServiceTestes
    {
        private readonly Mock<ICargoRepository> _mockCargoRepository;
        private readonly Mock<IFuncionarioRepository> _mockFuncionarioRepository;

        public CadastroFuncionarioServiceTestes()
        {
            _mockCargoRepository = new Mock<ICargoRepository>();
            _mockFuncionarioRepository = new Mock<IFuncionarioRepository>();
        }

        [Fact(DisplayName = "Adicionar Sucesso")]
        [Trait("Categoria", "Service Funcionario")]
        public void Services_Adicionar_Sucesso()
        {
            // Arrange
            var cargo = new Cargo(
                    id: 1,
                    nome: "Dev Back End",
                    valorHora: 100,
                    cargaHoraria: 8,
                    ativo: true
                    );

            var funcionario = new Funcionario(
            id: 2,
            nome: "joao",
            cpf: "11122233344",
            dataInicioContratacao: DateTime.MinValue,
            dataFimContratacao: DateTime.MaxValue,
            idCargo: 2,
            cargo
            );

            _mockCargoRepository.Setup(c => c.BuscarPorNome(It.IsAny<string>()))
                .Returns(cargo);
            _mockFuncionarioRepository.Setup(f => f.Inserir(It.IsAny<Funcionario>()))
                .Returns(1);

            var funcionarioService = new CadastroFuncionarioService(_mockFuncionarioRepository.Object, _mockCargoRepository.Object);

            // Act
            var resultado = funcionarioService.Adicionar(funcionario);

            // Assert
            Assert.True(resultado);
        }

        [Fact (DisplayName = "Atualizar Data Fim Contratacao Sucesso")]
        [Trait("Categoria", "Service Funcionario")]
        public void AtualizarDataFimContratacao_Sucesso()
        {
            // Arrange
            var cargo = new Cargo(
                    id: 2,
                    nome: "Dev Back End",
                    valorHora: 100,
                    cargaHoraria: 8,
                    ativo: true
                    );

            var funcionario = new Funcionario(
            id: 1,
            nome: "joao",
            cpf: "11122233344",
            dataInicioContratacao: DateTime.MinValue,
            dataFimContratacao: DateTime.MaxValue,
            idCargo: 2,
            cargo
            );

            _mockFuncionarioRepository.Setup(f => f.BuscarPorId(It.IsAny<long>()))
                .Returns(funcionario);
            _mockFuncionarioRepository.Setup(f => f.AtualizarDataFimContratacao(It.IsAny<long>(), It.IsAny<DateTime>()))
                .Returns(true);

            var funcionarioService = new CadastroFuncionarioService(_mockFuncionarioRepository.Object, _mockCargoRepository.Object);

            // Act
            var resultado = funcionarioService.AtualizarDataFimContratacao(1, DateTime.Now);

            // Assert
            Assert.True(resultado);
        }

        [Fact(DisplayName = "Atualizar Nome Sucesso")]
        [Trait("Categoria", "Service Funcionario")]
        public void AtualizarNome_Sucesso()
        {
            // Arrange
            _mockFuncionarioRepository.Setup(f => f.AtualizarNome(It.IsAny<long>(), It.IsAny<string>()))
                .Returns(true);

            var funcionarioService = new CadastroFuncionarioService(_mockFuncionarioRepository.Object, _mockCargoRepository.Object);

            // Act 
            var resultado = funcionarioService.AtualizarNome(1, "joao");

            // Assert
            Assert.True(resultado);
        }

        [Fact(DisplayName = "Mudar Cargo Funcionario Sucesso")]
        [Trait("Categoria", "Service Funcionario")]
        public void MudarCargoFuncionario_Sucesso()
        {
            // Arrange
            _mockFuncionarioRepository.Setup(f => f.MudarCargoFuncionario(It.IsAny<long>(), It.IsAny<long>()))
                .Returns(true);

            var funcionarioService = new CadastroFuncionarioService(_mockFuncionarioRepository.Object, _mockCargoRepository.Object);

            // Act
            var resultado = funcionarioService.MudarCargoFuncionario(1, 1);

            // Assert
            Assert.True(resultado);
        }
        
    }
}
