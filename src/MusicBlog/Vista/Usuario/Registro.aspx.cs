using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Presentador.Contratos;
using Presentador.Presenters;

namespace Vista.Usuario
{
    public partial class Registro : System.Web.UI.Page, IRegistro
    {
        private PresenterRegistro _presenter;

        protected void Page_Load(object sender, EventArgs e)
        {
            txtFechaNacimiento.Attributes.Add("readonly", "readonly");
            _presenter = new PresenterRegistro(this);
        }

        protected void btnCancelar_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btnRegistrar_OnClick(object sender, EventArgs e)
        {
            if (_presenter.ValidarCampos())
            {
                _presenter.RegistrarUsuario();
            }
        }

        #region Propiedades
        public string Nombre
        {
            get { return txtNombre.Text; }
        }

        public string Apellido
        {
            get { return txtApellido.Text; }
        }

        public string FechaNacimiento
        {
            get { return txtFechaNacimiento.Text; }
        }

        public string Correo
        {
            get { return txtCorreo.Text; }
        }

        public string Sexo
        {
            get { return rblSexo.SelectedValue; }
        }

        public string Nick
        {
            get { return txtUsuario.Text; }
        }

        public string Password
        {
            get { return txtPassword.Text; }
        }

        public string RepetirPassword
        {
            get { return txtRepetirPassword.Text; }
        }

        public void MostrarMensaje(bool accion, string titulo, string mensaje)
        {
            btnCancelar2.Visible = accion;
            lblTitulo.Text = titulo;
            lblMensaje.Text = mensaje;
            mpeMensaje.Show();
        }

        public Color LblErrorNombre
        {
            set { lblNombre.ForeColor = value; }
        }

        public Color LblErrorApellido
        {
            set { lblApellido.ForeColor = value; }
        }

        public Color LblErrorFechaNacimiento
        {
            set { lblFechaNacimiento.ForeColor = value; }
        }

        public Color LblErrorCorreo
        {
            set { lblCorreo.ForeColor = value; }
        }

        public Color LblErrorSexo
        {
            set { lblSexo.ForeColor = value; }
        }

        public Color LblErrorNick
        {
            set { lblUsuario.ForeColor = value; }
        }

        public Color LblErrorPassword
        {
            set { lblPassword.ForeColor = value; }
        }

        public Color LblErrorRepetirPassword
        {
            set { lblRepetirPassword.ForeColor = value; }
        }
        #endregion


    }
}