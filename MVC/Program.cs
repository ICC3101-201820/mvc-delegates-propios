﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Controlador controlador = new Controlador();
            Form1 form1 = new Form1();
            controlador.form1 = form1;
            form1.OnAgregarContacto += controlador.OnAgregarContacto;
            Application.Run(form1);
        }
    }
}
