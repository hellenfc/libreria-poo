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
    public partial class EliminarUsuario : Form
    {
        public EliminarUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EliminarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuAdministrador menuA = new MenuAdministrador();
            this.Visible = false;
            menuA.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.textBox1.Text != string.Empty)
                {
                    string usuario = textBox1.Text;
                  

                    Enlace.eliminarusuario(usuario);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        

            
            MessageBox.Show("Usuario Eliminado");
            this.Visible = false;
            MenuAdministrador men = new MenuAdministrador();
            men.ShowDialog();
        }
    }
}
