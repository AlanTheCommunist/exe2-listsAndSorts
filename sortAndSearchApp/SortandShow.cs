using System.Drawing.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace sortAndSearchApp
{
    public partial class SortandShow : Form
    {
        public SortandShow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private List<int> array = new List<int>();

        private void BtnInsert_click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(inputNumbers.Text, out number))
            {
                array.Add(number);
                UpdateLabel2();
            }
            else
            {
                label1.Text = "Conversion failed. Correct your input";
            }
            Console.WriteLine(number);
            inputNumbers.Clear();
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            array = Program.Bsort(array.ToArray()).ToList();
            UpdateLabel2();
        }

        private void UpdateLabel2()
        {
            label2.Text = string.Join(", ", array);
        }

        private void inputNumbers_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = "Insert ints";
        }

        private void BTN_Next_Click(object sender, EventArgs e)
        {
            nameSort nameSort = new nameSort();
            Hide();
            nameSort.Show();
        }

        private void BTN_Prev_Click(object sender, EventArgs e)
        {
            nameSort nameSort = new nameSort();
            Hide();
            nameSort.Show();
        }

    }
}
