
namespace BaterPonto.Domain.Entities
{
    public class Funcionario
    {
        public Funcionario()
        {

        }

        public Funcionario(Int64 id, string? nome, string? cpf, DateTime dataInicioContratacao, DateTime? dataFimContratacao, int idCargo, Cargo cargo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            DataInicioContratacao = dataInicioContratacao;
            DataFimContratacao = dataFimContratacao;
            IdCargo = idCargo;
            Cargo = cargo;

        }

        public Int64 Id { get; private set; }
        public string? Nome { get; private set; }
        public string? Cpf { get; private set; }
        public DateTime DataInicioContratacao { get; private set; }
        public DateTime? DataFimContratacao { get; private set; }
        public Int64 IdCargo { get; private set; }
        public Cargo Cargo { get; private set; }

        public void SetIdCargo(Int64 id)
        {
            this.IdCargo = id;
            this.Cargo = null;
        }
    }
}
