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
    public partial class ModificarUsuario : Form
    {
        private List<Libro> LibrosUsuario;
        private List<Libro> LibrosServer;
        private string usuario;

        public ModificarUsuario(List<Libro> LibrosServer, List<Libro> LibrosUsuario, string usuario)
        {
            InitializeComponent();
            this.LibrosUsuario = LibrosUsuario;
            this.LibrosServer = LibrosServer;
            this.usuario = usuario;
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.txtNombre.Text.Trim() != string.Empty && this.txtApellido.Text.Trim() != string.Empty
                     && this.txtNroTarjeta.Text != string.Empty)
                {
                    string usuario = Enlace.infoUsuario.User;
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    string tarjeta = txtNroTarjeta.Text;

                    Enlace.modificarusuario(usuario, nombre, apellido,tarjeta);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
            IniciarSesion ini = new IniciarSesion();
            ini.ShowDialog();
            this.Visible = false;

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            MiCuenta micuenta = new MiCuenta(LibrosServer, LibrosUsuario, usuario);
            this.Visible = false;
            micuenta.ShowDialog();
        }

        private void ModificarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            MiCuenta micuenta = new MiCuenta(LibrosServer, LibrosUsuario, usuario);
            this.Visible = false;
            micuenta.ShowDialog();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
