using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClaseAbstracta.Clases
{
    public class Rectangulo : Figura
    {
        public double LadoA { get; }
        public double LadoB { get; }

        public Rectangulo(double ladoA, double ladoB)
        {
            LadoA = ladoA;
            LadoB = ladoB;
        }

        public override double CalcularArea()
        {
            return LadoA * LadoB;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (LadoA + LadoB);
        }

        public override string FormaFigura()
        {
            return "Rectángulo";
        }
    }
}
