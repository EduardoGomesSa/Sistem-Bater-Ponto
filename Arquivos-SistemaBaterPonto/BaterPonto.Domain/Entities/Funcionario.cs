
namespace BaterPonto.Domain.Entities
{
    public class Funcionario
    {
        public Funcionario(int id, string? nome, string? cpf, DateTime dataInicioContratacao, DateTime? dataFimContratacao, Cargo cargo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            DataInicioContratacao = dataInicioContratacao;
            DataFimContratacao = dataFimContratacao;
            Cargo = cargo;
        }

        public int Id { get; private set; }
        public string? Nome { get; private set; }
        public string? Cpf { get; private set; }
        public DateTime DataInicioContratacao { get; private set; }
        public DateTime? DataFimContratacao { get; private set; }
        public Cargo Cargo { get; private set; }
    }
}
