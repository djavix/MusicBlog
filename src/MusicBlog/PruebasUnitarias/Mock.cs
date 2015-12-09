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
    }
}
