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

            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(frmCalculator_KeyPress);
        }

        // Detect all numeric characters at the form level and consume
        // Note that Form.KeyPreview must be set to true for this
        // event handler to be called.
        void frmCalculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 42 && e.KeyChar <= 57)
            {

                switch (e.KeyChar)
                {
                    case (char)42://*
                        //btnDecimal.PerformClick();
                        break;
                    case (char)43://+
                        break;
                    case (char)45:// -
                        break;
                    case (char)47:// "/"
                        break;
                    case (char)46://.
                        btnDecimal.PerformClick();
                        break;
                    case (char)48://0
                        btnZero.PerformClick();
                        break;
                    case (char)49://1
                        btn1.PerformClick();
                        break;
                    case (char)50://2
                        btn2.PerformClick();
                        break;
                    case (char)51://3
                        btn3.PerformClick();
                        break;
                    case (char)52://4
                        btn4.PerformClick();
                        break;
                    case (char)53://5
                        btn5.PerformClick();
                        break;
                    case (char)54://6
                        btn6.PerformClick();
                        break;
                    case (char)55://7
                        btn7.PerformClick();
                        break;
                    case (char)56://8
                        btn8.PerformClick();
                        break;
                    case (char)57://9
                        btn9.PerformClick();
                        break;
                    case (char)58:
                        break;
                }
            }
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

        private void frmCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
