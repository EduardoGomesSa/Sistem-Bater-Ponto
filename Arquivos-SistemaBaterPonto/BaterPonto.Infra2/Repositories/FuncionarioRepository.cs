using BaterPonto.Domain.Entities;
using BaterPonto.Infra.Interfaces;
using BaterPonto.Infra.Maps;
using BaterPonto.Infra.Repositories.Data;
using Microsoft.VisualBasic;

namespace BaterPonto.Infra.Repositories
{
    public class FuncionarioRepository : BaseRepository<Funcionario, FuncionarioMap>, IFuncionarioRepository
    {
        public bool AtualizarDataFimContratacao(long id, DateTime dataFim)
        {
            var query = $"update cadastro.funcionario set data_fim_contratacao = '{dataFim}' where id = {id};";

            return DBHelper<Funcionario>.InstanciaNpgsql.Get(query) != null;
        }

        public bool AtualizarNome(long id, string nome)
        {
            var query = $"update cadastro.funcionario set nome = '{nome}' where id = {id};";

            return DBHelper<Funcionario>.InstanciaNpgsql.Get(query) != null;
        }
    }
}
