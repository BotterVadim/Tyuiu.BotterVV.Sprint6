using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BotterVV.Sprint6.Task2.V29.Lib;


namespace Tyuiu.BotterVV.Sprint6.Task2.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDoneBVV_MouseEnter(object sender, EventArgs e)
        {
            buttonDoneBVV.BackColor = Color.Green;
        }

        private void buttonDoneBVV_MouseLeave(object sender, EventArgs e)
        {
            buttonDoneBVV.BackColor = Color.DarkSeaGreen;
        }

        private void buttonDoneBVV_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDoneBVV.BackColor = Color.Indigo;
        }

        private void buttonMessageBVV_MouseEnter(object sender, EventArgs e)
        {
            buttonMessageBVV.BackColor = Color.Blue;
        }

        private void buttonMessageBVV_MouseLeave(object sender, EventArgs e)
        {
            buttonMessageBVV.BackColor = Color.Cyan;
        }

        private void buttonMessageBVV_MouseDown(object sender, MouseEventArgs e)
        {
            buttonMessageBVV.BackColor = Color.Violet;
        }

        private void buttonMessageBVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ПКТб-23-2 Боттер Вадим Валерьевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDoneBVV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartValueBVV.Text);
                int stopStep = Convert.ToInt32(textBoxStopValueBVV.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartResultBVV.Titles.Add("График функции F(X)");

                this.chartResultBVV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResultBVV.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewResultBVV.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartResultBVV.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
