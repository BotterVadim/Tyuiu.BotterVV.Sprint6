
namespace Tyuiu.BotterVV.Sprint6.Task7.V14
{
    partial class FormAbout_BVV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_BVV));
            this.labelAbout_BVV = new System.Windows.Forms.Label();
            this.buttonOk_BVV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAbout_BVV
            // 
            this.labelAbout_BVV.AutoSize = true;
            this.labelAbout_BVV.Location = new System.Drawing.Point(140, 41);
            this.labelAbout_BVV.Name = "labelAbout_BVV";
            this.labelAbout_BVV.Size = new System.Drawing.Size(284, 117);
            this.labelAbout_BVV.TabIndex = 0;
            this.labelAbout_BVV.Text = resources.GetString("labelAbout_BVV.Text");
            // 
            // buttonOk_BVV
            // 
            this.buttonOk_BVV.Location = new System.Drawing.Point(394, 176);
            this.buttonOk_BVV.Name = "buttonOk_BVV";
            this.buttonOk_BVV.Size = new System.Drawing.Size(75, 23);
            this.buttonOk_BVV.TabIndex = 1;
            this.buttonOk_BVV.Text = "Ок";
            this.buttonOk_BVV.UseVisualStyleBackColor = true;
            this.buttonOk_BVV.Click += new System.EventHandler(this.buttonOk_BVV_Click);
            // 
            // FormAbout_BVV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.buttonOk_BVV);
            this.Controls.Add(this.labelAbout_BVV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout_BVV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAbout_BVV;
        private System.Windows.Forms.Button buttonOk_BVV;
    }
}