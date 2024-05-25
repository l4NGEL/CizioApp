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
            label1 = new Label();
            btnGirisYap = new Button();
            btnNasilOynanir = new Button();
            btnCikisYap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 78);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 46);
            label1.TabIndex = 0;
            label1.Text = "Çizio";
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new Point(200, 185);
            btnGirisYap.Margin = new Padding(4, 5, 4, 5);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(133, 35);
            btnGirisYap.TabIndex = 1;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // btnNasilOynanir
            // 
            btnNasilOynanir.Location = new Point(200, 246);
            btnNasilOynanir.Margin = new Padding(4, 5, 4, 5);
            btnNasilOynanir.Name = "btnNasilOynanir";
            btnNasilOynanir.Size = new Size(133, 35);
            btnNasilOynanir.TabIndex = 2;
            btnNasilOynanir.Text = "Nasıl Oynanır";
            btnNasilOynanir.UseVisualStyleBackColor = true;
            btnNasilOynanir.Click += btnNasilOynanir_Click;
            // 
            // btnCikisYap
            // 
            btnCikisYap.Location = new Point(200, 308);
            btnCikisYap.Margin = new Padding(4, 5, 4, 5);
            btnCikisYap.Name = "btnCikisYap";
            btnCikisYap.Size = new Size(133, 35);
            btnCikisYap.TabIndex = 3;
            btnCikisYap.Text = "Çıkış Yap";
            btnCikisYap.UseVisualStyleBackColor = true;
            btnCikisYap.Click += btnCikisYap_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 615);
            Controls.Add(btnCikisYap);
            Controls.Add(btnNasilOynanir);
            Controls.Add(btnGirisYap);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Çizio";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Button btnNasilOynanir;
        private System.Windows.Forms.Button btnCikisYap;
    }
}
