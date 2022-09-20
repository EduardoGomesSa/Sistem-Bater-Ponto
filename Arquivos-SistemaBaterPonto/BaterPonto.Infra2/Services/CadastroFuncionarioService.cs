using BaterPonto.Application.Interfaces;
using BaterPonto.Domain.Entities;
using BaterPonto.Infra.Interfaces;

namespace BaterPonto.Infra.Services
{
    public class CadastroFuncionarioService : ICadastroFuncionarioService
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public CadastroFuncionarioService(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        public bool Adicionar(Funcionario funcionario)
        {
            funcionario.SetIdCargo();

            return _funcionarioRepository.Inserir(funcionario) > 0;
        }
    }
}
