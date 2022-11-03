using BaterPonto.Domain.Entities;
using BaterPonto.Infra.Maps;
using Xunit;
using static Slapper.AutoMapper;

namespace BaterPonto.Testes.Maps
{
    public class FuncionarioMapTestes
    {
        [Fact(DisplayName = "FuncionarioMap Sucesso")]
        [Trait("Categoria", "Map Funcionario")]
        public void Map_FuncionarioMap_Sucesso()
        {
            var funcionario = new Funcionario(1,
                                             "Joao Santos", 
                                             "11122233344", 
                                             DateTime.Now, 
                                             DateTime.Now, 
                                             1, 
                                             new Cargo()
                                            );

            var map = new FuncionarioMap();
        }      
    }
}
