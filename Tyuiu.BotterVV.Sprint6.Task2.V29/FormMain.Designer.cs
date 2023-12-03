
namespace Tyuiu.BotterVV.Sprint6.Task2.V29
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTaskBVV = new System.Windows.Forms.GroupBox();
            this.groupBoxIntBVV = new System.Windows.Forms.GroupBox();
            this.textBoxStopValueBVV = new System.Windows.Forms.TextBox();
            this.textBoxStartValueBVV = new System.Windows.Forms.TextBox();
            this.labelStopValueBVV = new System.Windows.Forms.Label();
            this.labelStartValueBVV = new System.Windows.Forms.Label();
            this.groupBoxResultBVV = new System.Windows.Forms.GroupBox();
            this.chartResultBVV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewResultBVV = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDoneBVV = new System.Windows.Forms.Button();
            this.buttonMessageBVV = new System.Windows.Forms.Button();
            this.textBoxTaskBVV = new System.Windows.Forms.TextBox();
            this.groupBoxTaskBVV.SuspendLayout();
            this.groupBoxIntBVV.SuspendLayout();
            this.groupBoxResultBVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResultBVV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultBVV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTaskBVV
            // 
            this.groupBoxTaskBVV.Controls.Add(this.textBoxTaskBVV);
            this.groupBoxTaskBVV.Location = new System.Drawing.Point(13, 25);
            this.groupBoxTaskBVV.Name = "groupBoxTaskBVV";
            this.groupBoxTaskBVV.Size = new System.Drawing.Size(393, 228);
            this.groupBoxTaskBVV.TabIndex = 0;
            this.groupBoxTaskBVV.TabStop = false;
            this.groupBoxTaskBVV.Text = "Условие";
            // 
            // groupBoxIntBVV
            // 
            this.groupBoxIntBVV.Controls.Add(this.textBoxStopValueBVV);
            this.groupBoxIntBVV.Controls.Add(this.textBoxStartValueBVV);
            this.groupBoxIntBVV.Controls.Add(this.labelStopValueBVV);
            this.groupBoxIntBVV.Controls.Add(this.labelStartValueBVV);
            this.groupBoxIntBVV.Location = new System.Drawing.Point(13, 361);
            this.groupBoxIntBVV.Name = "groupBoxIntBVV";
            this.groupBoxIntBVV.Size = new System.Drawing.Size(240, 77);
            this.groupBoxIntBVV.TabIndex = 1;
            this.groupBoxIntBVV.TabStop = false;
            this.groupBoxIntBVV.Text = "Ввод данных";
            // 
            // textBoxStopValueBVV
            // 
            this.textBoxStopValueBVV.Location = new System.Drawing.Point(118, 51);
            this.textBoxStopValueBVV.Name = "textBoxStopValueBVV";
            this.textBoxStopValueBVV.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopValueBVV.TabIndex = 3;
            // 
            // textBoxStartValueBVV
            // 
            this.textBoxStartValueBVV.Location = new System.Drawing.Point(7, 50);
            this.textBoxStartValueBVV.Name = "textBoxStartValueBVV";
            this.textBoxStartValueBVV.Size = new System.Drawing.Size(90, 20);
            this.textBoxStartValueBVV.TabIndex = 2;
            // 
            // labelStopValueBVV
            // 
            this.labelStopValueBVV.AutoSize = true;
            this.labelStopValueBVV.Location = new System.Drawing.Point(115, 20);
            this.labelStopValueBVV.Name = "labelStopValueBVV";
            this.labelStopValueBVV.Size = new System.Drawing.Size(69, 13);
            this.labelStopValueBVV.TabIndex = 1;
            this.labelStopValueBVV.Text = "Конец шага:";
            // 
            // labelStartValueBVV
            // 
            this.labelStartValueBVV.AutoSize = true;
            this.labelStartValueBVV.Location = new System.Drawing.Point(7, 20);
            this.labelStartValueBVV.Name = "labelStartValueBVV";
            this.labelStartValueBVV.Size = new System.Drawing.Size(67, 13);
            this.labelStartValueBVV.TabIndex = 0;
            this.labelStartValueBVV.Text = "Старт шага:";
            // 
            // groupBoxResultBVV
            // 
            this.groupBoxResultBVV.Controls.Add(this.chartResultBVV);
            this.groupBoxResultBVV.Controls.Add(this.dataGridViewResultBVV);
            this.groupBoxResultBVV.Location = new System.Drawing.Point(421, 25);
            this.groupBoxResultBVV.Name = "groupBoxResultBVV";
            this.groupBoxResultBVV.Size = new System.Drawing.Size(367, 413);
            this.groupBoxResultBVV.TabIndex = 2;
            this.groupBoxResultBVV.TabStop = false;
            this.groupBoxResultBVV.Text = "Вывод данных";
            // 
            // chartResultBVV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResultBVV.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartResultBVV.Legends.Add(legend1);
            this.chartResultBVV.Location = new System.Drawing.Point(134, 19);
            this.chartResultBVV.Name = "chartResultBVV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResultBVV.Series.Add(series1);
            this.chartResultBVV.Size = new System.Drawing.Size(233, 388);
            this.chartResultBVV.TabIndex = 1;
            this.chartResultBVV.Text = "chart1";
            // 
            // dataGridViewResultBVV
            // 
            this.dataGridViewResultBVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultBVV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewResultBVV.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewResultBVV.Name = "dataGridViewResultBVV";
            this.dataGridViewResultBVV.ReadOnly = true;
            this.dataGridViewResultBVV.RowHeadersVisible = false;
            this.dataGridViewResultBVV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewResultBVV.Size = new System.Drawing.Size(122, 388);
            this.dataGridViewResultBVV.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.Width = 50;
            // 
            // buttonDoneBVV
            // 
            this.buttonDoneBVV.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonDoneBVV.Location = new System.Drawing.Point(344, 375);
            this.buttonDoneBVV.Name = "buttonDoneBVV";
            this.buttonDoneBVV.Size = new System.Drawing.Size(71, 57);
            this.buttonDoneBVV.TabIndex = 3;
            this.buttonDoneBVV.Text = "Выполнить";
            this.buttonDoneBVV.UseVisualStyleBackColor = false;
            this.buttonDoneBVV.Click += new System.EventHandler(this.buttonDoneBVV_Click);
            this.buttonDoneBVV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDoneBVV_MouseDown);
            this.buttonDoneBVV.MouseEnter += new System.EventHandler(this.buttonDoneBVV_MouseEnter);
            this.buttonDoneBVV.MouseLeave += new System.EventHandler(this.buttonDoneBVV_MouseLeave);
            // 
            // buttonMessageBVV
            // 
            this.buttonMessageBVV.BackColor = System.Drawing.Color.Cyan;
            this.buttonMessageBVV.Location = new System.Drawing.Point(263, 375);
            this.buttonMessageBVV.Name = "buttonMessageBVV";
            this.buttonMessageBVV.Size = new System.Drawing.Size(75, 56);
            this.buttonMessageBVV.TabIndex = 4;
            this.buttonMessageBVV.Text = "Справка";
            this.buttonMessageBVV.UseVisualStyleBackColor = false;
            this.buttonMessageBVV.Click += new System.EventHandler(this.buttonMessageBVV_Click);
            this.buttonMessageBVV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMessageBVV_MouseDown);
            this.buttonMessageBVV.MouseEnter += new System.EventHandler(this.buttonMessageBVV_MouseEnter);
            this.buttonMessageBVV.MouseLeave += new System.EventHandler(this.buttonMessageBVV_MouseLeave);
            // 
            // textBoxTaskBVV
            // 
            this.textBoxTaskBVV.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTaskBVV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTaskBVV.Location = new System.Drawing.Point(10, 19);
            this.textBoxTaskBVV.Multiline = true;
            this.textBoxTaskBVV.Name = "textBoxTaskBVV";
            this.textBoxTaskBVV.ReadOnly = true;
            this.textBoxTaskBVV.Size = new System.Drawing.Size(358, 177);
            this.textBoxTaskBVV.TabIndex = 0;
            this.textBoxTaskBVV.Text = resources.GetString("textBoxTaskBVV.Text");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMessageBVV);
            this.Controls.Add(this.buttonDoneBVV);
            this.Controls.Add(this.groupBoxResultBVV);
            this.Controls.Add(this.groupBoxIntBVV);
            this.Controls.Add(this.groupBoxTaskBVV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 29 | Боттер В.В.";
            this.groupBoxTaskBVV.ResumeLayout(false);
            this.groupBoxTaskBVV.PerformLayout();
            this.groupBoxIntBVV.ResumeLayout(false);
            this.groupBoxIntBVV.PerformLayout();
            this.groupBoxResultBVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResultBVV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultBVV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTaskBVV;
        private System.Windows.Forms.GroupBox groupBoxIntBVV;
        private System.Windows.Forms.GroupBox groupBoxResultBVV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResultBVV;
        private System.Windows.Forms.DataGridView dataGridViewResultBVV;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.Button buttonDoneBVV;
        private System.Windows.Forms.TextBox textBoxStopValueBVV;
        private System.Windows.Forms.TextBox textBoxStartValueBVV;
        private System.Windows.Forms.Label labelStopValueBVV;
        private System.Windows.Forms.Label labelStartValueBVV;
        private System.Windows.Forms.Button buttonMessageBVV;
        private System.Windows.Forms.TextBox textBoxTaskBVV;
    }
}

