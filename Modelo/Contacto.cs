using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Contacto
    {
        string nombre;
        string email;

        public Contacto(string n, string e)
        {
            nombre = n;
            email = e;
        }

        public override string ToString()
        {
            return $"{nombre} <{email}>";
        }
    }
}
