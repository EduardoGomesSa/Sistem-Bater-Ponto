using BaterPonto.Domain.Entities;

namespace BaterPonto.Application.Interfaces
{
    public interface ICadastroFuncionarioService
    {
        bool Adicionar(Funcionario funcionario);
    }
}
