using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentador.Contratos;

namespace Presentador.Presenters
{
    public class PresenterUsuario: PresenterBase
    {
        private IPresenterUsuario _pagina;

        public PresenterUsuario(IPresenterUsuario pagina)
            : base(pagina)
        {
            this._pagina = pagina;
        }
    }
}
