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
            this.lblCizen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCizen
            // 
            this.lblCizen.AutoSize = true;
            this.lblCizen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCizen.Location = new System.Drawing.Point(50, 50);
            this.lblCizen.Name = "lblCizen";
            this.lblCizen.Size = new System.Drawing.Size(52, 20);
            this.lblCizen.TabIndex = 0;
            this.lblCizen.Text = "Çizen:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.lblCizen);
            this.Name = "Form3";
            this.Text = "Oyun Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblCizen;
    }
}
