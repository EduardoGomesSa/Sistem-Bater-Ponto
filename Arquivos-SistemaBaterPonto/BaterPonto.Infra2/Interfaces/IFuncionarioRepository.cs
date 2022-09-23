using BaterPonto.Domain.Entities;

namespace BaterPonto.Infra.Interfaces
{
    public interface IFuncionarioRepository : IBaseRepository<Funcionario>
    {
        bool AtualizarNome(Int64 id, string nome);
        bool AtualizarDataFimContratacao(Int64 id, DateTime dataFim);
    }
}
