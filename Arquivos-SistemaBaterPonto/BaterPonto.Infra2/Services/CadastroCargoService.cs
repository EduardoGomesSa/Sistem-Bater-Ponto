﻿using BaterPonto.Domain.Entities;
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

        public bool AtualizarNome(long id, string nome)
        {
            return _cargoRepository.AtualizarNome(id, nome);
        }
    }
}
