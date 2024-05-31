
namespace Cizio
{
    partial class CorrectAnswerForm
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


        public void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            btnNewWord = new Button();
            btnSubmitGuess = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.LawnGreen;
            label2.Location = new Point(123, 56);
            label2.Name = "label2";
            label2.Size = new Size(584, 89);
            label2.TabIndex = 0;
            label2.Text = "Correct Answer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(340, 242);
            label1.Name = "label1";
            label1.Size = new Size(0, 35);
            label1.TabIndex = 1;
            // 
            // btnNewWord
            // 
            btnNewWord.BackColor = Color.LawnGreen;
            btnNewWord.FlatAppearance.BorderColor = Color.White;
            btnNewWord.FlatAppearance.BorderSize = 4;
            btnNewWord.FlatStyle = FlatStyle.Flat;
            btnNewWord.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnNewWord.ForeColor = Color.White;
            btnNewWord.Location = new Point(321, 322);
            btnNewWord.Margin = new Padding(4, 5, 4, 5);
            btnNewWord.Name = "btnNewWord";
            btnNewWord.Size = new Size(188, 46);
            btnNewWord.TabIndex = 1;
            btnNewWord.Text = "New Word";
            btnNewWord.UseVisualStyleBackColor = false;
            btnNewWord.Click += btnNewWord_Click;
            // 
            // btnSubmitGuess
            // 
            btnSubmitGuess.BackColor = Color.White;
            btnSubmitGuess.FlatAppearance.BorderColor = Color.LimeGreen;
            btnSubmitGuess.FlatAppearance.BorderSize = 8;
            btnSubmitGuess.FlatStyle = FlatStyle.Flat;
            btnSubmitGuess.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSubmitGuess.ForeColor = Color.LimeGreen;
            btnSubmitGuess.Location = new Point(653, 369);
            btnSubmitGuess.Name = "btnSubmitGuess";
            btnSubmitGuess.Size = new Size(155, 61);
            btnSubmitGuess.TabIndex = 4;
            btnSubmitGuess.Text = "Skor";
            btnSubmitGuess.UseVisualStyleBackColor = false;
            btnSubmitGuess.Click += btnSubmitGuess_Click;
            // 
            // CorrectAnswerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(820, 442);
            Controls.Add(btnSubmitGuess);
            Controls.Add(btnNewWord);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "CorrectAnswerForm";
            Load += CorrectAnswerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label2;
        private Label label1;
        private Button btnNewWord;
        private Button btnSubmitGuess;
    }
}