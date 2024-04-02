namespace _2210_001_GuerraEdgar_Project5
{
    partial class SplashScreen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProjName = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.OwnerLabel = new System.Windows.Forms.Label();
            this.CopyR = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Welcome = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::_2210_001_GuerraEdgar_Project5.Properties.Resources.e89ea22ab57572c1ef462e87f8e8203a;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 278);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ProjName
            // 
            this.ProjName.AutoSize = true;
            this.ProjName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ProjName.Location = new System.Drawing.Point(339, 12);
            this.ProjName.Name = "ProjName";
            this.ProjName.Size = new System.Drawing.Size(93, 17);
            this.ProjName.TabIndex = 1;
            this.ProjName.Text = "Project Name";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(339, 53);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(56, 17);
            this.Version.TabIndex = 2;
            this.Version.Text = "Version";
            // 
            // OwnerLabel
            // 
            this.OwnerLabel.AutoSize = true;
            this.OwnerLabel.Location = new System.Drawing.Point(339, 92);
            this.OwnerLabel.Name = "OwnerLabel";
            this.OwnerLabel.Size = new System.Drawing.Size(49, 17);
            this.OwnerLabel.TabIndex = 3;
            this.OwnerLabel.Text = "Owner";
            // 
            // CopyR
            // 
            this.CopyR.AutoSize = true;
            this.CopyR.Location = new System.Drawing.Point(339, 128);
            this.CopyR.Name = "CopyR";
            this.CopyR.Size = new System.Drawing.Size(50, 17);
            this.CopyR.TabIndex = 4;
            this.CopyR.Text = "CopyR";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(345, 148);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(275, 98);
            this.textBox1.TabIndex = 5;
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Welcome.Location = new System.Drawing.Point(446, 249);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(66, 17);
            this.Welcome.TabIndex = 6;
            this.Welcome.Text = "Welcome";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 302);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CopyR);
            this.Controls.Add(this.OwnerLabel);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.ProjName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ProjName;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label OwnerLabel;
        private System.Windows.Forms.Label CopyR;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Timer timer1;
    }
}