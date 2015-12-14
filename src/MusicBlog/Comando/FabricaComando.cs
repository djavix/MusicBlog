using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comando.ComandosPerfil;
using Comando.ComandosUsuario;
using Comun.Entidades;

namespace Comando
{
    public class FabricaComando
    {
        //Comandos de Usuario
        public static AgregarUsuario ObtenerComandoAgregarUsuario(Usuario usuario)
        {
            return new AgregarUsuario(usuario);
        }

        public static ModificarUsuario ObtenerComandoModificarUsuario(Usuario usuario)
        {
            return new ModificarUsuario(usuario);
        }

        public static EliminarUsuario ObtenerComandoEliminarUsuario(Usuario usaurio)
        {
            return new EliminarUsuario(usaurio);
        }

        public static BuscarUsuario ObtenerComandoBuscarUsuario(Usuario usuario)
        {
            return new BuscarUsuario(usuario);
        }

        public static BuscarUsuarios ObtenerComandoBuscarUsuarios(Boolean vof)
        {
            return new BuscarUsuarios(vof);
        }

        public static LoginUsuario ObtenerComandoLoginUsuario(Usuario usuario)
        {
            return new LoginUsuario(usuario);
        }

        public static ValidarNickUsuario ObtenerComandoNickUsuario(Usuario usuario)
        {
            return new ValidarNickUsuario(usuario);
        }

        //Comandos de Perfil
        public static AgregarPerfil ObtenerComandoAgregarPerfil(Perfil perfil)
        {
            return new AgregarPerfil(perfil);
        }

        public static ModificarPerfil ObtenerComandoModificarPerfil(Perfil perfil)
        {
            return new ModificarPerfil(perfil);
        }

        public static EliminarPerfil ObtenerComandoEliminarPerfil(Perfil perfil)
        {
            return new EliminarPerfil(perfil);
        }

        public static BuscarPerfil ObtenerComandoBuscarPerfil(Perfil perfil)
        {
            return new BuscarPerfil(perfil);
        }

        public static BuscarPerfiles ObternerComandoBuscarPerfiles(Boolean vof)
        {
            return new BuscarPerfiles(vof);
        }

        public static BuscarPerfilPorUsuario ObternerComandoBuscarPerfilPorUsuario(Usuario usuario)
        {
            return new BuscarPerfilPorUsuario(usuario);
        }
    }
}
