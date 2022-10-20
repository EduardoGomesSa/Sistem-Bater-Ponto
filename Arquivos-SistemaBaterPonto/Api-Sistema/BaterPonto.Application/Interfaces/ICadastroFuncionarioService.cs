using BaterPonto.Domain.Entities;

namespace BaterPonto.Application.Interfaces
{
    public interface ICadastroFuncionarioService
    {
        bool Adicionar(Funcionario funcionario);
        bool AtualizarNome(Int64 id, string nome);
        bool AtualizarDataFimContratacao(Int64 id, DateTime dataFim);
        bool FuncionarioExiste(string cpf);
        bool FuncionarioExiste(Int64 id);
        bool FuncionarioAindaTrabalha(Int64 id);
        bool CargoAindaTemFuncionarioCadastrado(Int64 id);
        bool MudarCargoFuncionario(Int64 idFuncionario, Int64 idCargo);
    }
}
