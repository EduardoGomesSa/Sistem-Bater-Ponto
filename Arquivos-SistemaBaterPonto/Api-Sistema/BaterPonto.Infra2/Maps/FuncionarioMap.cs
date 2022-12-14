using BaterPonto.Domain.Entities;
using DapperExtensions.Mapper;

namespace BaterPonto.Infra.Maps
{
    public class FuncionarioMap : ClassMapper<Funcionario>
    {
        public FuncionarioMap()
        {
            Table("funcionario");
            Schema("cadastro");

            Map(f => f.Id)
                .Column("id")
                .Key(KeyType.Identity);

            Map(f => f.Nome)
                .Column("nome");

            Map(f => f.Cpf)
                .Column("cpf");

            Map(f => f.DataInicioContratacao)
                .Column("data_inicio_contratacao");

            Map(f => f.DataFimContratacao)
                .Column("data_fim_contratacao");

            Map(f => f.IdCargo)
                .Column("id_cargo");

            Map(f => f.Cargo)
                .Ignore();

            AutoMap();
        }
    }
}
