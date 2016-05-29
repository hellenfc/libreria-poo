using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias
{
    [Serializable]	
    public class Administrador
    {
        public string Usuario { set; get; }
        public string Pass { set; get; }

        public List<Usuario> usuarios;
        public List<Libro> libros;

        public Administrador(string usuario , string pass) {
            this.Usuario = usuario;
            this.Pass    = pass;
        }

    }
}
