using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace App.Web
{
    public partial class CrearUsuario : System.Web.UI.Page
    {
        //propiedad
        /*public List<Object> GetListaUsuarios
        {
            //este "get" funciona como un constructor
            get
            {
                //si la variable no existe, la crea
                if (Session["listaUsuarios"] == null)
                {
                    Session["listaUsuarios"] = null;
                }
                //obtiene la variable
                return (List<>)Session["listaUsuarios"];
            }

            set
            {
                Session["listaUsuarios"] = value;
            }
        }*/

        //método
        protected void Page_Load(object sender, EventArgs e)
        {
            //desactiva la validación de campos por .net
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        }

        //método
        protected void Button1_Click(object sender, EventArgs e)
        {
            //crea el usuario y le asigna los valores directamente desde el formulario
            string nombre = TxtNombre.Text;
            string clave = TxtClave.Text;
            
            //llamar a servicio

            lblMensaje.Text = "Usuario creado.";
        }
    }
}