﻿using BaterPonto.Domain.Entities;

namespace BaterPonto.Infra.Interfaces
{
    public interface ICadastroCargoService
    {
        bool AtualizarNome(Int64 id, string nome);
    }
}
