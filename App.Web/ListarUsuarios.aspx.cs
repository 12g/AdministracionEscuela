using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App.Negocio;

namespace App.Web
{
    public partial class ListarUsuarios : System.Web.UI.Page
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
            
            String textoListaUsuarios = "";

            //por cada usuario
            foreach (Usuario item in MiListaUsuarios)
            {
                // 'variable += x'  es  'variable = variable + x'

                //agregamos a la lista su nombre y clave, separados por un espacio
                textoListaUsuarios += item.Nombre + " " + item.Clave;
            }

            txtLista.Text = textoListaUsuarios;
        }
    }
}