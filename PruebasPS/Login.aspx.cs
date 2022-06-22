using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace PruebasPS
{
    public partial class Login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnIngresar_Click(object sender, EventArgs e)
        {
            bool estado = false;
            UsuarioBD uBD = new UsuarioBD();

            string usuario = txtUser.Text.Trim(), clave = txtPassword.Text.Trim();

            estado = uBD.verificarUsuario(usuario, clave);

            if (estado)
            {
                LblMensaje.Visible = false;
                
                Session.Add("NombreUsuario", usuario);
                Response.Redirect("Index.aspx", true);
            }
            else
            {
                LblMensaje.Text = "Credenciales inválidas";
                LblMensaje.Visible = true;
            }


        }
    }
}


