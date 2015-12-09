using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comun.Entidades;
using DAO.Fabrica;
using DAO.IDao;
using NUnit.Framework;

namespace PruebasUnitarias.PruebasDao
{
    [TestFixture]
    public class DaoUsuarioTest
    {
        #region Atributos

        private IDaoUsuario dao;
        private Usuario usuario;
        private bool agregar = false;

        #endregion

        #region SetUp
        [SetUp]
        public void Init()
        {
            dao = FabricaDao.ObtenerDaoUsuario();
            usuario = Mock.ObtenerUsuario();
            agregar = false;
        }
        #endregion

        #region Tests
        [Test]
        public void Agregar()
        {
            dao.Agregar(usuario);
            Assert.AreNotEqual(usuario.Id, 0);
            agregar = true;
        }
        #endregion

        #region TearDown
        [TearDown]
        public void Dispose()
        {
            if (agregar)
            {
                dao.Eliminar(usuario);
            }
        }
        #endregion
    }
}
