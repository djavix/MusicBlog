using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentador.Contratos;

namespace Presentador.Presenters
{
    public class PresenterLogin
    {
        private ILogin view;

        public PresenterLogin(ILogin page)
        {
            view = page;
        }

        public bool Login(string nick, string password)
        {
            bool existe = false;

            return false;
        }
    }
}
