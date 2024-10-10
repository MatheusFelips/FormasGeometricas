using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaGeometrica.Formas.FormasGeometricas.Retangulo
{
    public class Retangulo : Forma
    {
        double baseRetangulo, altura;

        public Retangulo(double _baseRetangulo, double _altura)
        {
            this.baseRetangulo = _baseRetangulo;
            this.altura = _altura;
        }

        public override double calcularArea()
        {
            area = baseRetangulo * altura;
            return area;
        }

        public override double calcularPerimetro()
        {
            perimetro = (2 * baseRetangulo) + (altura * 2);
            return perimetro;
        }

        public double getBase()
        {
            return baseRetangulo;
        }
        public void setBase(double _baseRetangulo)
        {
            this.baseRetangulo = _baseRetangulo;
        }
        public double getAltura()
        {
            return altura;
        }
        public void setAltura(double _altura)
        {
            this.altura = _altura;
        }
    }
}
