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
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        const int HOTKEY_ONE = 1;
        const int HOTKEY_TWO = 2;

        public frmCalculator()
        {
            RegisterHotKey(this.Handle, HOTKEY_ONE, 0, (int)Keys.NumPad1);
            RegisterHotKey(this.Handle, HOTKEY_TWO, 0, (int)Keys.NumPad2);

            InitializeComponent();
        }


        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == HOTKEY_ONE)
            {
                btn1.PerformClick();
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == HOTKEY_TWO)
            {
                btn2.PerformClick();
            }
            base.WndProc(ref m);
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
