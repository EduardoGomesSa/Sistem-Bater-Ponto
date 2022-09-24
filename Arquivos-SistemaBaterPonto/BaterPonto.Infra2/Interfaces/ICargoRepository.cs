using BaterPonto.Domain.Entities;

namespace BaterPonto.Infra.Interfaces
{
    public interface ICargoRepository : IBaseRepository<Cargo>
    {
        Cargo BuscarPorNome(string nome);
        bool AtualizarNome(Int64 id, string nome);
    }
}
