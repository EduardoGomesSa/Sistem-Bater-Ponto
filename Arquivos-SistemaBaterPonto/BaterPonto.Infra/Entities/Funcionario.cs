using System;

namespace BaterPonto.Infra.Entities
{
    public class Funcionario
    {
        public Funcionario(int id, string nome, string cpf, decimal salario, int horasTrabalhadas)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Salario = salario;
            HorasTrabalhadas = horasTrabalhadas;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public decimal Salario { get; private set; }
        public DateTime DataInicioContratacao { get; private set; }
        public DateTime DataFimContratacao { get; private set; }
        public int HorasTrabalhadas { get; private set; }
    }
}
