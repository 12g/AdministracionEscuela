using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App.Negocio;

namespace App.Web
{
    public partial class EditarUsuario : System.Web.UI.Page
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

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            String nombreUsuarioBuscar = txtNombreBuscar.Text;

            foreach (Usuario item in MiListaUsuarios)
            {
                if (item.Nombre == nombreUsuarioBuscar)
                {
                    txtNombreCargado.Text = item.Nombre;
                    txtClaveCargada.Text = item.Clave;
                    break;
                }
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            String nombreUsuarioBuscar = txtNombreBuscar.Text;

            foreach (Usuario item in MiListaUsuarios)
            {
                if (item.Nombre == nombreUsuarioBuscar)
                {
                    item.Nombre = txtNombreCargado.Text;
                    item.Clave = txtClaveCargada.Text;
                    break;
                }
            }
        }
    }
}