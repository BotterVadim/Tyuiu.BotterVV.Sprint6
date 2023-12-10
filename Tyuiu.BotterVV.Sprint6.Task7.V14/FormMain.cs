using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.BotterVV.Sprint6.Task7.V14.Lib;

namespace Tyuiu.BotterVV.Sprint6.Task7.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_BVV.Filter = "Значения, разделённые запятыми(*.csv)| *.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_BVV.Filter = "Значения, разделённые запятыми(*.csv)| *.csv|Все файлы(*.*)|*.*";
        }

        public static int rows;
        public static int columns;
        public string openFilePath;

        DataService ds = new DataService();

        private void buttonOpenFile_BVV_MouseEnter(object sender, EventArgs e)
        {
            toolTip_BVV.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_BVV_MouseEnter(object sender, EventArgs e)
        {
            toolTip_BVV.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_BVV_MouseEnter(object sender, EventArgs e)
        {
            toolTip_BVV.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonMessage_BVV_MouseEnter(object sender, EventArgs e)
        {
            toolTip_BVV.ToolTipTitle = "Справка";
        }

        private void buttonOpenFile_BVV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_BVV.ShowDialog();
            openFilePath = openFileDialogTask_BVV.FileName;

            int[,] matrix = ds.GetMatrix(openFilePath);

            dataGridViewIn_BVV.ColumnCount = matrix.GetLength(1);
            dataGridViewIn_BVV.RowCount = matrix.GetLength(0);
            dataGridViewOut_BVV.ColumnCount = matrix.GetLength(1);
            dataGridViewOut_BVV.RowCount = matrix.GetLength(0);

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                dataGridViewIn_BVV.Columns[i].Width = 25;
                dataGridViewOut_BVV.Columns[i].Width = 25;
            }

            for (int r = 0; r < dataGridViewIn_BVV.RowCount; r++)
            {
                for (int c = 0; c < dataGridViewIn_BVV.ColumnCount; c++)
                {
                    dataGridViewIn_BVV.Rows[r].Cells[c].Value = matrix[r, c];
                }
            }
            buttonDone_BVV.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_BVV.ColumnCount = 50;
            dataGridViewOut_BVV.ColumnCount = 50;

            dataGridViewIn_BVV.RowCount = 50;
            dataGridViewOut_BVV.RowCount = 50;

            panelInPut_BVV.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_BVV.Columns[i].Width = 25;
                dataGridViewOut_BVV.Columns[i].Width = 25;
            }
        }

        private void buttonDone_BVV_Click(object sender, EventArgs e)
        {
            int[,] matrix = ds.GetMatrix(openFilePath);

            for (int r = 0; r < dataGridViewOut_BVV.RowCount; r++)
            {
                for (int c = 0; c < dataGridViewOut_BVV.ColumnCount; c++)
                {
                    if ((r == 1) & (matrix[r, c] % 2 == 0))
                    {
                        dataGridViewOut_BVV.Rows[r].Cells[c].Value = 44;
                    }
                    else
                    {
                        dataGridViewOut_BVV.Rows[r].Cells[c].Value = matrix[r, c];
                    }
                }
            }

            buttonSaveFile_BVV.Enabled = true;
        }

        private void buttonSaveFile_BVV_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_BVV.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_BVV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_BVV.ShowDialog();

            string path = saveFileDialogMatrix_BVV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_BVV.RowCount;
            int columns = dataGridViewOut_BVV.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns)
                    {
                        str = str + dataGridViewOut_BVV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_BVV.Rows[i].Cells[i].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonMessage_BVV_Click(object sender, EventArgs e)
        {
            FormAbout_BVV formAbout = new FormAbout_BVV();
            formAbout.ShowDialog();
        }
    }
}
