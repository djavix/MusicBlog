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
    public class DaoPerfil : DaoBase<Perfil>, IDaoPerfil
    {
        #region Constructor
        public DaoPerfil()
            : base()
        {
        }
        #endregion

        #region Implementacion
        public Perfil BuscarPerfilPorUsuario(Usuario usuario)
        {
            Perfil result = null;

            try
            {
                IQueryOver<Perfil> query =
                    _session.QueryOver<Perfil>()
                    .JoinQueryOver(p => p.Usuario)
                    .Where(u => u.Nick == usuario.Nick);
                result = query.SingleOrDefault();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return result;
        }
        #endregion

        
    }
}
