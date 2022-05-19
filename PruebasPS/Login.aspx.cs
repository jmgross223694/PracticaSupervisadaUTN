using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace PruebasPS
{
    public partial class Login : System.Web.UI.Page
    {
        private List<Alumno> listaAlumnos = new List<Alumno>();

        protected void Page_Load(object sender, EventArgs e)
        {
            dgvAlumnos.Visible = true;

            AlumnoDB aDB = new AlumnoDB();
            listaAlumnos = aDB.ListarAlumnos();

            dgvAlumnos.DataSource = listaAlumnos;
            dgvAlumnos.DataBind();
        }
    }
}