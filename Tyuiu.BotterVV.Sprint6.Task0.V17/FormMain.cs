using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BotterVV.Sprint6.Task0.V17.Lib;


namespace Tyuiu.BotterVV.Sprint6.Task0.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonResultBVV_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                textBoxResultBVV.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarXBVV.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarXBVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonMessageBVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ПКТб-23-2 Боттер Вадим Валерьевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        }
    }
}
