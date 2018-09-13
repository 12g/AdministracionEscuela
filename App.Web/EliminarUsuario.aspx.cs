using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App.Negocio;

namespace App.Web
{
    public partial class EliminarUsuario : System.Web.UI.Page
    {
        //propiedad
        private List<Usuario> MiListaUsuarios
        {
            get
            {
                if (Session["listaUsuarios"] == null)
                {
                    Session["listaUsuarios"] = new List<Usuario>();
                }
                return (List<Usuario>)Session["listaUsuarios"];
            }

            set
            {
                Session["listaUsuarios"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            String usuarioAEliminar = txtNombre.Text;

            foreach (Usuario item in MiListaUsuarios)
            {
                if (item.Nombre == usuarioAEliminar)
                {
                    MiListaUsuarios.Remove(item);
                    lblMensaje.Text = "Usuario eliminado.";
                    break;
                }
            }
        }
    }
}