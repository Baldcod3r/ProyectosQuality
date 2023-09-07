using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClaseAbstracta.Clases
{
    public class Circulo : Figura
    {
        public double Radio { get; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Radio * Radio ;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

        public override string FormaFigura()
        {
            return "Círculo";
        }
    }
}
