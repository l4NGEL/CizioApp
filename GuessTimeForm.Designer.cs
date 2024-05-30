namespace CizioApp
{
    partial class GuessTimeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuessTimeForm));
            label1 = new Label();
            btnSubmitGuess = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 48F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(140, 209);
            label1.Name = "label1";
            label1.Size = new Size(750, 318);
            label1.TabIndex = 2;
            label1.Text = "lütfen cihazı \r\ndiğer oyuncuya \r\n     verin\r\n";
            // 
            // btnSubmitGuess
            // 
            btnSubmitGuess.BackColor = Color.White;
            btnSubmitGuess.FlatAppearance.BorderColor = Color.Lime;
            btnSubmitGuess.FlatAppearance.BorderSize = 8;
            btnSubmitGuess.FlatStyle = FlatStyle.Flat;
            btnSubmitGuess.Font = new Font("Cascadia Code", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSubmitGuess.ForeColor = Color.Lime;
            btnSubmitGuess.Location = new Point(355, 606);
            btnSubmitGuess.Name = "btnSubmitGuess";
            btnSubmitGuess.Size = new Size(280, 86);
            btnSubmitGuess.TabIndex = 1;
            btnSubmitGuess.Text = "Hazırım";
            btnSubmitGuess.UseVisualStyleBackColor = false;
            btnSubmitGuess.Click += btnSubmitGuess_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 48F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(160, 103);
            label2.Name = "label2";
            label2.Size = new Size(656, 106);
            label2.TabIndex = 3;
            label2.Text = "Tahmin Zamanı";
            // 
            // GuessTimeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            ClientSize = new Size(987, 820);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSubmitGuess);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GuessTimeForm";
            Text = "Guess the Word";
            Load += GuessTimeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnSubmitGuess;
        private Label label2;
    }
}