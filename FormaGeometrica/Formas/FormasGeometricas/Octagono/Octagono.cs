using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaGeometrica.Formas.FormasGeometricas.Octagono
{
    public class Octagono : Forma
    {
        double lado;

        public Octagono(double _lado)
        {
            this.lado = _lado;
        }

        public override double calcularArea()
        {
            area = (Math.Pow(getLado(), 2) * 8) / (this.getLado() * Math.Tan(Math.PI / 8)); ;
            return area;
        }

        public override double calcularPerimetro()
        {
            perimetro = lado * 8;
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
