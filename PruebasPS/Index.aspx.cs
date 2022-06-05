using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebasPS
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] != null)
            {
                BtnExcel.Visible = true;
                BtnReporte1.Visible = true;
                BtnReporte2.Visible = true;
            }
            else
            {
                Session.Add("Error", "Debe loguearse para acceder a esta página.");
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void BtnExcel_Click(object sender, EventArgs e)
        {
            Response.Redirect("AnalizarExcel.aspx", false);
        }

        protected void BtnReporte1_Click(object sender, EventArgs e)
        {

            Response.Redirect("ListarAlumnosPrueba.aspx", false);
            //Response.Redirect("Reporte1.aspx", false);
        }

        protected void BtnReporte2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reporte2.aspx", false);
        }
    }
}