using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_POO
{
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void MenuAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            IniciarSesion inc = new IniciarSesion();
            this.Visible = false;
            DialogResult res = inc.ShowDialog();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            AgregarLibro agregar = new AgregarLibro();
            this.Visible = false;
            DialogResult res = agregar.ShowDialog();
        }

        private void buttonModificarLibro_Click(object sender, EventArgs e)
        {
            ModificarLibro modificarlibro = new ModificarLibro();
            this.Visible = false;
            modificarlibro.ShowDialog();
        }

        private void buttonModificarUsuario_Click(object sender, EventArgs e)
        {
            EliminarUsuario eliminarU = new EliminarUsuario();
            this.Visible = false;
            eliminarU.ShowDialog();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            IniciarSesion inc = new IniciarSesion();
            this.Visible = false;
            DialogResult res = inc.ShowDialog();
        }
    }
}
