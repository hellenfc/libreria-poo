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
    public partial class MejoresLibros : Form
    {
        private List<Libro> LibrosServer;
        private List<Libro> LibrosUsuario;
        private List<Libro> TopLibros;
        private string usuario;

        public MejoresLibros(List<Libro> LibrosServer, List<Libro> LibrosUsuario, string usuario)
        {
            InitializeComponent();
            this.LibrosServer = LibrosServer;
            this.LibrosUsuario = LibrosUsuario;
            this.usuario = usuario;
        }

        private void buttonInicio3_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(LibrosServer, LibrosUsuario, usuario);
            this.Visible = false;
            DialogResult res = inicio.ShowDialog();
        }

        private void buttonMiCuenta3_Click(object sender, EventArgs e)
        {
            MiCuenta cuenta = new MiCuenta(LibrosServer, LibrosUsuario, usuario);
            this.Visible = false;
            DialogResult res = cuenta.ShowDialog(); 
        }

        private void buttonMejoresLibros3_Click(object sender, EventArgs e)
        {
            //MejoresLibros mej = new MejoresLibros();
            //this.Visible = false;
            //DialogResult res = mej.ShowDialog();
        }

        private void buttonBuscar3_Click(object sender, EventArgs e)
        {
            BuscarLibro buscar = new BuscarLibro(LibrosServer, LibrosUsuario, usuario);
            this.Visible = false;
            DialogResult res = buscar.ShowDialog();
        }

        private void buttonCerrar3_Click(object sender, EventArgs e)
        {
            IniciarSesion iniciarSesion = new IniciarSesion();
            this.Visible = false;
            DialogResult res = iniciarSesion.ShowDialog();
        }

        private void MejoresLibros_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MejoresLibros_Load(object sender, EventArgs e)
        {
            TopLibros = Enlace.mejoreslibros();
            if (TopLibros[0].Imagen == null)
            {
                MessageBox.Show("ES NULA");
            }
            
            foreach (Libro x in TopLibros)
            {
                Panel panel1 = new System.Windows.Forms.Panel();
                PictureBox pictureBox1 = new System.Windows.Forms.PictureBox();
                Label label1 = new System.Windows.Forms.Label();
                Button button1 = new System.Windows.Forms.Button() { Tag = x.Nombre };
                Panel panelEstrellas1 = new System.Windows.Forms.Panel();
                Button estrella5 = new System.Windows.Forms.Button();
                Button estrella4 = new System.Windows.Forms.Button();
                Button estrella3 = new System.Windows.Forms.Button();
                Button estrella2 = new System.Windows.Forms.Button();
                Button estrella1 = new System.Windows.Forms.Button();
                // 
                // panel1
                // 
                panel1.BackColor = System.Drawing.Color.Transparent;
                panel1.Controls.Add(panelEstrellas1);
                panel1.Controls.Add(button1);
                panel1.Controls.Add(label1);
                panel1.Controls.Add(pictureBox1);
                panel1.Location = new System.Drawing.Point(59, 12);
                panel1.Name = "panel1";
                panel1.Size = new System.Drawing.Size(370, 600);
                panel1.TabIndex = 0;
                // 

                // pictureBox1
                // 
                pictureBox1.Location = new System.Drawing.Point(18, 12);
                pictureBox1.Name = "picturebox" + x.Nombre;
                pictureBox1.Image = x.Imagen;
                pictureBox1.Size = new System.Drawing.Size(234, 299);
                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox1.TabIndex = 0;
                pictureBox1.TabStop = false;
                // 
                // label1
                // 
                label1.AutoSize = true;
                label1.Location = new System.Drawing.Point(65, 400);
                label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                label1.Name = "label" + x.Nombre;
                label1.Size = new System.Drawing.Size(35, 13);
                label1.TabIndex = 1;
                label1.Text = x.ToString();
                // 
                // button1
                //                     
                button1.Location = new System.Drawing.Point(88, 332);
                button1.Name = "button1";
                button1.Size = new System.Drawing.Size(75, 23);
                button1.TabIndex = 2;
                button1.Text = "Comprar";
                button1.UseVisualStyleBackColor = true;
                button1.Click += new System.EventHandler(this.button_Click);

                // 
                // panelEstrellas1
                // 
                panelEstrellas1.BackColor = System.Drawing.Color.Transparent;
                panelEstrellas1.Controls.Add(estrella1);
                panelEstrellas1.Controls.Add(estrella2);
                panelEstrellas1.Controls.Add(estrella3);
                panelEstrellas1.Controls.Add(estrella4);
                panelEstrellas1.Controls.Add(estrella5);
                panelEstrellas1.Location = new System.Drawing.Point(43, 371);
                panelEstrellas1.Name = "panelEstrellas1";
                panelEstrellas1.Size = new System.Drawing.Size(175, 32);
                panelEstrellas1.TabIndex = 5;
                // 
                // estrella5
                // 
                estrella5.BackgroundImage = null;
                estrella5.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
                estrella5.FlatAppearance.BorderSize = 0;
                estrella5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                estrella5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                estrella5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                estrella5.Location = new System.Drawing.Point(138, 0);
                estrella5.Name = "button5";
                estrella5.Size = new System.Drawing.Size(28, 32);
                estrella5.TabIndex = 4;
                estrella5.UseVisualStyleBackColor = false;
                // 
                // estrella4
                //// 
                estrella4.BackgroundImage = null;
                estrella4.FlatAppearance.BorderSize = 0;
                estrella4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                estrella4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                estrella4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                estrella4.Location = new System.Drawing.Point(104, 0);
                estrella4.Name = "button4";
                estrella4.Size = new System.Drawing.Size(28, 32);
                estrella4.TabIndex = 3;
                estrella4.UseVisualStyleBackColor = true;
                // 
                // estrella3
                //// 
                estrella3.BackgroundImage = null;
                estrella3.FlatAppearance.BorderSize = 0;
                estrella3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                estrella3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                estrella3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                estrella3.Location = new System.Drawing.Point(70, 0);
                estrella3.Name = "button6";
                estrella3.Size = new System.Drawing.Size(28, 32);
                estrella3.TabIndex = 2;
                estrella3.UseVisualStyleBackColor = true;
                // 
                // estrella2
                // 
                estrella2.BackgroundImage = null;
                estrella2.FlatAppearance.BorderSize = 0;
                estrella2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                estrella2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                estrella2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                estrella2.Location = new System.Drawing.Point(36, 0);
                estrella2.Name = "button7";
                estrella2.Size = new System.Drawing.Size(28, 32);
                estrella2.TabIndex = 1;
                estrella2.UseVisualStyleBackColor = true;
                // 
                // estrella1
                // 
                estrella1.BackgroundImage = null;
                estrella1.FlatAppearance.BorderSize = 0;
                estrella1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                estrella1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                estrella1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                estrella1.Location = new System.Drawing.Point(3, 0);
                estrella1.Name = "estrella1";
                estrella1.Size = new System.Drawing.Size(28, 32);
                estrella1.TabIndex = 0;
                estrella1.UseVisualStyleBackColor = true;

                flowLayoutPanel1.Controls.Add(panel1);

                foreach (Libro y in Enlace.ListaValoracionesLibros)
                {
                    if (x.Isbn.Equals(y.Isbn))
                    {
                        switch (y.Valoracion)
                        {
                            case 0:
                                estrella1.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                estrella2.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                estrella3.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                estrella4.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                estrella5.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                break;
                            case 1:
                                estrella1.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                estrella2.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                estrella3.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                estrella4.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                estrella5.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                break;
                            case 2:
                                estrella1.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                estrella2.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                estrella3.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                estrella4.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                estrella5.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                break;
                            case 3:
                                estrella1.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                estrella2.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                estrella3.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                estrella4.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                estrella5.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                break;
                            case 4:
                                estrella1.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                estrella2.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                estrella3.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                estrella4.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                estrella5.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                break;
                            case 5:
                                estrella1.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                estrella2.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                estrella3.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                estrella4.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                estrella5.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                break;
                        }
                    }
                }

            }
        }

        private void button_Click(object sender, EventArgs e)
        {

            comprar(sender);

        }

        private void comprar(object sender)
        {

            Button bontoninvoco = (Button)sender;
            //Libro libro = (Libro)bontoninvoco.Tag;

            DialogResult result = MessageBox.Show(this.usuario + " Compraras " + bontoninvoco.Tag.ToString() + " ?", "Confirmacion", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {


                foreach (Libro i in LibrosServer)
                {
                    if (i.Nombre.Equals(bontoninvoco.Tag.ToString()))
                    {

                        if (System.IO.File.Exists(@"Descargas\" + i.Nombre + ".pdf"))
                        {

                            try
                            {
                                Enlace.AgregarLibroUsuario(i.Isbn, this.usuario);
                                LibrosUsuario.Add(i);
                                MessageBox.Show("Libro Comprado Con Exito");
                            }
                            catch (System.IO.IOException e)
                            {
                                MessageBox.Show(e.Message);
                                //return;
                            }
                        }
                        else
                        {

                            try
                            {

                                File.WriteAllBytes("Descargas\\" + i.Nombre + ".pdf", i.LibroPDF);
                                Enlace.AgregarLibroUsuario(i.Isbn, this.usuario);
                                LibrosUsuario.Add(i);
                                MessageBox.Show("Libro Comprado Con Exito.");
                            }
                            catch (System.IO.IOException e)
                            {
                                MessageBox.Show(e.Message);
                                //return;
                            }
                        }


                    }
                }
            }
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
