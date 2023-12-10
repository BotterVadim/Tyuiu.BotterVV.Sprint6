
namespace Tyuiu.BotterVV.Sprint6.Task6.V6
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
            this.buttonDone_BVV = new System.Windows.Forms.Button();
            this.buttonOpenFile_BVV = new System.Windows.Forms.Button();
            this.openFileDialogTask_BVV = new System.Windows.Forms.OpenFileDialog();
            this.toolTipOpenFile_BVV = new System.Windows.Forms.ToolTip(this.components);
            this.panelTask_BVV = new System.Windows.Forms.Panel();
            this.groupBoxTask_BVV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_BVV = new System.Windows.Forms.TextBox();
            this.panelResult_BVV = new System.Windows.Forms.Panel();
            this.toolTipDone_BVV = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMessage_BVV = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxInPut_BVV = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut_BVV = new System.Windows.Forms.GroupBox();
            this.textBoxIn_BVV = new System.Windows.Forms.TextBox();
            this.textBoxOut_BVV = new System.Windows.Forms.TextBox();
            this.panelButtons_BVV.SuspendLayout();
            this.panelTask_BVV.SuspendLayout();
            this.groupBoxTask_BVV.SuspendLayout();
            this.panelResult_BVV.SuspendLayout();
            this.groupBoxInPut_BVV.SuspendLayout();
            this.groupBoxOutPut_BVV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons_BVV
            // 
            this.panelButtons_BVV.Controls.Add(this.buttonMessage_BVV);
            this.panelButtons_BVV.Controls.Add(this.buttonDone_BVV);
            this.panelButtons_BVV.Controls.Add(this.buttonOpenFile_BVV);
            this.panelButtons_BVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_BVV.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_BVV.Name = "panelButtons_BVV";
            this.panelButtons_BVV.Size = new System.Drawing.Size(800, 82);
            this.panelButtons_BVV.TabIndex = 0;
            // 
            // buttonMessage_BVV
            // 
            this.buttonMessage_BVV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMessage_BVV.Image = ((System.Drawing.Image)(resources.GetObject("buttonMessage_BVV.Image")));
            this.buttonMessage_BVV.Location = new System.Drawing.Point(713, 3);
            this.buttonMessage_BVV.Name = "buttonMessage_BVV";
            this.buttonMessage_BVV.Size = new System.Drawing.Size(84, 76);
            this.buttonMessage_BVV.TabIndex = 2;
            this.toolTipMessage_BVV.SetToolTip(this.buttonMessage_BVV, "Сведения об авторе");
            this.buttonMessage_BVV.UseVisualStyleBackColor = true;
            this.buttonMessage_BVV.Click += new System.EventHandler(this.buttonMessage_BVV_Click);
            // 
            // buttonDone_BVV
            // 
            this.buttonDone_BVV.Enabled = false;
            this.buttonDone_BVV.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_BVV.Image")));
            this.buttonDone_BVV.Location = new System.Drawing.Point(93, 3);
            this.buttonDone_BVV.Name = "buttonDone_BVV";
            this.buttonDone_BVV.Size = new System.Drawing.Size(84, 76);
            this.buttonDone_BVV.TabIndex = 1;
            this.toolTipDone_BVV.SetToolTip(this.buttonDone_BVV, "Считать данные с файла\r\nВывести результат");
            this.buttonDone_BVV.UseVisualStyleBackColor = true;
            this.buttonDone_BVV.Click += new System.EventHandler(this.buttonDone_BVV_Click);
            // 
            // buttonOpenFile_BVV
            // 
            this.buttonOpenFile_BVV.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_BVV.Image")));
            this.buttonOpenFile_BVV.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenFile_BVV.Name = "buttonOpenFile_BVV";
            this.buttonOpenFile_BVV.Size = new System.Drawing.Size(84, 76);
            this.buttonOpenFile_BVV.TabIndex = 0;
            this.toolTipOpenFile_BVV.SetToolTip(this.buttonOpenFile_BVV, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_BVV.UseVisualStyleBackColor = true;
            this.buttonOpenFile_BVV.Click += new System.EventHandler(this.buttonOpenFile_BVV_Click);
            // 
            // openFileDialogTask_BVV
            // 
            this.openFileDialogTask_BVV.FileName = "openFileDialogTask_BVV";
            // 
            // toolTipOpenFile_BVV
            // 
            this.toolTipOpenFile_BVV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipOpenFile_BVV.ToolTipTitle = "Подсказка";
            // 
            // panelTask_BVV
            // 
            this.panelTask_BVV.Controls.Add(this.groupBoxTask_BVV);
            this.panelTask_BVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_BVV.Location = new System.Drawing.Point(0, 82);
            this.panelTask_BVV.Name = "panelTask_BVV";
            this.panelTask_BVV.Size = new System.Drawing.Size(800, 85);
            this.panelTask_BVV.TabIndex = 4;
            // 
            // groupBoxTask_BVV
            // 
            this.groupBoxTask_BVV.Controls.Add(this.textBoxTask_BVV);
            this.groupBoxTask_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_BVV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_BVV.Name = "groupBoxTask_BVV";
            this.groupBoxTask_BVV.Size = new System.Drawing.Size(800, 85);
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
            this.textBoxTask_BVV.Size = new System.Drawing.Size(794, 66);
            this.textBoxTask_BVV.TabIndex = 0;
            this.textBoxTask_BVV.Text = resources.GetString("textBoxTask_BVV.Text");
            // 
            // panelResult_BVV
            // 
            this.panelResult_BVV.Controls.Add(this.groupBoxOutPut_BVV);
            this.panelResult_BVV.Controls.Add(this.groupBoxInPut_BVV);
            this.panelResult_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResult_BVV.Location = new System.Drawing.Point(0, 167);
            this.panelResult_BVV.Name = "panelResult_BVV";
            this.panelResult_BVV.Size = new System.Drawing.Size(800, 594);
            this.panelResult_BVV.TabIndex = 5;
            // 
            // toolTipDone_BVV
            // 
            this.toolTipDone_BVV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipDone_BVV.ToolTipTitle = "Выполнить";
            // 
            // toolTipMessage_BVV
            // 
            this.toolTipMessage_BVV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipMessage_BVV.ToolTipTitle = "Справка";
            // 
            // groupBoxInPut_BVV
            // 
            this.groupBoxInPut_BVV.Controls.Add(this.textBoxIn_BVV);
            this.groupBoxInPut_BVV.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxInPut_BVV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_BVV.Name = "groupBoxInPut_BVV";
            this.groupBoxInPut_BVV.Size = new System.Drawing.Size(395, 594);
            this.groupBoxInPut_BVV.TabIndex = 0;
            this.groupBoxInPut_BVV.TabStop = false;
            this.groupBoxInPut_BVV.Text = "Ввод:";
            // 
            // groupBoxOutPut_BVV
            // 
            this.groupBoxOutPut_BVV.Controls.Add(this.textBoxOut_BVV);
            this.groupBoxOutPut_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_BVV.Location = new System.Drawing.Point(395, 0);
            this.groupBoxOutPut_BVV.Name = "groupBoxOutPut_BVV";
            this.groupBoxOutPut_BVV.Size = new System.Drawing.Size(405, 594);
            this.groupBoxOutPut_BVV.TabIndex = 1;
            this.groupBoxOutPut_BVV.TabStop = false;
            this.groupBoxOutPut_BVV.Text = "Вывод:";
            // 
            // textBoxIn_BVV
            // 
            this.textBoxIn_BVV.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxIn_BVV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIn_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIn_BVV.Location = new System.Drawing.Point(3, 16);
            this.textBoxIn_BVV.Multiline = true;
            this.textBoxIn_BVV.Name = "textBoxIn_BVV";
            this.textBoxIn_BVV.ReadOnly = true;
            this.textBoxIn_BVV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIn_BVV.Size = new System.Drawing.Size(389, 575);
            this.textBoxIn_BVV.TabIndex = 0;
            // 
            // textBoxOut_BVV
            // 
            this.textBoxOut_BVV.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxOut_BVV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOut_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOut_BVV.Location = new System.Drawing.Point(3, 16);
            this.textBoxOut_BVV.Multiline = true;
            this.textBoxOut_BVV.Name = "textBoxOut_BVV";
            this.textBoxOut_BVV.ReadOnly = true;
            this.textBoxOut_BVV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut_BVV.Size = new System.Drawing.Size(399, 575);
            this.textBoxOut_BVV.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 761);
            this.Controls.Add(this.panelResult_BVV);
            this.Controls.Add(this.panelTask_BVV);
            this.Controls.Add(this.panelButtons_BVV);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 6 | Боттер В.В.";
            this.panelButtons_BVV.ResumeLayout(false);
            this.panelTask_BVV.ResumeLayout(false);
            this.groupBoxTask_BVV.ResumeLayout(false);
            this.groupBoxTask_BVV.PerformLayout();
            this.panelResult_BVV.ResumeLayout(false);
            this.groupBoxInPut_BVV.ResumeLayout(false);
            this.groupBoxInPut_BVV.PerformLayout();
            this.groupBoxOutPut_BVV.ResumeLayout(false);
            this.groupBoxOutPut_BVV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_BVV;
        private System.Windows.Forms.Button buttonOpenFile_BVV;
        private System.Windows.Forms.Button buttonMessage_BVV;
        private System.Windows.Forms.Button buttonDone_BVV;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_BVV;
        private System.Windows.Forms.ToolTip toolTipOpenFile_BVV;
        private System.Windows.Forms.Panel panelTask_BVV;
        private System.Windows.Forms.GroupBox groupBoxTask_BVV;
        private System.Windows.Forms.TextBox textBoxTask_BVV;
        private System.Windows.Forms.Panel panelResult_BVV;
        private System.Windows.Forms.ToolTip toolTipMessage_BVV;
        private System.Windows.Forms.ToolTip toolTipDone_BVV;
        private System.Windows.Forms.GroupBox groupBoxOutPut_BVV;
        private System.Windows.Forms.TextBox textBoxOut_BVV;
        private System.Windows.Forms.GroupBox groupBoxInPut_BVV;
        private System.Windows.Forms.TextBox textBoxIn_BVV;
    }
}

