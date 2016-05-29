using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Librerias;

namespace Proyecto_POO
{
 
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonInicioSesion_Click(object sender, EventArgs e)
        {            
            IniciarSesion inc = new IniciarSesion();
            this.Visible = false;
            DialogResult res = inc.ShowDialog();
            
        }

        private void buttonRegistro_Click(object sender, EventArgs e)
        {
            Registro registrar = new Registro();
            this.Visible = false;
            DialogResult res = registrar.ShowDialog();
            
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
