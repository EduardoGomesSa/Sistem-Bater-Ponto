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

            return DBHelper<Cargo>.InstanciaNpgsql.GetQuery(sql).FirstOrDefault();
        }

        public bool AtualizarNome(long id, string nome)
        {
            var sql = $"update cadastro.cargo set nome = '{nome}' where id = {id};";

            return DBHelper<Cargo>.InstanciaNpgsql.Get(sql) > 0;
        }
    }
}
