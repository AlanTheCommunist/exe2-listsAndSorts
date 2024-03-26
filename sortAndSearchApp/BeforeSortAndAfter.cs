using sortAndSearchApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace exercises
{
    public partial class BeforeSortAndAfter : Form
    {
        public BeforeSortAndAfter()
        {
            InitializeComponent();
        }

        private List<int> array = [];

        private void beforeSortAndAfter_Load(object sender, EventArgs e) { }

        private void BtnInsert_click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(inputNumbers.Text, out number))
            {
                array.Add(number);
                UpdateLabelArray();
                UpdateLabelMin();
                UpdateLabelMax();
            }
            else
            {
                label1.Text = "Conversion failed. Correct your input";
            }
            inputNumbers.Clear();
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            array = Program.Bsort(array.ToArray()).ToList();
            UpdateLabelArray();
            UpdateLabelMax();
            UpdateLabelMin();
        }

        private void UpdateLabelArray()
        {
            labelArray.Text = string.Join(", ", array);
        }

        private void UpdateLabelMin()
        {
            labelMin.Text = array.Min().ToString() + ", pos: " + array.IndexOf(array.Min());
        }

        private void UpdateLabelMax()
        {
            labelMax.Text = array.Max().ToString() + ", pos: " + array.IndexOf(array.Max());
        }

        private void BTN_Next_Click(object sender, EventArgs e)
        {
            EscapeTheMatrix escapeTheMatrix = new();
            Hide();
            escapeTheMatrix.Show();
            this.Close();
        }

        private void BTN_Prev_Click(object sender, EventArgs e)
        {
            nameSort nameSort = new();
            Hide();
            nameSort.Show();
        }
    }
}
