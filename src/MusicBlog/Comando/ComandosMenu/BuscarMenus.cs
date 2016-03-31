using Comun.Entidades;
using DAO.Fabrica;
using DAO.IDao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando.ComandosMenu
{
    public class BuscarMenus: Comando<Boolean,IList<Menu>>
    {
        private IDaoBase<Menu> _dao;

        public BuscarMenus(Boolean vof)
            :base(vof)
        {
            _dao = FabricaDao.ObtenerDaoMenu();
        }
        public override void Ejecutar()
        {
            try 
            {
                _parametroResultado = _dao.BuscarTodos();
            }
            catch( Exception ex)
            {
                throw ex;
            }
        }
    }
}
