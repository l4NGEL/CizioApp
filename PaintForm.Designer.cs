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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintForm));
            SuspendLayout();
            // 
            // PaintForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 820);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "PaintForm";
            Text = "Paint Ekranı";
            Load += PaintForm_Load;
            Paint += PaintForm_Paint;
            MouseDown += PaintForm_MouseDown;
            MouseMove += PaintForm_MouseMove;
            MouseUp += PaintForm_MouseUp;
            ResumeLayout(false);
        }
    }
}
