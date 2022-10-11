using BaterPonto.Application.Interfaces;
using BaterPonto.Domain.Entities;
using BaterPonto.Infra.Interfaces;

namespace BaterPonto.Infra.Services
{
    public class CadastroCargoService : ICadastroCargoService
    {
        private readonly ICargoRepository _cargoRepository;
        private readonly ICadastroFuncionarioService _cadastroFuncionarioService;

        public CadastroCargoService(ICargoRepository cargoRepository, ICadastroFuncionarioService cadastroFuncionarioService)
        {
            _cargoRepository = cargoRepository;
            _cadastroFuncionarioService = cadastroFuncionarioService;   
        }

        public bool Adicionar(Cargo cargo)
        {
            return _cargoRepository.Inserir(cargo) > 0;
        }

        public bool AtualizarCargaHoraria(long id, int cargaHoraria)
        {
            return _cargoRepository.AtualizarCargaHoraria(id, cargaHoraria);
        }

        public bool AtualizarEstadoCargo(long id, bool ativo)
        {

            return _cargoRepository.AtualizarEstadoCargo(id, ativo);
        }

        public bool AtualizarNome(long id, string nome)
        {
            return _cargoRepository.AtualizarNome(id, nome);
        }

        public bool AtualizarValorHora(long id, decimal valorHora)
        {
            return _cargoRepository.AtualizarValorHora(id, valorHora);
        }

        public bool CargoExiste(long id)
        {
            var cargo = _cargoRepository.BuscarPorId(id);

            if (cargo == null) return false;

            return cargo.Id > 0;
        }

        public bool CargoExiste(string nome)
        {
            var resultadoBusca = _cargoRepository.BuscarPorNome(nome);

            if(resultadoBusca == null) return false;

            return resultadoBusca.Id > 0;
        }

        public bool CargoTemFuncionarioAtivo(long id)
        {
            return _cadastroFuncionarioService.CargoAindaTemFuncionarioCadastrado(id);
        }
    }
}
