using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Dominio;

namespace Negocio
{
    public class AlumnoDB
    {
        public List<Alumno> ListarAlumnos()
        {
            List<Alumno> lista = new List<Alumno>();
            DB select = new DB();

            try
            {
                string consulta = "select * from ExportAlumnos";


                select.SetearConsulta(consulta);
                select.EjecutarConsulta();

                while (select.Lector.Read())
                {
                    Alumno alumno = new Alumno();

                    alumno.DNI = select.Lector["DNI"].ToString();
                    alumno.ApeNom = select.Lector["ApeNom"].ToString();

                    lista.Add(alumno);
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally
            {
                select.CerrarConexion();
            }

            return lista;
        }
    }
}
