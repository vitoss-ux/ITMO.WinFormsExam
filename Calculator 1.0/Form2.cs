using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);
                double c = Convert.ToDouble(txtC.Text);
                double d = b * b - 4 * a * c;

                if (d < 0)
                {
                    textBoxOut.Text = "Дискриминант меньше нуля. Корней нет.";
                }

                if (d == 0)
                {
                    double x = (-b / (2 * a));
                    textBoxOut.Text = "Дискриминант равен нулю. x = " + Math.Round(x, 2) + "";
                }

                if (d > 0)
                {
                    double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                    double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                    textBoxOut.Text = "Дискриминант равен " + Math.Round(d, 2) + ". x₁ = " + Math.Round(x1, 2) + ". x₂ = " + Math.Round(x2, 2) + ".";
                }
            }
            catch
            {
                textBoxOut.Text = "Error! Invalid coefficients. Enter numbers";
            }
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (key != 8) && (key != 44) && (key != 45))
            {
                e.Handled = true;
            }
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (key != 8) && (key != 44) && (key != 45))
            {
                e.Handled = true;
            }
        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (key != 8) && (key != 44) && (key != 45))
            {
                e.Handled = true;
            }
        }
    }
}