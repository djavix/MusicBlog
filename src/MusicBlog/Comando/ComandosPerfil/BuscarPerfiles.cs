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
    public class BuscarPerfiles : Comando<Boolean,IList<Perfil>>
    {
        private IDaoBase<Perfil> _dao;

        public BuscarPerfiles(Boolean vof)
            : base(vof)
        {
            _dao = FabricaDao.ObtenerDaoPerfil();
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
