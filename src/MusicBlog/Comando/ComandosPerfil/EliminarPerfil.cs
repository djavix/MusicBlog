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
    public class EliminarPerfil : Comando<Perfil,Boolean>
    {
        private IDaoBase<Perfil> _dao;

        public EliminarPerfil(Perfil perfil)
            : base(perfil)
        {
            _dao = FabricaDao.ObtenerDaoPerfil();
        }

        public override void Ejecutar()
        {
            try
            {
                _dao.Eliminar(_parametroEntrada);
                _parametroResultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
