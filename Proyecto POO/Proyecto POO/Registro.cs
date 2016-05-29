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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Visible = false;
            DialogResult res = form1.ShowDialog();
        }

        private void buttonRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNombre.Text.Trim() != string.Empty && this.txtApellido.Text.Trim() != string.Empty
                    && this.txtUsuario.Text != string.Empty && this.txtContraseña.Text != string.Empty && this.txtNroTarjeta.Text != string.Empty && this.txtDinero.Text != string.Empty)
                {
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    string usuario = txtUsuario.Text;
                    string contraseña = txtContraseña.Text;
                    string tarjeta = txtNroTarjeta.Text;
                    decimal dinero = Convert.ToDecimal(txtDinero.Text);
                    Enlace.registrarusuario(nombre, apellido, usuario, contraseña, tarjeta, dinero);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }

            IniciarSesion iniciarSesion = new IniciarSesion();
            this.Visible = false;
            DialogResult res = iniciarSesion.ShowDialog();
        }

        private void Registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            this.Visible = false;
            DialogResult res = form1.ShowDialog();
        }
    }
}
