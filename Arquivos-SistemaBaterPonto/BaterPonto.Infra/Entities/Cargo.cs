using System;
using System.Collections.Generic;
using System.Text;

namespace BaterPonto.Infra.Entities
{
    public class Cargo
    {
        public Cargo(int id, string? nome, int cargaHoraria)
        {
            Id = id;
            Nome = nome;
            CargaHoraria = cargaHoraria;
        }

        public int Id { get; private set; }
        public string? Nome { get; private set; }
        public int CargaHoraria { get; private set; }
    }
}
