using System;
using System.Drawing;
using System.Windows.Forms;

/**
 * 
 * 6.13 Write an application that simulates coin tossing. Let the program toss the coin each time the 
 * user presses the “Toss” button. Count the number of times each side of the coin appears. Display the
 * results. The program should call a separate method Flip that takes no arguments and returns false
 * for tails and true for heads. [Note: If the program realistically simulates the coin tossing, each side
 * of the coin should appear approximately half of the time.]
 * 
 */

namespace HW_6._13
{
    public partial class Form1 : Form
    {
        Random random = new Random(); // random instance to generate random number
        string txt = "";

        /// <summary>
        ///     Form initializer
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     This method generates random number 1 or 2. 
        ///     1 means head, 2 means tail.
        /// </summary>
        /// <returns>true if result is head</returns>
        private bool Flip()
        {
            int number = random.Next(1, 3); // returns either 1 or 2
            //head
            if (number == 1) return true;
            //tail
            return false;
        }

        /// <summary>
        ///     This method is listener of btnPress button. Calls Flip() method and sets other tools properties.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPressClick(object sender, EventArgs e)
        {

            // Flip() returns true if side of coin is head
            bool isHead = Flip();

            if (isHead)
            {
                lblHeadCount.Text = (int.Parse(lblHeadCount.Text) + 1).ToString(); // increasing count
                txt = "HEAD"; // will be used for changing the text of lblText
                pictureBox.Image = new Bitmap(Properties.Resources.head); // changing the image of pictureBox
            }
            else
            {
                lblTailCount.Text = (int.Parse(lblTailCount.Text) + 1).ToString();
                txt = "TAIL";
                pictureBox.Image = new Bitmap(Properties.Resources.tail);

            }
            lblText.Text = txt;
        }

    }
}
