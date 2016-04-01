using Presentador.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
	public partial class MusicBlog2 : System.Web.UI.MasterPage, IMaster2
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		}

        IList<Comun.Entidades.Menu> IMaster2.Menu
        {
            set 
            {
                if (value != null  && value.Count > 0)
                {
                    foreach(Comun.Entidades.Menu item in value)
                    {
                        MenuItem menu = new MenuItem();
                        menu.Value = item.Id;
                        menu.Text = item.Nombre;
                        menu.NavigateUrl = item.Url;

                        Menu.Items.Add(menu);
                    }
                }
                else
                {
                    Menu.Visible = false;
                }
            }
        }
    }
}