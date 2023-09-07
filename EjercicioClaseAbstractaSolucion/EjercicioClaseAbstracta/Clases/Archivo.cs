

using EjercicioClaseAbstracta.Interfaces;
using System.IO;

namespace EjercicioClaseAbstracta.Clases
{
  

class Archivo
{



    public static void CrearArchivo(List<Figura> listFigura, string rutaArchivo)
        {
            rutaArchivo = rutaArchivo + "\\listaFigura.txt";

            StreamWriter archivo = File.CreateText(rutaArchivo);

            foreach (Figura a in listFigura)
            {
                archivo.WriteLine(a.FormaFigura());
                archivo.WriteLine(a.CalcularPerimetro());
                archivo.WriteLine(a.CalcularArea());
                archivo.WriteLine(DateTime.Now.ToShortTimeString());
            }

            archivo.Close();
            Console.WriteLine("## El archivo fue guardado Correctamente ##");
        }

    public static void LeerArchivo(List<Figura> listFigura, string rutaArchivo)
    {
            StreamReader archivoALeer;
            rutaArchivo = rutaArchivo + "\\listaFigura.txt";
            archivoALeer = File.OpenText(rutaArchivo);
            string lectura;
            Console.WriteLine("");
            Console.WriteLine("**************Ahora leemos el archivo************");
            do
            {
                lectura = archivoALeer.ReadLine();
                Console.WriteLine(lectura);
            } while (lectura != null);
            archivoALeer.Close();
        }

    public static void AgregarContenidoArchivo(string rutaArchivo)
    {
            StreamWriter archivoAModificar;
            rutaArchivo = rutaArchivo + "\\listaFigura.txt";
            string nuevoTexto;
            nuevoTexto = Console.ReadLine();
            File.AppendAllText(rutaArchivo, nuevoTexto);
            


        }




    }

}
