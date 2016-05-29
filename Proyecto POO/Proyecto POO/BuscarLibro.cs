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
    public partial class BuscarLibro : Form
    {
        private List<Libro> LibrosServer;
        private List<Libro> LibrosUsuario;
        string PalabraBuscar;
        string criterio;
        string usuario;

        public BuscarLibro(List<Libro> LibrosServer, List<Libro> LibrosUsuario, string usuario)
        {
            InitializeComponent();
            this.LibrosServer = LibrosServer;
            this.LibrosUsuario = LibrosUsuario;
            this.usuario = usuario;
        }

        private void BuscarLibro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Inicio inicio = new Inicio(LibrosServer, LibrosUsuario, usuario);
            this.Visible = false;
            DialogResult res = inicio.ShowDialog();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            labelInfoLibro.Text = "";
            pictureBox1.Image = null;
            estrella1.Image = null;
            button2.Image = null;
            button3.Image = null;
            button4.Image = null;
            button5.Image = null;

            PalabraBuscar = txtBuscar.Text.Trim().ToLowerInvariant();
            criterio = comboBox1.Text; 

            if (criterio == "Categoría")
            {
                foreach (Libro x in LibrosServer)
                {
                    bool contiene = x.Categoria.Trim().ToLowerInvariant().Contains(PalabraBuscar);
                    if (contiene)
                    {
                        listBox1.Items.Add(x.Nombre);
                    }
                }

            }
            else if (criterio == "Título")
            {
                foreach (Libro x in LibrosServer)
                {
                    bool contiene = x.Nombre.Trim().ToLowerInvariant().Contains(PalabraBuscar);
                    if (contiene)
                    {
                        listBox1.Items.Add(x.Nombre);
                    }
                }
            }
            else if (criterio == "Autor")
            {
                foreach (Libro x in LibrosServer)
                {
                    bool contiene = x.Autor.Trim().ToLowerInvariant().Contains(PalabraBuscar);
                    if (contiene)
                    {
                        listBox1.Items.Add(x.Nombre);
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                foreach (Libro x in LibrosServer)
                {
                    if (listBox1.SelectedItem.ToString().Equals(x.Nombre))//libro seleccionado listbox está en librosserver
                    {
                                                
                        //Deja las estrellas en transparente y sin valores, saca info del libro
                        #region
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
                        estrella1.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                        button2.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                        button3.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                        button4.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                        button5.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                        #endregion
                        pictureBox1.Image = x.Imagen;
                        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                        labelInfoLibro.Text = x.ToString();
                        foreach(Libro y in Enlace.ListaValoracionesLibros)
                        {
                            if(x.Isbn.Equals(y.Isbn))//Busca el libro en listaValoraciones y pone su valoración
                            {
                                switch (y.Valoracion)
                                {
                                    case 0:
                                        estrella1.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                        button2.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                        button3.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                        button4.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                        button5.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                        break;
                                    case 1:
                                        estrella1.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                        button2.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                        button3.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                        button4.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                        button5.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                        break;
                                    case 2:
                                        estrella1.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                        button2.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                        button3.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                        button4.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                        button5.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                        break;
                                    case 3:
                                        estrella1.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                        button2.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                        button3.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                        button4.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                        button5.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                        break;
                                    case 4:
                                        estrella1.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                        button2.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                        button3.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                        button4.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                        button5.Image = global::Proyecto_POO.Properties.Resources.star__2_;
                                        break;
                                    case 5:
                                        estrella1.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                        button2.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                        button3.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                        button4.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                        button5.Image = global::Proyecto_POO.Properties.Resources.star__1_;
                                        break;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            if (labelInfoLibro.Text.Equals(""))
            {

                MessageBox.Show("Nada Que Comprar");

            }
            else
            {
                comprar();
            } //Llama al Metodo Comprar 
        }

        private void comprar()
        {
            DialogResult result = MessageBox.Show(this.usuario + " Compraras " + listBox1.SelectedItem.ToString() + " ?", "Confirmacion", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {


                foreach (Libro i in LibrosServer)
                {
                    if (i.Nombre.Equals(listBox1.SelectedItem.ToString()))
                    {
                        if (System.IO.File.Exists(@"Descargas\" + i.Nombre + ".pdf"))
                        {
                            try
                            {
                                Enlace.AgregarLibroUsuario(i.Isbn, this.usuario);
                                LibrosUsuario.Add(i);
                                MessageBox.Show("Libro Comprado Con Exito");
                                this.Close();
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
                                MessageBox.Show("Libro Comprado Con Exito,");
                                this.Close();
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


    }
}
