using System;
using System.Collections.Generic;
using System.Text;

namespace BaterPonto.Infra.Entities
{
    public class Funcionario
    {
        public Funcionario(int id, string cpf, decimal salario, int horasTrabalhadas)
        {
            Id = id;
            Cpf = cpf;
            Salario = salario;
            HorasTrabalhadas = horasTrabalhadas;
        }

        public int Id { get; private set; }
        public string Cpf { get; set; }
        public decimal Salario { get; private set; }
        public int HorasTrabalhadas { get; private set; }
    }
}
