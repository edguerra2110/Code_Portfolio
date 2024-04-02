namespace Project3
{
    partial class Splashscreen
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
            this.components = new System.ComponentModel.Container();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.ProjectNameLabel = new System.Windows.Forms.Label();
            this.SplashScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.SplashScreenImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SplashScreenImg)).BeginInit();
            this.SuspendLayout();
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.BackColor = System.Drawing.Color.White;
            this.VersionLabel.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.Location = new System.Drawing.Point(52, 425);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(95, 41);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "label1";
            // 
            // ProjectNameLabel
            // 
            this.ProjectNameLabel.AutoSize = true;
            this.ProjectNameLabel.BackColor = System.Drawing.Color.White;
            this.ProjectNameLabel.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectNameLabel.Location = new System.Drawing.Point(456, 425);
            this.ProjectNameLabel.Name = "ProjectNameLabel";
            this.ProjectNameLabel.Size = new System.Drawing.Size(235, 41);
            this.ProjectNameLabel.TabIndex = 2;
            this.ProjectNameLabel.Text = "Tower Of Hanoi";
            // 
            // SplashScreenTimer
            // 
            this.SplashScreenTimer.Enabled = true;
            this.SplashScreenTimer.Interval = 2500;
            this.SplashScreenTimer.Tick += new System.EventHandler(this.SplashScreenTimer_Tick);
            // 
            // SplashScreenImg
            // 
            this.SplashScreenImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplashScreenImg.Image = global::Project3.Properties.Resources.e89ea22ab57572c1ef462e87f8e8203a;
            this.SplashScreenImg.Location = new System.Drawing.Point(0, 0);
            this.SplashScreenImg.Name = "SplashScreenImg";
            this.SplashScreenImg.Size = new System.Drawing.Size(749, 495);
            this.SplashScreenImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SplashScreenImg.TabIndex = 0;
            this.SplashScreenImg.TabStop = false;
            // 
            // Splashscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 495);
            this.Controls.Add(this.ProjectNameLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.SplashScreenImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splashscreen";
            this.Opacity = 0.7D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SplashScreenImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SplashScreenImg;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label ProjectNameLabel;
        private System.Windows.Forms.Timer SplashScreenTimer;
    }
}