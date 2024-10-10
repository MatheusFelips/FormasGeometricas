using FormaGeometrica.Formas.FormasGeometricas.Circulo;
using FormaGeometrica.Formas.FormasGeometricas.Hexagono;
using FormaGeometrica.Formas.FormasGeometricas.Octagono;
using FormaGeometrica.Formas.FormasGeometricas.Pentagono;
using FormaGeometrica.Formas.FormasGeometricas.Quadrado;
using FormaGeometrica.Formas.FormasGeometricas.Retangulo;
using FormaGeometrica.Formas.FormasGeometricas.Triângulo;

namespace FormaGeometrica
{
    public partial class FrmForma : Form
    {
        public FrmForma()
        {
            InitializeComponent();
        }

        private void txtLadoQuadrado_TextChanged(object sender, EventArgs e)
        {
            pnlQuadrado.Visible = false;
        }

        private void btnCalcularQuadrado_Click(object sender, EventArgs e)
        {
            double ladoQuadrado;
            double area;
            double perimetro;

            pnlQuadrado.Visible = true;
            lblLadoQuadrado.Text = txtLadoQuadrado.Text;

            if (txtLadoQuadrado.Text == "")
                MessageBox.Show("Digite o tamanho do lado do quadrado");
            else if (!double.TryParse(txtLadoQuadrado.Text, out ladoQuadrado))
                MessageBox.Show("Tamanho do lado do quadrado não é um número válido");
            else
            {
                Quadrado quadrado = new Quadrado(ladoQuadrado);

                area = quadrado.calcularArea();
                perimetro = quadrado.calcularPerimetro();

                lblResultadoQuadrado.Text = $"A área do quadrado é {area}cm² e o perímetro é {perimetro}cm";
            }
        }
        private void txtLado1Retangulo_TextChanged(object sender, EventArgs e)
        {
            pnlRetangulo.Visible = false;
        }

        private void txtLado2Retangulo_TextChanged(object sender, EventArgs e)
        {
            pnlRetangulo.Visible = false;
        }

        private void btnCalcularRetangulo_Click(object sender, EventArgs e)
        {
            double lado1, lado2;
            double area;
            double perimetro;

            pnlRetangulo.Visible = true;



            if (txtLado1Retangulo.Text == "" || txtLado2Retangulo.Text == "")
                MessageBox.Show("Digite os tamanhos dos lados do retângulo");
            else if (!double.TryParse(txtLado1Retangulo.Text, out lado1) || !double.TryParse(txtLado2Retangulo.Text, out lado2))
                MessageBox.Show("Um dos lados do retângulo não é um número válido");
            else
            {

                if (lado1 >= lado2)
                {
                    lblBaseRetangulo.Text = lado1.ToString();
                    lblAlturaRetangulo.Text = lado2.ToString();

                    Retangulo retangulo = new Retangulo(lado1, lado2);
                    area = retangulo.calcularArea();
                    perimetro = retangulo.calcularPerimetro();
                }
                else
                {
                    lblBaseRetangulo.Text = lado2.ToString();
                    lblAlturaRetangulo.Text = lado1.ToString();

                    Retangulo retangulo = new Retangulo(lado2, lado1);
                    area = retangulo.calcularArea();
                    perimetro = retangulo.calcularPerimetro();
                }

                lblResultadoRetangulo.Text = $"A área do retângulo é {area}cm² e o perímetro é {perimetro}cm";
            }
        }

        private void lblTxtLado1Retangulo_Click(object sender, EventArgs e)
        {

        }

        private void FrmForma_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtLblLado1Triangulo_TextChanged(object sender, EventArgs e)
        {
            pnlTriangulo.Visible = false;
        }

        private void txtLblLado2Triangulo_TextChanged(object sender, EventArgs e)
        {
            pnlTriangulo.Visible = false;
        }

        private void txtLblLado3Triangulo_TextChanged(object sender, EventArgs e)
        {
            pnlTriangulo.Visible = false;
        }

        private void calcularTriangulo_Click(object sender, EventArgs e)
        {
            double lado1, lado2, lado3;
            double area;
            double perimetro;

            pnlTriangulo.Visible = true;



            if (txtLado1Triangulo.Text == "" || txtLado2Triangulo.Text == "" || txtLado3Triangulo.Text == "")
                MessageBox.Show("Digite os tamanhos dos lados do tirângulo");
            else if (!double.TryParse(txtLado1Triangulo.Text, out lado1) || !double.TryParse(txtLado2Triangulo.Text, out lado2) || !double.TryParse(txtLado3Triangulo.Text, out lado3))
                MessageBox.Show("Um dos lados do triângulo não é um número válido");
            else
            {

                if (lado1 > lado2)
                {
                    if (lado1 > lado3)
                    {
                        lblLadoMaior.Text = lado1.ToString();
                        if (lado2 > lado3)
                        {
                            lblLadoMenor.Text = lado3.ToString();
                            lblLadoCentral.Text = lado2.ToString();
                        }
                        else
                        {
                            lblLadoMenor.Text = lado2.ToString();
                            lblLadoCentral.Text = lado3.ToString();
                        }
                    }
                    else
                    {
                        lblLadoMaior.Text = lado3.ToString();
                        lblLadoMenor.Text = lado2.ToString();
                        lblLadoCentral.Text = lado1.ToString();
                    }
                }
                if (lado1 > lado3)
                {
                    if (lado1 > lado2)
                    {
                        lblLadoMaior.Text = lado1.ToString();
                        if (lado2 > lado3)
                        {
                            lblLadoMenor.Text = lado3.ToString();
                            lblLadoCentral.Text = lado2.ToString();
                        }
                        else
                        {
                            lblLadoMenor.Text = lado2.ToString();
                            lblLadoCentral.Text = lado3.ToString();
                        }
                    }
                    else
                    {
                        lblLadoMaior.Text = lado2.ToString();
                        lblLadoMenor.Text = lado3.ToString();
                        lblLadoCentral.Text = lado1.ToString();
                    }
                }
                if (lado2 > lado3)
                {
                    if (lado2 > lado1)
                    {
                        lblLadoMaior.Text = lado2.ToString();
                        if (lado1 > lado3)
                        {
                            lblLadoMenor.Text = lado3.ToString();
                            lblLadoCentral.Text = lado1.ToString();
                        }
                        else
                        {
                            lblLadoMenor.Text = lado1.ToString();
                            lblLadoCentral.Text = lado3.ToString();
                        }
                    }
                    else
                    {
                        lblLadoMaior.Text = lado1.ToString();
                        lblLadoMenor.Text = lado3.ToString();
                        lblLadoCentral.Text = lado2.ToString();
                    }
                }
                if (lado1 == lado2 && lado2 == lado3)
                {
                    lblLadoMaior.Text = lado1.ToString();
                    lblLadoMenor.Text = lado3.ToString();
                    lblLadoCentral.Text = lado2.ToString();
                }

                Triangulo triangulo = new Triangulo(lado1, lado2, lado3);
                area = triangulo.calcularArea();
                perimetro = triangulo.calcularPerimetro();

                lblResultadoTriangulo.Text = $"A área do triângulo é {area}cm² e o perímetro é {perimetro}cm";
            }
        }

        private void txtLadoOctagono_TextChanged(object sender, EventArgs e)
        {
            pnlOctagono.Visible = false;
        }

        private void calcularOctagono_Click(object sender, EventArgs e)
        {
            double ladoOctagono;
            double area;
            double perimetro;

            pnlOctagono.Visible = true;
            lblLadoOctagono.Text = txtLadoOctagono.Text;

            if (txtLadoOctagono.Text == "")
                MessageBox.Show("Digite o tamanho do lado do octagono");
            else if (!double.TryParse(txtLadoOctagono.Text, out ladoOctagono))
                MessageBox.Show("Tamanho do lado do octagono não é um número válido");
            else
            {
                Octagono octagono = new Octagono(ladoOctagono);

                area = octagono.calcularArea();
                perimetro = octagono.calcularPerimetro();

                lblResultadoOctagono.Text = $"A área do octagono é {area}cm² e o perímetro é {perimetro}cm";
            }
        }

        private void lblLadoOctagono_Click(object sender, EventArgs e)
        {

        }

        private void lblTxtLadoHexagono_Click(object sender, EventArgs e)
        {

        }

        private void txtLadoHexagono_TextChanged(object sender, EventArgs e)
        {
            pnlHexagono.Visible = false;
        }



        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularHexagono_Click(object sender, EventArgs e)
        {
            double ladoHexagono;
            double area;
            double perimetro;

            pnlHexagono.Visible = true;
            lblLadoHexagono.Text = txtLadoHexagono.Text;

            if (txtLadoHexagono.Text == "")
                MessageBox.Show("Digite o tamanho do lado do Hexagono");
            else if (!double.TryParse(txtLadoHexagono.Text, out ladoHexagono))
                MessageBox.Show("Tamanho do lado do Hexagono não é um número válido");
            else
            {
                Hexagono hexagono = new Hexagono(ladoHexagono);

                area = hexagono.calcularArea();
                perimetro = hexagono.calcularPerimetro();

                lblResultadoHexagono.Text = $"A área do Hexagono é {area}cm² e o perímetro é {perimetro}cm";
            }
        }

        private void txtLadoPentagono_TextChanged(object sender, EventArgs e)
        {
            pnlPentagono.Visible = false;
        }

        private void btnCalcularPentagono_Click(object sender, EventArgs e)
        {
            double ladoPentagono;
            double area;
            double perimetro;

            pnlPentagono.Visible = true;
            lblLadoPentagono.Text = txtLadoPentagono.Text;

            if (txtLadoPentagono.Text == "")
                MessageBox.Show("Digite o tamanho do lado do Pentagono");
            else if (!double.TryParse(txtLadoPentagono.Text, out ladoPentagono))
                MessageBox.Show("Tamanho do lado do Pentagono não é um número válido");
            else
            {
                Pentagono pentagono = new Pentagono(ladoPentagono);

                area = pentagono.calcularArea();
                perimetro = pentagono.calcularPerimetro();

                lblResultadoPentagono.Text = $"A área do Pentagono é {area}cm² e o perímetro é {perimetro}cm";
            }
        }

        private void pnlOctagono_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCirculo_TextChanged(object sender, EventArgs e)
        {
            pnlCirculo.Visible = false;
        }

        private void btnCalcularCirculo_Click(object sender, EventArgs e)
        {
            double raio;
            double area;
            double perimetro;

            pnlCirculo.Visible = true;
            lblRaioCirculo.Text = txtRaioCirculo.Text;

            if (txtRaioCirculo.Text == "")
                MessageBox.Show("Digite o tamanho do lado do Circulo");
            else if (!double.TryParse(txtRaioCirculo.Text, out raio))
                MessageBox.Show("Tamanho do lado do Circulo não é um número válido");
            else
            {
                Circulo circulo = new Circulo(raio);

                area = circulo.calcularArea();
                perimetro = circulo.calcularPerimetro();

                lblResultadoCirculo.Text = $"A área do Circulo é {area}cm² e o perímetro é {perimetro}cm";
            }
        }
    }
}
