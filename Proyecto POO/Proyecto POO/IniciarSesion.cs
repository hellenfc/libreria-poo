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
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Proyecto_POO
{
    public partial class IniciarSesion : Form
    {
        
        public static List<Libro> LibroServer = new List<Libro>();
        public static List<Libro> LibrosUsuario = new List<Libro>();
        public static string id;
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (txtUsuaio.Text.Trim() != string.Empty && txtContraseña.Text.Trim() != string.Empty)
            {   
                id = txtUsuaio.Text.Trim();
                string pass = txtContraseña.Text.Trim();
                
                Enlace.login(id, pass);
                this.DialogResult = DialogResult.OK;
                validaradministrador(Enlace.tipo);
             }
            else 
            {
                MessageBox.Show("No han llenado todos los campos. Intenta de nuevo.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Clear();
                txtUsuaio.Clear();
            }

            this.Visible = true;
            
        }
        public static void validaradministrador(int x)
        {
            if (x == 1)
            {
                MenuAdministrador menuadmin = new MenuAdministrador();
                menuadmin.ShowDialog();
            }

            else if (x == 2)
            {
                LibrosUsuario = Enlace.cargarLibrosUsuario(id);
                LibroServer = Enlace.cargarLibros();
                Inicio inicio = new Inicio(LibroServer, LibrosUsuario, id);
                inicio.ShowDialog();
            }
            else {
                MessageBox.Show("Nombre de usuario o pass equivocado. Intenta de nuevo.", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                IniciarSesion iniciar = new IniciarSesion();
                iniciar.ShowDialog();
            
            }
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Visible = false;
            DialogResult res = form1.ShowDialog();
        }

        private void IniciarSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }



    }
}
