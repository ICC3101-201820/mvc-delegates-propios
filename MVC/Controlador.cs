using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace MVC
{
    class Controlador
    {
        public Form1 form1;
        private ListaContactos contactos;

        public Controlador()
        {
            contactos = new ListaContactos();
        }

        public void OnAgregarContacto(string nombre, string email)
        {
            Contacto contacto = new Contacto(nombre, email);
            contactos.Agregar(contacto);
            form1.AgregarContacto(contacto);
        }
    }
}
