using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias
{
    [Serializable]	
    public class Usuario
    {
        public List<Libro> libro;
        public string User { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Pass { set; get; }
        public string N_tarjeta  { set; get; }
        public decimal Cantidad { set; get; }

        public Usuario() { }

           public Usuario(string usuario,string nombre , string apellido, string pass , string n_tarjeta , decimal cantidad ) 
           {
            this.User = usuario;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Pass = pass;
            this.N_tarjeta = n_tarjeta;
            this.Cantidad = cantidad;
        }
        
           public override string ToString()
           {
               return "\n Usuario: " + this.User + " \n Nombre: " + this.Nombre + " " + this.Apellido + "\n N° Tarjeta: " + this.N_tarjeta + "\n Saldo actual: " + this.Cantidad+ "Lps.";
           }
    }
}
