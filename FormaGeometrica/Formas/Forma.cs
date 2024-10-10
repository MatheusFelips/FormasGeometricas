using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaGeometrica.Formas
{
    public abstract class Forma
    {
       public  double perimetro;
       public double area;

       public abstract double calcularPerimetro();
       public abstract double calcularArea();

    }
}
