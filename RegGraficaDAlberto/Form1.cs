using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegGraficaDAlberto
{
    public partial class Form1 : Form
    {
        int ancho, alto, numPuntos = 10, segmentoX;

        Point[] tabPuntos;

        public Form1()
        {
            InitializeComponent();
        }

        private void panelGeneral_Paint(object sender, PaintEventArgs e)
        {
            ancho = panelGeneral.Width;
            alto = panelGeneral.Height;
            tabPuntos = new Point[numPuntos];
            Random azar = new Random();

            for (int i = 0; i < tabPuntos.Length; i++)
            {
                tabPuntos[i] = new Point(i * segmentoX, azar.Next(alto));
            }

            Pen pen = new Pen(Color.Black, 3);


        }
    }
}
