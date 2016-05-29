using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Librerias
{
    [Serializable]	
    public class Libro
    {
        public string Isbn { set; get; }
        public string Nombre { set; get; }
        public  int Año { get; set; }
        public string Autor { set; get; }
        public string Categoria { set; get; }
        public string Edicion { set; get; }
        public int N_paginas { set; get; }
        public Bitmap Imagen { set; get; }
        public decimal Precio { set; get; }
        public int Valoracion { set; get; }
        public byte[] LibroPDF { get; set; }
        //public byte[] PortadaLibro { get; set; }

        public Libro(string isbn, string nombre, int año, string autor, string categoria, string edicion, int n_paginas, decimal precio, int valoracion, byte[] libroPdf, Bitmap portadaLibro) 
        {
            this.Isbn = isbn;
            this.Nombre = nombre;
            this.Año = año;
            this.Autor = autor;
            this.Categoria = categoria;
            this.Edicion = edicion;
            this.N_paginas = n_paginas;
            this.Imagen = portadaLibro;
            this.Precio = precio;
            this.Valoracion = valoracion;
            this.LibroPDF = libroPdf;
            //this.PortadaLibro = portadaLibro;
        }



        public Libro() { }

        public override string ToString()
        {
            return "\n ISBN: " + this.Isbn + " \n Nombre: " + this.Nombre + "\n Autor: " + this.Autor + "\n Edicion: " + this.Edicion + "\n Categoria: " + this.Categoria + "\n Paginas: " + this.N_paginas + "\n Precio: " + Convert.ToString(this.Precio) + " LPS";

        }
 
    }
}
