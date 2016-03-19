using Comun.Entidades;
using DAO.IDao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Dao
{
    public class DaoRol : DaoBase<Rol>, IDaoRol
    {
        #region Constructor
        public DaoRol()
            : base()
        {
        }
        #endregion
    }
}
