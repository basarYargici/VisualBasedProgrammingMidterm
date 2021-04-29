using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_7._9
{
    public partial class Form : System.Windows.Forms.Form
    {
        private String key;
        int[] a = { 0, 2, 4, 6, 8, 10, 12, 14, 16, 26, 18, 20, 22, 24, 26, 28 };
        public Form()
        {
            InitializeComponent();
            lblSearched.Text = "Portitions of array searched";
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
        
            foreach(int num in a)
            {
                lblResultSet.Text += num.ToString();
            }
            lblResultSet.Text += Environment.NewLine;

        }

    }
}
