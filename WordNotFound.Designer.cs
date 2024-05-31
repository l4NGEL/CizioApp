

namespace Cizio
{
    partial class WordNotFound
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


        private void InitializeComponent()
        {
            btnNewWord = new Button();
            label2 = new Label();
            label1 = new Label();
            btnSubmitGuess = new Button();
            SuspendLayout();
            // 
            // btnNewWord
            // 
            btnNewWord.BackColor = Color.LawnGreen;
            btnNewWord.FlatAppearance.BorderColor = Color.White;
            btnNewWord.FlatAppearance.BorderSize = 4;
            btnNewWord.FlatStyle = FlatStyle.Flat;
            btnNewWord.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnNewWord.ForeColor = Color.White;
            btnNewWord.Location = new Point(298, 308);
            btnNewWord.Margin = new Padding(4, 5, 4, 5);
            btnNewWord.Name = "btnNewWord";
            btnNewWord.Size = new Size(188, 46);
            btnNewWord.TabIndex = 1;
            btnNewWord.Text = "New Word";
            btnNewWord.UseVisualStyleBackColor = false;
            btnNewWord.Click += btnNewWord_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(104, 52);
            label2.Name = "label2";
            label2.Size = new Size(584, 89);
            label2.TabIndex = 2;
            label2.Text = "Word Not Found";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(312, 198);
            label1.Name = "label1";
            label1.Size = new Size(155, 35);
            label1.TabIndex = 3;
            label1.Text = "Your point: 0";
            // 
            // btnSubmitGuess
            // 
            btnSubmitGuess.BackColor = Color.White;
            btnSubmitGuess.FlatAppearance.BorderColor = Color.Lime;
            btnSubmitGuess.FlatAppearance.BorderSize = 8;
            btnSubmitGuess.FlatStyle = FlatStyle.Flat;
            btnSubmitGuess.Font = new Font("Cascadia Code", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSubmitGuess.ForeColor = Color.Lime;
            btnSubmitGuess.Location = new Point(586, 363);
            btnSubmitGuess.Name = "btnSubmitGuess";
            btnSubmitGuess.Size = new Size(155, 61);
            btnSubmitGuess.TabIndex = 5;
            btnSubmitGuess.Text = "Skor";
            btnSubmitGuess.UseVisualStyleBackColor = false;
            btnSubmitGuess.Click += btnSubmitGuess_Click;
            // 
            // WordNotFound
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(764, 450);
            Controls.Add(btnSubmitGuess);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnNewWord);
            Name = "WordNotFound";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Button btnNewWord;
        private Button btnSubmitGuess;
    }
}