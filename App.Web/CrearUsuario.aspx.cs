using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App.Negocio;

namespace App.Web
{
    public partial class CrearUsuario : System.Web.UI.Page
    {
        //propiedad
        private List<Usuario> MiListaUsuarios
        {
            //este "get" funciona como un constructor
            get
            {
                //si la variable no existe, la crea
                if (Session["listaUsuarios"] == null)
                {
                    Session["listaUsuarios"] = new List<Usuario>();
                }
                //obtiene la variable
                return (List<Usuario>)Session["listaUsuarios"];
            }

            set
            {
                Session["listaUsuarios"] = value;
            }
        }

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
            Usuario nuevo = new Usuario();
            nuevo.Nombre = TxtNombre.Text;
            nuevo.Clave = TxtClave.Text;

            //Al escribir MiListaUsuarios, llamamos al constructor "get" explicado más arriba
            //MiListaUsuarios es un objeto List con un método Add
            MiListaUsuarios.Add(nuevo);

            lblMensaje.Text = "Usuario creado.";
        }
    }
}