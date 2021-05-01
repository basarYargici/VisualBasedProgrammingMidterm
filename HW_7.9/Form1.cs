using System;

/**
 * 7.9 (Binary Search) Modify the program in Fig. 7.12 to use a recursive method BinarySearch to perform the binary search of the array. 
 * The method should receive an integer array and the starting and ending subscript as arguments. If the search key is found, 
 * return the array subscript; otherwise, return –1.
 */
namespace HW_7._9
{
    public partial class Form : System.Windows.Forms.Form
    {
        int[] a = { 0, 2, 4, 6, 8, 10, 12, 14, 16, 26, 18, 20, 22, 24, 26, 28 }; // array which will be searched to find key

        /// <summary>
        ///     Form initializer
        /// </summary>
        public Form()
        {
            InitializeComponent();
            lblSearched.Text = "Portitions of array searched";
        }

        /// <summary>
        ///     This method is listener of btnFind button. Calls Flip() method and sets other tools properties.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BtnFind_Click(object sender, EventArgs e)
        {
            int searchKey;
            try
            {
                searchKey = Int32.Parse(tbKey.Text);
                lblResultSet.Text = "";


                // perform the binary search
                int element = BinarySearch(a, searchKey, 0, a.Length - 1);

                if (element != -1)
                    lblExplanation.Text = "Found value at element " + element;
                else
                    lblExplanation.Text = "Value not found";
            }
            catch (Exception ex)
            {
                lblResultSet.Text = ex.Message.ToUpperInvariant();
            }

        }


        /// <summary>
        ///     Binary Search method to find given key in given array that offered by book.
        /// </summary>
        /// <param name="array">array which will be searched to find key</param>
        /// <param name="key">element which will be searched in array</param>
        /// <returns></returns>
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

        }

        /// <summary>
        ///     Binary Search method to find given key in given array recursively.
        /// </summary>
        /// <param name="array">array which will be searched to find key</param>
        /// <param name="key">element which will be searched in array</param>
        /// <param name="start">first index to start searching in array</param>
        /// <param name="end">last index to end searching in array</param>
        /// <returns></returns>
        public int BinarySearch(int[] array, int key, int start, int end)
        {
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
                    return BinarySearch(array, key, start, mid - 1);

                }

                // Else the element can only be present
                // in right subarray
                BuildOutput(a, start, mid, end);
                return BinarySearch(array, key, mid + 1, end);
            }

            return -1; // search key not found

        }


        /// <summary>
        ///     This method prints the search steps in lblResultSet tool.
        /// </summary>
        /// <param name="array">array which is searched to find key</param>
        /// <param name="low">low subscript</param>
        /// <param name="mid">middle subscript</param>
        /// <param name="high">high subscript</param>
        public void BuildOutput(int[] array, int low, int mid, int high)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i < low || i > high)
                    lblResultSet.Text += " ";

                // mark middle element in output
                else if (i == mid)
                    lblResultSet.Text += array[i].ToString("00") + "* ";
                else
                    lblResultSet.Text += array[i].ToString("00") + " ";
            }

            lblResultSet.Text += "\r\n";

        } // end BuildOutput


    }
}
