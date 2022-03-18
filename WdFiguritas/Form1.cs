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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            Cuadrado Cdr = new Cuadrado();
            Cdr.Show();
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            Circulo Crl = new Circulo();
            Crl.Show();
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            Rectangulo Rtg = new Rectangulo();
            Rtg.Show();
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            Triangulo Trg = new Triangulo();
            Trg.Show();
        }
    }
}
