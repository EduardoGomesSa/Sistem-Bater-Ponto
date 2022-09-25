using BaterPonto.Domain.Entities;

namespace BaterPonto.Infra.Interfaces
{
    public interface ICadastroCargoService
    {
        bool AtualizarNome(Int64 id, string nome);
        bool AtualizarCargaHoraria(Int64 id, int cargaHoraria);
        bool CargoExiste(Int64 id);
    }
}
