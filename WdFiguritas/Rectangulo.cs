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
    public partial class Rectangulo : Form
    {
        Graphics grafico;
        public Rectangulo()
        {
            InitializeComponent();
            grafico = CreateGraphics();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularRtg_Click(object sender, EventArgs e)
        {
            try
            {
                double Base = double.Parse(txtBaseRtg.Text);
                double Altura = double.Parse(txtAlturaRtg.Text);
                double Area = 0;

                clsAreaRectangulo Calcular = new clsAreaRectangulo(Base,Altura);

                Area = Calcular.obtenAreaRtg();

                txtAreaRtg.Text = Convert.ToString(Area);
            }

            catch (Exception)
            {

                MessageBox.Show("Digite el valor en tipo numerico");
            }
        }

        private void btnDibujarRtg_Click(object sender, EventArgs e)
        {
            try
            {
                double Base = double.Parse(txtBaseRtg.Text);
                double Altura = double.Parse(txtAlturaRtg.Text);

                Pen blackPen = new Pen(Color.Black, 3);

                grafico.DrawRectangle(blackPen, 0, 0, (float)Base, (float)Altura);

            }

            catch (Exception)
            {

                MessageBox.Show("Digite el valor en tipo numerico");
            }
        }
    }
}
