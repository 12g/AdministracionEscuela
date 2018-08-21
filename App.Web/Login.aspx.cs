using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App.Negocio;

namespace App.Web
{
    public partial class Login : System.Web.UI.Page
    {
        private Usuario sesionActiva
        {
            get
            {
                if (Session["miSesion"] == null)
                {
                    Session["miSesion"] = new Usuario();
                }
                return (Usuario) Session["miSesion"];
            }
            set
            {
                sesionActiva = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void BtnEntrar_Click(object sender, EventArgs e)
        {
            Usuario sesion = new Usuario();

            sesion.Nombre = TxtUsuario.Text;
            sesion.Clave = TxtClave.Text;

            sesionActiva = sesion;

            Server.TransferRequest("Home.aspx");
        }
    }
}