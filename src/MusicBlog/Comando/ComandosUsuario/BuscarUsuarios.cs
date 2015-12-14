using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comun.Entidades;
using DAO.Fabrica;
using DAO.IDao;

namespace Comando.ComandosUsuario
{
    public class BuscarUsuarios : Comando<Boolean,IList<Usuario>>
    {
        private IDaoBase<Usuario> _dao;

        public BuscarUsuarios(Boolean vof)
            : base(vof)
        {
            _dao = FabricaDao.ObtenerDaoUsuario();
        }

        public override void Ejecutar()
        {
            try
            {
                _parametroResultado = _dao.BuscarTodos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
