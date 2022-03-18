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
    public partial class Circulo : Form
    {
        /// <summary>
        /// Pedro Andres Lara, Alexis Knight Wilfer, Kevin Kaled Rojas
        /// Dibujar Figuras 
        /// 17/03/2022
        /// </summary>
        Graphics grafico;


        public Circulo()
        {
            InitializeComponent();
            grafico = CreateGraphics();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void btnCalcularCrl_Click(object sender, EventArgs e)
        {
            try
            { 
                double Radio = double.Parse(txtRadio.Text);
                double Area = 0;

                clsAreaCirculo Calcular = new clsAreaCirculo( Radio);

                Area = Calcular.obtenAreaCrl();

                txtAreaCrl.Text = Convert.ToString(Area);
            }

            catch (Exception)
            {

                MessageBox.Show("Digite el valor en tipo numerico");
            }
        }

        private void btnDibujarCrl_Click(object sender, EventArgs e)
        {
            try
            { 
                double Radio = double.Parse(txtRadio.Text);

                Pen blackPen = new Pen(Color.Black, 3);

                grafico.DrawEllipse(blackPen, 0, 0, (float)Radio, (float)Radio);

            }

            catch (Exception)
            {

                MessageBox.Show("Digite el valor en tipo numerico");
            }
}
    }
}
