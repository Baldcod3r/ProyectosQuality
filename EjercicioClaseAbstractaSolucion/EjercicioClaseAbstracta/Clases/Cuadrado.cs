using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClaseAbstracta.Clases
{
    public sealed  class Cuadrado : Rectangulo
    {
        private double lado;

        public double Lado { get; set; }

        
        
        public Cuadrado(double lado) : base(lado, lado)
        {

        }

        public override string FormaFigura()
        {
            return "Cuadrado";
        }
    }
}
