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
    public partial class Login : System.Web.UI.Page, ILogin
    {
        private PresenterLogin _presenter;
        protected void Page_Load(object sender, EventArgs e)
        {
            _presenter = new PresenterLogin(this);
            if (!IsPostBack)
            {
                
            }
        }

        protected void btnEntrar_OnClick(object sender, EventArgs e)
        {
            if(_presenter.ValidarCampos())
            {
                if (_presenter.Login())
                {

                }
            }
        }

        public string Nick
        {
            get { return txtUser.Text; }
        }

        public string Password
        {
            get { return txtPasword.Text; }
        }

        public void MostrarMensaje(bool accion, string titulo, string mensaje)
        {
            mpeMensaje.Show();
            btnCancelar.Visible = accion;
            lblTitulo.Text = titulo;
            lblMensaje.Text = mensaje;
        }
        
        public object SessionUsuario
        {
            get { return Session["Usuario"]; }
            set { Session["Usuario"] = value; }
        }
    }
}