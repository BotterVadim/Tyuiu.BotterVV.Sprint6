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
using Tyuiu.BotterVV.Sprint6.Task5.V4.Lib;

namespace Tyuiu.BotterVV.Sprint6.Task5.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_BVV_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_BVV.BackColor = Color.Aquamarine;
        }

        private void buttonDone_BVV_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_BVV.BackColor = Color.MediumAquamarine;
        }

        private void buttonSave_BVV_MouseEnter(object sender, EventArgs e)
        {
            buttonSave_BVV.BackColor = Color.Violet;
        }

        private void buttonSave_BVV_MouseLeave(object sender, EventArgs e)
        {
            buttonSave_BVV.BackColor = Color.Plum;
        }

        private void buttonMessage_BVV_MouseEnter(object sender, EventArgs e)
        {
            buttonMessage_BVV.BackColor = Color.RoyalBlue;
        }

        private void buttonMessage_BVV_MouseLeave(object sender, EventArgs e)
        {
            buttonMessage_BVV.BackColor = Color.LightSkyBlue;
        }

        private void buttonSave_BVV_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\noph\source\repos\Tyuiu.BotterVV.Sprint6\Tyuiu.BotterVV.Sprint6.Task5.V4\bin\Debug\InPutFileTask5V4.txt";
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        string path = @"C:\Users\noph\source\repos\Tyuiu.BotterVV.Sprint6\Tyuiu.BotterVV.Sprint6.Task5.V4\bin\Debug\InPutFileTask5V4.txt";
        private void buttonDone_BVV_Click(object sender, EventArgs e)
        {
            dataGridViewResult_BVV.ColumnCount = 2;
            dataGridViewResult_BVV.Columns[0].Width = 20;
            dataGridViewResult_BVV.Columns[1].Width = 50;

            this.chartResult_BVV.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_BVV.ChartAreas[0].AxisY.Title = "Ось Y";

            chartResult_BVV.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_BVV.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartResult_BVV.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonMessage_BVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПКТб-23-2 Боттер Вадим Валерьевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
