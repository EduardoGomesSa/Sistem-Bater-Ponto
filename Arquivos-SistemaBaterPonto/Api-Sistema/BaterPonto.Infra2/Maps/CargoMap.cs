using BaterPonto.Domain.Entities;
using DapperExtensions.Mapper;

namespace BaterPonto.Infra.Maps
{
    public class CargoMap : ClassMapper<Cargo>
    {
        public CargoMap()
        {
            Table("cargo");
            Schema("cadastro");

            Map(c => c.Id)
                .Column("id")
                .Key(KeyType.Identity);

            Map(c => c.Nome)
                .Column("nome");

            Map(c => c.ValorHora)
                .Column("valor_hora");

            Map(c => c.CargaHoraria)
                .Column("carga_horaria");

            AutoMap();
        }
    }
}
