﻿namespace Cizio
{
    partial class WrongAnswerForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnSubmitGuess = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(150, 56);
            label1.Name = "label1";
            label1.Size = new Size(506, 89);
            label1.TabIndex = 2;
            label1.Text = "Wrong Answer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(290, 242);
            label2.Name = "label2";
            label2.Size = new Size(0, 35);
            label2.TabIndex = 1;
            // 
            // btnSubmitGuess
            // 
            btnSubmitGuess.BackColor = Color.White;
            btnSubmitGuess.FlatAppearance.BorderColor = Color.Lime;
            btnSubmitGuess.FlatAppearance.BorderSize = 8;
            btnSubmitGuess.FlatStyle = FlatStyle.Flat;
            btnSubmitGuess.Font = new Font("Cascadia Code", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSubmitGuess.ForeColor = Color.Lime;
            btnSubmitGuess.Location = new Point(567, 347);
            btnSubmitGuess.Name = "btnSubmitGuess";
            btnSubmitGuess.Size = new Size(155, 61);
            btnSubmitGuess.TabIndex = 3;
            btnSubmitGuess.Text = "Skor";
            btnSubmitGuess.UseVisualStyleBackColor = false;
            // 
            // WrongAnswerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(764, 450);
            Controls.Add(btnSubmitGuess);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "WrongAnswerForm";
            Text = "WrongAnswerForm";
            Load += WrongAnswerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Button btnSubmitGuess;
    }
}