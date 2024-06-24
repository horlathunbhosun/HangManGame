namespace HangMan
{
    partial class Form1
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
            lblWordToGuess = new Label();
            txtGuess = new TextBox();
            btnGuess = new Button();
            lblAttemptsLeft = new Label();
            pbHangman = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbHangman).BeginInit();
            SuspendLayout();
            // 
            // lblWordToGuess
            // 
            lblWordToGuess.AutoSize = true;
            lblWordToGuess.Location = new Point(117, 122);
            lblWordToGuess.Name = "lblWordToGuess";
            lblWordToGuess.Size = new Size(0, 15);
            lblWordToGuess.TabIndex = 0;
            lblWordToGuess.Click += label1_Click;
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(25, 233);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(100, 23);
            txtGuess.TabIndex = 1;
            // 
            // btnGuess
            // 
            btnGuess.Location = new Point(25, 276);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(75, 23);
            btnGuess.TabIndex = 2;
            btnGuess.Text = "Enter";
            btnGuess.UseVisualStyleBackColor = true;
            btnGuess.Click += btnGuess_Click;
            // 
            // lblAttemptsLeft
            // 
            lblAttemptsLeft.AutoSize = true;
            lblAttemptsLeft.Location = new Point(117, 162);
            lblAttemptsLeft.Name = "lblAttemptsLeft";
            lblAttemptsLeft.Size = new Size(0, 15);
            lblAttemptsLeft.TabIndex = 3;
            // 
            // pbHangman
            // 
            pbHangman.Location = new Point(25, 12);
            pbHangman.Name = "pbHangman";
            pbHangman.Size = new Size(100, 96);
            pbHangman.TabIndex = 4;
            pbHangman.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 122);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "Guess";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 171);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 6;
            label2.Text = "Attempts Left :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 30F);
            label3.Location = new Point(2, 387);
            label3.Name = "label3";
            label3.Size = new Size(354, 45);
            label3.TabIndex = 7;
            label3.Text = "HANGMAN GAME";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbHangman);
            Controls.Add(lblAttemptsLeft);
            Controls.Add(btnGuess);
            Controls.Add(txtGuess);
            Controls.Add(lblWordToGuess);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbHangman).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWordToGuess;
        private TextBox txtGuess;
        private Button btnGuess;
        private Label lblAttemptsLeft;
        private PictureBox pbHangman;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
