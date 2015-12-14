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
    public class BuscarUsuario : Comando<Usuario,Usuario>
    {
        private IDaoBase<Usuario> _dao;

        public BuscarUsuario(Usuario usuario)
            : base(usuario)
        {
            _dao = FabricaDao.ObtenerDaoUsuario();
        }

        public override void Ejecutar()
        {
            try
            {
                _parametroResultado = _dao.BuscarPorId(_parametroEntrada.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
