using BaterPonto.Domain.Entities;

namespace BaterPonto.Application.Interfaces
{
    public interface ICadastroFuncionarioService
    {
        bool Adicionar(Funcionario funcionario);
        bool AtualizarNome(Int64 id, string nome);
        bool AtualizarDataFimContratacao(Int64 id, DateTime dataFim);
        bool FuncionarioExiste(string cpf);
    }
}
