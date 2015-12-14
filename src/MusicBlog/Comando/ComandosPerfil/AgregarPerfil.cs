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
    public class AgregarPerfil : Comando<Perfil,Boolean>
    {
        private IDaoBase<Perfil> _dao;

        public AgregarPerfil(Perfil perfil)
            : base(perfil)
        {
            _dao = FabricaDao.ObtenerDaoPerfil();
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
