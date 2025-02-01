namespace thisProject
{
    partial class rpsGame
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
            this.bRock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bPaper = new System.Windows.Forms.Button();
            this.bScissors = new System.Windows.Forms.Button();
            this.playerPick = new System.Windows.Forms.Label();
            this.computerPick = new System.Windows.Forms.Label();
            this.winLose = new System.Windows.Forms.Label();
            this.pickerReturn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.points = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bRock
            // 
            this.bRock.Location = new System.Drawing.Point(71, 12);
            this.bRock.Name = "bRock";
            this.bRock.Size = new System.Drawing.Size(55, 23);
            this.bRock.TabIndex = 0;
            this.bRock.Text = "Rock";
            this.bRock.UseVisualStyleBackColor = true;
            this.bRock.Click += new System.EventHandler(this.bRock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your pick:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Computer\'s pick:";
            // 
            // bPaper
            // 
            this.bPaper.Location = new System.Drawing.Point(132, 12);
            this.bPaper.Name = "bPaper";
            this.bPaper.Size = new System.Drawing.Size(55, 23);
            this.bPaper.TabIndex = 5;
            this.bPaper.Text = "Paper";
            this.bPaper.UseVisualStyleBackColor = true;
            this.bPaper.Click += new System.EventHandler(this.bPaper_Click);
            // 
            // bScissors
            // 
            this.bScissors.Location = new System.Drawing.Point(193, 12);
            this.bScissors.Name = "bScissors";
            this.bScissors.Size = new System.Drawing.Size(55, 23);
            this.bScissors.TabIndex = 6;
            this.bScissors.Text = "Scissors";
            this.bScissors.UseVisualStyleBackColor = true;
            this.bScissors.Click += new System.EventHandler(this.bScissors_Click);
            // 
            // playerPick
            // 
            this.playerPick.AutoSize = true;
            this.playerPick.Location = new System.Drawing.Point(12, 49);
            this.playerPick.Name = "playerPick";
            this.playerPick.Size = new System.Drawing.Size(59, 13);
            this.playerPick.TabIndex = 7;
            this.playerPick.Text = "<<player>>";
            // 
            // computerPick
            // 
            this.computerPick.AutoSize = true;
            this.computerPick.Location = new System.Drawing.Point(12, 126);
            this.computerPick.Name = "computerPick";
            this.computerPick.Size = new System.Drawing.Size(75, 13);
            this.computerPick.TabIndex = 8;
            this.computerPick.Text = "<<computer>>";
            // 
            // winLose
            // 
            this.winLose.AutoSize = true;
            this.winLose.Location = new System.Drawing.Point(12, 181);
            this.winLose.Name = "winLose";
            this.winLose.Size = new System.Drawing.Size(42, 13);
            this.winLose.TabIndex = 9;
            this.winLose.Text = "W/D/L";
            // 
            // pickerReturn
            // 
            this.pickerReturn.Location = new System.Drawing.Point(155, 203);
            this.pickerReturn.Name = "pickerReturn";
            this.pickerReturn.Size = new System.Drawing.Size(93, 23);
            this.pickerReturn.TabIndex = 10;
            this.pickerReturn.Text = "Return to picker";
            this.pickerReturn.UseVisualStyleBackColor = true;
            this.pickerReturn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Points:";
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Location = new System.Drawing.Point(48, 208);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(13, 13);
            this.points.TabIndex = 12;
            this.points.Text = "0";
            // 
            // rpsGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 240);
            this.Controls.Add(this.points);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pickerReturn);
            this.Controls.Add(this.winLose);
            this.Controls.Add(this.computerPick);
            this.Controls.Add(this.playerPick);
            this.Controls.Add(this.bScissors);
            this.Controls.Add(this.bPaper);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bRock);
            this.Name = "rpsGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bRock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bPaper;
        private System.Windows.Forms.Button bScissors;
        private System.Windows.Forms.Label playerPick;
        private System.Windows.Forms.Label computerPick;
        private System.Windows.Forms.Label winLose;
        private System.Windows.Forms.Button pickerReturn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label points;
    }
}