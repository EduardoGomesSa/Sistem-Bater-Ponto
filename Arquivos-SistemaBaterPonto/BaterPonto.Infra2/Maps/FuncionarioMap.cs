using BaterPonto.Domain.Entities;
using DapperExtensions.Mapper;

namespace BaterPonto.Infra.Maps
{
    //public string? Cpf { get; private set; }
    //public DateTime DataInicioContratacao { get; private set; }
    //public DateTime? DataFimContratacao { get; private set; }
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

            Map(f => f.Cargo)
                .Ignore();

            AutoMap();
        }
    }
}
