using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaGeometrica.Formas.FormasGeometricas.Pentagono
{
    public class Pentagono : Forma
    {
        double lado;

        public Pentagono(double _lado)
        {
            this.lado = _lado;
        }

        public override double calcularArea()
        {
            area = (Math.Pow(getLado(), 2) * 5) / (this.getLado() * Math.Tan(Math.PI / 5)); ;
            return area;
        }

        public override double calcularPerimetro()
        {
            perimetro = lado * 5;
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
