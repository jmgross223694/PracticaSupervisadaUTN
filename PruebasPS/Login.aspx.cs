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
            UsuarioBD perfil = new UsuarioBD();
            Usuario user = new Usuario();

            estado = perfil.verificarUsuario(txtUser.Text.Trim(), txtPassword.Text.Trim());
            if (estado == true)
            {

                //  Session["NombreUsuario"] = txtUser.Text.Trim();


                // user.UsuarioMp=(txtUser.Text);


                LblMensaje.Visible = false;
                
                    Session.Add("login", "correcto");
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


