using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebasPS
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string pagina = HttpContext.Current.Request.Url.AbsoluteUri;

            BtnLogin.Visible = false;
            BtnInicio.Visible = false;

            if (Session["login"] != null)
            {
                if (pagina == "https://localhost:44395/AnalizarExcel.aspx"
                    || pagina == "https://localhost:44395/Reporte1.aspx"
                    || pagina == "https://localhost:44395/Reporte2.aspx")
                {
                    BtnInicio.Visible = true;
                }

                BtnLogin.Visible = false;
                BtnCerrarSesion.Visible = true;
            }
            else
            {
                if (pagina == "https://localhost:44395/Error.aspx")
                {
                    BtnLogin.Visible = true;
                }
            }
        }

        protected void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Logout();
            Response.Redirect("Login.aspx", false);
        }

        public void Logout()
        {
            Session.Abandon();
            Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx", false);
        }

        protected void BtnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx", false);
        }
    }
}