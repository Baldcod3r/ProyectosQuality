using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClaseAbstracta.Clases
{
    public abstract class Figura
    {

        public int ladoUno { get;  set; }
        public int ladoDos { get;  set; }
        public int ladoTres   { get;  set; }



        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();

        public virtual string FormaFigura()
        {
            return null;
        }


    }
}
