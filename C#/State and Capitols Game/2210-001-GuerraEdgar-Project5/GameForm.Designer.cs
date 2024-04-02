namespace _2210_001_GuerraEdgar_Project5
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.CapitLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.StateNameTB = new System.Windows.Forms.TextBox();
            this.TimerTB = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CorrectLBL = new System.Windows.Forms.Label();
            this.attemptsLBL = new System.Windows.Forms.Label();
            this.NextQSTNBTN = new System.Windows.Forms.Button();
            this.EndGameBTN = new System.Windows.Forms.Button();
            this.AttemptsTXTB = new System.Windows.Forms.TextBox();
            this.CorrectTXTB = new System.Windows.Forms.TextBox();
            this.StatePic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StatePic)).BeginInit();
            this.SuspendLayout();
            // 
            // CapitLabel
            // 
            this.CapitLabel.AutoSize = true;
            this.CapitLabel.Location = new System.Drawing.Point(12, 53);
            this.CapitLabel.Name = "CapitLabel";
            this.CapitLabel.Size = new System.Drawing.Size(144, 17);
            this.CapitLabel.TabIndex = 0;
            this.CapitLabel.Text = "What is the capital of:\r\n";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(13, 128);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(110, 51);
            this.TimeLabel.TabIndex = 1;
            this.TimeLabel.Text = "Time Remaining\r\n\r\n\r\n";
            // 
            // StateNameTB
            // 
            this.StateNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateNameTB.Location = new System.Drawing.Point(176, 42);
            this.StateNameTB.Name = "StateNameTB";
            this.StateNameTB.ReadOnly = true;
            this.StateNameTB.Size = new System.Drawing.Size(165, 27);
            this.StateNameTB.TabIndex = 2;
            this.StateNameTB.Text = "\r\n";
            this.StateNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimerTB
            // 
            this.TimerTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TimerTB.Location = new System.Drawing.Point(16, 157);
            this.TimerTB.Name = "TimerTB";
            this.TimerTB.ReadOnly = true;
            this.TimerTB.Size = new System.Drawing.Size(107, 34);
            this.TimerTB.TabIndex = 3;
            this.TimerTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(364, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(163, 388);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // CorrectLBL
            // 
            this.CorrectLBL.AutoSize = true;
            this.CorrectLBL.Location = new System.Drawing.Point(208, 331);
            this.CorrectLBL.Name = "CorrectLBL";
            this.CorrectLBL.Size = new System.Drawing.Size(58, 17);
            this.CorrectLBL.TabIndex = 6;
            this.CorrectLBL.Text = "Correct:";
            // 
            // attemptsLBL
            // 
            this.attemptsLBL.AutoSize = true;
            this.attemptsLBL.Location = new System.Drawing.Point(48, 331);
            this.attemptsLBL.Name = "attemptsLBL";
            this.attemptsLBL.Size = new System.Drawing.Size(67, 17);
            this.attemptsLBL.TabIndex = 7;
            this.attemptsLBL.Text = "Attempts:";
            // 
            // NextQSTNBTN
            // 
            this.NextQSTNBTN.Location = new System.Drawing.Point(12, 409);
            this.NextQSTNBTN.Name = "NextQSTNBTN";
            this.NextQSTNBTN.Size = new System.Drawing.Size(144, 32);
            this.NextQSTNBTN.TabIndex = 8;
            this.NextQSTNBTN.Text = "Next Question";
            this.NextQSTNBTN.UseVisualStyleBackColor = true;
            this.NextQSTNBTN.Click += new System.EventHandler(this.NextQSTNBTN_Click);
            // 
            // EndGameBTN
            // 
            this.EndGameBTN.Location = new System.Drawing.Point(189, 409);
            this.EndGameBTN.Name = "EndGameBTN";
            this.EndGameBTN.Size = new System.Drawing.Size(144, 32);
            this.EndGameBTN.TabIndex = 9;
            this.EndGameBTN.Text = "End Game";
            this.EndGameBTN.UseVisualStyleBackColor = true;
            this.EndGameBTN.Click += new System.EventHandler(this.EndGameBTN_Click);
            // 
            // AttemptsTXTB
            // 
            this.AttemptsTXTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AttemptsTXTB.Location = new System.Drawing.Point(51, 351);
            this.AttemptsTXTB.Name = "AttemptsTXTB";
            this.AttemptsTXTB.ReadOnly = true;
            this.AttemptsTXTB.Size = new System.Drawing.Size(60, 34);
            this.AttemptsTXTB.TabIndex = 10;
            this.AttemptsTXTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CorrectTXTB
            // 
            this.CorrectTXTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CorrectTXTB.Location = new System.Drawing.Point(211, 351);
            this.CorrectTXTB.Name = "CorrectTXTB";
            this.CorrectTXTB.ReadOnly = true;
            this.CorrectTXTB.Size = new System.Drawing.Size(60, 34);
            this.CorrectTXTB.TabIndex = 11;
            this.CorrectTXTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StatePic
            // 
            this.StatePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StatePic.Location = new System.Drawing.Point(164, 75);
            this.StatePic.Name = "StatePic";
            this.StatePic.Size = new System.Drawing.Size(194, 253);
            this.StatePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StatePic.TabIndex = 4;
            this.StatePic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select The Captial";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 477);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CorrectTXTB);
            this.Controls.Add(this.AttemptsTXTB);
            this.Controls.Add(this.EndGameBTN);
            this.Controls.Add(this.NextQSTNBTN);
            this.Controls.Add(this.attemptsLBL);
            this.Controls.Add(this.CorrectLBL);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.StatePic);
            this.Controls.Add(this.TimerTB);
            this.Controls.Add(this.StateNameTB);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.CapitLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matching State Capitals";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.StatePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CapitLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.TextBox StateNameTB;
        private System.Windows.Forms.TextBox TimerTB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox StatePic;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label CorrectLBL;
        private System.Windows.Forms.Label attemptsLBL;
        private System.Windows.Forms.Button NextQSTNBTN;
        private System.Windows.Forms.Button EndGameBTN;
        private System.Windows.Forms.TextBox AttemptsTXTB;
        private System.Windows.Forms.TextBox CorrectTXTB;
        private System.Windows.Forms.Label label1;
    }
}