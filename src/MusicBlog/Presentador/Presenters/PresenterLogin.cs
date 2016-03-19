using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comando;
using Comun.Entidades;
using Comun.Recursos;
using Presentador.Contratos;

namespace Presentador.Presenters
{
    public class PresenterLogin
    {
        private ILogin view;

        public PresenterLogin(ILogin page)
        {
            view = page;
        }

        public bool ValidarCampos()
        {
            bool valido = true;
            if (view.Nick == string.Empty || view.Password == string.Empty)
            {
                view.MostrarMensaje(false,Mensajes.TituloError,Mensajes.CamposObligatoriosLogin);
                valido = false;
            }

            return valido;
        }

        public bool Login()
        {
            bool existe = false;

            try
            {
                Comando<Usuario, Usuario> comando = FabricaComando.ObtenerComandoLoginUsuario(ObtenerUsuario());
                comando.Ejecutar();
                if (comando.Resultado != null)
                {
                    view.SessionUsuario = comando.Resultado;
                    existe = true;
                }
                else
                {
                    view.MostrarMensaje(false,Mensajes.TituloError,Mensajes.LoginFailed);
                }
            }
            catch (Exception ex)
            {

                view.MostrarMensaje(false, Mensajes.TituloError, Mensajes.ErrorDeSistema);
            }

            return existe;
        }

        #region Metodos Privados
        private Usuario ObtenerUsuario()
        {
            Usuario usuario = new Usuario();
            usuario.Nick = view.Nick;
            usuario.Password = view.Password;
            return usuario;
        }
        #endregion
    }
}
