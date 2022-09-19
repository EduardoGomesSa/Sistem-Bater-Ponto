﻿using BaterPonto.Infra.Repositories.Data;
using System.Collections.Generic;
using System;

namespace BaterPonto.Infra.Interfaces
{
    public interface IBaseRepository<TEntity>
    {
        bool Atualizar(TEntity entity);

        bool Excluir(TEntity entity);

        Int64 Inserir(TEntity entity);

        TEntity BuscarPorId(long id);

        List<TEntity> BuscarTodos();

        void Commit();

        void Roolback();

        void IniciarTransacao();
    }
}
