using BaterPonto.Infra.Interfaces;
using BaterPonto.Infra.Repositories.Data;
using DapperExtensions;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BaterPonto.Infra.Repositories
{
    public class BaseRepository<TEntity, TMap> : IBaseRepository<TEntity>
        where TEntity : class
    {
        public BaseRepository()
        {
            DapperExtensions.DapperExtensions.SetMappingAssemblies(new List<Assembly> { typeof(TMap).Assembly });
        }

        public virtual bool Atualizar(TEntity entity)
        {
            return DBHelper<TEntity>.InstanciaNpgsql.Atualizar(entity);
        }

        public virtual bool Excluir(TEntity entity)
        {
            return DBHelper<TEntity>.InstanciaNpgsql.Excluir(entity);
        }

        public virtual Int64 Inserir(TEntity entity)
        {
            return DBHelper<TEntity>.InstanciaNpgsql.Inserir(entity);
        }

        public virtual TEntity BuscarPorId(long id)
        {
            return DBHelper<TEntity>.InstanciaNpgsql.Get(id);

        }

        public virtual List<TEntity> BuscarTodos()
        {
            return DBHelper<TEntity>.InstanciaNpgsql.GetAll();

        }

        public void Commit()
        {
            DBHelper<TEntity>.InstanciaNpgsql.CommitTransaction();
        }

        public void Roolback()
        {
            DBHelper<TEntity>.InstanciaNpgsql.RollbackTransaction();
        }

        public void IniciarTransacao()
        {
            DBHelper<TEntity>.InstanciaNpgsql.BeginTransaction();
        }
    }
}
