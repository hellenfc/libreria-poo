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
using System.IO;

namespace Proyecto_POO
{
    public partial class MiCuenta : Form
    {
        private List<Libro> LibrosUsuario;
        private List<Libro> LibrosServer;
        private string url;
        private string usuario;
        private int valoracion;
        private string isbn;

        public MiCuenta(List<Libro> LibrosServer, List<Libro> LibrosUsuario, string usuario)
        {
            InitializeComponent();
            this.LibrosUsuario = LibrosUsuario;
            this.LibrosServer = LibrosServer;
            this.usuario= usuario;
            estrella1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            estrella1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            foreach (Libro x in this.LibrosUsuario)
            {
                listBoxLibros.Items.Add(x.Nombre);
            }
        }


        public MiCuenta(List<Libro> LibroServer)
        {
            InitializeComponent();
            this.LibrosServer = LibroServer;
        }

         public MiCuenta(List<Libro> LibrosUsuario,string url)
         {
             InitializeComponent();
             this.LibrosUsuario = LibrosUsuario;
             this.url = url;
             foreach (Libro x in LibrosUsuario)
             {
                 listBoxLibros.Items.Add(x.Nombre);
             }
         }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxLibros.SelectedIndex >= 0)
            {
                foreach (Libro u in LibrosUsuario)
                {
                    if (url.Equals(u.Nombre))
                    {
                        LeerLibro leer = new LeerLibro(url, this.LibrosUsuario, LibrosServer, usuario);
                        this.Visible = false;
                        DialogResult res = leer.ShowDialog();

                    }
                }
            }
            
        }

        private void buttonMejoresLibros2_Click(object sender, EventArgs e)
        {
            MejoresLibros mej = new MejoresLibros(LibrosServer, LibrosUsuario, usuario);
            this.Visible = false;
            DialogResult res = mej.ShowDialog();
        }

        private void buttonBuscar2_Click(object sender, EventArgs e)
        {
            BuscarLibro buscar = new BuscarLibro(LibrosServer, LibrosUsuario, usuario);
            this.Visible = false;
            DialogResult res = buscar.ShowDialog();
            
        }

        private void buttonInicio2_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(LibrosServer, LibrosUsuario, usuario);
            this.Visible = false;
            DialogResult res = inicio.ShowDialog();
        }

        private void buttonMiCuenta2_Click(object sender, EventArgs e)
        {
            //MiCuenta cuenta = new MiCuenta();
            //this.Visible = false;
            //DialogResult res = cuenta.ShowDialog(); 
        }

        private void buttonCerrar2_Click(object sender, EventArgs e)
        {
            IniciarSesion iniciarSesion = new IniciarSesion();
            this.Visible = false;
            DialogResult res = iniciarSesion.ShowDialog();
        }

        private void MiCuenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MiCuenta_Load(object sender, EventArgs e)
        {

            Enlace.datosUsuario(usuario);
            this.labelInfoUsuario.Text= Enlace.infoUsuario.ToString();
            foreach (Libro i in LibrosUsuario)
            {
                if (!System.IO.File.Exists(@"Descargas\" + i.Nombre + ".pdf"))
                {
                    // Use a try block to catch IOExceptions, to
                    // handle the case of the file already being
                    // opened by another process.
                    try
                    {
                        File.WriteAllBytes("Descargas\\" + i.Nombre + ".pdf", i.LibroPDF);

                    }
                    catch (System.IO.IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                        //return;
                    }
                }

            }
        }

        private void listBoxLibros_SelectedIndexChanged(object sender, EventArgs e)
        {

            estrella1.Image = global::Proyecto_POO.Properties.Resources.star__2_;
            button2.Image = global::Proyecto_POO.Properties.Resources.star__2_;
            button3.Image = global::Proyecto_POO.Properties.Resources.star__2_;
            button4.Image = global::Proyecto_POO.Properties.Resources.star__2_;
            button5.Image = global::Proyecto_POO.Properties.Resources.star__2_;
            foreach (Libro x in LibrosUsuario) {
                try
                {
                    if (listBoxLibros.SelectedItem.ToString().Equals(x.Nombre))
                    {
                        pictureBoxPortada2.Image = x.Imagen;
                        labelInfoLibro.Text = x.ToString();
                        url = x.Nombre;
                    }
                }catch{}
            }
        }

        private void estrella1_Click(object sender, EventArgs e)
        {
            if (listBoxLibros.SelectedIndex >= 0)
            {
                estrella1.BackgroundImage = null;
                estrella1.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                button2.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                button3.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                button4.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                button5.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                int seleccion = listBoxLibros.SelectedIndex;
                if (seleccion > -1)
                {
                    Enlace.darvaloracionlibro(LibrosUsuario[seleccion].Isbn, usuario, 1);
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBoxLibros.SelectedIndex >= 0)
            {
                estrella1.BackgroundImage = null;
            button2.BackgroundImage = null;
            estrella1.Image = global::Proyecto_POO.Properties.Resources.star__1_;
            button2.Image = global::Proyecto_POO.Properties.Resources.star__1_;
            button3.Image = global::Proyecto_POO.Properties.Resources.star__2_;
            button4.Image = global::Proyecto_POO.Properties.Resources.star__2_;
            button5.Image = global::Proyecto_POO.Properties.Resources.star__2_;
            int seleccion = listBoxLibros.SelectedIndex;
            if (seleccion > -1)
            {
                Enlace.darvaloracionlibro(LibrosUsuario[seleccion].Isbn, usuario, 2);
                            
            }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBoxLibros.SelectedIndex >= 0)
            {
                estrella1.BackgroundImage = null;
            button2.BackgroundImage = null;
            button3.BackgroundImage = null;
            estrella1.Image = global::Proyecto_POO.Properties.Resources.star__1_;
            button2.Image = global::Proyecto_POO.Properties.Resources.star__1_;
            button3.Image = global::Proyecto_POO.Properties.Resources.star__1_;
            button4.Image = global::Proyecto_POO.Properties.Resources.star__2_;
            button5.Image = global::Proyecto_POO.Properties.Resources.star__2_;
            int seleccion = listBoxLibros.SelectedIndex;
            if (seleccion > -1)
            {
                Enlace.darvaloracionlibro(LibrosUsuario[seleccion].Isbn, usuario, 3);
            }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBoxLibros.SelectedIndex >= 0)
            {
                estrella1.BackgroundImage = null;
            button2.BackgroundImage = null;
            button3.BackgroundImage = null;
            button4.BackgroundImage = null;
            estrella1.Image = global::Proyecto_POO.Properties.Resources.star__1_;
            button2.Image = global::Proyecto_POO.Properties.Resources.star__1_;
            button3.Image = global::Proyecto_POO.Properties.Resources.star__1_;
            button4.Image = global::Proyecto_POO.Properties.Resources.star__1_;
            button5.Image = global::Proyecto_POO.Properties.Resources.star__2_;
            int seleccion = listBoxLibros.SelectedIndex;
            if (seleccion > -1)
            {
                Enlace.darvaloracionlibro(LibrosUsuario[seleccion].Isbn, usuario, 4);                            
            }
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBoxLibros.SelectedIndex >= 0)
            {
                estrella1.BackgroundImage = null;
            button2.BackgroundImage = null;
            button3.BackgroundImage = null;
            button4.BackgroundImage = null;
            button5.BackgroundImage = null;
            estrella1.Image = global::Proyecto_POO.Properties.Resources.star__1_;
            button2.Image = global::Proyecto_POO.Properties.Resources.star__1_;
            button3.Image = global::Proyecto_POO.Properties.Resources.star__1_;
            button4.Image = global::Proyecto_POO.Properties.Resources.star__1_;
            button5.Image = global::Proyecto_POO.Properties.Resources.star__1_;
            int seleccion = listBoxLibros.SelectedIndex;
            if (seleccion > -1)
            {
                Enlace.darvaloracionlibro(LibrosUsuario[seleccion].Isbn, usuario, 5);
            }
            }

        }

        private void buttonEliminarCuenta_Click(object sender, EventArgs e)
        {
            string usuario = Enlace.infoUsuario.User;
            Enlace.eliminarusuario(usuario);
            MessageBox.Show("Su cuenta ha sido eliminada con éxito");
            this.Visible = false;
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void buttonModificarUsuario_Click(object sender, EventArgs e)
        {
            ModificarUsuario modiU = new ModificarUsuario(LibrosServer, LibrosUsuario, usuario);
            this.Visible = false;
            modiU.ShowDialog();
        }

        private void buttonAbonar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != string.Empty)
            {
                decimal agregarcuenta;
                if (decimal.TryParse(textBox1.Text, out agregarcuenta))
                {
                    Enlace.abonarausuario(agregarcuenta, usuario, Enlace.infoUsuario.Cantidad);
                    textBox1.Clear();
                    MessageBox.Show("Saldo enviado");
                    Enlace.datosUsuario(usuario);
                    this.labelInfoUsuario.Text = Enlace.infoUsuario.ToString();

                }

                else { MessageBox.Show("No se pudo convertir a decimal."); }
            }
            else
            {
                MessageBox.Show("No ha llenado el campo.");
            }
        }

        private void estrella1_DragOver(object sender, DragEventArgs e)
        {
            
        }

        private void estrella1_MouseEnter(object sender, EventArgs e)
        {
            estrella1.BackgroundImage = null;
            estrella1.Image = global::Proyecto_POO.Properties.Resources.star__1_;
            button2.Image = global::Proyecto_POO.Properties.Resources.star__2_;
            button3.Image = global::Proyecto_POO.Properties.Resources.star__2_;
            button4.Image = global::Proyecto_POO.Properties.Resources.star__2_;
            button5.Image = global::Proyecto_POO.Properties.Resources.star__2_;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            estrella1.BackgroundImage = null;
            button2.BackgroundImage = null;
            estrella1.Image = global::Proyecto_POO.Properties.Resources.star__1_;
            button2.Image = global::Proyecto_POO.Properties.Resources.star__1_;
            button3.Image = global::Proyecto_POO.Properties.Resources.star__2_;
            button4.Image = global::Proyecto_POO.Properties.Resources.star__2_;
            button5.Image = global::Proyecto_POO.Properties.Resources.star__2_;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            estrella1.BackgroundImage = null;
            button2.BackgroundImage = null;
            button3.BackgroundImage = null;
            estrella1.Image = global::Proyecto_POO.Properties.Resources.star__1_;
            button2.Image = global::Proyecto_POO.Properties.Resources.star__1_;
            button3.Image = global::Proyecto_POO.Properties.Resources.star__1_;
            button4.Image = global::Proyecto_POO.Properties.Resources.star__2_;
            button5.Image = global::Proyecto_POO.Properties.Resources.star__2_;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            estrella1.BackgroundImage = null;
            button2.BackgroundImage = null;
            button3.BackgroundImage = null;
            button4.BackgroundImage = null;
            estrella1.Image = global::Proyecto_POO.Properties.Resources.star__1_;
            button2.Image = global::Proyecto_POO.Properties.Resources.star__1_;
            button3.Image = global::Proyecto_POO.Properties.Resources.star__1_;
            button4.Image = global::Proyecto_POO.Properties.Resources.star__1_;
            button5.Image = global::Proyecto_POO.Properties.Resources.star__2_;

        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            estrella1.BackgroundImage = null;
            button2.BackgroundImage = null;
            button3.BackgroundImage = null;
            button4.BackgroundImage = null;
            button5.BackgroundImage = null;
            estrella1.Image = global::Proyecto_POO.Properties.Resources.star__1_;
            button2.Image = global::Proyecto_POO.Properties.Resources.star__1_;
            button3.Image = global::Proyecto_POO.Properties.Resources.star__1_;
            button4.Image = global::Proyecto_POO.Properties.Resources.star__1_;
            button5.Image = global::Proyecto_POO.Properties.Resources.star__1_;
        }
    }
}
