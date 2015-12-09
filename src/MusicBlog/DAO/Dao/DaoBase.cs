using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comun.Entidades;
using DAO.IDao;
using DAO.NHibernate;
using NHibernate;

namespace DAO.Dao
{
    public class DaoBase<TEntidad> : IDaoBase<TEntidad> where TEntidad : Entidad
    {
        #region Variables
        public readonly ISession _session;
        private ITransaction _transaction;
        #endregion

        #region Constructor

        public DaoBase()
        {
            _session = new NHibernateManager().Session;
        }

        #endregion

        public void Agregar(TEntidad entidad)
        {
            try
            {
                _transaction = _session.BeginTransaction();
                _session.Save(entidad);
                _transaction.Commit();
            }
            catch (Exception e)
            {
                _transaction.Rollback();
                throw e;
            }
        }

        public void Modificar(TEntidad entidad)
        {
            try
            {
                _transaction = _session.BeginTransaction();
                _session.Update(entidad);
                _transaction.Commit();
            }
            catch (Exception e)
            {
                _transaction.Rollback();
                throw e;
            }
        }

        public void Eliminar(TEntidad entidad)
        {
            try
            {
                _transaction = _session.BeginTransaction();
                _session.Delete(entidad);
                _transaction.Commit();
            }
            catch (Exception e)
            {
                _transaction.Rollback();
                throw e;
            }
        }

        public TEntidad BuscarPorId(int id)
        {
            TEntidad retorno = null;
            try
            {
                retorno = _session.Get<TEntidad>(id);
            }
            catch (Exception e)
            {
                throw e;
            }
            return retorno;
        }

        public IList<TEntidad> BuscarTodos()
        {
            IList<TEntidad> list = null;
            try
            {
                list = _session.CreateCriteria(typeof(TEntidad)).List<TEntidad>();
            }
            catch (Exception e)
            {
                throw e;
            }
            return list;
        }
    }
}
