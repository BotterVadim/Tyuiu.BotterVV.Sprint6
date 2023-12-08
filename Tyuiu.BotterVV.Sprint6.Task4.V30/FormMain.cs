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
using Tyuiu.BotterVV.Sprint6.Task4.V30.Lib;

namespace Tyuiu.BotterVV.Sprint6.Task4.V30
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
            buttonDone_BVV.BackColor = Color.Green;
        }

        private void buttonDone_BVV_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_BVV.BackColor = Color.PaleGreen;
        }

        private void buttonSave_BVV_MouseEnter(object sender, EventArgs e)
        {
            buttonSave_BVV.BackColor = Color.Turquoise;
        }

        private void buttonSave_BVV_MouseLeave(object sender, EventArgs e)
        {
            buttonSave_BVV.BackColor = Color.PaleTurquoise;
        }

        private void buttonMessage_BVV_MouseEnter(object sender, EventArgs e)
        {
            buttonMessage_BVV.BackColor = Color.MediumSlateBlue;
        }

        private void buttonMessage_BVV_MouseLeave(object sender, EventArgs e)
        {
            buttonMessage_BVV.BackColor = Color.BlueViolet;
        }

        private void buttonMessage_BVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ПКТб-23-2 Боттер Вадим Валерьевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_BVV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxTaskStartValue_BVV.Text);
                int stopStep = Convert.ToInt32(textBoxTaskStopValue_BVV.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartResult_BVV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_BVV.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_BVV.Text = "";

                chartResult_BVV.Series[0].Points.Clear();

                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartResult_BVV.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_BVV.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_BVV_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V30.txt";
                File.WriteAllText(path, textBoxResult_BVV.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранён успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
