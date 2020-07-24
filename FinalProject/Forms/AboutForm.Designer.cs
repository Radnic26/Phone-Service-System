namespace FinalProject
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.userControl11 = new UserControlClass.UserControl1();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl11.BackgroundImage")));
            this.userControl11.Location = new System.Drawing.Point(0, -2);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(710, 481);
            this.userControl11.TabIndex = 0;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 459);
            this.Controls.Add(this.userControl11);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UserControlClass.UserControl1 userControl11;
    }
}