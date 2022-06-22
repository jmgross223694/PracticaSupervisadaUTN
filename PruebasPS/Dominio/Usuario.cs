using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class Usuario
    {
        private string usuarioMp;
        private string password;

        public Usuario()
        {
        }

        public Usuario(string usuarioMp, string password)
        {
            this.usuarioMp = usuarioMp;
            this.password = password;
        }

        public string UsuarioMp { get => usuarioMp; set => usuarioMp = value; }
        public string Password { get => password; set => password = value; }
    }
}
