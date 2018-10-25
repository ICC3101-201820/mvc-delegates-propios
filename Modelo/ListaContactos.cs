using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ListaContactos
    {
        List<Contacto> contactos;

        public ListaContactos()
        {
            contactos = new List<Contacto>();
        }

        public void Agregar(Contacto contacto)
        {
            contactos.Add(contacto);
        }
    }
}
