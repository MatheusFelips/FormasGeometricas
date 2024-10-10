using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaGeometrica.Formas.FormasGeometricas.Circulo
{
    public class Circulo : Forma
    {
        double raio;
        public Circulo(double _raio) 
        {
            this.raio = _raio;
        }
        public double getRaio()
        {
            return raio;
        }
        public void setRaio(double _raio)
        {
            this.raio= _raio;
        }
        public override double calcularArea()
        {
            area = Math.PI * (Math.Pow(raio, 2));
            return area;
        }

        public override double calcularPerimetro()
        {
            perimetro = 2 * Math.PI * raio;
            return perimetro;
        }
    }
}
