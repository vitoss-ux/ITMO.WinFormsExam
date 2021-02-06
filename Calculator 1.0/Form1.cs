using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Calculator
{
    public partial class Form1 : Form
    {
        String operation = "";
        Double firstnumber, secondnumber;
        bool operIsSelected;
        bool updateSecondNum;

        public Form1()
        {
            InitializeComponent();
            this.Width = 310;
            this.Height = 495;
            this.txtDisplay.Width = 280;
        }

        //disable keyboard input
        private void txtDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        //standart
        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 310;
            this.Height = 495;
            this.txtDisplay.Width = 280;
        }

        //scientific
        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 480;
            this.Height = 495;
            this.txtDisplay.Width = 450;
        }

        //buttons 0-9 press
        private void NumericValue(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (operIsSelected)
            {
                txtDisplay.Text = "";
                operIsSelected = false;
            }

            if (txtDisplay.Text == "0")
                txtDisplay.Text = "";
            if (b.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + b.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + b.Text;
            }
        }

        //button cancel
        private void butC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        //operator +,-,*,/ buttons
        private void Operation_Func(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            firstnumber = Double.Parse(txtDisplay.Text);
            operation = b.Text;
            //txtDisplay.Text = "";
            operIsSelected = true;
            updateSecondNum = true;
        }

        //button backspace
        private void butDel_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        //button change +/-
        private void butSymbol_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("-"))
            {
                txtDisplay.Text = txtDisplay.Text.Remove(0, 1);
            }
            else
            {
                txtDisplay.Text = "-" + txtDisplay.Text;
            }
                
        }

        //square root
        private void butSqrt_Click(object sender, EventArgs e)
        {
            Double sqt = Double.Parse(txtDisplay.Text);
            sqt = Math.Sqrt(sqt);
            txtDisplay.Text = Convert.ToString(sqt);
        }

        //reverse number 1/x
        private void butRevNum_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtDisplay.Text));
            txtDisplay.Text = Convert.ToString(a);
        }

        //square number
        private void butSquareNum_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtDisplay.Text);
            a = Math.Pow(a, 2);
            txtDisplay.Text = Convert.ToString(a);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        //factorial
        private void button1_Click(object sender, EventArgs e)
        {
            long num = long.Parse(txtDisplay.Text);
            long factorial = 1;
            for (int i = 1; num >= i; ++i)
                factorial *= i;
            txtDisplay.Text = Convert.ToString(factorial);
            if (num <= 0)
                txtDisplay.Text = "Error";
        }

        //cubic root
        private void button2_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtDisplay.Text);
            a = Math.Pow(a, 1.0 / 3.0);
            txtDisplay.Text = Convert.ToString(a);
        }

        private void butExp_Click(object sender, EventArgs e)
        {
            Double i = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Exp(i).ToString();
        }

        Form2 f = new Form2();
        public void button3_Click(object sender, EventArgs e)
        {
            f.Show();
            this.TopMost = false;
        }

        //equal metod
        private void butEqual_Click(object sender, EventArgs e)
        {
            if (updateSecondNum)
            {
                secondnumber = double.Parse(txtDisplay.Text);
                updateSecondNum = false;
            }
            
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = Convert.ToString(firstnumber + secondnumber);
                    break;
                case "-":
                    txtDisplay.Text = Convert.ToString(firstnumber - secondnumber);
                    break;
                case "*":
                    txtDisplay.Text = Convert.ToString(firstnumber * secondnumber);
                    break;
                case "/":
                    if (secondnumber != 0)
                        txtDisplay.Text = Convert.ToString(firstnumber / secondnumber);
                    else
                        txtDisplay.Text = "Деление на 0!";
                    break;
                default:
                    break;
            }

            if(double.TryParse(txtDisplay.Text, out firstnumber))
            {
                firstnumber = Double.Parse(txtDisplay.Text);
            }
        }
    }
}
