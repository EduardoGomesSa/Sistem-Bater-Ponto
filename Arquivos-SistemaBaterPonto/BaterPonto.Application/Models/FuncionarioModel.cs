namespace BaterPonto.Application.Models
{
    public class FuncionarioModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataInicioContratacao { get; set; }
        public DateTime? DataFimContratacao { get; set; }
        public int HorasTrabalhadas { get; set; }
    }
}
