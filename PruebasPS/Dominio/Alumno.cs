using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Alumno
    {
        public string DNI { get; set; }
        public string ApeNom { get; set; }

        public Alumno() { }

        public Alumno(string dNI, string apeNom)
        {
            DNI = dNI;
            ApeNom = apeNom;
        }
    }
}
