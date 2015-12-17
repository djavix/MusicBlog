using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentador.Contratos;

namespace Presentador.Presenters
{
    public class PresenterBase
    {
        private IPresenterBase _pagina;

        public PresenterBase(IPresenterBase pagina)
        {
            this._pagina = pagina;
        }

        public void InicializarComponentesDeMensaje(string control)
        {
            _pagina.Accionador = control;
        }
    }
}
