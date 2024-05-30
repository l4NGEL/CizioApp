using System;
using System.Windows.Forms;

namespace CizioApp
{


    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            btnGirisYap = new Button();
            btnNasilOynanir = new Button();
            btnCikisYap = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Forte", 90F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(321, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(387, 164);
            label1.TabIndex = 0;
            label1.Text = "Çizio";
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.White;
            btnGirisYap.FlatAppearance.BorderColor = Color.Chartreuse;
            btnGirisYap.FlatAppearance.BorderSize = 7;
            btnGirisYap.FlatStyle = FlatStyle.Flat;
            btnGirisYap.Font = new Font("Cascadia Code", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGirisYap.ForeColor = Color.Chartreuse;
            btnGirisYap.Location = new Point(139, 187);
            btnGirisYap.Margin = new Padding(4, 5, 4, 5);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(206, 57);
            btnGirisYap.TabIndex = 1;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // btnNasilOynanir
            // 
            btnNasilOynanir.BackColor = Color.White;
            btnNasilOynanir.FlatAppearance.BorderColor = Color.DarkOrange;
            btnNasilOynanir.FlatAppearance.BorderSize = 7;
            btnNasilOynanir.FlatStyle = FlatStyle.Flat;
            btnNasilOynanir.Font = new Font("Cascadia Code", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnNasilOynanir.ForeColor = Color.DarkOrange;
            btnNasilOynanir.Location = new Point(424, 182);
            btnNasilOynanir.Margin = new Padding(4, 5, 4, 5);
            btnNasilOynanir.Name = "btnNasilOynanir";
            btnNasilOynanir.Size = new Size(206, 62);
            btnNasilOynanir.TabIndex = 2;
            btnNasilOynanir.Text = "Nasıl Oynanır";
            btnNasilOynanir.UseVisualStyleBackColor = false;
            btnNasilOynanir.Click += btnNasilOynanir_Click;
            // 
            // btnCikisYap
            // 
            btnCikisYap.BackColor = Color.White;
            btnCikisYap.FlatAppearance.BorderColor = Color.Crimson;
            btnCikisYap.FlatAppearance.BorderSize = 7;
            btnCikisYap.FlatStyle = FlatStyle.Flat;
            btnCikisYap.Font = new Font("Cascadia Code", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCikisYap.ForeColor = Color.Crimson;
            btnCikisYap.Location = new Point(710, 178);
            btnCikisYap.Margin = new Padding(4, 5, 4, 5);
            btnCikisYap.Name = "btnCikisYap";
            btnCikisYap.Size = new Size(206, 66);
            btnCikisYap.TabIndex = 3;
            btnCikisYap.Text = "Çıkış Yap";
            btnCikisYap.UseVisualStyleBackColor = false;
            btnCikisYap.Click += btnCikisYap_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(636, 252);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(388, 387);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 217);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(914, 584);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(1024, 867);
            Controls.Add(pictureBox1);
            Controls.Add(btnCikisYap);
            Controls.Add(btnNasilOynanir);
            Controls.Add(btnGirisYap);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Çizio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Button btnNasilOynanir;
        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}