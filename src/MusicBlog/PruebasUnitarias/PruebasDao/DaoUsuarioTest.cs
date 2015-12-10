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

        [Test]
        public void Modificar()
        {
            dao.Agregar(usuario);
            usuario.Nick = "sa";
            dao.Modificar(usuario);
            Usuario result = dao.BuscarPorId(usuario.Id);
            Assert.AreEqual(usuario.Nick,result.Nick);
            agregar = true;
        }

        [Test]
        public void ConsultarPorId()
        {
            dao.Agregar(usuario);
            Usuario result = dao.BuscarPorId(usuario.Id);
            Assert.NotNull(result);
            agregar = true;
        }

        [Test]
        public void ConsultarTodos()
        {
            dao.Agregar(usuario);
            IList<Usuario> list = dao.BuscarTodos();
            Assert.NotNull(list);
            Assert.IsTrue(list.Count > 0);
            agregar = true;
        }

        [Test]
        public void Login()
        {
            dao.Agregar(usuario);
            Usuario result = dao.Login(usuario);
            Assert.IsNotNull(result);
            Assert.AreEqual(usuario.Nick,result.Nick);
            agregar = true;
        }

        [Test]
        public void ValidarNickUsuarioExiste()
        {
            dao.Agregar(usuario);
            Assert.IsTrue(dao.ValidarNickUsuario(usuario));
            agregar = true;
        }

        [Test]
        public void ValidarNickUsuarioNoExiste()
        {
            Assert.IsFalse(dao.ValidarNickUsuario(usuario));
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
