namespace thisProject
{
    partial class guessGame
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
            this.pickerReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGuess = new System.Windows.Forms.TextBox();
            this.bEnter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hint = new System.Windows.Forms.Label();
            this.numGuesses = new System.Windows.Forms.Label();
            this.playAgain = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pickerReturn
            // 
            this.pickerReturn.Location = new System.Drawing.Point(108, 160);
            this.pickerReturn.Name = "pickerReturn";
            this.pickerReturn.Size = new System.Drawing.Size(93, 23);
            this.pickerReturn.TabIndex = 3;
            this.pickerReturn.Text = "Return to picker";
            this.pickerReturn.UseVisualStyleBackColor = true;
            this.pickerReturn.Click += new System.EventHandler(this.pickerReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Guess a number between 1 to 100!";
            // 
            // tbGuess
            // 
            this.tbGuess.Location = new System.Drawing.Point(12, 48);
            this.tbGuess.Name = "tbGuess";
            this.tbGuess.Size = new System.Drawing.Size(100, 20);
            this.tbGuess.TabIndex = 5;
            // 
            // bEnter
            // 
            this.bEnter.Location = new System.Drawing.Point(126, 47);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(75, 23);
            this.bEnter.TabIndex = 6;
            this.bEnter.Text = "Enter";
            this.bEnter.UseVisualStyleBackColor = true;
            this.bEnter.Click += new System.EventHandler(this.bEnter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number of guesses:";
            // 
            // hint
            // 
            this.hint.AutoSize = true;
            this.hint.Location = new System.Drawing.Point(12, 81);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(48, 13);
            this.hint.TabIndex = 8;
            this.hint.Text = "<<hint>>";
            // 
            // numGuesses
            // 
            this.numGuesses.AutoSize = true;
            this.numGuesses.Location = new System.Drawing.Point(119, 129);
            this.numGuesses.Name = "numGuesses";
            this.numGuesses.Size = new System.Drawing.Size(13, 13);
            this.numGuesses.TabIndex = 9;
            this.numGuesses.Text = "0";
            // 
            // playAgain
            // 
            this.playAgain.Location = new System.Drawing.Point(12, 160);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(75, 23);
            this.playAgain.TabIndex = 10;
            this.playAgain.Text = "Play again";
            this.playAgain.UseVisualStyleBackColor = true;
            this.playAgain.Click += new System.EventHandler(this.playAgain_Click);
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(12, 106);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(66, 13);
            this.number.TabIndex = 11;
            this.number.Text = "<<number>>";
            // 
            // guessGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 195);
            this.Controls.Add(this.number);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.numGuesses);
            this.Controls.Add(this.hint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bEnter);
            this.Controls.Add(this.tbGuess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pickerReturn);
            this.Name = "guessGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess the Number";
            this.Load += new System.EventHandler(this.guessGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button pickerReturn;   
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGuess;
        private System.Windows.Forms.Button bEnter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hint;
        private System.Windows.Forms.Label numGuesses;
        private System.Windows.Forms.Button playAgain;
        private System.Windows.Forms.Label number;
    }
}