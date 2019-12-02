using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2pontos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        distancia c = new distancia();

        private void Button1_Click(object sender, EventArgs e)
        {
            c.X1 = x1.Text;
            c.X2 = x2.Text;
            c.Y1 = y1.Text;
            c.Y2 = y2.Text;

            label1.Text = c.Distancia;
        }
    }
}
