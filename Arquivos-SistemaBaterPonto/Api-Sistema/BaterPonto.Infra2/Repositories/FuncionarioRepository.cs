using BaterPonto.Domain.Entities;
using BaterPonto.Infra.Interfaces;
using BaterPonto.Infra.Maps;
using BaterPonto.Infra.Repositories.Data;
using Microsoft.VisualBasic;
using static Slapper.AutoMapper;

namespace BaterPonto.Infra.Repositories
{
    public class FuncionarioRepository : BaseRepository<Funcionario, FuncionarioMap>, IFuncionarioRepository
    {
        public bool AtualizarDataFimContratacao(long id, DateTime dataFim)
        {
            var query = $"update cadastro.funcionario set data_fim_contratacao = '{dataFim}' where id = {id};";

            return DBHelper<Funcionario>.InstanciaNpgsql.Get(query) >= 0;
        }

        public bool AtualizarNome(long id, string nome)
        {
            var query = $"update cadastro.funcionario set nome = '{nome}' where id = {id};";

            return DBHelper<Funcionario>.InstanciaNpgsql.Get(query) >= 0;
        }

        public bool FuncionarioExiste(string cpf)
        {
            var query = $"select * from cadastro.funcionario where cpf = '{cpf}';";

            return DBHelper<Funcionario>.InstanciaNpgsql.Get(query) == 0;
        }

        public List<Funcionario> CargoTemFuncionario(long id)
        {
            var sql = $"select* from cadastro.funcionario where id_cargo = {id};";

            var funcionariosDoCargo = DBHelper<Funcionario>.InstanciaNpgsql.GetQuery(sql);

            if (funcionariosDoCargo.Count > 0) return funcionariosDoCargo;

            return new List<Funcionario>();
        }

        public bool MudarCargoFuncionario(long idFuncionario, long idCargo)
        {
            

            var query = $"update cadastro.funcionario set id_cargo = {idCargo} where id = {idFuncionario};";

            return DBHelper<Funcionario>.InstanciaNpgsql.Get(query) >= 0;
        }
    }
}
