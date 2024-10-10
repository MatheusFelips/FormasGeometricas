using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaGeometrica.Formas.FormasGeometricas.Triângulo
{
    public class Triangulo : Forma
    {
        double lado1,lado2, lado3, medianaLados;

        public Triangulo(double _lado1, double _lado2, double _lado3)
        {
            this.lado1 = _lado1;
            this.lado2 = _lado2;
            this.lado3 = _lado3;
        }

        public override double calcularArea()
        {
            var medianaLados = (lado1 + lado2 + lado3) / 2;
            area = Math.Sqrt(medianaLados * (medianaLados - lado1) * (medianaLados - lado2) * (medianaLados - lado3));
            return area;
        }

        public override double calcularPerimetro()
        {
            perimetro = lado1 + lado2 + lado3;
            return perimetro;
        }

        public double getLado1(){ return lado1; }
        public void setLado1(double _lado1){ this.lado1 = _lado1; }
        public double getLado2(){ return lado2; }
        public void setALado3(double _lado2) { this.lado2 = _lado2; }
        public double getLado3() { return lado3; }
        public void setLado3(double _lado3) { this.lado2 = _lado3; }
    }
}
