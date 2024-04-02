namespace Project3
{
    partial class AboutForm
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
            this.AboutImage = new System.Windows.Forms.PictureBox();
            this.ProductName = new System.Windows.Forms.Label();
            this.AboutButton = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.AurthourName = new System.Windows.Forms.Label();
            this.Copyright = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AboutImage)).BeginInit();
            this.SuspendLayout();
            // 
            // AboutImage
            // 
            this.AboutImage.Image = global::Project3.Properties.Resources.e89ea22ab57572c1ef462e87f8e8203a;
            this.AboutImage.Location = new System.Drawing.Point(0, 0);
            this.AboutImage.Name = "AboutImage";
            this.AboutImage.Size = new System.Drawing.Size(418, 397);
            this.AboutImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AboutImage.TabIndex = 0;
            this.AboutImage.TabStop = false;
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ProductName.Location = new System.Drawing.Point(446, 36);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(149, 25);
            this.ProductName.TabIndex = 2;
            this.ProductName.Text = "Tower Of Hanoi";
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(687, 368);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(75, 23);
            this.AboutButton.TabIndex = 11;
            this.AboutButton.Text = "Ok";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click_1);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(451, 194);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(312, 167);
            this.textBoxDescription.TabIndex = 10;
            // 
            // AurthourName
            // 
            this.AurthourName.AutoSize = true;
            this.AurthourName.Location = new System.Drawing.Point(448, 154);
            this.AurthourName.Name = "AurthourName";
            this.AurthourName.Size = new System.Drawing.Size(108, 17);
            this.AurthourName.TabIndex = 9;
            this.AurthourName.Text = "Company Name";
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.Location = new System.Drawing.Point(448, 121);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(68, 17);
            this.Copyright.TabIndex = 8;
            this.Copyright.Text = "Copyright";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(448, 86);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(56, 17);
            this.Version.TabIndex = 7;
            this.Version.Text = "Version";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.AurthourName);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.AboutImage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.AboutImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AboutImage;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label AurthourName;
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.Label Version;
    }
}