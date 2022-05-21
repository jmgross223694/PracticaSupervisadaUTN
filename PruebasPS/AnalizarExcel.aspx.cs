using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using SpreadsheetLight;

namespace PruebasPS
{
    public partial class AnalizarExcel : System.Web.UI.Page
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

        private void RecorrerArchivo(SLDocument archivo)
        {
            int iRow = 1, iCol = 1, cantFilas = 0, cantColumnas = 0;

            while (!string.IsNullOrEmpty(archivo.GetCellValueAsString(iRow, 1))) //Cuenta la cantidad de filas con datos que tiene el archivo
            {
                iRow++;
                cantFilas++;
            }

            while (!string.IsNullOrEmpty(archivo.GetCellValueAsString(1, iCol))) //Cuenta la cantidad de columnas con datos que tiene el archivo
            {
                iCol++;
                cantColumnas++;
            }

            string cadena = "";

            for(iRow = 1;  iRow <= cantFilas; iRow++)
            { 
                for(iCol = 1; iCol <= cantColumnas; iCol++)
                {
                    string valor = archivo.GetCellValueAsString(iRow, iCol); //Recorremos el archivo celda por celda y obtenemos su respectivo valor

                    cadena += " | " + valor;
                }
            }

            cadena += " |";

            MostrarMensaje(cadena); //Mostramos todos los valores de las celdas concatenados
        }

        private void LeerArchivo(string extension)
        {
            string ruta = "C:/Users/Juanma/Desktop/GitHub/PracticaSupervisadaUTN/PruebasPS/Planillas_Subidas/";

            SLDocument sl = new SLDocument(@"" + ruta + "Libro1." + extension); //Abrimos el archivo que se acaba de guardar

            RecorrerArchivo(sl);
        }

        protected void BtnProcesarArchivo_Click(object sender, EventArgs e)
        {
            if (CargarArchivo.HasFile) //Validamos que se halla seleccionado algún archivo
            {
                string extension = System.IO.Path.GetExtension(CargarArchivo.FileName); //Obtenemos la extension del archivo seleccionado
                extension = extension.ToLower();

                int tam = CargarArchivo.PostedFile.ContentLength; //Obtenemos el tamaño del archivo seleccionado

                if (extension == ".xlsx" || extension == ".xls") //Validamos el formato del archivo seleccionado
                {
                    if (tam <= 1048576) //Validamos su tamaño (en bytes)
                    {
                        string path = "~/Planillas_Subidas/";

                        CargarArchivo.SaveAs(Server.MapPath(path + "Libro1." + extension)); //Guardamos el archivo seleccionado en la carpeta indicada

                        LeerArchivo(extension);
                    }
                }
            }
            else
            {
                MostrarMensaje("No se seleccionó ningún archivo.");
            }
        }

        private void MostrarMensaje(string mensaje)
        {
            LblMensaje.Text = mensaje;
            LblMensaje.Visible = true;
        }
    }
}