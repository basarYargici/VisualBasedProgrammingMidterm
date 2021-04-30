using System;

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
            int searchKey;
            try {
                searchKey = Int32.Parse(tbKey.Text);
                lblResultSet.Text = "";

                // initialize display string for the new search

                // perform the binary search
                int element = BinarySearch(a, searchKey, 0, a.Length - 1);

                if (element != -1)
                    lblExplanation.Text = "Found value at element " + element;
                else
                    lblExplanation.Text = "Value not found";
            } catch (Exception ex)
            {
                lblResultSet.Text = ex.Message.ToUpperInvariant();
            }
            
        }

        public int BinarySearch(int[] array, int key)
        {
            int low = 0; // low subscript
            int high = array.Length - 1; // high subscript
            int middle; // middle subscript

            while (low <= high)
            {
                middle = (low + high) / 2;

                // the following line displays the portion
                // of the array currently being manipulated during
                // each iteration of the binary search loop
                BuildOutput(a, low, middle, high);

                if (key == array[middle]) // match
                    return middle;
                else if (key < array[middle])
                    high = middle - 1; // search low end of array
                else
                    low = middle + 1;

            } // end BinarySearch

            return -1; // search key not found

        } // end method BinarySearch

        public int BinarySearch(int[] array, int key,int start, int end)
        {
            int low = 0; // low subscript
            int high = array.Length - 1; // high subscript
            int middle; // middle subscript

            if (end >= start)
            {
                int mid = start + (end - start) / 2;
                
                // If the element is present at the
                // middle itself
                if (array[mid] == key)
                {
                    BuildOutput(a, start, mid, end);
                    return mid;
                }
                   

                // If element is smaller than mid, then
                // it can only be present in left subarray
                if (array[mid] > key)
                {
                    BuildOutput(a, start, mid, end);
                    return BinarySearch(array, key, start, mid-1);

                }

                // Else the element can only be present
                // in right subarray
                BuildOutput(a, start, mid, end);
                return BinarySearch(array, key, mid + 1, end);
            }

                return -1; // search key not found

        } // end method BinarySearch


        public void BuildOutput(
        int[] array, int low, int mid, int high)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i < low || i > high)
                    lblResultSet.Text += " ";

                // mark middle element in output
                else if (i == mid)
                    lblResultSet.Text +=
                    array[i].ToString("00") + "* ";
                else
                    lblResultSet.Text +=
                    array[i].ToString("00") + " ";
            }

            lblResultSet.Text += "\r\n";

        } // end BuildOutput

 
    }
}
