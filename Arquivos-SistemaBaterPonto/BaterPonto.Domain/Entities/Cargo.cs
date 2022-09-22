using System;
using System.Collections.Generic;
using System.Text;

namespace BaterPonto.Domain.Entities
{
    public class Cargo
    {
        public Cargo()
        {

        }

        public Cargo(Int64 id, string? nome, decimal valorHora, int cargaHoraria)
        {
            Id = id;
            Nome = nome;
            ValorHora = valorHora;
            CargaHoraria = cargaHoraria;
        }

        public Int64 Id { get; private set; }
        public string? Nome { get; private set; }
        public decimal ValorHora { get; private set; }
        public int CargaHoraria { get; private set; }
    }
}
