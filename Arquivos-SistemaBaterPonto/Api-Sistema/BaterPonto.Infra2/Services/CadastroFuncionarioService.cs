using BaterPonto.Application.Interfaces;
using BaterPonto.Domain.Entities;
using BaterPonto.Infra.Interfaces;
using BaterPonto.Infra.Repositories.Data;
using Microsoft.VisualBasic;
using NHibernate.Mapping;

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

        public bool AtualizarDataFimContratacao(long id, DateTime dataFim)
        {
            var funcionario = _funcionarioRepository.BuscarPorId(id);

            if(funcionario == null) return false;

            if (funcionario.DataInicioContratacao > dataFim) return false;

            return _funcionarioRepository.AtualizarDataFimContratacao(id, dataFim);
        }

        public bool AtualizarNome(long id, string nome)
        {
            return _funcionarioRepository.AtualizarNome(id, nome);
        }

        public bool MudarCargoFuncionario(long idFuncionario, long idCargo)
        {
            return _funcionarioRepository.MudarCargoFuncionario(idFuncionario, idCargo);
        }

        // Verificações
        public bool FuncionarioExiste(Int64 id)
        {
            var funcionario = _funcionarioRepository.BuscarPorId(id);

            if (funcionario == null) return false;

            return funcionario.Id > 0;
        }

        public bool FuncionarioExiste(string cpf)
        {
            return _funcionarioRepository.FuncionarioExiste(cpf);
        }

        public bool FuncionarioAindaTrabalha(long id)
        {
            var funcionario = _funcionarioRepository.BuscarPorId(id);

            if (funcionario == null) return false;

            if (funcionario.DataFimContratacao == null) return true;

            return false;
        }

        public bool CargoAindaTemFuncionarioCadastrado(Int64 id)
        {
            var listaFuncionario = _funcionarioRepository.CargoTemFuncionario(id);

            List<Funcionario> funcionariosEmpregados = new List<Funcionario>();

            foreach (var funcionario in listaFuncionario)
            {
                if(funcionario.DataFimContratacao == null)
                {
                    funcionariosEmpregados.Add(funcionario);
                }
            }

            if(funcionariosEmpregados.Count > 0) return true;

            return false;
        }
    }
}
