using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebasPS
{
    public partial class Reporte1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] != null)
            {
                //mostrar todo lo que haya que mostrar.
            }
            else
            {
                //ocultar todo lo que haya que ocultar

                Session.Add("Error", "Debe loguearse para acceder a esta página.");
                Response.Redirect("Error.aspx", false);
            }
        }
    }
}