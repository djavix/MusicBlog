using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun.Entidades
{
    public class Rol: Entidad
    {
        private string _nombre;

        public Rol()
            : base()
        {
        }

        public virtual string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
    }
}
