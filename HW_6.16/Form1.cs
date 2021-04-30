using System;
using System.Windows.Forms;

namespace HW_6._16
{
    public partial class Form1 : Form
    {

        /// <summary>
        ///     Form initializer
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     This method is listener of btnFind button. Gets two input from tbFirstNum and tbSecondNum textBoxes and
        ///     finds their general common divisors.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFind_Click(object sender, EventArgs e)
        {
            try
            {
                int firstNum = Int32.Parse(tbFirstNum.Text);
                int secondNum = Int32.Parse(tbSecondNum.Text);

                lblGcd.Text = "Greatest Common Divisor : " + Gcd(firstNum, secondNum).ToString();
            }
            catch (Exception exception)
            {
                lblGcd.Text = exception.Message.ToString();
            }

        }

        /// <summary>
        ///     This method takes two integer parameters and finds their general common divisors recursively.
        /// </summary>
        /// <param name="x">First integer number</param>
        /// <param name="y">Second integer number</param>
        /// <returns>General common divisor</returns>
        private int Gcd(int x, int y)
        {
            if (y == 0)
                return x;
            else
                return Gcd(y, x % y);
        }
    }
}
