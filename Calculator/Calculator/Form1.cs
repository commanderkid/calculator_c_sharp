using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public double a;
        public double b;
        public bool switcher = false;
        char c;
        double besideValueHolder;

        public Form1()
        {
            InitializeComponent();
            tB.Text = "0";
        }
        
        private void butOne_Click(object sender, EventArgs e)
        {
            if (!switcher)
                tB.Text = "";
                switcher = true;
                
            if (tB.Text == "0")
                tB.Text = "1";
            else
                tB.Text += "1";
        }

        private void butTwo_Click(object sender, EventArgs e)
        {
            if (!switcher)
                tB.Text = "";
            switcher = true;

            if (tB.Text == "0")
                tB.Text = "2";
            else
                tB.Text += "2";
        }

        private void butThree_Click(object sender, EventArgs e)
        {
            if (!switcher)
                tB.Text = "";
            switcher = true;

            if (tB.Text == "0")
                tB.Text = "3";
            else
                tB.Text += "3";
        }

        private void butFour_Click(object sender, EventArgs e)
        {
            if (!switcher)
                tB.Text = "";
            switcher = true;

            if (tB.Text == "0")
                tB.Text = "4";
            else
                tB.Text += "4";
        }

        private void butFive_Click(object sender, EventArgs e)
        {
            if (!switcher)
                tB.Text = "";
            switcher = true;

            if (tB.Text == "0")
                tB.Text = "5";
            else
                tB.Text += "5";
        }

        private void butSix_Click(object sender, EventArgs e)
        {
            if (!switcher)
                tB.Text = "";
            switcher = true;

            if (tB.Text == "0")
                tB.Text = "6";
            else
                tB.Text += "6";
        }

        private void butSeven_Click(object sender, EventArgs e)
        {
            if (!switcher)
                tB.Text = "";
            switcher = true;

            if (tB.Text == "0")
                tB.Text = "7";
            else
                tB.Text += "7";
        }

        private void butEight_Click(object sender, EventArgs e)
        {
            if (!switcher)
                tB.Text = "";
            switcher = true;

            if (tB.Text == "0")
                tB.Text = "8";
            else
                tB.Text += "8";
        }

        private void butNine_Click(object sender, EventArgs e)
        {
            if (!switcher)
                tB.Text = "";
            switcher = true;

            if (tB.Text == "0")
                tB.Text = "9";
            else
                tB.Text += "9";
        }

        private void butZero_Click(object sender, EventArgs e)
        {
            if (!switcher)
                tB.Text = "";
            switcher = true;

            if (tB.Text == "0")
                tB.Text = "0";
            else
                tB.Text += "0";
        }

        private void butDZero_Click(object sender, EventArgs e)
        {
            if (!switcher)
                tB.Text = "";
            switcher = true;

            if (tB.Text == "0" || tB.Text == "")
                tB.Text = "0";
            else
                tB.Text += "00";
        }

        private void butDot_Click(object sender, EventArgs e)
        {
            if (!tB.Text.Contains(",") && tB.Text != "")
                tB.Text += ',';
                switcher = true;
        }

        private void butE_Click(object sender, EventArgs e)
        {
            besideValueHolder = Convert.ToDouble(tB.Text);
            switch (c)
            {
                case '+':
                    besideValueHolder = a;
                    a = b;
                    tB.Text = Convert.ToString(a + b);
                    break;
                case '-':
                    tB.Text = Convert.ToString(a - b);
                    break;
                case '*':
                    tB.Text = Convert.ToString(a * b);
                    break;
                case '/':
                    if (b != 0)
                        tB.Text = Convert.ToString(a / b);
                    else
                    {
                        tB.Text = "ZeroDivisionError";
                        switcher = false;
                    }
                    break;
                case '^':
                    tB.Text = Convert.ToString(Math.Pow(a, b));
                    break;
                case 'r':
                    tB.Text = Convert.ToString(Math.Pow(a, 1 / b));
                    break;
            }
        }

        private void butPlus_Click(object sender, EventArgs e)
        {
            if (tB.Text != "ZeroDivisionError")
            {
                a = Convert.ToDouble(tB.Text);
            }
            c = '+';
            switcher = false;
        }

        private void butMinus_Click(object sender, EventArgs e)
        {
            if (tB.Text != "ZeroDivisionError")
                a = Convert.ToDouble(tB.Text);
            c = '-';
            switcher = false;
        }

        private void butMult_Click(object sender, EventArgs e)
        {
            if (tB.Text != "ZeroDivisionError")
                a = Convert.ToDouble(tB.Text);
            c = '*';
            switcher = false;
        }

        private void butDivision_Click(object sender, EventArgs e)
        {
            if (tB.Text != "ZeroDivisionError")
                a = Convert.ToDouble(tB.Text);
            c = '/';
            switcher = false;
        }

        private void butPowT_Click(object sender, EventArgs e)
        {
            if (tB.Text != "ZeroDivisionError")
                a = Convert.ToDouble(tB.Text);
            c = '^';
            switcher = false;
        }

        private void butSQRT_Click(object sender, EventArgs e)
        {
            if (tB.Text != "ZeroDivisionError")
                a = Convert.ToDouble(tB.Text);
            c = 'r';
            switcher = false;
        }

        private void butSin_Click(object sender, EventArgs e)
        {
            if (tB.Text != "ZeroDivisionError")
                a = Convert.ToDouble(tB.Text);
            tB.Text = Convert.ToString(Math.Sin(a));
        }

        private void butCos_Click(object sender, EventArgs e)
        {
            if (tB.Text != "ZeroDivisionError")
                a = Convert.ToDouble(tB.Text);
            tB.Text = Convert.ToString(Math.Cos(a));
        }

        private void butTg_Click(object sender, EventArgs e)
        {
            if (tB.Text != "ZeroDivisionError")
                a = Convert.ToDouble(tB.Text);
            tB.Text = Convert.ToString(Math.Tan(a));
        }

        private void butCtg_Click(object sender, EventArgs e)
        {
            if (tB.Text != "ZeroDivisionError")
                a = Convert.ToDouble(tB.Text);
            tB.Text = Convert.ToString(1 / Math.Tan(a));
        }

        private void butC_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            tB.Text = "0";
            switcher = true;
        }

        private void butBs_Click(object sender, EventArgs e)
        {

        }

        private void obautToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TB_rez_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form1.
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
