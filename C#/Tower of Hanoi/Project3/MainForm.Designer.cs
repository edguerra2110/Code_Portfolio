namespace Project3
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GameMenuStrip = new System.Windows.Forms.MenuStrip();
            this.filEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextMoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NumDiskGrpBox = new System.Windows.Forms.GroupBox();
            this.NumDiskTxtBx = new System.Windows.Forms.TextBox();
            this.NumDiskLabel = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.FirstPoleTxtBx = new System.Windows.Forms.TextBox();
            this.SecondPoleTxtBx = new System.Windows.Forms.TextBox();
            this.ThirdPoleTxtBx = new System.Windows.Forms.TextBox();
            this.NextMoveBtn = new System.Windows.Forms.Button();
            this.GameToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.CurrentMoveInt = new System.Windows.Forms.ToolStripLabel();
            this.TotalNumMovesLabel = new System.Windows.Forms.ToolStripLabel();
            this.NumLabel = new System.Windows.Forms.ToolStripLabel();
            this.GameMenuStrip.SuspendLayout();
            this.NumDiskGrpBox.SuspendLayout();
            this.GameToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameMenuStrip
            // 
            this.GameMenuStrip.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.GameMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.GameMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filEToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.GameMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.GameMenuStrip.Name = "GameMenuStrip";
            this.GameMenuStrip.Size = new System.Drawing.Size(800, 28);
            this.GameMenuStrip.TabIndex = 0;
            this.GameMenuStrip.Text = "menuStrip1";
            // 
            // filEToolStripMenuItem
            // 
            this.filEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.nextMoveToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.filEToolStripMenuItem.Name = "filEToolStripMenuItem";
            this.filEToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.filEToolStripMenuItem.Text = "File";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // nextMoveToolStripMenuItem
            // 
            this.nextMoveToolStripMenuItem.Enabled = false;
            this.nextMoveToolStripMenuItem.Name = "nextMoveToolStripMenuItem";
            this.nextMoveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nextMoveToolStripMenuItem.Text = "Next Move";
            this.nextMoveToolStripMenuItem.Click += new System.EventHandler(this.nextMoveToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // NumDiskGrpBox
            // 
            this.NumDiskGrpBox.Controls.Add(this.NumDiskTxtBx);
            this.NumDiskGrpBox.Controls.Add(this.NumDiskLabel);
            this.NumDiskGrpBox.Location = new System.Drawing.Point(87, 35);
            this.NumDiskGrpBox.Name = "NumDiskGrpBox";
            this.NumDiskGrpBox.Size = new System.Drawing.Size(432, 73);
            this.NumDiskGrpBox.TabIndex = 1;
            this.NumDiskGrpBox.TabStop = false;
            this.NumDiskGrpBox.Text = "Please Enter the Number  of Disks:";
            // 
            // NumDiskTxtBx
            // 
            this.NumDiskTxtBx.Location = new System.Drawing.Point(133, 34);
            this.NumDiskTxtBx.Name = "NumDiskTxtBx";
            this.NumDiskTxtBx.Size = new System.Drawing.Size(287, 22);
            this.NumDiskTxtBx.TabIndex = 2;
            // 
            // NumDiskLabel
            // 
            this.NumDiskLabel.AutoSize = true;
            this.NumDiskLabel.Location = new System.Drawing.Point(12, 34);
            this.NumDiskLabel.Name = "NumDiskLabel";
            this.NumDiskLabel.Size = new System.Drawing.Size(116, 17);
            this.NumDiskLabel.TabIndex = 0;
            this.NumDiskLabel.Text = "Number of Disks:";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(570, 56);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(104, 34);
            this.StartBtn.TabIndex = 2;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // FirstPoleTxtBx
            // 
            this.FirstPoleTxtBx.AcceptsReturn = true;
            this.FirstPoleTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstPoleTxtBx.Location = new System.Drawing.Point(75, 116);
            this.FirstPoleTxtBx.Multiline = true;
            this.FirstPoleTxtBx.Name = "FirstPoleTxtBx";
            this.FirstPoleTxtBx.ReadOnly = true;
            this.FirstPoleTxtBx.Size = new System.Drawing.Size(170, 292);
            this.FirstPoleTxtBx.TabIndex = 3;
            this.FirstPoleTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SecondPoleTxtBx
            // 
            this.SecondPoleTxtBx.AcceptsReturn = true;
            this.SecondPoleTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondPoleTxtBx.Location = new System.Drawing.Point(317, 116);
            this.SecondPoleTxtBx.Multiline = true;
            this.SecondPoleTxtBx.Name = "SecondPoleTxtBx";
            this.SecondPoleTxtBx.ReadOnly = true;
            this.SecondPoleTxtBx.Size = new System.Drawing.Size(170, 292);
            this.SecondPoleTxtBx.TabIndex = 4;
            this.SecondPoleTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ThirdPoleTxtBx
            // 
            this.ThirdPoleTxtBx.AcceptsReturn = true;
            this.ThirdPoleTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirdPoleTxtBx.Location = new System.Drawing.Point(550, 116);
            this.ThirdPoleTxtBx.Multiline = true;
            this.ThirdPoleTxtBx.Name = "ThirdPoleTxtBx";
            this.ThirdPoleTxtBx.ReadOnly = true;
            this.ThirdPoleTxtBx.Size = new System.Drawing.Size(170, 292);
            this.ThirdPoleTxtBx.TabIndex = 5;
            this.ThirdPoleTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NextMoveBtn
            // 
            this.NextMoveBtn.Enabled = false;
            this.NextMoveBtn.Location = new System.Drawing.Point(358, 436);
            this.NextMoveBtn.Name = "NextMoveBtn";
            this.NextMoveBtn.Size = new System.Drawing.Size(104, 34);
            this.NextMoveBtn.TabIndex = 6;
            this.NextMoveBtn.Text = "Next Move";
            this.NextMoveBtn.UseVisualStyleBackColor = true;
            this.NextMoveBtn.Click += new System.EventHandler(this.NextMoveBtn_Click);
            // 
            // GameToolStrip
            // 
            this.GameToolStrip.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.GameToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GameToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.GameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.CurrentMoveInt,
            this.TotalNumMovesLabel,
            this.NumLabel});
            this.GameToolStrip.Location = new System.Drawing.Point(0, 513);
            this.GameToolStrip.Name = "GameToolStrip";
            this.GameToolStrip.Size = new System.Drawing.Size(800, 25);
            this.GameToolStrip.TabIndex = 7;
            this.GameToolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(101, 22);
            this.toolStripLabel1.Text = "Current Move:";
            // 
            // CurrentMoveInt
            // 
            this.CurrentMoveInt.Name = "CurrentMoveInt";
            this.CurrentMoveInt.Size = new System.Drawing.Size(17, 22);
            this.CurrentMoveInt.Text = "0";
            // 
            // TotalNumMovesLabel
            // 
            this.TotalNumMovesLabel.Name = "TotalNumMovesLabel";
            this.TotalNumMovesLabel.Size = new System.Drawing.Size(168, 22);
            this.TotalNumMovesLabel.Text = "Total Number of Moves:";
            // 
            // NumLabel
            // 
            this.NumLabel.Name = "NumLabel";
            this.NumLabel.Size = new System.Drawing.Size(17, 22);
            this.NumLabel.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.GameToolStrip);
            this.Controls.Add(this.NextMoveBtn);
            this.Controls.Add(this.ThirdPoleTxtBx);
            this.Controls.Add(this.SecondPoleTxtBx);
            this.Controls.Add(this.FirstPoleTxtBx);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.NumDiskGrpBox);
            this.Controls.Add(this.GameMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.GameMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tower of Hanoi";
            this.GameMenuStrip.ResumeLayout(false);
            this.GameMenuStrip.PerformLayout();
            this.NumDiskGrpBox.ResumeLayout(false);
            this.NumDiskGrpBox.PerformLayout();
            this.GameToolStrip.ResumeLayout(false);
            this.GameToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip GameMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem filEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox NumDiskGrpBox;
        private System.Windows.Forms.TextBox NumDiskTxtBx;
        private System.Windows.Forms.Label NumDiskLabel;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.TextBox FirstPoleTxtBx;
        private System.Windows.Forms.TextBox SecondPoleTxtBx;
        private System.Windows.Forms.TextBox ThirdPoleTxtBx;
        private System.Windows.Forms.Button NextMoveBtn;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip GameToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel CurrentMoveInt;
        private System.Windows.Forms.ToolStripLabel TotalNumMovesLabel;
        private System.Windows.Forms.ToolStripLabel NumLabel;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextMoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}

