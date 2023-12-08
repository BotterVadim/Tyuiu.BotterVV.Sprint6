
namespace Tyuiu.BotterVV.Sprint6.Task4.V30
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelTask_BVV = new System.Windows.Forms.Panel();
            this.groupBoxInputOutput_BVV = new System.Windows.Forms.GroupBox();
            this.buttonSave_BVV = new System.Windows.Forms.Button();
            this.buttonMessage_BVV = new System.Windows.Forms.Button();
            this.buttonDone_BVV = new System.Windows.Forms.Button();
            this.textBoxTaskStopValue_BVV = new System.Windows.Forms.TextBox();
            this.textBoxTaskStartValue_BVV = new System.Windows.Forms.TextBox();
            this.labelTaskStopValue_BVV = new System.Windows.Forms.Label();
            this.labelTaskStartValue_BVV = new System.Windows.Forms.Label();
            this.groupBoxTask_BVV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_BVV = new System.Windows.Forms.TextBox();
            this.panelResult_BVV = new System.Windows.Forms.Panel();
            this.groupBoxResult_BVV = new System.Windows.Forms.GroupBox();
            this.textBoxResult_BVV = new System.Windows.Forms.TextBox();
            this.splitterResult_BVV = new System.Windows.Forms.Splitter();
            this.panelResultGraph_BVV = new System.Windows.Forms.Panel();
            this.chartResult_BVV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTask_BVV.SuspendLayout();
            this.groupBoxInputOutput_BVV.SuspendLayout();
            this.groupBoxTask_BVV.SuspendLayout();
            this.panelResult_BVV.SuspendLayout();
            this.groupBoxResult_BVV.SuspendLayout();
            this.panelResultGraph_BVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_BVV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask_BVV
            // 
            this.panelTask_BVV.BackColor = System.Drawing.SystemColors.Control;
            this.panelTask_BVV.Controls.Add(this.groupBoxInputOutput_BVV);
            this.panelTask_BVV.Controls.Add(this.groupBoxTask_BVV);
            this.panelTask_BVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_BVV.Location = new System.Drawing.Point(0, 0);
            this.panelTask_BVV.Name = "panelTask_BVV";
            this.panelTask_BVV.Size = new System.Drawing.Size(800, 93);
            this.panelTask_BVV.TabIndex = 0;
            // 
            // groupBoxInputOutput_BVV
            // 
            this.groupBoxInputOutput_BVV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInputOutput_BVV.Controls.Add(this.buttonSave_BVV);
            this.groupBoxInputOutput_BVV.Controls.Add(this.buttonMessage_BVV);
            this.groupBoxInputOutput_BVV.Controls.Add(this.buttonDone_BVV);
            this.groupBoxInputOutput_BVV.Controls.Add(this.textBoxTaskStopValue_BVV);
            this.groupBoxInputOutput_BVV.Controls.Add(this.textBoxTaskStartValue_BVV);
            this.groupBoxInputOutput_BVV.Controls.Add(this.labelTaskStopValue_BVV);
            this.groupBoxInputOutput_BVV.Controls.Add(this.labelTaskStartValue_BVV);
            this.groupBoxInputOutput_BVV.Location = new System.Drawing.Point(376, 4);
            this.groupBoxInputOutput_BVV.Name = "groupBoxInputOutput_BVV";
            this.groupBoxInputOutput_BVV.Size = new System.Drawing.Size(421, 84);
            this.groupBoxInputOutput_BVV.TabIndex = 1;
            this.groupBoxInputOutput_BVV.TabStop = false;
            this.groupBoxInputOutput_BVV.Text = "Ввод данных";
            // 
            // buttonSave_BVV
            // 
            this.buttonSave_BVV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave_BVV.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonSave_BVV.Location = new System.Drawing.Point(276, 19);
            this.buttonSave_BVV.Name = "buttonSave_BVV";
            this.buttonSave_BVV.Size = new System.Drawing.Size(73, 55);
            this.buttonSave_BVV.TabIndex = 6;
            this.buttonSave_BVV.Text = "Сохранить";
            this.buttonSave_BVV.UseVisualStyleBackColor = false;
            this.buttonSave_BVV.Click += new System.EventHandler(this.buttonSave_BVV_Click);
            this.buttonSave_BVV.MouseEnter += new System.EventHandler(this.buttonSave_BVV_MouseEnter);
            this.buttonSave_BVV.MouseLeave += new System.EventHandler(this.buttonSave_BVV_MouseLeave);
            // 
            // buttonMessage_BVV
            // 
            this.buttonMessage_BVV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMessage_BVV.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonMessage_BVV.Location = new System.Drawing.Point(355, 19);
            this.buttonMessage_BVV.Name = "buttonMessage_BVV";
            this.buttonMessage_BVV.Size = new System.Drawing.Size(60, 55);
            this.buttonMessage_BVV.TabIndex = 5;
            this.buttonMessage_BVV.Text = "Справка";
            this.buttonMessage_BVV.UseVisualStyleBackColor = false;
            this.buttonMessage_BVV.Click += new System.EventHandler(this.buttonMessage_BVV_Click);
            this.buttonMessage_BVV.MouseEnter += new System.EventHandler(this.buttonMessage_BVV_MouseEnter);
            this.buttonMessage_BVV.MouseLeave += new System.EventHandler(this.buttonMessage_BVV_MouseLeave);
            // 
            // buttonDone_BVV
            // 
            this.buttonDone_BVV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone_BVV.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonDone_BVV.Location = new System.Drawing.Point(194, 19);
            this.buttonDone_BVV.Name = "buttonDone_BVV";
            this.buttonDone_BVV.Size = new System.Drawing.Size(76, 55);
            this.buttonDone_BVV.TabIndex = 4;
            this.buttonDone_BVV.Text = "Выполнить";
            this.buttonDone_BVV.UseVisualStyleBackColor = false;
            this.buttonDone_BVV.Click += new System.EventHandler(this.buttonDone_BVV_Click);
            this.buttonDone_BVV.MouseEnter += new System.EventHandler(this.buttonDone_BVV_MouseEnter);
            this.buttonDone_BVV.MouseLeave += new System.EventHandler(this.buttonDone_BVV_MouseLeave);
            // 
            // textBoxTaskStopValue_BVV
            // 
            this.textBoxTaskStopValue_BVV.Location = new System.Drawing.Point(98, 38);
            this.textBoxTaskStopValue_BVV.Name = "textBoxTaskStopValue_BVV";
            this.textBoxTaskStopValue_BVV.Size = new System.Drawing.Size(76, 20);
            this.textBoxTaskStopValue_BVV.TabIndex = 3;
            // 
            // textBoxTaskStartValue_BVV
            // 
            this.textBoxTaskStartValue_BVV.Location = new System.Drawing.Point(10, 37);
            this.textBoxTaskStartValue_BVV.Name = "textBoxTaskStartValue_BVV";
            this.textBoxTaskStartValue_BVV.Size = new System.Drawing.Size(73, 20);
            this.textBoxTaskStartValue_BVV.TabIndex = 2;
            // 
            // labelTaskStopValue_BVV
            // 
            this.labelTaskStopValue_BVV.AutoSize = true;
            this.labelTaskStopValue_BVV.Location = new System.Drawing.Point(95, 20);
            this.labelTaskStopValue_BVV.Name = "labelTaskStopValue_BVV";
            this.labelTaskStopValue_BVV.Size = new System.Drawing.Size(69, 13);
            this.labelTaskStopValue_BVV.TabIndex = 1;
            this.labelTaskStopValue_BVV.Text = "Конец шага:";
            // 
            // labelTaskStartValue_BVV
            // 
            this.labelTaskStartValue_BVV.AutoSize = true;
            this.labelTaskStartValue_BVV.Location = new System.Drawing.Point(7, 20);
            this.labelTaskStartValue_BVV.Name = "labelTaskStartValue_BVV";
            this.labelTaskStartValue_BVV.Size = new System.Drawing.Size(67, 13);
            this.labelTaskStartValue_BVV.TabIndex = 0;
            this.labelTaskStartValue_BVV.Text = "Старт шага:";
            // 
            // groupBoxTask_BVV
            // 
            this.groupBoxTask_BVV.Controls.Add(this.textBoxTask_BVV);
            this.groupBoxTask_BVV.Location = new System.Drawing.Point(6, 3);
            this.groupBoxTask_BVV.Name = "groupBoxTask_BVV";
            this.groupBoxTask_BVV.Size = new System.Drawing.Size(364, 84);
            this.groupBoxTask_BVV.TabIndex = 0;
            this.groupBoxTask_BVV.TabStop = false;
            this.groupBoxTask_BVV.Text = "Условие:";
            // 
            // textBoxTask_BVV
            // 
            this.textBoxTask_BVV.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_BVV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_BVV.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_BVV.Multiline = true;
            this.textBoxTask_BVV.Name = "textBoxTask_BVV";
            this.textBoxTask_BVV.ReadOnly = true;
            this.textBoxTask_BVV.Size = new System.Drawing.Size(351, 58);
            this.textBoxTask_BVV.TabIndex = 0;
            this.textBoxTask_BVV.Text = resources.GetString("textBoxTask_BVV.Text");
            // 
            // panelResult_BVV
            // 
            this.panelResult_BVV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelResult_BVV.Controls.Add(this.groupBoxResult_BVV);
            this.panelResult_BVV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelResult_BVV.Location = new System.Drawing.Point(0, 93);
            this.panelResult_BVV.Name = "panelResult_BVV";
            this.panelResult_BVV.Size = new System.Drawing.Size(177, 357);
            this.panelResult_BVV.TabIndex = 1;
            // 
            // groupBoxResult_BVV
            // 
            this.groupBoxResult_BVV.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxResult_BVV.Controls.Add(this.textBoxResult_BVV);
            this.groupBoxResult_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_BVV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_BVV.Name = "groupBoxResult_BVV";
            this.groupBoxResult_BVV.Size = new System.Drawing.Size(177, 357);
            this.groupBoxResult_BVV.TabIndex = 0;
            this.groupBoxResult_BVV.TabStop = false;
            this.groupBoxResult_BVV.Text = "Вывод:";
            // 
            // textBoxResult_BVV
            // 
            this.textBoxResult_BVV.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResult_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_BVV.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult_BVV.Multiline = true;
            this.textBoxResult_BVV.Name = "textBoxResult_BVV";
            this.textBoxResult_BVV.ReadOnly = true;
            this.textBoxResult_BVV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_BVV.Size = new System.Drawing.Size(171, 338);
            this.textBoxResult_BVV.TabIndex = 0;
            // 
            // splitterResult_BVV
            // 
            this.splitterResult_BVV.Location = new System.Drawing.Point(0, 0);
            this.splitterResult_BVV.Name = "splitterResult_BVV";
            this.splitterResult_BVV.Size = new System.Drawing.Size(3, 357);
            this.splitterResult_BVV.TabIndex = 0;
            this.splitterResult_BVV.TabStop = false;
            // 
            // panelResultGraph_BVV
            // 
            this.panelResultGraph_BVV.BackColor = System.Drawing.SystemColors.Control;
            this.panelResultGraph_BVV.Controls.Add(this.chartResult_BVV);
            this.panelResultGraph_BVV.Controls.Add(this.splitterResult_BVV);
            this.panelResultGraph_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResultGraph_BVV.Location = new System.Drawing.Point(177, 93);
            this.panelResultGraph_BVV.Name = "panelResultGraph_BVV";
            this.panelResultGraph_BVV.Size = new System.Drawing.Size(623, 357);
            this.panelResultGraph_BVV.TabIndex = 1;
            // 
            // chartResult_BVV
            // 
            chartArea6.Name = "ChartArea1";
            this.chartResult_BVV.ChartAreas.Add(chartArea6);
            this.chartResult_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.chartResult_BVV.Legends.Add(legend6);
            this.chartResult_BVV.Location = new System.Drawing.Point(3, 0);
            this.chartResult_BVV.Name = "chartResult_BVV";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartResult_BVV.Series.Add(series6);
            this.chartResult_BVV.Size = new System.Drawing.Size(620, 357);
            this.chartResult_BVV.TabIndex = 1;
            this.chartResult_BVV.Text = "chartFunction";
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title6.ForeColor = System.Drawing.Color.DarkOrchid;
            title6.Name = "TitleFunc";
            title6.Text = "График функции f(x)";
            this.chartResult_BVV.Titles.Add(title6);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelResultGraph_BVV);
            this.Controls.Add(this.panelResult_BVV);
            this.Controls.Add(this.panelTask_BVV);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 30 | Боттер В.В.";
            this.panelTask_BVV.ResumeLayout(false);
            this.groupBoxInputOutput_BVV.ResumeLayout(false);
            this.groupBoxInputOutput_BVV.PerformLayout();
            this.groupBoxTask_BVV.ResumeLayout(false);
            this.groupBoxTask_BVV.PerformLayout();
            this.panelResult_BVV.ResumeLayout(false);
            this.groupBoxResult_BVV.ResumeLayout(false);
            this.groupBoxResult_BVV.PerformLayout();
            this.panelResultGraph_BVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_BVV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTask_BVV;
        private System.Windows.Forms.Panel panelResult_BVV;
        private System.Windows.Forms.GroupBox groupBoxInputOutput_BVV;
        private System.Windows.Forms.Button buttonSave_BVV;
        private System.Windows.Forms.Button buttonMessage_BVV;
        private System.Windows.Forms.Button buttonDone_BVV;
        private System.Windows.Forms.TextBox textBoxTaskStopValue_BVV;
        private System.Windows.Forms.TextBox textBoxTaskStartValue_BVV;
        private System.Windows.Forms.Label labelTaskStopValue_BVV;
        private System.Windows.Forms.Label labelTaskStartValue_BVV;
        private System.Windows.Forms.GroupBox groupBoxTask_BVV;
        private System.Windows.Forms.TextBox textBoxTask_BVV;
        private System.Windows.Forms.GroupBox groupBoxResult_BVV;
        private System.Windows.Forms.TextBox textBoxResult_BVV;
        private System.Windows.Forms.Splitter splitterResult_BVV;
        private System.Windows.Forms.Panel panelResultGraph_BVV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_BVV;
    }
}

