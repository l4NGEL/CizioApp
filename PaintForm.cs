using System;
using System.Drawing;
using System.Windows.Forms;

namespace CizioApp
{
    public partial class PaintForm : Form
    {
        private Bitmap canvas;
        private Color currentColor = Color.Black;
        private string currentShape = "FreeDraw"; // Varsayılan olarak serbest çizim
        private bool isDrawing = false;
        private Point startPoint, endPoint;

        private string word;
        private Label lblWord;
        private System.Windows.Forms.Timer wordTimer;
        private System.Windows.Forms.Timer drawTimer;
        private Label lblTimer;
        private int drawTimeLeft = 60; // 60 saniye

        public PaintForm(string playerName, string word)
        {
            InitializeComponent();
            this.Text = $"{playerName} Çiziyor";
            this.canvas = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            this.word = word;

            lblWord = new Label();
            lblWord.Text = word;
            lblWord.Font = new Font("Arial", 24, FontStyle.Bold); // Font size updated for better visibility
            lblWord.ForeColor = Color.Red; // Color updated for better visibility
            lblWord.BackColor = Color.White;
            lblWord.AutoSize = true;
            lblWord.Location = new Point(this.ClientSize.Width - lblWord.Width - 10, this.ClientSize.Height - lblWord.Height - 10);
            this.Controls.Add(lblWord);

            wordTimer = new System.Windows.Forms.Timer();
            wordTimer.Interval = 10000; // 10 saniye
            wordTimer.Tick += new EventHandler(WordTimer_Tick);
            wordTimer.Start();

            drawTimer = new System.Windows.Forms.Timer();
            drawTimer.Interval = 1000; // 1 saniye
            drawTimer.Tick += new EventHandler(DrawTimer_Tick);
            drawTimer.Start();

            lblTimer = new Label();
            lblTimer.Font = new Font("Arial", 16, FontStyle.Bold);
            lblTimer.Location = new Point(this.ClientSize.Width - 100, 10);
            lblTimer.Text = drawTimeLeft.ToString();
            this.Controls.Add(lblTimer);
        }

        private void WordTimer_Tick(object sender, EventArgs e)
        {
            lblWord.Visible = false;
            wordTimer.Stop();
        }

        private void DrawTimer_Tick(object sender, EventArgs e)
        {
            drawTimeLeft--;
            lblTimer.Text = drawTimeLeft.ToString();
            if (drawTimeLeft <= 0)
            {
                drawTimer.Stop();
                MessageBox.Show("Süre doldu!");
                this.Close();
            }
        }

        private void PaintForm_Load(object sender, EventArgs e)
        {
            string[] colors = { "Black", "Red", "Green", "Blue", "Yellow", "Orange", "Purple", "Brown", "Pink", "Gray", "Cyan", "Magenta" };
            int colorButtonSize = 40;
            for (int i = 0; i < colors.Length; i++)
            {
                Button colorButton = new Button();
                colorButton.BackColor = Color.FromName(colors[i]);
                colorButton.Size = new Size(colorButtonSize, colorButtonSize);
                colorButton.Location = new Point(10 + (i % 6) * (colorButtonSize + 10), 10 + (i / 6) * (colorButtonSize + 10));
                colorButton.Click += new EventHandler(this.ColorButton_Click);
                this.Controls.Add(colorButton);
            }

            string[] shapes = { "FreeDraw", "Line", "Rectangle", "Ellipse", "Triangle", "Eraser" };
            for (int i = 0; i < shapes.Length; i++)
            {
                Button shapeButton = new Button();
                shapeButton.Tag = shapes[i];
                shapeButton.Text = shapes[i];
                shapeButton.Location = new Point(10 + (i * 80), 2 * (colorButtonSize + 10) + 20);
                shapeButton.Size = new Size(75, 23);
                shapeButton.Click += new EventHandler(this.ShapeButton_Click);
                this.Controls.Add(shapeButton);
            }
        }

        private void PaintForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startPoint = e.Location;
            }
        }

        private void PaintForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                endPoint = e.Location;
                if (currentShape == "Eraser")
                {
                    using (Graphics g = Graphics.FromImage(canvas))
                    {
                        g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                        using (Brush eraser = new SolidBrush(Color.White))
                        {
                            g.FillEllipse(eraser, endPoint.X - 10, endPoint.Y - 10, 20, 20);
                        }
                    }
                }
                else if (currentShape == "FreeDraw")
                {
                    using (Graphics g = Graphics.FromImage(canvas))
                    {
                        using (Pen pen = new Pen(currentColor, 2))
                        {
                            g.DrawLine(pen, startPoint, endPoint);
                        }
                        startPoint = endPoint;
                    }
                }
                this.Invalidate();
            }
        }

        private void PaintForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
                endPoint = e.Location;
                if (currentShape != "Eraser" && currentShape != "FreeDraw")
                {
                    using (Graphics g = Graphics.FromImage(canvas))
                    {
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        using (Pen pen = new Pen(currentColor, 2))
                        {
                            DrawCurrentShape(g, pen);
                        }
                    }
                }
                this.Invalidate();
            }
        }

        private void PaintForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(canvas, Point.Empty);
            if (isDrawing && currentShape != "Eraser" && currentShape != "FreeDraw")
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(currentColor, 2))
                {
                    DrawCurrentShape(e.Graphics, pen);
                }
            }
        }

        private void DrawCurrentShape(Graphics g, Pen pen)
        {
            switch (currentShape)
            {
                case "Line":
                    g.DrawLine(pen, startPoint, endPoint);
                    break;
                case "Rectangle":
                    g.DrawRectangle(pen, GetRectangle(startPoint, endPoint));
                    break;
                case "Ellipse":
                    g.DrawEllipse(pen, GetRectangle(startPoint, endPoint));
                    break;
                case "Triangle":
                    DrawTriangle(g, pen, startPoint, endPoint);
                    break;
            }
        }

        private void DrawTriangle(Graphics g, Pen pen, Point p1, Point p2)
        {
            Point p3 = new Point(p1.X + ((p2.X - p1.X) / 2), p1.Y - (p2.Y - p1.Y));
            Point[] points = { p1, p2, p3 };
            g.DrawPolygon(pen, points);
        }

        private Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle(
                Math.Min(p1.X, p2.X),
                Math.Min(p1.Y, p2.Y),
                Math.Abs(p1.X - p2.X),
                Math.Abs(p1.Y - p2.Y));
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            currentColor = button.BackColor;
        }

        private void ShapeButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            currentShape = button.Tag.ToString();
        }
    }
}
