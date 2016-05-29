using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;


using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;


using Librerias;

namespace ServidorProyectoPOO
{
    class Program
    {
        private static string cadenaConexion;
        private static OleDbConnection conexion;
        private static OleDbCommand comandoSQL;
        private static OleDbDataReader lectorDatos;

        private static BinaryReader br;
        private static BinaryWriter bw;
        private static NetworkStream ns;
        private static TcpClient cliente;
        private static Usuario usua;
        static void Main(string[] args)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 51111);
            listener.Start();
            while (true)
            {
                using (cliente = listener.AcceptTcpClient())
                using (ns = cliente.GetStream())
                {
                    Console.WriteLine("Conexion recibida desde: " + cliente.Client.RemoteEndPoint.ToString());

                    br = new BinaryReader(ns);
                    bw = new BinaryWriter(ns);
                    
                    string tipoMensaje = br.ReadString();
                    try
                    {
                        switch (tipoMensaje)
                        {

                            case "LOGIN":
                                Login();
                                break;
                            case "ELIMINAR_USUARIO":
                                EliminarUsuario();
                                break;
                            case "REGISTRAR_USUARIO":
                                RegistrarUsuario();
                                break;
                            case "MODIFICAR_USUARIO":
                                ModificarUsuario();
                                break;
                            case "ELIMINAR_LIBRO":
                                EliminarLibro();
                                break;
                            case "AGREGAR_LIBRO":
                                AgregarLibro();
                                break;
                            case "MODIFICAR_LIBRO":
                                ModificarLibro();
                                break;
                            case "MEJORES_LIBROS":
                                MejoresLibros();
                                break;                            
                            case "ABONAR_USUARIO":
                                AbonarUsuario();
                                break;
                            case "DAR_VALORACION_LIBRO":
                                DarValoracionLibro();
                                break;
                            case "OBTENER_VALORACION_LIBRO":
                                ObtenerValoracionLibro();
                                break;
                            case "CARGAR_LIBRO":
                                CargarLibro();
                                break;
                            case "DATOS_USUARIO":
                                DatosUsuario();
                                break;
                            case "CARGAR_LIBRO_USUARIO":
                                CargarLibroUsuario();
                                break;
                            case "GUARDAR_LIBRO_USUARIO":
                                AgregarLibroUsuario();
                                break;

                            default:
                                Console.WriteLine("ERROR: MENSAJE DESCONOCIDO");
                                throw new Exception("se recibió un mensaje desconocido en el servidor");

                        }
                    }
                    catch (Exception ex)
                    {
                        // Las excepciones se envían como mensajes al cliente
                        bw.Write(ex.Message);
                        bw.Flush();
                    }

                    }

            }
        
        }
        //Metodos Josue
        #region
        public static void Login()
        {            
            int tipo = 0;
            string cadenaConexion = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDProyecto.accdb");

            OleDbConnection conexion = new OleDbConnection(cadenaConexion);
            conexion.Open();

            string usuario = br.ReadString();
            string password = br.ReadString();

            Console.WriteLine("Usuario: " + usuario + " Contraseña: " + password);
            OleDbCommand comando = new OleDbCommand("SELECT * FROM usuario WHERE usuario='" + usuario + "' AND password='" + password + "'", conexion);
            OleDbDataReader resultado = comando.ExecuteReader();
            while(resultado.Read())
            {
                string passwordReal = resultado.GetString(1);
                tipo = resultado.GetInt32(2);
                Console.WriteLine("El tipo de usuario es: " + tipo);
            }
            bw.Write("OK");
            bw.Write(tipo);
            bw.Flush();
          
            resultado.Close();
            conexion.Close();
        }

        public static void AbonarUsuario()
        {
            decimal catidadaagregar = br.ReadDecimal();
            string usuario = br.ReadString();
            decimal cantidadactual = br.ReadDecimal();
            string cadenaConexion = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDProyecto.accdb");
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);
            conexion.Open();

            decimal cantidadtotal = cantidadactual + catidadaagregar;
            string sentenciaSQL2 = "UPDATE cliente SET dinero_cliente=" + cantidadtotal + " WHERE usuario ='" + usuario + "'";

            Console.WriteLine("Agregando saldo ...");
            OleDbCommand comando1 = new OleDbCommand(sentenciaSQL2, conexion);
            try
            {
                Console.WriteLine("Entra al try");
                comando1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine("Agregacion  dada su nuevo saldo es :" + cantidadtotal);
            conexion.Close();
        }

        #endregion

        //Metodos Siboney
        #region
        public static void EliminarUsuario()
        {
            string usuario = br.ReadString();
            string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDProyecto.accdb";
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);
            conexion.Open();
            string sentenciaSQL1 = "DELETE * FROM cliente WHERE usuario = " + "'" + usuario + "'";
            OleDbCommand comando1 = new OleDbCommand(sentenciaSQL1, conexion);
            string sentenciaSQL2 = "DELETE * FROM usuario WHERE usuario = " + "'" + usuario + "'";
            OleDbCommand comando2 = new OleDbCommand(sentenciaSQL2, conexion);

            try
            {
                comando1.ExecuteNonQuery();
                comando2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.WriteLine("Cliente Eliminado");
            conexion.Close();
        }

        public static void RegistrarUsuario()
        {
            string nombre = br.ReadString();
            string apellido = br.ReadString();
            string usuario = br.ReadString();
            string contraseña = br.ReadString();
            string tarjeta = br.ReadString();
            decimal dinero = br.ReadDecimal();
            string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDProyecto.accdb";
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);
            conexion.Open();
            string sentenciaSQL1 = "INSERT INTO cliente VALUES(@usuario, @nombre, @apellido, @numero_tarjeta, @dinero_cliente)";
            OleDbCommand comando1 = new OleDbCommand(sentenciaSQL1, conexion);
            comando1.Parameters.AddWithValue("@usuario", usuario);
            comando1.Parameters.AddWithValue("@nombre", nombre);
            comando1.Parameters.AddWithValue("@apellido", apellido);
            comando1.Parameters.AddWithValue("@numero_tarjeta", tarjeta);
            comando1.Parameters.AddWithValue("@dinero_cliente", dinero);
            string sentenciaSQL2 = "INSERT INTO usuario VALUES(@usuario, @password, @tipo)";
            OleDbCommand comando2 = new OleDbCommand(sentenciaSQL2, conexion);
            comando2.Parameters.AddWithValue("@usuario", usuario);
            comando2.Parameters.AddWithValue("@password", contraseña);
            comando2.Parameters.AddWithValue("@tipo", 2);
            try
            {
                comando1.ExecuteNonQuery();
                comando2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.WriteLine("Cliente Registrado");
            conexion.Close();
        }

        public static void ModificarUsuario()
        {
            string usuario = br.ReadString();
            string nombre = br.ReadString();
            string apellido = br.ReadString();
            string tarjeta = br.ReadString();
            string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDProyecto.accdb";
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);
            conexion.Open();
            OleDbCommand comando1 = new OleDbCommand("UPDATE cliente SET nombre='" + nombre + "', apellido='" + apellido + "',numero_tarjeta='" + tarjeta + "' WHERE usuario='" + usuario + "'", conexion);
            
            try
            {
                comando1.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.WriteLine("Cliente Modificado");
            conexion.Close();
        }

        #endregion


        //Metodos Branly
        #region
        public static void EliminarLibro()
        {
        }

        public static void AgregarLibro()
        {
            BinaryFormatter bf = new BinaryFormatter();

            Libro LibroAdmin = (Libro)bf.Deserialize(cliente.GetStream());

            string isbn = LibroAdmin.Isbn;
            string nombre = LibroAdmin.Nombre;
            int año = LibroAdmin.Año;
            string autor = LibroAdmin.Autor;
            string categoria = LibroAdmin.Categoria;
            string edicion = LibroAdmin.Edicion;
            int numeroPaginas = LibroAdmin.N_paginas;
            decimal precio = LibroAdmin.Precio;
            string nombreLibro = LibroAdmin.Nombre + ".pdf";
            string nombrePortada = LibroAdmin.Nombre + ".jpg";

            Console.WriteLine(isbn + " " + nombre + " " + año + " " + autor + " " + categoria + " " + edicion + " " + numeroPaginas + " " + precio + " " + nombreLibro + " " + nombrePortada);
            string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDProyecto.accdb";
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);
            conexion.Open();
            string sentenciaSQL = "INSERT INTO libro VALUES(@isbn, @nombre_libro, @año, @autor, @categoria, @edicion, @numero_pagina, @precio, @ruta_libro, @ruta_portada)";
            OleDbCommand comando = new OleDbCommand(sentenciaSQL, conexion);
            comando.Parameters.AddWithValue("@isbn", isbn);
            comando.Parameters.AddWithValue("@nombre_libro", nombre);
            comando.Parameters.AddWithValue("@año", año);
            comando.Parameters.AddWithValue("@autor", autor);
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.Parameters.AddWithValue("@edicion", edicion);
            comando.Parameters.AddWithValue("@numero_pagina", numeroPaginas);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@ruta_libro", nombreLibro);
            comando.Parameters.AddWithValue("@ruta_portada", nombrePortada);
            try
            {
                comando.ExecuteNonQuery();

                byte[] imagen = ImageToByte(LibroAdmin.Imagen);
                File.WriteAllBytes("Libros" + "\\" + LibroAdmin.Nombre + ".pdf", LibroAdmin.LibroPDF);
                File.WriteAllBytes("Portadas" + "\\" + LibroAdmin.Nombre + ".jpg", imagen);
                Console.WriteLine("Libros" + "\\" + LibroAdmin.Nombre + ".pdf");
                Console.WriteLine("Portadas" + "\\" + LibroAdmin.Nombre + ".jpg");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.WriteLine("Libro agregado");
            conexion.Close();

        }

        public static void ModificarLibro()
        {
        }

        #endregion
        

        //Metodos Hellen
        #region 
        public static void DatosUsuario()
        {
            Console.WriteLine("Obteniendo Datos del usuario...");
            Usuario usua = new Usuario();
            string cadenaConexion = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDProyecto.accdb");
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);
            conexion.Open();
            string usuario = br.ReadString();
            OleDbCommand comando1 = new OleDbCommand("SELECT * FROM cliente WHERE usuario='" + usuario + "'", conexion);
            OleDbDataReader resultado1 = comando1.ExecuteReader();
            if (resultado1.Read())
            {
                usua.User = resultado1.GetString(0);
                usua.Nombre = resultado1.GetString(1);
                usua.Apellido = resultado1.GetString(2);
                usua.N_tarjeta = resultado1.GetString(3);
                usua.Cantidad = resultado1.GetDecimal(4);
            }

            bw.Write("OK");
            bw.Flush();
            BinaryFormatter bf = new BinaryFormatter();
            Console.WriteLine("Enviando usuario....");
            bf.Serialize(cliente.GetStream(), usua);
            Console.WriteLine("Enviado....");
            resultado1.Close();
            conexion.Close();
        }
        public static void DarValoracionLibro()
        {
            string cadenaConexion = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDProyecto.accdb");
            Console.WriteLine("Dando valoración...");
            string isbn = br.ReadString();
            string usuario = br.ReadString();
            int valoracion = br.ReadInt32();
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);
            conexion.Open();
            string sentenciaSQL1 = "UPDATE libro_cliente SET valoracion = " + valoracion + " WHERE isbn ='"+ isbn + "'AND user ='"+ usuario + "'";
            OleDbCommand comando1 = new OleDbCommand(sentenciaSQL1, conexion);
            try
            {
                comando1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.WriteLine("Valoracion dada.");
            conexion.Close();
        }

        public static void ObtenerValoracionLibro()
        {
            List<Libro> LibrosVal = new List<Libro>();
            List<int> valoraciones = new List<int>();
            int valoracionTotal = 0;
            Libro librito;
            string cadenaConexion = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDProyecto.accdb");
            Console.WriteLine("Obteniendo valoración...");
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);
            conexion.Open();
            string sentenciaSQL1 = "SELECT * FROM LIBRO";
            OleDbCommand comando1 = new OleDbCommand(sentenciaSQL1, conexion);
            OleDbDataReader lectorDatos1 = comando1.ExecuteReader();
            while(lectorDatos1.Read())
            {
                string isbn = lectorDatos1.GetString(0);
                string sentenciaSQL2 = "SELECT * FROM libro_cliente WHERE isbn='" + isbn + "'";
                OleDbCommand comando2 = new OleDbCommand(sentenciaSQL2, conexion);
                OleDbDataReader lectorDatos2 = comando2.ExecuteReader();
                while (lectorDatos2.Read())
                {
                    int valoracion = lectorDatos2.GetInt32(2);
                    valoraciones.Add(valoracion);
                }

                int sumatoria = 0;
                foreach (int x in valoraciones)
                {
                    sumatoria = sumatoria + x;
                }
                try
                {
                    valoracionTotal = (sumatoria / valoraciones.Count);
                }
                catch (DivideByZeroException )
                {
                    valoracionTotal = 0;
                }
                librito = new Libro();
                librito.Isbn = isbn;
                librito.Valoracion = valoracionTotal;
                librito.Nombre = lectorDatos1.GetString(1);// Obtiene nombre de user y lo mete en nombre de libro
                LibrosVal.Add(librito);
                valoraciones.Clear();
            }
            
            bw.Write("OK");
            bw.Flush();

            BinaryFormatter bf = new BinaryFormatter();
            Console.WriteLine("Enviando Lista de valoraciones....");
            bf.Serialize(cliente.GetStream(), LibrosVal);
            Console.WriteLine("Enviado....");
            lectorDatos1.Close();
            conexion.Close();

        }
        
        public static void CargarLibroUsuario()
        {
            Console.WriteLine("Se Cargaran e enviaran los libros del usuario...");
            List<Libro> libros = new List<Libro>();
            Libro obtenido;

            string cadenaConexion = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDProyecto.accdb");
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);
            conexion.Open();
            string usuario = br.ReadString();
            string sentenciaSQL1 = "SELECT * FROM libro_cliente WHERE user ='" + usuario + "'";
            OleDbCommand comando1 = new OleDbCommand(sentenciaSQL1, conexion);
            OleDbDataReader lectorDatos1 = comando1.ExecuteReader();
            while (lectorDatos1.Read())
            {
                string isbn = lectorDatos1.GetString(0);
                string sentenciaSQL2 = "SELECT * FROM libro WHERE isbn='" + isbn + "'";
                OleDbCommand comando2 = new OleDbCommand(sentenciaSQL2, conexion);
                OleDbDataReader lectorDatos2 = comando2.ExecuteReader();
                while (lectorDatos2.Read())
                {
                    obtenido = new Libro();
                    obtenido.Isbn = lectorDatos2.GetString(0);
                    obtenido.Nombre = lectorDatos2.GetString(1);
                    obtenido.Año = lectorDatos2.GetInt32(2);
                    obtenido.Autor = lectorDatos2.GetString(3);
                    obtenido.Categoria = lectorDatos2.GetString(4);
                    obtenido.Edicion = lectorDatos2.GetString(5);
                    obtenido.N_paginas = lectorDatos2.GetInt32(6);
                    obtenido.Precio = lectorDatos2.GetDecimal(7);
                    string rutaLibro = lectorDatos2.GetString(8);
                    string ruta1 = "Libros" + "\\" + rutaLibro;
                    Console.WriteLine(ruta1);
                    byte[] fileArray = File.ReadAllBytes(ruta1);
                    obtenido.LibroPDF = fileArray;
                    string rutaImagen = lectorDatos2.GetString(9);
                    string ruta2 = "Portadas" + "\\" + rutaImagen;
                    Console.WriteLine(ruta2);
                    Bitmap portada = new Bitmap(ruta2);
                    obtenido.Imagen = portada;
                    libros.Add(obtenido);
                }
            }
            BinaryFormatter bf = new BinaryFormatter();
            Console.WriteLine("Enviando Lista De Libros del usuario....");
            bf.Serialize(cliente.GetStream(), libros);
            Console.WriteLine("Libros Enviados....");
        }
        
        public static void MejoresLibros()
        {
            string cadenaConexion = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDProyecto.accdb");
            Console.WriteLine("Se buscan los mejores libros");
            List<Libro> mejoresLibros = new List<Libro>();
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);
            conexion.Open();
            string sentenciaSQL1 = "SELECT isbn, AVG(valoracion) FROM libro_cliente GROUP BY isbn HAVING AVG(valoracion) >= 4 ORDER BY AVG(valoracion) DESC";
            OleDbCommand comando1 = new OleDbCommand(sentenciaSQL1, conexion);
            OleDbDataReader lectorDatos1 = comando1.ExecuteReader();
            while (lectorDatos1.Read())
            {
                string isbn = lectorDatos1.GetString(0);
                string senteciaSQL2 = "SELECT * FROM libro WHERE isbn ='" + isbn + "'";
                OleDbCommand comando2 = new OleDbCommand(senteciaSQL2, conexion);
                OleDbDataReader lectorDatos2 = comando2.ExecuteReader();
                if (lectorDatos2.Read())
                {
                    Libro obtenido = new Libro();
                    obtenido.Isbn = isbn;
                    obtenido.Nombre = lectorDatos2.GetString(1);
                    obtenido.Año = lectorDatos2.GetInt32(2);
                    obtenido.Autor = lectorDatos2.GetString(3);
                    obtenido.Categoria = lectorDatos2.GetString(4);
                    obtenido.Edicion = lectorDatos2.GetString(5);
                    obtenido.N_paginas = lectorDatos2.GetInt32(6);
                    obtenido.Precio = lectorDatos2.GetDecimal(7);
                    string rutaLibro = lectorDatos2.GetString(8);
                    string ruta1 = "Libros" + "\\" + rutaLibro;
                    Console.WriteLine(ruta1);
                    byte[] fileArray = File.ReadAllBytes(ruta1);
                    string rutaImagen = lectorDatos2.GetString(9);
                    string ruta2 = "Portadas" + "\\" + rutaImagen;
                    Console.WriteLine(ruta2);
                    Bitmap portada = new Bitmap(ruta2);
                    obtenido.Imagen = portada;
                    mejoresLibros.Add(obtenido);

                }
            }
            bw.Write("OK");
            bw.Flush();

            BinaryFormatter bf = new BinaryFormatter();
            Console.WriteLine("Enviando Lista De mejores libros....");
            bf.Serialize(cliente.GetStream(), mejoresLibros);
            Console.WriteLine("Libros Enviados....");
            lectorDatos1.Close();
            conexion.Close();
            
        }
        #endregion


        //Metodos Victor
        #region
        public static void CargarLibro()
        {
            Console.WriteLine("Se Cargaran e enviaran los libros");
            List<Libro> libros = new List<Libro>();
            Libro obtenido;

            //try
            //{
                string cadenaConexion = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDProyecto.accdb");

                OleDbConnection conexion = new OleDbConnection(cadenaConexion);
                conexion.Open();
                OleDbCommand comando = new OleDbCommand("SELECT * FROM libro", conexion);
                OleDbDataReader resultado = comando.ExecuteReader();
                while (resultado.Read())
                {
                    obtenido = new Libro();
                    obtenido.Isbn = resultado.GetString(0);
                    obtenido.Nombre = resultado.GetString(1);
                    obtenido.Año = resultado.GetInt32(2);
                    obtenido.Autor = resultado.GetString(3);
                    obtenido.Categoria = resultado.GetString(4);
                    obtenido.Edicion = resultado.GetString(5);
                    obtenido.N_paginas = resultado.GetInt32(6);
                    obtenido.Precio = resultado.GetDecimal(7);
                    string rutaLibro = resultado.GetString(8);
                    string ruta1 = "Libros" + "\\"+rutaLibro;
                    Console.WriteLine(ruta1);
                    byte[] fileArray = File.ReadAllBytes(ruta1);
                    obtenido.LibroPDF = fileArray;
                    string rutaImagen = resultado.GetString(9);
                    string ruta2 = "Portadas" + "\\" + rutaImagen;
                    Console.WriteLine(ruta2);
                    Bitmap portada = new Bitmap(ruta2);
                    obtenido.Imagen = portada;
                    //Console.WriteLine("Creando Libro ");
                    libros.Add(obtenido);
                }
                BinaryFormatter bf = new BinaryFormatter();
                Console.WriteLine("Enviando Lista De Libros....");
                bf.Serialize(cliente.GetStream(),libros);
                Console.WriteLine("Libros Enviados....");
                //conexion.Close();
            //}
            //catch
            //{
            //    //MessageBox.Show("Error de Conexion");
            //}

        }
        
        public static void AgregarLibroUsuario()
        {// Libros comprados por el usuario
            string isbn = br.ReadString();
            string usuario = br.ReadString();

            string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDProyecto.accdb";
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);
            conexion.Open();
            string sentenciaSQL1 = "INSERT INTO libro_cliente VALUES(@isbn, @usuario,@valoracion)";
            OleDbCommand comando2 = new OleDbCommand(sentenciaSQL1, conexion);
            comando2.Parameters.AddWithValue("@isbn", isbn);
            comando2.Parameters.AddWithValue("@usuario", usuario);
            comando2.Parameters.AddWithValue("@valoracion", 0);

            try
            {

                comando2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.WriteLine("Libro Comprado Guardado USUARIO");
            conexion.Close();


        }
        #endregion
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

    }
}
