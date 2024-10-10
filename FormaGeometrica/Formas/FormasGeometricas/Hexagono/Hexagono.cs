using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaGeometrica.Formas.FormasGeometricas.Hexagono
{
    public class Hexagono : Forma
    {
        double lado;

        public Hexagono(double _lado)
        {
            this.lado = _lado;
        }

        public override double calcularArea()
        {
            area = (Math.Pow(getLado(), 2) * 6) / (this.getLado() * Math.Tan(Math.PI / 6)); ;
            return area;
        }

        public override double calcularPerimetro()
        {
            perimetro = lado * 6;
            return perimetro;
        }

        public double getLado()
        {
            return lado;
        }
        public void setLado(double _lado)
        {
            this.lado = _lado;
        }
    }
}
