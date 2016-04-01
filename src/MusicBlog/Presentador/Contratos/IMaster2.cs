using Comun.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentador.Contratos
{
    public interface IMaster2
    {
        IList<Menu> Menu { set; }
    }
}
