using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Dao;
using DAO.IDao;

namespace DAO.Fabrica
{
    public class FabricaDao
    {
        public static IDaoUsuario ObtenerDaoUsuario()
        {
            return new DaoUsuario();
        }
    }
}
