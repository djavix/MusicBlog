using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comun.Entidades;
using DAO.IDao;
using NHibernate;

namespace DAO.Dao
{
    public class DaoUsuario : DaoBase<Usuario>, IDaoUsuario
    {
        #region Constructor
        public DaoUsuario()
            : base()
        {
        }
        #endregion

        #region Implementacion
        public Usuario Login(Usuario usuario)
        {
            Usuario result = null;

            try
            {
                IQueryOver<Usuario> query =
                    _session.QueryOver<Usuario>()
                        .Where(u => u.Nick == usuario.Nick)
                        .And(u => u.Password == usuario.Password);
                result = query.SingleOrDefault();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            return result;
        }

        public bool ValidarNickUsuario(Usuario usuario)
        {
            bool existe = false;
            Usuario user = null;
            try
            {
                IQueryOver<Usuario> query =
                    _session.QueryOver<Usuario>()
                        .Where(u => u.Nick == usuario.Nick);
                user = query.SingleOrDefault();
                if (user != null)
                    existe = true;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            return existe;
        }
        #endregion

       
    }
}
