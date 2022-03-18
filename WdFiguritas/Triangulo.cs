using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WdFiguritas
{
    public partial class Triangulo : Form
    {
        Graphics grafico;
        public Triangulo()
        {
            InitializeComponent();
            grafico = CreateGraphics();
        }

        private void btnCalcularTrg_Click(object sender, EventArgs e)
        {
            try
            {
                double Base = double.Parse(txtBaseTrg.Text);
                double Altura = double.Parse(txtAlturaTrg.Text);
                double Area = 0;

                clsAreaTriangulo Calcular = new clsAreaTriangulo(Base, Altura);

                Area = Calcular.obtenAreaTrg();

                txtAreaTrg.Text = Convert.ToString(Area);
            }

            catch (Exception)
            {

                MessageBox.Show("Digite el valor en tipo numerico");
            }
        }

        private void btnDibujarTrg_Click(object sender, EventArgs e)
        {
            try
            {
                double Base = double.Parse(txtBaseTrg.Text);
                double Altura = double.Parse(txtAlturaTrg.Text);

                Pen blackPen = new Pen(Color.Black, 3);

                PointF BaseInicial = new PointF(0, (float)Altura);
                PointF BaseFinal = new PointF((float)Base, (float)Altura);
                PointF AlturaInicial = new PointF(0, 0);
                PointF AlturaFinal = new PointF(0, (float)Altura);

                grafico.DrawLine(blackPen, BaseInicial, BaseFinal);
                grafico.DrawLine(blackPen, AlturaInicial, AlturaFinal);
                grafico.DrawLine(blackPen, AlturaInicial, BaseFinal);

            }

            catch (Exception)
            {

                MessageBox.Show("Digite el valor en tipo numerico");
            }
        }
    }
}
