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
    public partial class AgregarLibro : Form
    {

        private string nombreLibro = string.Empty;
        private string nombrePortada = string.Empty;
     
        public AgregarLibro()
        {
            InitializeComponent();
        }

        private void AgregarLibro_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuAdministrador menu = new MenuAdministrador();
            this.Visible = false;
            DialogResult res = menu.ShowDialog();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            
            if (this.txtNombre.Text.Trim() != string.Empty && this.txtIsbn.Text.Trim() != string.Empty
                   && this.numericAño.Value != 0 && this.txtAutor.Text != string.Empty && this.comboBoxCategoria.Text != string.Empty
                   && this.txtEdicion.Text != string.Empty && this.numericUpDown1.Value != 0 && this.txtPrecio.Text != string.Empty
                   && this.nombreLibro != string.Empty && this.nombrePortada != string.Empty)
            {

                string isbn = txtIsbn.Text;
                string nombre = txtNombre.Text;
                int año = (int)numericAño.Value;
                string autor = txtAutor.Text;
                string categoria = comboBoxCategoria.Text;
                string edicion = txtEdicion.Text;
                int numeroPaginas = (int)numericUpDown1.Value;
                decimal precio = Convert.ToDecimal(txtPrecio.Text);
                string Libro = nombreLibro;
                string Portada = nombrePortada;


                Enlace.agregarlibro(isbn, nombre, año, autor, categoria, edicion, numeroPaginas, precio, Libro, Portada);
                MessageBox.Show("Libro Agregado");
                this.Close();
            }
            else { MessageBox.Show("Rellene Todos Los Campos"); }
        }

        private void buttonBuscarP_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "JPEG files (*.jpg)|*.jpg|All (*.*)|*.* ";
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                this.nombrePortada = dialog.FileName;
                this.pictureBox1.ImageLocation = dialog.FileName;
            }
        }

        private void buttonBuscarL_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PDF document (*.pdf)|*.pdf";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {

                    nombreLibro = dialog.FileName;
                    //MessageBox.Show(rutaLibro);
                }
                catch (Exception exe)
                {
                    MessageBox.Show(exe.Message, "Spire.PdfViewer Demo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            MenuAdministrador menuA = new MenuAdministrador();
            this.Visible = false;
            menuA.ShowDialog();
        }
    }
}
