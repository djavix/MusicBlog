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
    public class AgregarUsuario : Comando<Usuario,Boolean>
    {
        private IDaoBase<Usuario> _dao;

        public AgregarUsuario(Usuario usuario)
            : base(usuario)
        {
            _dao = FabricaDao.ObtenerDaoUsuario();
        }

        public override void Ejecutar()
        {
            try
            {
                _dao.Agregar(_parametroEntrada);
                _parametroResultado = _parametroEntrada.Id > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
