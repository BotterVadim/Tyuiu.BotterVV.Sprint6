
namespace Tyuiu.BotterVV.Sprint6.Task0.V17
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
            this.pictureBoxFormulaBVV = new System.Windows.Forms.PictureBox();
            this.groupBoxIntBVV = new System.Windows.Forms.GroupBox();
            this.labelVarXBVV = new System.Windows.Forms.Label();
            this.textBoxVarXBVV = new System.Windows.Forms.TextBox();
            this.groupBoxResultBVV = new System.Windows.Forms.GroupBox();
            this.labelResultBVV = new System.Windows.Forms.Label();
            this.textBoxResultBVV = new System.Windows.Forms.TextBox();
            this.buttonResultBVV = new System.Windows.Forms.Button();
            this.buttonMessageBVV = new System.Windows.Forms.Button();
            this.groupBoxTaskBVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormulaBVV)).BeginInit();
            this.groupBoxIntBVV.SuspendLayout();
            this.groupBoxResultBVV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTaskBVV
            // 
            this.groupBoxTaskBVV.Controls.Add(this.textBoxTaskBVV);
            this.groupBoxTaskBVV.Controls.Add(this.pictureBoxFormulaBVV);
            this.groupBoxTaskBVV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTaskBVV.Name = "groupBoxTaskBVV";
            this.groupBoxTaskBVV.Size = new System.Drawing.Size(776, 241);
            this.groupBoxTaskBVV.TabIndex = 0;
            this.groupBoxTaskBVV.TabStop = false;
            this.groupBoxTaskBVV.Text = "Условие:";
            // 
            // textBoxTaskBVV
            // 
            this.textBoxTaskBVV.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTaskBVV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTaskBVV.Location = new System.Drawing.Point(15, 24);
            this.textBoxTaskBVV.Multiline = true;
            this.textBoxTaskBVV.Name = "textBoxTaskBVV";
            this.textBoxTaskBVV.ReadOnly = true;
            this.textBoxTaskBVV.Size = new System.Drawing.Size(618, 128);
            this.textBoxTaskBVV.TabIndex = 2;
            this.textBoxTaskBVV.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFormulaBVV
            // 
            this.pictureBoxFormulaBVV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormulaBVV.Image")));
            this.pictureBoxFormulaBVV.Location = new System.Drawing.Point(639, 24);
            this.pictureBoxFormulaBVV.Name = "pictureBoxFormulaBVV";
            this.pictureBoxFormulaBVV.Size = new System.Drawing.Size(95, 69);
            this.pictureBoxFormulaBVV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFormulaBVV.TabIndex = 1;
            this.pictureBoxFormulaBVV.TabStop = false;
            // 
            // groupBoxIntBVV
            // 
            this.groupBoxIntBVV.Controls.Add(this.labelVarXBVV);
            this.groupBoxIntBVV.Controls.Add(this.textBoxVarXBVV);
            this.groupBoxIntBVV.Location = new System.Drawing.Point(12, 272);
            this.groupBoxIntBVV.Name = "groupBoxIntBVV";
            this.groupBoxIntBVV.Size = new System.Drawing.Size(405, 100);
            this.groupBoxIntBVV.TabIndex = 1;
            this.groupBoxIntBVV.TabStop = false;
            this.groupBoxIntBVV.Text = "Ввод данных:";
            // 
            // labelVarXBVV
            // 
            this.labelVarXBVV.AutoSize = true;
            this.labelVarXBVV.Location = new System.Drawing.Point(12, 29);
            this.labelVarXBVV.Name = "labelVarXBVV";
            this.labelVarXBVV.Size = new System.Drawing.Size(84, 13);
            this.labelVarXBVV.TabIndex = 1;
            this.labelVarXBVV.Text = "Переменная X:";
            // 
            // textBoxVarXBVV
            // 
            this.textBoxVarXBVV.Location = new System.Drawing.Point(15, 56);
            this.textBoxVarXBVV.Name = "textBoxVarXBVV";
            this.textBoxVarXBVV.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarXBVV.TabIndex = 0;
            this.textBoxVarXBVV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarXBVV_KeyPress);
            // 
            // groupBoxResultBVV
            // 
            this.groupBoxResultBVV.Controls.Add(this.labelResultBVV);
            this.groupBoxResultBVV.Controls.Add(this.textBoxResultBVV);
            this.groupBoxResultBVV.Location = new System.Drawing.Point(460, 272);
            this.groupBoxResultBVV.Name = "groupBoxResultBVV";
            this.groupBoxResultBVV.Size = new System.Drawing.Size(328, 100);
            this.groupBoxResultBVV.TabIndex = 2;
            this.groupBoxResultBVV.TabStop = false;
            this.groupBoxResultBVV.Text = "Вывод данных:";
            // 
            // labelResultBVV
            // 
            this.labelResultBVV.AutoSize = true;
            this.labelResultBVV.Location = new System.Drawing.Point(19, 28);
            this.labelResultBVV.Name = "labelResultBVV";
            this.labelResultBVV.Size = new System.Drawing.Size(62, 13);
            this.labelResultBVV.TabIndex = 1;
            this.labelResultBVV.Text = "Результат:";
            // 
            // textBoxResultBVV
            // 
            this.textBoxResultBVV.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResultBVV.Location = new System.Drawing.Point(19, 56);
            this.textBoxResultBVV.Name = "textBoxResultBVV";
            this.textBoxResultBVV.ReadOnly = true;
            this.textBoxResultBVV.Size = new System.Drawing.Size(100, 20);
            this.textBoxResultBVV.TabIndex = 0;
            // 
            // buttonResultBVV
            // 
            this.buttonResultBVV.Location = new System.Drawing.Point(665, 400);
            this.buttonResultBVV.Name = "buttonResultBVV";
            this.buttonResultBVV.Size = new System.Drawing.Size(123, 38);
            this.buttonResultBVV.TabIndex = 3;
            this.buttonResultBVV.Text = "Выполнить";
            this.buttonResultBVV.UseVisualStyleBackColor = true;
            this.buttonResultBVV.Click += new System.EventHandler(this.buttonResultBVV_Click);
            // 
            // buttonMessageBVV
            // 
            this.buttonMessageBVV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMessageBVV.Location = new System.Drawing.Point(608, 402);
            this.buttonMessageBVV.Name = "buttonMessageBVV";
            this.buttonMessageBVV.Size = new System.Drawing.Size(37, 35);
            this.buttonMessageBVV.TabIndex = 4;
            this.buttonMessageBVV.Text = "?";
            this.buttonMessageBVV.UseVisualStyleBackColor = true;
            this.buttonMessageBVV.Click += new System.EventHandler(this.buttonMessageBVV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMessageBVV);
            this.Controls.Add(this.buttonResultBVV);
            this.Controls.Add(this.groupBoxResultBVV);
            this.Controls.Add(this.groupBoxIntBVV);
            this.Controls.Add(this.groupBoxTaskBVV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 17 | Боттер В.В.";
            this.groupBoxTaskBVV.ResumeLayout(false);
            this.groupBoxTaskBVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormulaBVV)).EndInit();
            this.groupBoxIntBVV.ResumeLayout(false);
            this.groupBoxIntBVV.PerformLayout();
            this.groupBoxResultBVV.ResumeLayout(false);
            this.groupBoxResultBVV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTaskBVV;
        private System.Windows.Forms.PictureBox pictureBoxFormulaBVV;
        private System.Windows.Forms.TextBox textBoxTaskBVV;
        private System.Windows.Forms.GroupBox groupBoxIntBVV;
        private System.Windows.Forms.Label labelVarXBVV;
        private System.Windows.Forms.TextBox textBoxVarXBVV;
        private System.Windows.Forms.GroupBox groupBoxResultBVV;
        private System.Windows.Forms.Label labelResultBVV;
        private System.Windows.Forms.TextBox textBoxResultBVV;
        private System.Windows.Forms.Button buttonResultBVV;
        private System.Windows.Forms.Button buttonMessageBVV;
    }
}

