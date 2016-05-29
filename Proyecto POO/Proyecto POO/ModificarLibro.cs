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
    public partial class ModificarLibro : Form
    {
        public ModificarLibro()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            MenuAdministrador menuA = new MenuAdministrador();
            this.Visible = false;
            menuA.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

        }

        private void ModificarLibro_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuAdministrador menuA = new MenuAdministrador();
            this.Visible = false;
            menuA.ShowDialog();
        }
    }
}
