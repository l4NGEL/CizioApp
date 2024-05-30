
namespace CizioApp
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnOyunaBasla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.TextBox txtPlayer2;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            btnOyunaBasla = new Button();
            label1 = new Label();
            label2 = new Label();
            txtPlayer1 = new TextBox();
            txtPlayer2 = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnOyunaBasla
            // 
            btnOyunaBasla.BackColor = Color.LawnGreen;
            btnOyunaBasla.FlatAppearance.BorderColor = Color.White;
            btnOyunaBasla.FlatAppearance.BorderSize = 4;
            btnOyunaBasla.FlatStyle = FlatStyle.Flat;
            btnOyunaBasla.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOyunaBasla.ForeColor = Color.White;
            btnOyunaBasla.Location = new Point(391, 683);
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
            label1.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(176, 527);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 27);
            label1.TabIndex = 2;
            label1.Text = "Player 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(670, 527);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 27);
            label2.TabIndex = 3;
            label2.Text = "Player 2:";
            // 
            // txtPlayer1
            // 
            txtPlayer1.Location = new Point(102, 588);
            txtPlayer1.Margin = new Padding(4, 5, 4, 5);
            txtPlayer1.Name = "txtPlayer1";
            txtPlayer1.Size = new Size(265, 27);
            txtPlayer1.TabIndex = 5;
            // 
            // txtPlayer2
            // 
            txtPlayer2.Location = new Point(601, 588);
            txtPlayer2.Margin = new Padding(4, 5, 4, 5);
            txtPlayer2.Name = "txtPlayer2";
            txtPlayer2.Size = new Size(265, 27);
            txtPlayer2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.LawnGreen;
            label5.Location = new Point(-133, 28);
            label5.Name = "label5";
            label5.Size = new Size(818, 178);
            label5.TabIndex = 9;
            label5.Text = "              Oyun \r\n            Ayarları";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(113, 235);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 280);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(601, 244);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(271, 282);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.FlatAppearance.BorderColor = Color.Indigo;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cascadia Code", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(303, 448);
            button1.Name = "button1";
            button1.Size = new Size(46, 50);
            button1.TabIndex = 12;
            button1.Text = "↓";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Indigo;
            button2.FlatAppearance.BorderColor = Color.Indigo;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cascadia Code", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(788, 448);
            button2.Name = "button2";
            button2.Size = new Size(46, 50);
            button2.TabIndex = 13;
            button2.Text = "↓";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(958, 867);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(txtPlayer2);
            Controls.Add(txtPlayer1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOyunaBasla);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
    }
}