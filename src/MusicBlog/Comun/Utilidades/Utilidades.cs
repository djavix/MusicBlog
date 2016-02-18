using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun.Utilidades
{
    public class Utilidades
    {
        public static DateTime ConvertirStringAFecha(string fecha)
        {
            return Convert.ToDateTime(fecha);
        }
    }
}
