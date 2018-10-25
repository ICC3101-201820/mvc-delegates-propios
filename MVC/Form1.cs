using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace MVC
{
    public delegate void AgregarContactoDelegate(string nombre, string email);

    public partial class Form1 : Form
    {
        public event AgregarContactoDelegate OnAgregarContacto;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // hay suscritos?
            if (OnAgregarContacto != null)
            {
                // Notificar a los suscritos
                OnAgregarContacto.Invoke(nombreTextBox.Text, emailTextBox.Text);
            }
        }

        public void AgregarContacto(Contacto contacto)
        {
            contactosList.Items.Add(contacto);
        }
    }
}
