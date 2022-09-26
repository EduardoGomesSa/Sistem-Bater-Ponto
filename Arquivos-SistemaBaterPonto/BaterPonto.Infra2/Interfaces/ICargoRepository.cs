using BaterPonto.Domain.Entities;

namespace BaterPonto.Infra.Interfaces
{
    public interface ICargoRepository : IBaseRepository<Cargo>
    {
        Cargo BuscarPorNome(string nome);
        bool AtualizarNome(Int64 id, string nome);
        bool AtualizarCargaHoraria(Int64 id, int cargaHoraria);
        bool AtualizarValorHora(Int64 id, decimal valorHora);
    }
}
