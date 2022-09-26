using BaterPonto.Domain.Entities;
using BaterPonto.Infra.Interfaces;
using BaterPonto.Infra.Maps;
using BaterPonto.Infra.Repositories.Data;

namespace BaterPonto.Infra.Repositories
{
    public class CargoRepository : BaseRepository<Cargo, CargoMap>, ICargoRepository
    {
        public Cargo BuscarPorNome(string nome)
        {
            var sql = $"select * from cadastro.cargo where nome = '{nome}';";

            var cargo = DBHelper<Cargo>.InstanciaNpgsql.GetQuery(sql).FirstOrDefault();

            if (cargo != null) return cargo;

            return null;
        }

        public bool AtualizarNome(long id, string nome)
        {
            var sql = $"update cadastro.cargo set nome = '{nome}' where id = {id};";

            return DBHelper<Cargo>.InstanciaNpgsql.Get(sql) != null;
        }

        public bool AtualizarCargaHoraria(long id, int cargaHoraria)
        {
            var sql = $"update cadastro.cargo set carga_horaria = {cargaHoraria} where id = {id};";

            return DBHelper<Cargo>.InstanciaNpgsql.Get(sql) != null;
        }

        public bool AtualizarValorHora(long id, decimal valorHora)
        {
            var sql = $"update cadastro.cargo set valor_hora = {valorHora} where id = {id}";

            return DBHelper<Cargo>.InstanciaNpgsql.Get(sql) != null;
        }
    }
}
