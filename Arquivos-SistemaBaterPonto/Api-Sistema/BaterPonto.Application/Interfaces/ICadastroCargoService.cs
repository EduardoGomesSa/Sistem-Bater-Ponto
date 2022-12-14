using BaterPonto.Domain.Entities;

namespace BaterPonto.Application.Interfaces
{
    public interface ICadastroCargoService
    {
        bool Adicionar(Cargo cargo);
        bool AtualizarNome(Int64 id, string nome);
        bool AtualizarCargaHoraria(Int64 id, int cargaHoraria);
        bool CargoExiste(Int64 id);
        bool AtualizarValorHora(Int64 id, decimal valorHora);
        bool AtualizarEstadoCargo(Int64 id, bool ativo);
        bool CargoTemFuncionarioAtivo(Int64 id);
        bool CargoExiste(string nome);
        bool CargoEstaAtivo(Int64 id);
    }
}
