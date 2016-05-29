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
    public partial class LeerLibro : Form
    {
        private List<Libro> usuario;
        private List<Libro> LibroServer;
        private string user;
        private string url;

        public LeerLibro(string url, List<Libro> usuario, List<Libro> LibroServer,string user )
        {
            InitializeComponent();
            this.url = @"Descargas\"+url+".pdf";
            this.usuario = usuario;
            this.LibroServer = LibroServer;
            //string nueva = @"Descargas\Harry Poter y La Piedra Filosofal.pdf";
            this.user = user;
            axAcroPDF1.LoadFile(this.url);
        }

        private void LeerLibro_FormClosed(object sender, FormClosedEventArgs e)
        {
            MiCuenta miCuenta = new MiCuenta(this.LibroServer, usuario,user);
            this.Visible = false;
            DialogResult res = miCuenta.ShowDialog();
        }

        private void LeerLibro_Load(object sender, EventArgs e)
        {

        }
    }
}
