using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //required for dll import

namespace BasicCalc
{
    public partial class frmCalculator : Form
    {

        public frmCalculator()
        {

            InitializeComponent();
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            CalcDisplay CD = new CalcDisplay();
            lblCalc.Text = CD.UpdateDisplay(lblCalc.Text,"1");            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            CalcDisplay CD = new CalcDisplay();
            lblCalc.Text = CD.UpdateDisplay(lblCalc.Text, "2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            CalcDisplay CD = new CalcDisplay();
            lblCalc.Text = CD.UpdateDisplay(lblCalc.Text, "3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            CalcDisplay CD = new CalcDisplay();
            lblCalc.Text = CD.UpdateDisplay(lblCalc.Text, "4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            CalcDisplay CD = new CalcDisplay();
            lblCalc.Text = CD.UpdateDisplay(lblCalc.Text, "5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            CalcDisplay CD = new CalcDisplay();
            lblCalc.Text = CD.UpdateDisplay(lblCalc.Text, "6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            CalcDisplay CD = new CalcDisplay();
            lblCalc.Text = CD.UpdateDisplay(lblCalc.Text, "7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            CalcDisplay CD = new CalcDisplay();
            lblCalc.Text = CD.UpdateDisplay(lblCalc.Text, "8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            CalcDisplay CD = new CalcDisplay();
            lblCalc.Text = CD.UpdateDisplay(lblCalc.Text, "9");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            CalcDisplay CD = new CalcDisplay();
            lblCalc.Text = CD.UpdateDisplay(lblCalc.Text, "0");
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            CalcDisplay CD = new CalcDisplay();
            lblCalc.Text = CD.UpdateDisplay(lblCalc.Text, ".");
        }
    }
}
