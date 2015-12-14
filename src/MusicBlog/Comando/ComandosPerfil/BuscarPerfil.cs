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
    public class BuscarPerfil : Comando<Perfil,Perfil>
    {
        private IDaoBase<Perfil> _dao;

        public BuscarPerfil(Perfil perfil)
            : base(perfil)
        {
            _dao = FabricaDao.ObtenerDaoPerfil();
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
