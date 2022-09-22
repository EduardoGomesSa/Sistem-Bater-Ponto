using BaterPonto.Application.Interfaces;
using BaterPonto.Domain.Entities;
using BaterPonto.Infra.Interfaces;

namespace BaterPonto.Infra.Services
{
    public class CadastroFuncionarioService : ICadastroFuncionarioService
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        private readonly ICargoRepository _cargoRepository;

        public CadastroFuncionarioService(IFuncionarioRepository funcionarioRepository, ICargoRepository cargoRepository)
        {
            _funcionarioRepository = funcionarioRepository;
            _cargoRepository = cargoRepository;
        }

        public bool Adicionar(Funcionario funcionario)
        {
            var cargo = _cargoRepository.BuscarPorNome(funcionario.Cargo.Nome);

            if(cargo != null && cargo.Id > 0)
            {
                funcionario.SetIdCargo(cargo.Id);
            }
            else
            {
                var cargoId = _cargoRepository.Inserir(funcionario.Cargo);

                funcionario.SetIdCargo((int)cargoId);
            }

            return _funcionarioRepository.Inserir(funcionario) > 0;
        }
    }
}
