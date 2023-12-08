
namespace Tyuiu.BotterVV.Sprint6.Task5.V4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTask_BVV = new System.Windows.Forms.Panel();
            this.buttonMessage_BVV = new System.Windows.Forms.Button();
            this.buttonSave_BVV = new System.Windows.Forms.Button();
            this.buttonDone_BVV = new System.Windows.Forms.Button();
            this.groupBoxTask_BVV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_BVV = new System.Windows.Forms.TextBox();
            this.panelResult_BVV = new System.Windows.Forms.Panel();
            this.groupBoxResult_BVV = new System.Windows.Forms.GroupBox();
            this.panelChart_BVV = new System.Windows.Forms.Panel();
            this.chartResult_BVV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitterResult_BVV = new System.Windows.Forms.Splitter();
            this.dataGridViewResult_BVV = new System.Windows.Forms.DataGridView();
            this.ColumnResult_BVV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTask_BVV.SuspendLayout();
            this.groupBoxTask_BVV.SuspendLayout();
            this.panelResult_BVV.SuspendLayout();
            this.groupBoxResult_BVV.SuspendLayout();
            this.panelChart_BVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_BVV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_BVV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask_BVV
            // 
            this.panelTask_BVV.BackColor = System.Drawing.SystemColors.Control;
            this.panelTask_BVV.Controls.Add(this.buttonMessage_BVV);
            this.panelTask_BVV.Controls.Add(this.buttonSave_BVV);
            this.panelTask_BVV.Controls.Add(this.buttonDone_BVV);
            this.panelTask_BVV.Controls.Add(this.groupBoxTask_BVV);
            this.panelTask_BVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_BVV.Location = new System.Drawing.Point(0, 0);
            this.panelTask_BVV.Name = "panelTask_BVV";
            this.panelTask_BVV.Size = new System.Drawing.Size(800, 93);
            this.panelTask_BVV.TabIndex = 0;
            // 
            // buttonMessage_BVV
            // 
            this.buttonMessage_BVV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMessage_BVV.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonMessage_BVV.Location = new System.Drawing.Point(679, 21);
            this.buttonMessage_BVV.Name = "buttonMessage_BVV";
            this.buttonMessage_BVV.Size = new System.Drawing.Size(86, 46);
            this.buttonMessage_BVV.TabIndex = 3;
            this.buttonMessage_BVV.Text = "Справка";
            this.buttonMessage_BVV.UseVisualStyleBackColor = false;
            this.buttonMessage_BVV.Click += new System.EventHandler(this.buttonMessage_BVV_Click);
            this.buttonMessage_BVV.MouseEnter += new System.EventHandler(this.buttonMessage_BVV_MouseEnter);
            this.buttonMessage_BVV.MouseLeave += new System.EventHandler(this.buttonMessage_BVV_MouseLeave);
            // 
            // buttonSave_BVV
            // 
            this.buttonSave_BVV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave_BVV.BackColor = System.Drawing.Color.Plum;
            this.buttonSave_BVV.Location = new System.Drawing.Point(581, 21);
            this.buttonSave_BVV.Name = "buttonSave_BVV";
            this.buttonSave_BVV.Size = new System.Drawing.Size(82, 46);
            this.buttonSave_BVV.TabIndex = 2;
            this.buttonSave_BVV.Text = "Открыть файл";
            this.buttonSave_BVV.UseVisualStyleBackColor = false;
            this.buttonSave_BVV.Click += new System.EventHandler(this.buttonSave_BVV_Click);
            this.buttonSave_BVV.MouseEnter += new System.EventHandler(this.buttonSave_BVV_MouseEnter);
            this.buttonSave_BVV.MouseLeave += new System.EventHandler(this.buttonSave_BVV_MouseLeave);
            // 
            // buttonDone_BVV
            // 
            this.buttonDone_BVV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone_BVV.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonDone_BVV.Location = new System.Drawing.Point(480, 21);
            this.buttonDone_BVV.Name = "buttonDone_BVV";
            this.buttonDone_BVV.Size = new System.Drawing.Size(75, 46);
            this.buttonDone_BVV.TabIndex = 1;
            this.buttonDone_BVV.Text = "Выполнить";
            this.buttonDone_BVV.UseVisualStyleBackColor = false;
            this.buttonDone_BVV.Click += new System.EventHandler(this.buttonDone_BVV_Click);
            this.buttonDone_BVV.MouseEnter += new System.EventHandler(this.buttonDone_BVV_MouseEnter);
            this.buttonDone_BVV.MouseLeave += new System.EventHandler(this.buttonDone_BVV_MouseLeave);
            // 
            // groupBoxTask_BVV
            // 
            this.groupBoxTask_BVV.Controls.Add(this.textBoxTask_BVV);
            this.groupBoxTask_BVV.Location = new System.Drawing.Point(4, 4);
            this.groupBoxTask_BVV.Name = "groupBoxTask_BVV";
            this.groupBoxTask_BVV.Size = new System.Drawing.Size(448, 83);
            this.groupBoxTask_BVV.TabIndex = 0;
            this.groupBoxTask_BVV.TabStop = false;
            this.groupBoxTask_BVV.Text = "Условие:";
            // 
            // textBoxTask_BVV
            // 
            this.textBoxTask_BVV.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_BVV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_BVV.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_BVV.Multiline = true;
            this.textBoxTask_BVV.Name = "textBoxTask_BVV";
            this.textBoxTask_BVV.ReadOnly = true;
            this.textBoxTask_BVV.Size = new System.Drawing.Size(442, 64);
            this.textBoxTask_BVV.TabIndex = 0;
            this.textBoxTask_BVV.Text = "Прочитать данные из файла InPutFileTask5V4.txt. Вывести в dataGridView. \r\nВывести" +
    " все целые числа. Построить диаграмму по этим значениям.";
            // 
            // panelResult_BVV
            // 
            this.panelResult_BVV.Controls.Add(this.groupBoxResult_BVV);
            this.panelResult_BVV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelResult_BVV.Location = new System.Drawing.Point(0, 93);
            this.panelResult_BVV.Name = "panelResult_BVV";
            this.panelResult_BVV.Size = new System.Drawing.Size(200, 357);
            this.panelResult_BVV.TabIndex = 1;
            // 
            // groupBoxResult_BVV
            // 
            this.groupBoxResult_BVV.Controls.Add(this.dataGridViewResult_BVV);
            this.groupBoxResult_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_BVV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_BVV.Name = "groupBoxResult_BVV";
            this.groupBoxResult_BVV.Size = new System.Drawing.Size(200, 357);
            this.groupBoxResult_BVV.TabIndex = 0;
            this.groupBoxResult_BVV.TabStop = false;
            this.groupBoxResult_BVV.Text = "Вывод данных:";
            // 
            // panelChart_BVV
            // 
            this.panelChart_BVV.Controls.Add(this.chartResult_BVV);
            this.panelChart_BVV.Controls.Add(this.splitterResult_BVV);
            this.panelChart_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart_BVV.Location = new System.Drawing.Point(200, 93);
            this.panelChart_BVV.Name = "panelChart_BVV";
            this.panelChart_BVV.Size = new System.Drawing.Size(600, 357);
            this.panelChart_BVV.TabIndex = 2;
            // 
            // chartResult_BVV
            // 
            chartArea3.Name = "ChartArea1";
            this.chartResult_BVV.ChartAreas.Add(chartArea3);
            this.chartResult_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartResult_BVV.Legends.Add(legend3);
            this.chartResult_BVV.Location = new System.Drawing.Point(3, 0);
            this.chartResult_BVV.Name = "chartResult_BVV";
            this.chartResult_BVV.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.ChartArea = "ChartArea1";
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartResult_BVV.Series.Add(series3);
            this.chartResult_BVV.Size = new System.Drawing.Size(597, 357);
            this.chartResult_BVV.TabIndex = 1;
            this.chartResult_BVV.Text = "chart1";
            // 
            // splitterResult_BVV
            // 
            this.splitterResult_BVV.Location = new System.Drawing.Point(0, 0);
            this.splitterResult_BVV.Name = "splitterResult_BVV";
            this.splitterResult_BVV.Size = new System.Drawing.Size(3, 357);
            this.splitterResult_BVV.TabIndex = 0;
            this.splitterResult_BVV.TabStop = false;
            // 
            // dataGridViewResult_BVV
            // 
            this.dataGridViewResult_BVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_BVV.ColumnHeadersVisible = false;
            this.dataGridViewResult_BVV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnResult_BVV});
            this.dataGridViewResult_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_BVV.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResult_BVV.Name = "dataGridViewResult_BVV";
            this.dataGridViewResult_BVV.RowHeadersVisible = false;
            this.dataGridViewResult_BVV.Size = new System.Drawing.Size(194, 338);
            this.dataGridViewResult_BVV.TabIndex = 0;
            // 
            // ColumnResult_BVV
            // 
            this.ColumnResult_BVV.HeaderText = "";
            this.ColumnResult_BVV.Name = "ColumnResult_BVV";
            this.ColumnResult_BVV.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelChart_BVV);
            this.Controls.Add(this.panelResult_BVV);
            this.Controls.Add(this.panelTask_BVV);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 4 | Боттер В.В.";
            this.panelTask_BVV.ResumeLayout(false);
            this.groupBoxTask_BVV.ResumeLayout(false);
            this.groupBoxTask_BVV.PerformLayout();
            this.panelResult_BVV.ResumeLayout(false);
            this.groupBoxResult_BVV.ResumeLayout(false);
            this.panelChart_BVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_BVV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_BVV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTask_BVV;
        private System.Windows.Forms.Button buttonMessage_BVV;
        private System.Windows.Forms.Button buttonSave_BVV;
        private System.Windows.Forms.Button buttonDone_BVV;
        private System.Windows.Forms.GroupBox groupBoxTask_BVV;
        private System.Windows.Forms.TextBox textBoxTask_BVV;
        private System.Windows.Forms.Panel panelResult_BVV;
        private System.Windows.Forms.GroupBox groupBoxResult_BVV;
        private System.Windows.Forms.Panel panelChart_BVV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_BVV;
        private System.Windows.Forms.Splitter splitterResult_BVV;
        private System.Windows.Forms.DataGridView dataGridViewResult_BVV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResult_BVV;
    }
}

