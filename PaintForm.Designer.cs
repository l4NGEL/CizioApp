namespace CizioApp
{
    partial class PaintForm
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
            this.SuspendLayout();
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Name = "PaintForm";
            this.Text = "Paint Ekranı";
            this.Load += new System.EventHandler(this.PaintForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PaintForm_MouseUp);
            this.ResumeLayout(false);

        }
    }
}
