using EjercicioClaseAbstracta.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClaseAbstracta.Clases
{
    public class Triangulo : Figura, IAngulos
    {
        private double lado1;
        private double lado2;
        private double lado3;

        public Triangulo(double lado1, double lado2, double lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public int ladoA { get; set; }

        public int ladoB { get; set; }

        public int ladoC { get; set; }


        public override double CalcularArea()
        {
            int areaTriangulo = (ladoUno + ladoDos + ladoTres);
            return areaTriangulo;
        }
            
            
        public  override double CalcularPerimetro()
        {
            return CalcularArea();
        }

        public int CantAngulos()
        {
            Console.WriteLine("El triangulo tiene 3 angulos");
            return 3;
        }

        
    }
}
