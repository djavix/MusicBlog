using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comun.Entidades;

namespace PruebasUnitarias
{
    public class Mock
    {
        public static Usuario ObtenerUsuario()
        {
            Usuario user = new Usuario();
            user.Nick = "javierv";
            user.Password = "sa123!!";
            return user;
        }

        public static Perfil ObtenerPefil()
        {
            Perfil perfil = new Perfil();
            perfil.Nombre = "Javier";
            perfil.Apellido = "Velasquez";
            perfil.FechaNacimiento = new DateTime(1992, 7, 17);
            perfil.Sexo = 'M';
            perfil.Correo = "djavix.17@gmail.com";
            return perfil;
        }
    }
}
