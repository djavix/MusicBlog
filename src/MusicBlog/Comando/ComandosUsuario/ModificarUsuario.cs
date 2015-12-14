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
    public class ModificarUsuario : Comando<Usuario,Boolean>
    {
        private IDaoBase<Usuario> _dao;

        public ModificarUsuario(Usuario usuario)
            : base(usuario)
        {
            _dao = FabricaDao.ObtenerDaoUsuario();
        }

        public override void Ejecutar()
        {
            try
            {
                _dao.Modificar(_parametroEntrada);
                _parametroResultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
