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
using Tyuiu.BotterVV.Sprint6.Task6.V6.Lib;

namespace Tyuiu.BotterVV.Sprint6.Task6.V6
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        string openFilePath;
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_BVV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_BVV.ShowDialog();
            openFilePath = openFileDialogTask_BVV.FileName;
            textBoxIn_BVV.Text = File.ReadAllText(openFilePath);
            groupBoxOutPut_BVV.Text = groupBoxOutPut_BVV.Text + " " + openFileDialogTask_BVV.FileName;
            buttonDone_BVV.Enabled = true;
        }

        private void buttonDone_BVV_Click(object sender, EventArgs e)
        {
            textBoxOut_BVV.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonMessage_BVV_Click(object sender, EventArgs e)
        {
            FormAbout_BVV formAbout_BVV = new FormAbout_BVV();
            formAbout_BVV.ShowDialog();
        }
    }
}
