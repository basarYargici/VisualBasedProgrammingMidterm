using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_6._16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            try
            {
                int firstNum = Int32.Parse(tbFirstNum.Text);
                int secondNum = Int32.Parse(tbSecondNum.Text);

                lblGcd.Text = "Greatest Common Divisor : " + Gcd(firstNum, secondNum).ToString();
            }
            catch(Exception exception) {
                lblGcd.Text = exception.Message.ToString();
            }

        }

        private int Gcd(int x, int y)
        {
            if (y == 0) 
                return x;
            else
                return Gcd(y, x % y);
        }
    }
}
