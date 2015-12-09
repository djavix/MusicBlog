using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comun.Entidades;
using DAO.IDao;

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
    }
}
