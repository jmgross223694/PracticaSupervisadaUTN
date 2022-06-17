using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Negocio
{
    public class DB
    {
        private NpgsqlConnection conexion;
        private NpgsqlCommand comando;
        private NpgsqlDataReader lector;

        public DB()
        {
            string server = "localhost";
            string database = "proyecto"; //Cambiar por nombre de su DB
            string user = "postgres";
            string password = "admin"; //Cambiar por la clave que generaron
            string port = "5432";

            string stringConnection = "server=" + server + ";" + "port=" + port + ";" + "user id=" +
                                    user + ";" + "password=" + password + ";" + "database=" + database + ";";

            conexion = new NpgsqlConnection(stringConnection);
            comando = new NpgsqlCommand();
        }

        public void SetearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void EjecutarConsulta()
        {
            comando.Connection = conexion;
            conexion.Open();
            lector = comando.ExecuteReader();
        }

        public void CerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }

        public NpgsqlDataReader Lector
        {
            get { return lector; }
        }
    }
}
