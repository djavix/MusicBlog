using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun.Entidades
{
    public abstract class Entidad
    {
        private int _id;

        public Entidad()
        {
        }

        public virtual int Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
