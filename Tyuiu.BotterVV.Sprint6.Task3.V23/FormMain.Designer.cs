
namespace Tyuiu.BotterVV.Sprint6.Task3.V23
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
            this.groupBoxTaskBVV = new System.Windows.Forms.GroupBox();
            this.dataGridViewTaskBVV = new System.Windows.Forms.DataGridView();
            this.textBoxTaskBVV = new System.Windows.Forms.TextBox();
            this.groupBoxResultBVV = new System.Windows.Forms.GroupBox();
            this.labelResultBVV = new System.Windows.Forms.Label();
            this.buttonDoneBVV = new System.Windows.Forms.Button();
            this.buttonMessageBVV = new System.Windows.Forms.Button();
            this.dataGridViewResultBVV = new System.Windows.Forms.DataGridView();
            this.groupBoxTaskBVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaskBVV)).BeginInit();
            this.groupBoxResultBVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultBVV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTaskBVV
            // 
            this.groupBoxTaskBVV.Controls.Add(this.dataGridViewTaskBVV);
            this.groupBoxTaskBVV.Controls.Add(this.textBoxTaskBVV);
            this.groupBoxTaskBVV.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTaskBVV.Name = "groupBoxTaskBVV";
            this.groupBoxTaskBVV.Size = new System.Drawing.Size(568, 311);
            this.groupBoxTaskBVV.TabIndex = 0;
            this.groupBoxTaskBVV.TabStop = false;
            this.groupBoxTaskBVV.Text = "Условие";
            // 
            // dataGridViewTaskBVV
            // 
            this.dataGridViewTaskBVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTaskBVV.ColumnHeadersVisible = false;
            this.dataGridViewTaskBVV.Location = new System.Drawing.Point(322, 20);
            this.dataGridViewTaskBVV.Name = "dataGridViewTaskBVV";
            this.dataGridViewTaskBVV.ReadOnly = true;
            this.dataGridViewTaskBVV.RowHeadersVisible = false;
            this.dataGridViewTaskBVV.Size = new System.Drawing.Size(229, 220);
            this.dataGridViewTaskBVV.TabIndex = 1;
            // 
            // textBoxTaskBVV
            // 
            this.textBoxTaskBVV.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTaskBVV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTaskBVV.Location = new System.Drawing.Point(7, 20);
            this.textBoxTaskBVV.Multiline = true;
            this.textBoxTaskBVV.Name = "textBoxTaskBVV";
            this.textBoxTaskBVV.ReadOnly = true;
            this.textBoxTaskBVV.Size = new System.Drawing.Size(309, 220);
            this.textBoxTaskBVV.TabIndex = 0;
            this.textBoxTaskBVV.Text = "Дан массив 5 на 5.\r\nВыполнить сортировку по возрастанию во втором столбце.\r\nРезул" +
    "ьтат вывести в DataGridView.";
            // 
            // groupBoxResultBVV
            // 
            this.groupBoxResultBVV.Controls.Add(this.dataGridViewResultBVV);
            this.groupBoxResultBVV.Controls.Add(this.labelResultBVV);
            this.groupBoxResultBVV.Location = new System.Drawing.Point(588, 13);
            this.groupBoxResultBVV.Name = "groupBoxResultBVV";
            this.groupBoxResultBVV.Size = new System.Drawing.Size(200, 250);
            this.groupBoxResultBVV.TabIndex = 1;
            this.groupBoxResultBVV.TabStop = false;
            this.groupBoxResultBVV.Text = "Вывод данных";
            // 
            // labelResultBVV
            // 
            this.labelResultBVV.AutoSize = true;
            this.labelResultBVV.Location = new System.Drawing.Point(7, 20);
            this.labelResultBVV.Name = "labelResultBVV";
            this.labelResultBVV.Size = new System.Drawing.Size(62, 13);
            this.labelResultBVV.TabIndex = 0;
            this.labelResultBVV.Text = "Результат:";
            // 
            // buttonDoneBVV
            // 
            this.buttonDoneBVV.Location = new System.Drawing.Point(692, 269);
            this.buttonDoneBVV.Name = "buttonDoneBVV";
            this.buttonDoneBVV.Size = new System.Drawing.Size(96, 55);
            this.buttonDoneBVV.TabIndex = 2;
            this.buttonDoneBVV.Text = "Выполнить";
            this.buttonDoneBVV.UseVisualStyleBackColor = true;
            this.buttonDoneBVV.Click += new System.EventHandler(this.buttonDoneBVV_Click);
            // 
            // buttonMessageBVV
            // 
            this.buttonMessageBVV.Location = new System.Drawing.Point(643, 293);
            this.buttonMessageBVV.Name = "buttonMessageBVV";
            this.buttonMessageBVV.Size = new System.Drawing.Size(31, 31);
            this.buttonMessageBVV.TabIndex = 3;
            this.buttonMessageBVV.Text = "?";
            this.buttonMessageBVV.UseVisualStyleBackColor = true;
            this.buttonMessageBVV.Click += new System.EventHandler(this.buttonMessageBVV_Click);
            // 
            // dataGridViewResultBVV
            // 
            this.dataGridViewResultBVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultBVV.ColumnHeadersVisible = false;
            this.dataGridViewResultBVV.Location = new System.Drawing.Point(10, 36);
            this.dataGridViewResultBVV.Name = "dataGridViewResultBVV";
            this.dataGridViewResultBVV.ReadOnly = true;
            this.dataGridViewResultBVV.RowHeadersVisible = false;
            this.dataGridViewResultBVV.Size = new System.Drawing.Size(184, 204);
            this.dataGridViewResultBVV.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 336);
            this.Controls.Add(this.buttonMessageBVV);
            this.Controls.Add(this.buttonDoneBVV);
            this.Controls.Add(this.groupBoxResultBVV);
            this.Controls.Add(this.groupBoxTaskBVV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 23 | Боттер В.В.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTaskBVV.ResumeLayout(false);
            this.groupBoxTaskBVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaskBVV)).EndInit();
            this.groupBoxResultBVV.ResumeLayout(false);
            this.groupBoxResultBVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultBVV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTaskBVV;
        private System.Windows.Forms.DataGridView dataGridViewTaskBVV;
        private System.Windows.Forms.TextBox textBoxTaskBVV;
        private System.Windows.Forms.GroupBox groupBoxResultBVV;
        private System.Windows.Forms.Label labelResultBVV;
        private System.Windows.Forms.Button buttonDoneBVV;
        private System.Windows.Forms.Button buttonMessageBVV;
        private System.Windows.Forms.DataGridView dataGridViewResultBVV;
    }
}

