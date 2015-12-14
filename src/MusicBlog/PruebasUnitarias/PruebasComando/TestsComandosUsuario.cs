using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comando;
using Comun.Entidades;
using NUnit.Framework;

namespace PruebasUnitarias.PruebasComando
{
    [TestFixture]
    public class TestsComandosUsuario
    {
        #region Atributos

        private Usuario _usuario;
        private bool agregar;

        #endregion

        #region SetUp
        [SetUp]
        public void Init()
        {
            _usuario = Mock.ObtenerUsuario();
            agregar = false;
        }
        #endregion

        #region Tests

        [Test]
        public void Agregar()
        {
            Comando<Usuario, Boolean> comando = FabricaComando.ObtenerComandoAgregarUsuario(_usuario);
            comando.Ejecutar();
            Assert.IsTrue(comando.Resultado);
            agregar = true;
        }

        [Test]

        #endregion

        #region TearDown
        [TearDown]
        public void Dispose()
        {
            if (agregar)
            {
                Comando<Usuario, Boolean> comando = FabricaComando.ObtenerComandoEliminarUsuario(_usuario);
                comando.Ejecutar();
            }
        }
        #endregion
    }
}
