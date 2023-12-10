
namespace Tyuiu.BotterVV.Sprint6.Task7.V14
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons_BVV = new System.Windows.Forms.Panel();
            this.buttonMessage_BVV = new System.Windows.Forms.Button();
            this.buttonSaveFile_BVV = new System.Windows.Forms.Button();
            this.buttonDone_BVV = new System.Windows.Forms.Button();
            this.buttonOpenFile_BVV = new System.Windows.Forms.Button();
            this.panelTask_BVV = new System.Windows.Forms.Panel();
            this.groupBoxTask_BVV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_BVV = new System.Windows.Forms.TextBox();
            this.panelInPut_BVV = new System.Windows.Forms.Panel();
            this.groupBoxInPut_BVV = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_BVV = new System.Windows.Forms.DataGridView();
            this.panelOutPut_BVV = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_BVV = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut_BVV = new System.Windows.Forms.DataGridView();
            this.splitterResult_BVV = new System.Windows.Forms.Splitter();
            this.toolTip_BVV = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogTask_BVV = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_BVV = new System.Windows.Forms.SaveFileDialog();
            this.panelButtons_BVV.SuspendLayout();
            this.panelTask_BVV.SuspendLayout();
            this.groupBoxTask_BVV.SuspendLayout();
            this.panelInPut_BVV.SuspendLayout();
            this.groupBoxInPut_BVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_BVV)).BeginInit();
            this.panelOutPut_BVV.SuspendLayout();
            this.groupBoxOutPut_BVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_BVV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons_BVV
            // 
            this.panelButtons_BVV.Controls.Add(this.buttonMessage_BVV);
            this.panelButtons_BVV.Controls.Add(this.buttonSaveFile_BVV);
            this.panelButtons_BVV.Controls.Add(this.buttonDone_BVV);
            this.panelButtons_BVV.Controls.Add(this.buttonOpenFile_BVV);
            this.panelButtons_BVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_BVV.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_BVV.Name = "panelButtons_BVV";
            this.panelButtons_BVV.Size = new System.Drawing.Size(800, 73);
            this.panelButtons_BVV.TabIndex = 0;
            // 
            // buttonMessage_BVV
            // 
            this.buttonMessage_BVV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMessage_BVV.Image = ((System.Drawing.Image)(resources.GetObject("buttonMessage_BVV.Image")));
            this.buttonMessage_BVV.Location = new System.Drawing.Point(713, 12);
            this.buttonMessage_BVV.Name = "buttonMessage_BVV";
            this.buttonMessage_BVV.Size = new System.Drawing.Size(75, 55);
            this.buttonMessage_BVV.TabIndex = 3;
            this.toolTip_BVV.SetToolTip(this.buttonMessage_BVV, "Сведения о разработчике.");
            this.buttonMessage_BVV.UseVisualStyleBackColor = true;
            this.buttonMessage_BVV.Click += new System.EventHandler(this.buttonMessage_BVV_Click);
            this.buttonMessage_BVV.MouseEnter += new System.EventHandler(this.buttonMessage_BVV_MouseEnter);
            // 
            // buttonSaveFile_BVV
            // 
            this.buttonSaveFile_BVV.Enabled = false;
            this.buttonSaveFile_BVV.Image = global::Tyuiu.BotterVV.Sprint6.Task7.V14.Properties.Resources.disk;
            this.buttonSaveFile_BVV.Location = new System.Drawing.Point(174, 12);
            this.buttonSaveFile_BVV.Name = "buttonSaveFile_BVV";
            this.buttonSaveFile_BVV.Size = new System.Drawing.Size(75, 55);
            this.buttonSaveFile_BVV.TabIndex = 2;
            this.toolTip_BVV.SetToolTip(this.buttonSaveFile_BVV, "Сохранение обработанного файла.");
            this.buttonSaveFile_BVV.UseVisualStyleBackColor = true;
            this.buttonSaveFile_BVV.Click += new System.EventHandler(this.buttonSaveFile_BVV_Click);
            this.buttonSaveFile_BVV.MouseEnter += new System.EventHandler(this.buttonSaveFile_BVV_MouseEnter);
            // 
            // buttonDone_BVV
            // 
            this.buttonDone_BVV.Enabled = false;
            this.buttonDone_BVV.Image = global::Tyuiu.BotterVV.Sprint6.Task7.V14.Properties.Resources.page_go;
            this.buttonDone_BVV.Location = new System.Drawing.Point(93, 12);
            this.buttonDone_BVV.Name = "buttonDone_BVV";
            this.buttonDone_BVV.Size = new System.Drawing.Size(75, 55);
            this.buttonDone_BVV.TabIndex = 1;
            this.toolTip_BVV.SetToolTip(this.buttonDone_BVV, "Обработать данные из файла согласно условию задачи.");
            this.buttonDone_BVV.UseVisualStyleBackColor = true;
            this.buttonDone_BVV.Click += new System.EventHandler(this.buttonDone_BVV_Click);
            this.buttonDone_BVV.MouseEnter += new System.EventHandler(this.buttonDone_BVV_MouseEnter);
            // 
            // buttonOpenFile_BVV
            // 
            this.buttonOpenFile_BVV.Image = global::Tyuiu.BotterVV.Sprint6.Task7.V14.Properties.Resources.folder_page_white;
            this.buttonOpenFile_BVV.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_BVV.Name = "buttonOpenFile_BVV";
            this.buttonOpenFile_BVV.Size = new System.Drawing.Size(75, 55);
            this.buttonOpenFile_BVV.TabIndex = 0;
            this.toolTip_BVV.SetToolTip(this.buttonOpenFile_BVV, "Выберите файл для обработки.");
            this.buttonOpenFile_BVV.UseVisualStyleBackColor = true;
            this.buttonOpenFile_BVV.Click += new System.EventHandler(this.buttonOpenFile_BVV_Click);
            this.buttonOpenFile_BVV.MouseEnter += new System.EventHandler(this.buttonOpenFile_BVV_MouseEnter);
            // 
            // panelTask_BVV
            // 
            this.panelTask_BVV.Controls.Add(this.groupBoxTask_BVV);
            this.panelTask_BVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_BVV.Location = new System.Drawing.Point(0, 73);
            this.panelTask_BVV.Name = "panelTask_BVV";
            this.panelTask_BVV.Size = new System.Drawing.Size(800, 87);
            this.panelTask_BVV.TabIndex = 1;
            // 
            // groupBoxTask_BVV
            // 
            this.groupBoxTask_BVV.Controls.Add(this.textBoxTask_BVV);
            this.groupBoxTask_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_BVV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_BVV.Name = "groupBoxTask_BVV";
            this.groupBoxTask_BVV.Size = new System.Drawing.Size(800, 87);
            this.groupBoxTask_BVV.TabIndex = 0;
            this.groupBoxTask_BVV.TabStop = false;
            this.groupBoxTask_BVV.Text = "Условие:";
            // 
            // textBoxTask_BVV
            // 
            this.textBoxTask_BVV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_BVV.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_BVV.Multiline = true;
            this.textBoxTask_BVV.Name = "textBoxTask_BVV";
            this.textBoxTask_BVV.ReadOnly = true;
            this.textBoxTask_BVV.Size = new System.Drawing.Size(794, 68);
            this.textBoxTask_BVV.TabIndex = 0;
            this.textBoxTask_BVV.Text = resources.GetString("textBoxTask_BVV.Text");
            // 
            // panelInPut_BVV
            // 
            this.panelInPut_BVV.Controls.Add(this.groupBoxInPut_BVV);
            this.panelInPut_BVV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInPut_BVV.Location = new System.Drawing.Point(0, 160);
            this.panelInPut_BVV.Name = "panelInPut_BVV";
            this.panelInPut_BVV.Size = new System.Drawing.Size(386, 290);
            this.panelInPut_BVV.TabIndex = 2;
            // 
            // groupBoxInPut_BVV
            // 
            this.groupBoxInPut_BVV.Controls.Add(this.dataGridViewIn_BVV);
            this.groupBoxInPut_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_BVV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_BVV.Name = "groupBoxInPut_BVV";
            this.groupBoxInPut_BVV.Size = new System.Drawing.Size(386, 290);
            this.groupBoxInPut_BVV.TabIndex = 0;
            this.groupBoxInPut_BVV.TabStop = false;
            this.groupBoxInPut_BVV.Text = "Ввод:";
            // 
            // dataGridViewIn_BVV
            // 
            this.dataGridViewIn_BVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_BVV.ColumnHeadersVisible = false;
            this.dataGridViewIn_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn_BVV.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewIn_BVV.Name = "dataGridViewIn_BVV";
            this.dataGridViewIn_BVV.ReadOnly = true;
            this.dataGridViewIn_BVV.RowHeadersVisible = false;
            this.dataGridViewIn_BVV.Size = new System.Drawing.Size(380, 271);
            this.dataGridViewIn_BVV.TabIndex = 0;
            // 
            // panelOutPut_BVV
            // 
            this.panelOutPut_BVV.Controls.Add(this.groupBoxOutPut_BVV);
            this.panelOutPut_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutPut_BVV.Location = new System.Drawing.Point(386, 160);
            this.panelOutPut_BVV.Name = "panelOutPut_BVV";
            this.panelOutPut_BVV.Size = new System.Drawing.Size(414, 290);
            this.panelOutPut_BVV.TabIndex = 3;
            // 
            // groupBoxOutPut_BVV
            // 
            this.groupBoxOutPut_BVV.Controls.Add(this.dataGridViewOut_BVV);
            this.groupBoxOutPut_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_BVV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_BVV.Name = "groupBoxOutPut_BVV";
            this.groupBoxOutPut_BVV.Size = new System.Drawing.Size(414, 290);
            this.groupBoxOutPut_BVV.TabIndex = 0;
            this.groupBoxOutPut_BVV.TabStop = false;
            this.groupBoxOutPut_BVV.Text = "Вывод:";
            // 
            // dataGridViewOut_BVV
            // 
            this.dataGridViewOut_BVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_BVV.ColumnHeadersVisible = false;
            this.dataGridViewOut_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut_BVV.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOut_BVV.Name = "dataGridViewOut_BVV";
            this.dataGridViewOut_BVV.ReadOnly = true;
            this.dataGridViewOut_BVV.RowHeadersVisible = false;
            this.dataGridViewOut_BVV.Size = new System.Drawing.Size(408, 271);
            this.dataGridViewOut_BVV.TabIndex = 0;
            // 
            // splitterResult_BVV
            // 
            this.splitterResult_BVV.Location = new System.Drawing.Point(386, 160);
            this.splitterResult_BVV.Name = "splitterResult_BVV";
            this.splitterResult_BVV.Size = new System.Drawing.Size(3, 290);
            this.splitterResult_BVV.TabIndex = 4;
            this.splitterResult_BVV.TabStop = false;
            // 
            // toolTip_BVV
            // 
            this.toolTip_BVV.IsBalloon = true;
            this.toolTip_BVV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // openFileDialogTask_BVV
            // 
            this.openFileDialogTask_BVV.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitterResult_BVV);
            this.Controls.Add(this.panelOutPut_BVV);
            this.Controls.Add(this.panelInPut_BVV);
            this.Controls.Add(this.panelTask_BVV);
            this.Controls.Add(this.panelButtons_BVV);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 14 | Боттер В.В.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelButtons_BVV.ResumeLayout(false);
            this.panelTask_BVV.ResumeLayout(false);
            this.groupBoxTask_BVV.ResumeLayout(false);
            this.groupBoxTask_BVV.PerformLayout();
            this.panelInPut_BVV.ResumeLayout(false);
            this.groupBoxInPut_BVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_BVV)).EndInit();
            this.panelOutPut_BVV.ResumeLayout(false);
            this.groupBoxOutPut_BVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_BVV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_BVV;
        private System.Windows.Forms.Panel panelTask_BVV;
        private System.Windows.Forms.Panel panelInPut_BVV;
        private System.Windows.Forms.Panel panelOutPut_BVV;
        private System.Windows.Forms.Button buttonMessage_BVV;
        private System.Windows.Forms.Button buttonSaveFile_BVV;
        private System.Windows.Forms.Button buttonDone_BVV;
        private System.Windows.Forms.Button buttonOpenFile_BVV;
        private System.Windows.Forms.GroupBox groupBoxTask_BVV;
        private System.Windows.Forms.TextBox textBoxTask_BVV;
        private System.Windows.Forms.GroupBox groupBoxInPut_BVV;
        private System.Windows.Forms.DataGridView dataGridViewIn_BVV;
        private System.Windows.Forms.GroupBox groupBoxOutPut_BVV;
        private System.Windows.Forms.DataGridView dataGridViewOut_BVV;
        private System.Windows.Forms.Splitter splitterResult_BVV;
        private System.Windows.Forms.ToolTip toolTip_BVV;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_BVV;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_BVV;
    }
}

