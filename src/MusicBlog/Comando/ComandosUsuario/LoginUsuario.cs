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
    public class LoginUsuario : Comando<Usuario,Usuario>
    {
        private IDaoUsuario _dao;

        public LoginUsuario(Usuario usuario)
            : base(usuario)
        {
            _dao = FabricaDao.ObtenerDaoUsuario();
        }

        public override void Ejecutar()
        {
            try
            {
                _parametroResultado = _dao.Login(_parametroEntrada);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
