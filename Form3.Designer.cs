namespace CizioApp
{
    partial class Form3
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
            lblCizen = new Label();
            SuspendLayout();
            // 
            // lblCizen
            // 
            lblCizen.AutoSize = true;
            lblCizen.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCizen.Location = new Point(80, 87);
            lblCizen.Margin = new Padding(4, 0, 4, 0);
            lblCizen.Name = "lblCizen";
            lblCizen.Size = new Size(75, 25);
            lblCizen.TabIndex = 0;
            lblCizen.Text = "Çizen:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 615);
            Controls.Add(lblCizen);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form3";
            Text = "Oyun Ekranı";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblCizen;
    }
}
