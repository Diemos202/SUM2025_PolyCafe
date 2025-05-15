namespace GUI_PolyCafe
{
    partial class frmWelcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Location = new Point(0, 440);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(801, 10);
            progressBar.TabIndex = 0;
            // 
            // frmWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.img_coffe;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar);
            DoubleBuffered = true;
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "frmWelcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chào mừng đến với PolyCafe";
            FormClosing += Welcome_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar;
    }
}
