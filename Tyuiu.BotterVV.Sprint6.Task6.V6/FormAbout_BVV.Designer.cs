
namespace Tyuiu.BotterVV.Sprint6.Task6.V6
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
            this.buttonQuit_BVV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAbout_BVV
            // 
            this.labelAbout_BVV.AutoSize = true;
            this.labelAbout_BVV.Location = new System.Drawing.Point(128, 40);
            this.labelAbout_BVV.Name = "labelAbout_BVV";
            this.labelAbout_BVV.Size = new System.Drawing.Size(284, 117);
            this.labelAbout_BVV.TabIndex = 0;
            this.labelAbout_BVV.Text = resources.GetString("labelAbout_BVV.Text");
            // 
            // buttonQuit_BVV
            // 
            this.buttonQuit_BVV.Location = new System.Drawing.Point(397, 226);
            this.buttonQuit_BVV.Name = "buttonQuit_BVV";
            this.buttonQuit_BVV.Size = new System.Drawing.Size(75, 23);
            this.buttonQuit_BVV.TabIndex = 1;
            this.buttonQuit_BVV.Text = "Ок";
            this.buttonQuit_BVV.UseVisualStyleBackColor = true;
            this.buttonQuit_BVV.Click += new System.EventHandler(this.buttonQuit_BVV_Click);
            // 
            // FormAbout_BVV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.buttonQuit_BVV);
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
        private System.Windows.Forms.Button buttonQuit_BVV;
    }
}