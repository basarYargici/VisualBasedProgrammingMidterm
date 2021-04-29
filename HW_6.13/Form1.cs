using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_6._13
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        string txt = "";

        public Form1()
        {
            InitializeComponent();
        }

        private bool Flip()
        {
            int number = random.Next(1, 3); // returns either 1 or 2
            //head
            if (number == 1) return true;
            //tail
            return false;
        }

        private void BtnPressClick(object sender, EventArgs e)
        {

            bool isHead = Flip();

            if (isHead)
            {
                lblHeadCount.Text = (int.Parse(lblHeadCount.Text) + 1).ToString();
                txt = "HEAD";
                pictureBox.Image = new System.Drawing.Bitmap(Properties.Resources.head);
            }
            else
            {
                lblTailCount.Text = (int.Parse(lblTailCount.Text) + 1).ToString();
                txt = "TAIL";
                pictureBox.Image = new System.Drawing.Bitmap(Properties.Resources.tail);

            }
            lblText.Text = txt;
        }

    }
}
