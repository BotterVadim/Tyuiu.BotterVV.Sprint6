using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BotterVV.Sprint6.Task3.V23.Lib;


namespace Tyuiu.BotterVV.Sprint6.Task3.V23
{
    public partial class FormMain : Form
    {
        
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { {0, -19, 25, 34, 0 },
                                      {-19, -16, 1, -5, 34 },
                                      {1, 13, -5, -17, -5 },
                                      {3, -9, -15, -1, 0 },
                                      {1, 20, 15, -5, 31 } };

        private void buttonMessageBVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ПКТб-23-2 Боттер Вадим Валерьевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDoneBVV_Click(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewResultBVV.RowCount = rows;
            dataGridViewResultBVV.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResultBVV.Columns[i].Width = 25;
            }

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    dataGridViewResultBVV.Rows[i].Cells[j].Value = Convert.ToString(ds.Calculate(mtrx)[i, j]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewTaskBVV.RowCount = rows;
            dataGridViewTaskBVV.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewTaskBVV.Columns[i].Width = 25;
            }
            
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    dataGridViewTaskBVV.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
    }
}
