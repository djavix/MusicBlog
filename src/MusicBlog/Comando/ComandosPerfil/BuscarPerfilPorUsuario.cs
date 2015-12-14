using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comun.Entidades;
using DAO.Fabrica;
using DAO.IDao;

namespace Comando.ComandosPerfil
{
    public class BuscarPerfilPorUsuario : Comando<Usuario,Perfil>
    {
        private IDaoPerfil _dao;

        public BuscarPerfilPorUsuario(Usuario usuario)
            : base(usuario)
        {
            _dao = FabricaDao.ObtenerDaoPerfil();
        }

        public override void Ejecutar()
        {
            try
            {
                _parametroResultado = _dao.BuscarPerfilPorUsuario(_parametroEntrada);
            }
            catch (Exception ex )
            {
                throw ex;
            }
        }
    }
}
