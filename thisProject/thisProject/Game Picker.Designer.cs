namespace thisProject
{
    partial class gamePicker
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
            this.guessForm = new System.Windows.Forms.Button();
            this.rpsForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guessForm
            // 
            this.guessForm.Location = new System.Drawing.Point(12, 12);
            this.guessForm.Name = "guessForm";
            this.guessForm.Size = new System.Drawing.Size(114, 23);
            this.guessForm.TabIndex = 0;
            this.guessForm.Text = "Guess the Number";
            this.guessForm.UseVisualStyleBackColor = true;
            this.guessForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // rpsForm
            // 
            this.rpsForm.Location = new System.Drawing.Point(12, 41);
            this.rpsForm.Name = "rpsForm";
            this.rpsForm.Size = new System.Drawing.Size(114, 23);
            this.rpsForm.TabIndex = 1;
            this.rpsForm.Text = "Rock Paper Scissors";
            this.rpsForm.UseVisualStyleBackColor = true;
            this.rpsForm.Click += new System.EventHandler(this.button2_Click);
            // 
            // gamePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 136);
            this.Controls.Add(this.rpsForm);
            this.Controls.Add(this.guessForm);
            this.Name = "gamePicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Picker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button guessForm;
        private System.Windows.Forms.Button rpsForm;
    }
}