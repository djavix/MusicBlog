using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun.Entidades
{
    public class Menu: Entidad
    {
        private string _seccion;
        private string _nombre;
        private string _url;

        public Menu()
            : base()
        {
        }

        public virtual string Seccion
        {
            get { return _seccion; }
            set { _seccion = value; }
        }

        public virtual string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public virtual string Url
        {
            get { return _url; }
            set { _url = value; }
        }
    }
}
