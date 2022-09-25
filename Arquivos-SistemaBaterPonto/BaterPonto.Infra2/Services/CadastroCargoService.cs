using BaterPonto.Domain.Entities;
using BaterPonto.Infra.Interfaces;

namespace BaterPonto.Infra.Services
{
    public class CadastroCargoService : ICadastroCargoService
    {
        private readonly ICargoRepository _cargoRepository;

        public CadastroCargoService(ICargoRepository cargoRepository)
        {
            _cargoRepository = cargoRepository;
        }

        public bool AtualizarCargaHoraria(long id, int cargaHoraria)
        {
            return _cargoRepository.AtualizarCargaHoraria(id, cargaHoraria);
        }

        public bool AtualizarNome(long id, string nome)
        {
            return _cargoRepository.AtualizarNome(id, nome);
        }

        public bool CargoExiste(long id)
        {
            var cargo = _cargoRepository.BuscarPorId(id);

            if (cargo == null) return false;

            return cargo.Id > 0;
        }
    }
}
