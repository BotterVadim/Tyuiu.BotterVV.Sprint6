
namespace Tyuiu.BotterVV.Sprint6.Task1.V14
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
            this.groupBoxTaskBVV = new System.Windows.Forms.GroupBox();
            this.textBoxTaskBVV = new System.Windows.Forms.TextBox();
            this.groupBoxResultBVV = new System.Windows.Forms.GroupBox();
            this.textBoxResultBVV = new System.Windows.Forms.TextBox();
            this.labelResultBVV = new System.Windows.Forms.Label();
            this.buttonResultBVV = new System.Windows.Forms.Button();
            this.groupBoxIntDataBVV = new System.Windows.Forms.GroupBox();
            this.textBoxStopValueBVV = new System.Windows.Forms.TextBox();
            this.textBoxStartValueBVV = new System.Windows.Forms.TextBox();
            this.labelStopValueBVV = new System.Windows.Forms.Label();
            this.labelStartValueBVV = new System.Windows.Forms.Label();
            this.buttonMessageBVV = new System.Windows.Forms.Button();
            this.groupBoxTaskBVV.SuspendLayout();
            this.groupBoxResultBVV.SuspendLayout();
            this.groupBoxIntDataBVV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTaskBVV
            // 
            this.groupBoxTaskBVV.Controls.Add(this.textBoxTaskBVV);
            this.groupBoxTaskBVV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTaskBVV.Name = "groupBoxTaskBVV";
            this.groupBoxTaskBVV.Size = new System.Drawing.Size(531, 304);
            this.groupBoxTaskBVV.TabIndex = 0;
            this.groupBoxTaskBVV.TabStop = false;
            this.groupBoxTaskBVV.Text = "Условие";
            // 
            // textBoxTaskBVV
            // 
            this.textBoxTaskBVV.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTaskBVV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTaskBVV.Location = new System.Drawing.Point(6, 29);
            this.textBoxTaskBVV.Multiline = true;
            this.textBoxTaskBVV.Name = "textBoxTaskBVV";
            this.textBoxTaskBVV.ReadOnly = true;
            this.textBoxTaskBVV.Size = new System.Drawing.Size(371, 159);
            this.textBoxTaskBVV.TabIndex = 0;
            this.textBoxTaskBVV.Text = resources.GetString("textBoxTaskBVV.Text");
            // 
            // groupBoxResultBVV
            // 
            this.groupBoxResultBVV.Controls.Add(this.textBoxResultBVV);
            this.groupBoxResultBVV.Controls.Add(this.labelResultBVV);
            this.groupBoxResultBVV.Location = new System.Drawing.Point(588, 12);
            this.groupBoxResultBVV.Name = "groupBoxResultBVV";
            this.groupBoxResultBVV.Size = new System.Drawing.Size(200, 410);
            this.groupBoxResultBVV.TabIndex = 1;
            this.groupBoxResultBVV.TabStop = false;
            this.groupBoxResultBVV.Text = "Вывод данных";
            // 
            // textBoxResultBVV
            // 
            this.textBoxResultBVV.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResultBVV.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResultBVV.Location = new System.Drawing.Point(6, 46);
            this.textBoxResultBVV.Multiline = true;
            this.textBoxResultBVV.Name = "textBoxResultBVV";
            this.textBoxResultBVV.ReadOnly = true;
            this.textBoxResultBVV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultBVV.Size = new System.Drawing.Size(188, 358);
            this.textBoxResultBVV.TabIndex = 1;
            // 
            // labelResultBVV
            // 
            this.labelResultBVV.AutoSize = true;
            this.labelResultBVV.Location = new System.Drawing.Point(3, 16);
            this.labelResultBVV.Name = "labelResultBVV";
            this.labelResultBVV.Size = new System.Drawing.Size(62, 13);
            this.labelResultBVV.TabIndex = 0;
            this.labelResultBVV.Text = "Результат:";
            // 
            // buttonResultBVV
            // 
            this.buttonResultBVV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonResultBVV.Location = new System.Drawing.Point(436, 357);
            this.buttonResultBVV.Name = "buttonResultBVV";
            this.buttonResultBVV.Size = new System.Drawing.Size(127, 65);
            this.buttonResultBVV.TabIndex = 2;
            this.buttonResultBVV.Text = "Выполнить";
            this.buttonResultBVV.UseVisualStyleBackColor = false;
            this.buttonResultBVV.Click += new System.EventHandler(this.buttonResultBVV_Click);
            // 
            // groupBoxIntDataBVV
            // 
            this.groupBoxIntDataBVV.Controls.Add(this.textBoxStopValueBVV);
            this.groupBoxIntDataBVV.Controls.Add(this.textBoxStartValueBVV);
            this.groupBoxIntDataBVV.Controls.Add(this.labelStopValueBVV);
            this.groupBoxIntDataBVV.Controls.Add(this.labelStartValueBVV);
            this.groupBoxIntDataBVV.Location = new System.Drawing.Point(12, 357);
            this.groupBoxIntDataBVV.Name = "groupBoxIntDataBVV";
            this.groupBoxIntDataBVV.Size = new System.Drawing.Size(269, 65);
            this.groupBoxIntDataBVV.TabIndex = 3;
            this.groupBoxIntDataBVV.TabStop = false;
            this.groupBoxIntDataBVV.Text = "Ввод данных";
            // 
            // textBoxStopValueBVV
            // 
            this.textBoxStopValueBVV.Location = new System.Drawing.Point(150, 38);
            this.textBoxStopValueBVV.Name = "textBoxStopValueBVV";
            this.textBoxStopValueBVV.Size = new System.Drawing.Size(86, 20);
            this.textBoxStopValueBVV.TabIndex = 3;
            // 
            // textBoxStartValueBVV
            // 
            this.textBoxStartValueBVV.Location = new System.Drawing.Point(9, 38);
            this.textBoxStartValueBVV.Name = "textBoxStartValueBVV";
            this.textBoxStartValueBVV.Size = new System.Drawing.Size(83, 20);
            this.textBoxStartValueBVV.TabIndex = 2;
            // 
            // labelStopValueBVV
            // 
            this.labelStopValueBVV.AutoSize = true;
            this.labelStopValueBVV.Location = new System.Drawing.Point(147, 16);
            this.labelStopValueBVV.Name = "labelStopValueBVV";
            this.labelStopValueBVV.Size = new System.Drawing.Size(69, 13);
            this.labelStopValueBVV.TabIndex = 1;
            this.labelStopValueBVV.Text = "Конец шага:";
            // 
            // labelStartValueBVV
            // 
            this.labelStartValueBVV.AutoSize = true;
            this.labelStartValueBVV.Location = new System.Drawing.Point(6, 16);
            this.labelStartValueBVV.Name = "labelStartValueBVV";
            this.labelStartValueBVV.Size = new System.Drawing.Size(67, 13);
            this.labelStartValueBVV.TabIndex = 0;
            this.labelStartValueBVV.Text = "Старт шага:";
            // 
            // buttonMessageBVV
            // 
            this.buttonMessageBVV.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonMessageBVV.Location = new System.Drawing.Point(360, 357);
            this.buttonMessageBVV.Name = "buttonMessageBVV";
            this.buttonMessageBVV.Size = new System.Drawing.Size(59, 65);
            this.buttonMessageBVV.TabIndex = 4;
            this.buttonMessageBVV.Text = "?";
            this.buttonMessageBVV.UseVisualStyleBackColor = false;
            this.buttonMessageBVV.Click += new System.EventHandler(this.buttonMessageBVV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMessageBVV);
            this.Controls.Add(this.groupBoxIntDataBVV);
            this.Controls.Add(this.buttonResultBVV);
            this.Controls.Add(this.groupBoxResultBVV);
            this.Controls.Add(this.groupBoxTaskBVV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 14 | Боттер В.В.";
            this.groupBoxTaskBVV.ResumeLayout(false);
            this.groupBoxTaskBVV.PerformLayout();
            this.groupBoxResultBVV.ResumeLayout(false);
            this.groupBoxResultBVV.PerformLayout();
            this.groupBoxIntDataBVV.ResumeLayout(false);
            this.groupBoxIntDataBVV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTaskBVV;
        private System.Windows.Forms.TextBox textBoxTaskBVV;
        private System.Windows.Forms.GroupBox groupBoxResultBVV;
        private System.Windows.Forms.TextBox textBoxResultBVV;
        private System.Windows.Forms.Label labelResultBVV;
        private System.Windows.Forms.Button buttonResultBVV;
        private System.Windows.Forms.GroupBox groupBoxIntDataBVV;
        private System.Windows.Forms.Label labelStopValueBVV;
        private System.Windows.Forms.Label labelStartValueBVV;
        private System.Windows.Forms.TextBox textBoxStopValueBVV;
        private System.Windows.Forms.TextBox textBoxStartValueBVV;
        private System.Windows.Forms.Button buttonMessageBVV;
    }
}

