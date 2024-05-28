namespace CizioApp
{
    partial class FormHowToPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHowToPlay));
            labelInstructions = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // labelInstructions
            // 
            labelInstructions.AutoSize = true;
            labelInstructions.Font = new Font("Cascadia Code", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInstructions.ForeColor = Color.Yellow;
            labelInstructions.Location = new Point(50, 39);
            labelInstructions.Margin = new Padding(4, 0, 4, 0);
            labelInstructions.Name = "labelInstructions";
            labelInstructions.Size = new Size(308, 32);
            labelInstructions.TabIndex = 0;
            labelInstructions.Text = "Çizio Nasıl Oynanır ?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 81);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(704, 357);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(582, 402);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(432, 406);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(231, 388);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(523, 430);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // FormHowToPlay
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(1006, 820);
            Controls.Add(label1);
            Controls.Add(labelInstructions);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormHowToPlay";
            Text = "Nasıl Oynanır";
            Load += FormHowToPlay_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelInstructions;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
