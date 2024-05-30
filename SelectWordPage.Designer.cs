using CizioApp;
using System.Reflection.Emit;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace Cizio
{
    partial class SelectWordPage
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
            text = new TextBox();
            btnOyunaBasla = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // text
            // 
            text.Location = new Point(329, 244);
            text.Margin = new Padding(4, 5, 4, 5);
            text.Name = "text";
            text.Size = new Size(265, 27);
            text.TabIndex = 5;
            // 
            // btnOyunaBasla
            // 
            btnOyunaBasla.BackColor = Color.LawnGreen;
            btnOyunaBasla.FlatAppearance.BorderColor = Color.White;
            btnOyunaBasla.FlatAppearance.BorderSize = 4;
            btnOyunaBasla.FlatStyle = FlatStyle.Flat;
            btnOyunaBasla.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOyunaBasla.ForeColor = Color.White;
            btnOyunaBasla.Location = new Point(363, 360);
            btnOyunaBasla.Margin = new Padding(4, 5, 4, 5);
            btnOyunaBasla.Name = "btnOyunaBasla";
            btnOyunaBasla.Size = new Size(188, 46);
            btnOyunaBasla.TabIndex = 1;
            btnOyunaBasla.Text = "Oyuna Başla";
            btnOyunaBasla.UseVisualStyleBackColor = false;
            btnOyunaBasla.Click += btnOyunaBasla_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.LawnGreen;
            label1.Location = new Point(242, 69);
            label1.Name = "label1";
            label1.Size = new Size(428, 89);
            label1.TabIndex = 9;
            label1.Text = "Kelime Gir";
            // 
            // SelectWordPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(935, 500);
            Controls.Add(label1);
            Controls.Add(text);
            Controls.Add(btnOyunaBasla);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SelectWordPage";
            Text = "Form2";
            Load += SelectWordPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnOyunaBasla_Click(object sender, EventArgs e)
        {
            PaintForm paintForm = new PaintForm(drawingPlayer, text.Text, playerTurn, player1Point, player2Point, player1Name, player2Name);
            paintForm.Show();
            this.Hide();
        }

        private TextBox text;
        private Button btnOyunaBasla;
        private Label label1;
    }
}