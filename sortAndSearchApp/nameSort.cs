using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sortAndSearchApp
{
    public partial class nameSort : Form
    {
        public nameSort()
        {
            InitializeComponent();
        }

        private static List<string> names = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Insert_Click(object sender, EventArgs e)
        {
            names.Add(nameInsertionBox.Text);
            UpdateNameLabel();
        }

        private void BTN_Sort_Click(object sender, EventArgs e)
        {
            names.Sort();
            UpdateNameLabel();
        }

        private void BTN_Next_Click(object sender, EventArgs e)
        {
            SortandShow sortandShow = new SortandShow();
            Hide();
            sortandShow.Show();
        }

        private void BTN_Prev_Click(object sender, EventArgs e)
        {
            SortandShow sortandShow=new SortandShow();
            Hide();
            sortandShow.Show();
        }

        private void UpdateNameLabel()
        {
            nameArray.Text = string.Join(", ", names);
        }

    }
}
