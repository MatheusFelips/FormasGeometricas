using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FormaGeometrica.Formas.FormasGeometricas.Quadrado
{
    public class Quadrado : Forma
    {
        double lado;

        public Quadrado(double _lado)
        {
            this.lado = _lado;
        }

        public override double calcularArea()
        {
            area = lado * lado;
            return area;
        }

        public override double calcularPerimetro()
        {
            perimetro = lado * 4;
            return perimetro;
        }

        public double getLado() { 
            return lado; 
        }
        public void setLado(double _lado) { 
            this.lado = _lado; 
        }

    }
}
