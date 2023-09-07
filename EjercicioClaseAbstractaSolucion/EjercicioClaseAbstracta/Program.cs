using EjercicioClaseAbstracta.Clases;
using EjercicioClaseAbstracta.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("##############################################################");
        Console.WriteLine("Indique el directorio donde desea ubicar el archivo de texto: ");
        Console.WriteLine("##############################################################");
        string rutaArchivo = Console.ReadLine();

        if (Directory.Exists(rutaArchivo))
        {
            Console.WriteLine("El directorio existe.");
        }
        else
        {
            Directory.CreateDirectory(rutaArchivo);
        }

        List<Figura> figuras = new List<Figura>();

        //RECTANGUL
        Console.WriteLine("Ingrese los datos para el Rectángulo:");
        Console.Write("Lado A: ");
        double ladoA = double.Parse(Console.ReadLine());
        Console.Write("Lado B: ");
        double ladoB = double.Parse(Console.ReadLine());
        figuras.Add(new Rectangulo(ladoA, ladoB));

        //CIRCULO
        Console.WriteLine("\nIngrese el radio para el Círculo:");
        double radio = double.Parse(Console.ReadLine());
        figuras.Add(new Circulo(radio));

        //CUADRADO
        Console.WriteLine("\nIngrese el lado para el Cuadrado:");
        double ladoCuadrado = double.Parse(Console.ReadLine());
        figuras.Add(new Cuadrado(ladoCuadrado));

        //TRIANGULO 
        Console.WriteLine("\nIngrese los lados del Triángulo:");
        Console.Write("Lado 1: ");
        double lado1 = double.Parse(Console.ReadLine());
        Console.Write("Lado 2: ");
        double lado2 = double.Parse(Console.ReadLine());
        Console.Write("Lado 3: ");
        double lado3 = double.Parse(Console.ReadLine());
        figuras.Add(new Triangulo(lado1, lado2, lado3));

        Console.WriteLine("\nResultados:");

        //MOSTRAR DATOS 
        foreach (var figura in figuras)
        {
            Console.WriteLine($"Forma: {figura.FormaFigura()}");
            Console.WriteLine($"Área: {figura.CalcularArea()}");
            Console.WriteLine($"Perímetro: {figura.CalcularPerimetro()}");
            if (figura is IAngulos angulos)
            {
                Console.WriteLine($"Cantidad de ángulos: {angulos.CantAngulos()}");
            }
            Console.WriteLine();
        }

        // LISTA ORDENADA FORMA ASCENDENTE
        var figurasOrdenadasPorArea = figuras.OrderBy(f => f.CalcularArea()).ToList();
        Console.WriteLine("Figuras ordenadas por área:");
        foreach (var figura in figurasOrdenadasPorArea)
        {
            Console.WriteLine($"{figura.FormaFigura()} - Área: {figura.CalcularArea()}");
        }

        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Crear un archivo");
            Console.WriteLine("2. Leer un archivo");
            Console.WriteLine("3. Agregar contenido a un archivo");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Archivo.CrearArchivo(figuras, rutaArchivo);
                    Console.WriteLine($"Nombre del archivo {rutaArchivo}");


                    break;

                case "2":
                    Console.Write("Ingrese un directorio para leer el archivo: ");
                    string directorioLeer = Console.ReadLine();
                    Console.Write("Ingrese el nombre del archivo a leer: ");
                    string nombreArchivoLeer = Console.ReadLine();

                    Archivo.LeerArchivo(figuras, nombreArchivoLeer);
                    break;

                case "3":
                    Console.Write("Ingrese un directorio para agregar contenido al archivo: ");
                    string directorioAgregar = Console.ReadLine();
                    Console.Write("Ingrese el nombre del archivo al que desea agregar contenido: ");
                    string nombreArchivoAgregar = Console.ReadLine();
                    Console.WriteLine("Ingrese el contenido que desea agregar: ");

                    Archivo.AgregarContenidoArchivo(rutaArchivo);
                    break;

                case "4":
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }
        }
    }
}
