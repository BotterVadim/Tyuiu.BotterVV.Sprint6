using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BotterVV.Sprint6.Task1.V14.Lib;

namespace Tyuiu.BotterVV.Sprint6.Task1.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonResultBVV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartValueBVV.Text);
                int stopStep = Convert.ToInt32(textBoxStopValueBVV.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxResultBVV.Text = "";
                textBoxResultBVV.AppendText("+---------+---------+" + Environment.NewLine);
                textBoxResultBVV.AppendText("|   X     |   f(x)  |" + Environment.NewLine);
                textBoxResultBVV.AppendText("+---------+---------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|{0,6:d}   | {1, 7:f2} |", startStep, valueArray[i]);
                    textBoxResultBVV.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResultBVV.AppendText("+---------+---------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMessageBVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ПКТб-23-2 Боттер Вадим Валерьевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
