using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Presentador.Contratos;
using Presentador.Presenters;

namespace Vista.Usuario
{
    public partial class Login : System.Web.UI.Page, IPresenterUsuario
    {
        private PresenterUsuario _presentardor;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                _presentardor = new PresenterUsuario(this);
                _presentardor.InicializarComponentesDeMensaje(btnEntrar.ClientID);
            }
        }



        public string Nick
        {
            get { return txtUser.Text; }
            set { txtUser.Text = value; }
        }

        public string Password
        {
            get { return txtPasword.Text; }
            set { txtPasword.Text = value; }
        }

        protected void btnEntrar_OnClick(object sender, EventArgs e)
        {

        }
    }
}