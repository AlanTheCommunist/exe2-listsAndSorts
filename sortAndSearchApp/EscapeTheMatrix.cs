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

namespace exercises
{
    public partial class EscapeTheMatrix : Form
    {

        private int[,] matrix = {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
        };
        public EscapeTheMatrix()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = matrix.GetLength(1);
            dataGridView1.RowCount = matrix.GetLength(0);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridView1[j, i].Value = matrix[i, j];
                }
            }

            int cellSize = Math.Max(dataGridView1.Width / dataGridView1.ColumnCount, dataGridView1.Height / dataGridView1.RowCount);
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.Width = cellSize;
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = cellSize;
            }
        }

        private static int[,] TransposeMatrix(int[,] matrixData)
        {
            int rows = matrixData.GetLength(0);
            int columns = matrixData.GetLength(1);
            int[,] transposedMatrix = new int[columns, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    transposedMatrix[j, i] = matrixData[i, j];
                }
            }

            return transposedMatrix;
        }

        private void PopulateDataGridView(int[,] matrixData, DataGridView dataGridView)
        {
            for (int i = 0; i < matrixData.GetLength(0); i++)
            {
                for (int j = 0; j < matrixData.GetLength(1); j++)
                {
                    dataGridView[j, i].Value = matrixData[i, j];
                }
            }
        }

        private void BtnTranspose_Click(object sender, EventArgs e)
        {
           
            int[,] transposedMatrix = TransposeMatrix(matrix);
            PopulateDataGridView(transposedMatrix, dataGridView1);
        }

        private void BTN_Next_Click(object sender, EventArgs e)
        {
            SortandShow sortandShow = new SortandShow();
            Hide();
            sortandShow.Show();
        }

        private void BTN_Prev_Click(object sender, EventArgs e)
        {
            BeforeSortAndAfter beforeSortAndAfter = new BeforeSortAndAfter();
            Hide();
            beforeSortAndAfter.Show();
        }

    }
}
