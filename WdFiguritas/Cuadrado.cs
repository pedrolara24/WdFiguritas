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
    public partial class Cuadrado : Form
    {
        Graphics grafico;
        public Cuadrado()
        {
            InitializeComponent();
            grafico = CreateGraphics();
        }

        private void btnCalcularCdr_Click(object sender, EventArgs e)
        {
            try
            {
                double Lado = double.Parse(txtLado.Text);
                double Area = 0;

                clsAreaCuadrado Calcular = new clsAreaCuadrado(Lado);

                Area = Calcular.obtenAreaCdr();

                txtAreaCdr.Text = Convert.ToString(Area);
            }

            catch (Exception)
            {

                MessageBox.Show("Digite el valor en tipo numerico");
            }
        }

        private void btnDibujarCdr_Click(object sender, EventArgs e)
        {
            try
            {
                double Lado = double.Parse(txtLado.Text);

                Pen blackPen = new Pen(Color.Black, 3);

                grafico.DrawRectangle(blackPen, 0, 0, (float)Lado, (float)Lado);

            }

            catch (Exception)
            {

                MessageBox.Show("Digite el valor en tipo numerico");
            }
        }
    }
}
