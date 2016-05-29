using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

using Librerias;
using System.Windows.Forms;
using System.Runtime.Serialization;
namespace Proyecto_POO
{
    class Enlace
    {
        public static Administrador administrador;
        public static Libro libro;
        public static Usuario usuario;
        public static List<Libro> ListaMejoresLibros;
        public static List<Libro> ListaValoracionesLibros;
        public static List<Libro> LibroServer;
        public static List<Libro> LibrosUsuario;
        public static Libro nuevo;
        public static BinaryFormatter bf;
        public static Usuario infoUsuario;

        public static int Id { get; set; }
        public static int tipo { get; set; }
        public static string IP = "127.0.0.1";

        //Metodos Josue
        #region
        public static void login(string user, string pass)
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IP), 51111);
            TcpClient cliente = new TcpClient();
            cliente.Connect(ep);
            BinaryWriter bw = new BinaryWriter(cliente.GetStream());
            BinaryReader br = new BinaryReader(cliente.GetStream());


            bw.Write("LOGIN");
            bw.Write(user);
            bw.Write(pass);
            bw.Flush();

            string respuesta = br.ReadString();
            tipo = br.ReadInt16();
            if (respuesta == "OK")
            {   
            }
            else
            {

                throw new Exception("HAY PROBLEMA AL REGISTRAR");
            }
            bw.Close();

        }


        public static void abonarausuario(decimal cagregar, string user, decimal cactual)
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IP), 51111);
            TcpClient cliente = new TcpClient();
            cliente.Connect(ep);
            BinaryWriter bw = new BinaryWriter(cliente.GetStream());
            BinaryReader br = new BinaryReader(cliente.GetStream());

            bw.Write("ABONAR_USUARIO");
            bw.Write(cagregar);
            bw.Write(user);
            bw.Write(cactual);
            bw.Flush();
        }
        #endregion

        //Metodos Siboney
        #region
        public static void registrarusuario(string nombre, string apellido, string usuario, string contraseña, string tarjeta, decimal cant_dinero)
        {
            using (TcpClient client = new TcpClient(IP, 51111))
            using (NetworkStream n = client.GetStream())
            {
                BinaryWriter bw = new BinaryWriter(n);
                bw.Write("REGISTRAR_USUARIO");
                bw.Write(nombre);
                bw.Write(apellido);
                bw.Write(usuario);
                bw.Write(contraseña);
                bw.Write(tarjeta);
                bw.Write(cant_dinero);
                bw.Flush();

            }
        }

        public static void eliminarusuario(string usuario)
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IP), 51111);
            TcpClient cliente = new TcpClient();
            cliente.Connect(ep);

            BinaryWriter bw = new BinaryWriter(cliente.GetStream());
            bw.Write("ELIMINAR_USUARIO");
            bw.Write(usuario);
            bw.Flush();
        }

        public static void modificarusuario(string usuario, string nombre, string apellido,  string tarjeta)
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IP), 51111);
            TcpClient cliente = new TcpClient();
            cliente.Connect(ep);

            BinaryWriter bw = new BinaryWriter(cliente.GetStream());
            bw.Write("MODIFICAR_USUARIO");
            bw.Write(usuario);
            bw.Write(nombre);
            bw.Write(apellido);
            bw.Write(tarjeta);
            bw.Flush();   
        }
        #endregion

        //Metodos Branly
        #region
        public static void agregarlibro(string isbn, string nombre, int año, string autor, string categoria, string edicion, int num_pagina, decimal precio, string nombreLibro, string nombrePortada)
        {
            using (TcpClient cliente = new TcpClient(IP, 51111))
            using (NetworkStream n = cliente.GetStream())
            {
                BinaryWriter bw = new BinaryWriter(n);
                bw.Write("AGREGAR_LIBRO");

                nuevo = new Libro();
                nuevo.Isbn = isbn;
                nuevo.Nombre = nombre;
                nuevo.Año = año;
                nuevo.Autor = autor;
                nuevo.Categoria = categoria;
                nuevo.Edicion = edicion;
                nuevo.N_paginas = num_pagina;
                nuevo.Precio = precio;
                byte[] fileArray = File.ReadAllBytes(nombreLibro);
                nuevo.LibroPDF = fileArray;
                Bitmap portada = new Bitmap(nombrePortada);
                nuevo.Imagen = portada;
                BinaryFormatter bf = new BinaryFormatter();

                bf.Serialize(cliente.GetStream(), nuevo);

            }
        }

        public static void modificarlibro()
        {
            using (TcpClient client = new TcpClient(IP, 1234))
            using (NetworkStream n = client.GetStream())
            {
                BinaryWriter bw = new BinaryWriter(n);
                bw.Write("MODIFICAR_LIBRO");
                bw.Flush();
            }
        }

        public static void eliminarlibro(string isbn)
        {
            using (TcpClient client = new TcpClient(IP, 1234))
            using (NetworkStream n = client.GetStream())
            {
                BinaryWriter bw = new BinaryWriter(n);
                bw.Write("ELIMINAR_LIBRO");
                bw.Write(isbn);
                bw.Flush();
            }
        }

        #endregion

        //Metodos Hellen
        #region
        public static List<Libro> mejoreslibros()
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IP), 51111);
            TcpClient cliente = new TcpClient();
            cliente.Connect(ep);
            BinaryWriter bw = new BinaryWriter(cliente.GetStream());
            BinaryReader br = new BinaryReader(cliente.GetStream());
            bw.Write("MEJORES_LIBROS");
            bw.Flush();
            string respuesta = br.ReadString();
            if (respuesta == "OK")
            {
                BinaryFormatter bf = new BinaryFormatter();
                ListaMejoresLibros = (List<Libro>)bf.Deserialize(cliente.GetStream());
                return ListaMejoresLibros;
            }
            else
            {
                throw new Exception(respuesta);
            }
        }
        public static void darvaloracionlibro(string isbn, string user, int valoracion)
        {
            using (TcpClient client = new TcpClient(IP, 51111))
            using (NetworkStream n = client.GetStream())
            {
                BinaryWriter bw = new BinaryWriter(n);
                bw.Write("DAR_VALORACION_LIBRO");
                bw.Write(isbn);
                bw.Write(user);
                bw.Write(valoracion);
                bw.Flush();
            }
        }
        public static void obtenervaloracionlibro()
        {
            using (TcpClient client = new TcpClient(IP, 51111))
            using (NetworkStream n = client.GetStream())
            {
                BinaryWriter bw = new BinaryWriter(n);
                bw.Write("OBTENER_VALORACION_LIBRO");
                bw.Flush();

                BinaryReader br = new BinaryReader(n);
                string respuesta = br.ReadString();
                if (respuesta == "OK")
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    ListaValoracionesLibros = (List<Libro>)bf.Deserialize(client.GetStream());
                }
                else
                {
                    throw new Exception(respuesta);
                }
            }
        }

        public static List<Libro> cargarLibrosUsuario(string Id)
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IP), 51111);
            TcpClient cliente = new TcpClient();
            cliente.Connect(ep);
            BinaryWriter bw = new BinaryWriter(cliente.GetStream());

            bw.Write("CARGAR_LIBRO_USUARIO");
            bw.Write(Id);
            bw.Flush();

            BinaryFormatter bf = new BinaryFormatter();

            LibrosUsuario = (List<Libro>)bf.Deserialize(cliente.GetStream());
            cliente.Close();
            return LibrosUsuario;
        }

        public static void datosUsuario(string Id)
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IP), 51111);
            TcpClient cliente = new TcpClient();
            cliente.Connect(ep);
            BinaryWriter bw = new BinaryWriter(cliente.GetStream());
            BinaryReader br = new BinaryReader(cliente.GetStream());
            bw.Write("DATOS_USUARIO");
            bw.Write(Id);
            bw.Flush();
            string respuesta = br.ReadString();
            if (respuesta == "OK")
            {
                BinaryFormatter bf = new BinaryFormatter();
                infoUsuario = (Usuario)bf.Deserialize(cliente.GetStream());
            }
            else
            {
                throw new Exception(respuesta);
            }
        }
        #endregion

        //Metodos Victor
        #region
        public static List<Libro> cargarLibros()
         {
             IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IP), 51111);
             TcpClient cliente = new TcpClient();
             cliente.Connect(ep);
             BinaryWriter escritor = new BinaryWriter(cliente.GetStream());

             escritor.Write("CARGAR_LIBRO");

             BinaryFormatter bf = new BinaryFormatter();

             LibroServer = (List<Libro>)bf.Deserialize(cliente.GetStream());

             cliente.Close();
             return LibroServer;
         }

         public static void AgregarLibroUsuario(string Isbn, string usuario)
         {
             IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IP), 51111);
             TcpClient cliente = new TcpClient();
             cliente.Connect(ep);
             BinaryWriter bw = new BinaryWriter(cliente.GetStream());

             bw.Write("GUARDAR_LIBRO_USUARIO");
             bw.Write(Isbn);
             bw.Write(usuario);
             bw.Flush();
         }
        #endregion


    }
   

}
