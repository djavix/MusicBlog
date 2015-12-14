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
    public class DaoPerfilTest
    {
        #region Atributos

        private IDaoPerfil dao;
        private Perfil perfil;
        private bool agregar = false;

        #endregion

        #region SetUp
        [SetUp]
        public void Init()
        {
            dao = FabricaDao.ObtenerDaoPerfil();
            perfil = Mock.ObtenerPefil();
            agregar = false;
        }
        #endregion

        #region Tests
        [Test]
        public void Agregar()
        {
            dao.Agregar(perfil);
            Assert.AreNotEqual(perfil.Id, 0);
            agregar = true;
        }

        [Test]
        public void Modificar()
        {
            dao.Agregar(perfil);
            perfil.Nombre = "sa";
            dao.Modificar(perfil);
            Perfil result = dao.BuscarPorId(perfil.Id);
            Assert.AreEqual(perfil.Nombre, result.Nombre);
            agregar = true;
        }

        [Test]
        public void ConsultarPorId()
        {
            dao.Agregar(perfil);
            Perfil result = dao.BuscarPorId(perfil.Id);
            Assert.NotNull(result);
            agregar = true;
        }

        [Test]
        public void ConsultarTodos()
        {
            dao.Agregar(perfil);
            IList<Perfil> list = dao.BuscarTodos();
            Assert.NotNull(list);
            Assert.IsTrue(list.Count > 0);
            agregar = true;
        }

        [Test]
        public void AgregarPerfilConUsuario()
        {
            perfil.Usuario = Mock.ObtenerUsuario();
            dao.Agregar(perfil);
            Assert.AreNotEqual(perfil.Id, 0);
            agregar = true;
        }

        [Test]
        public void BuscarPerfilPorUsuario()
        {
            perfil.Usuario = Mock.ObtenerUsuario();
            dao.Agregar(perfil);
            Perfil result = dao.BuscarPerfilPorUsuario(Mock.ObtenerUsuario());
            Assert.IsNotNull(result);
            Assert.AreEqual(perfil.Id,result.Id);
            Assert.AreEqual(perfil.Usuario.Id,result.Usuario.Id);
            agregar = true;
        }
        #endregion

        #region TearDown
        [TearDown]
        public void Dispose()
        {
            if (agregar)
            {
                dao.Eliminar(perfil);
            }
        }
        #endregion
    }
}
