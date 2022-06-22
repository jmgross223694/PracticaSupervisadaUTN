using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Dominio;
using System.Web;

namespace Negocio
{
    public class UsuarioBD
    {
        private DB conex = new DB();

        public bool verificarUsuario(string Usuario, string Password)
        {
            Usuario user= new Usuario();

            user.UsuarioMp=Usuario;
            user.Password= Password;
            DB select = new DB();

            bool estado = false;
                  string    consulta =
               "SELECT usua_user, usua_password from susuarios where usua_user = '" + Usuario + "'   and usua_password = '" + Password + "'";

            try
            {
                conex.SetearConsulta(consulta);
                conex.EjecutarConsulta();

                if (conex.Lector.Read())
                {
                    estado = true;
                    HttpContext.Current.Session["NombreUsuario"] = Usuario;
                }
            }
            catch
            {
                estado = false;
            }
            finally
            {
                conex.CerrarConexion();
            }
            return estado;

           
        }
    }
}
