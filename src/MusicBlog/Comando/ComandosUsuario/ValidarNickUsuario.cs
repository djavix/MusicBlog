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
    public class ValidarNickUsuario : Comando<Usuario,Boolean>
    {
        private IDaoUsuario _dao;

        public ValidarNickUsuario(Usuario usuario)
            : base(usuario)
        {
            _dao = FabricaDao.ObtenerDaoUsuario();
        }

        public override void Ejecutar()
        {
            try
            {
                _parametroResultado = _dao.ValidarNickUsuario(_parametroEntrada);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
