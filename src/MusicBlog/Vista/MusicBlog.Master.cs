using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Presentador.Contratos;

namespace Vista
{
    public partial class MusicBlog : System.Web.UI.MasterPage , IPresenterBase
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string Accionador
        {
            set { mpeMensaje.TargetControlID = value; }
        }

        public string TituloMensaje
        {
            set { lblTitulo.Text = value; }
        }

        public string Mensaje
        {
            set { lblMensaje.Text = value; }
        }

        public void MostarMensaje(bool accion)
        {
            btnCancelar.Visible = accion;
            mpeMensaje.Show();
        }
    }
}