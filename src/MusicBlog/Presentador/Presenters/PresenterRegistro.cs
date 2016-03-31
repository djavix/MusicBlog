using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Comando;
using Presentador.Contratos;
using Comun.Recursos;
using Comun.Entidades;
using Comun.Enum;
using Comun.Utilidades;

namespace Presentador.Presenters
{
    public class PresenterRegistro
    {
        private IRegistro view;

        public PresenterRegistro(IRegistro page)
        {
            view = page;
        }

        #region Metodos Publicos
        public bool ValidarCampos()
        {
            bool validos = true;
            bool camposVacios = false;
            bool passwordValido = false;
            bool formatoInvalido = false;
            string mnjError = string.Empty;

            if (view.Nombre == string.Empty)
            {
                view.LblErrorNombre = Color.Red;
                camposVacios = true;
            }
            if (view.Apellido == string.Empty)
            {
                view.LblErrorApellido = Color.Red;
                camposVacios = true;
            }
            if (view.FechaNacimiento == string.Empty)
            {
                view.LblErrorFechaNacimiento = Color.Red;
                camposVacios = true;
            }
            if (view.Sexo == string.Empty)
            {
                view.LblErrorSexo = Color.Red;
                camposVacios = true;
            }
            if (view.Correo == string.Empty)
            {
                view.LblErrorCorreo = Color.Red;
                camposVacios = true;
            }
            else
            {
                formatoInvalido = ValidarFormatoCorreo();
            }
            if (view.Nick == string.Empty)
            {
                view.LblErrorNick = Color.Red;
            }
            if (view.Password == string.Empty)
            {
                view.LblErrorPassword = Color.Red;
                camposVacios = true;
            }
            if (view.RepetirPassword == string.Empty)
            {
                view.LblErrorRepetirPassword = Color.Red;
            }
            else
            {
                passwordValido = CompararPassword();
            }

            if (camposVacios)
            {
                mnjError += Mensajes.CampoObligatorios;
                validos = false;
            }
            if (formatoInvalido)
            {
                mnjError += Mensajes.FormatoCorreoErroneo;
                validos = false;
            }
            if (!passwordValido)
            {
                mnjError += Mensajes.CoincidenciaDePasswords;
                validos = false;
            }

            if (!validos)
            {
                view.MostrarMensaje(false,Mensajes.TituloError,mnjError);
            }

            return validos;
        }

        public void RegistrarUsuario()
        {
            Perfil perfil = ObtenerPerfil();
            try
            {
                Comando<Perfil, bool> comando = FabricaComando.ObtenerComandoAgregarPerfil(perfil);
                comando.Ejecutar();
                if (comando.Resultado)
                {
                    view.MostrarMensaje(false,string.Empty,Mensajes.RegistroExitoso);
                }

            }
            catch (Exception ex)
            {
                
                view.MostrarMensaje(false,Mensajes.TituloError,Mensajes.ErrorDeSistema);
            }
        }

        #endregion

        #region Metodos Privados
        private bool ValidarFormatoCorreo()
        {
            string expresion = ExpresionesRegulares.Correo;
            if (Regex.IsMatch(view.Correo, expresion))
            {
                if (Regex.Replace(view.Correo, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private bool CompararPassword()
        {
            bool igual = view.Password == view.RepetirPassword;
            return igual;
        }

        private Perfil ObtenerPerfil()
        {
            Perfil perfil = new Perfil();
            perfil.Nombre = view.Nombre;
            perfil.Apellido = view.Apellido;
            perfil.FechaNacimiento = Utilidades.ConvertirStringAFecha(view.FechaNacimiento);
            perfil.Sexo = view.Sexo[0];
            perfil.Correo = view.Correo;
            perfil.Usuario = ObtnerUsuario();
            return perfil;
        }

        private Usuario ObtnerUsuario()
        {
            Usuario usuario = new Usuario();
            usuario.Nick = view.Nick;
            usuario.Password = view.Password;
            usuario.Rol = ObtenerRolUsuario();
            return usuario;
        }

        private Rol ObtenerRolUsuario()
        {
            Rol rol = new Rol();
            rol.Id = (int)EnumRol.Usuario;
            return rol;
        }

        #endregion
    }
}
