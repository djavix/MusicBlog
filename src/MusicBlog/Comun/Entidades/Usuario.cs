using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun.Entidades
{
    public class Usuario : Entidad
    {
        private string _nick;
        private string _password;
        private Rol _rol;

        public Usuario()
            : base()
        {

        }

        public virtual string Nick
        {
            get { return _nick; }
            set { _nick = value; }
        }

        public virtual string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public virtual Rol Rol
        {
            get { return _rol; }
            set { _rol = value; }
        }
    }
}
