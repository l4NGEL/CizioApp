using System;
using System.Drawing;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Windows.Forms;

namespace CizioApp
{
    public partial class PaintForm : Form
    {
        private Bitmap canvas;
        private Color currentColor = Color.Black;
        private string currentShape = "FreeDraw";
        private bool isDrawing = false;
        private Point startPoint, endPoint;

        private string word;
        private int player1Point;
        private int player2Point;
        private string player1Name;
        private string player2Name;



        private Label lblWord;
        private System.Windows.Forms.Timer wordTimer;
        private System.Windows.Forms.Timer drawTimer;
        private Label lblTimer;
        private int drawTimeLeft = 60;
        private int playerTurn;
        private static readonly HttpClient client = new HttpClient();

        public PaintForm(string playerName, string word, int playerTurn, int player1Point, int player2Point, string player1Name, string player2Name)
        {
            InitializeComponent();
            this.Text = $"{playerName} Çiziyor";
            this.canvas = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            this.word = word;
            this.player1Point = player1Point;
            this.player2Point = player2Point;
            this.playerTurn = playerTurn;
            this.player1Name = player1Name;
            this.player2Name = player2Name;

            lblWord = new Label();
            lblWord.Text = word;
            lblWord.Font = new Font("Arial", 15, FontStyle.Bold);
            lblWord.ForeColor = Color.Red;
            lblWord.BackColor = Color.White;
            lblWord.AutoSize = true;
            lblWord.Location = new Point(710, 20);
            this.Controls.Add(lblWord);

            wordTimer = new System.Windows.Forms.Timer();
            wordTimer.Interval = 10000;
            wordTimer.Tick += new EventHandler(WordTimer_Tick);
            wordTimer.Start();

            drawTimer = new System.Windows.Forms.Timer();
            drawTimer.Interval = 1000;
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
                ShowGuessTimeForm();
            }
        }

        private void PaintForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

            int colorButtonSize = 40;
            Button colorButton = new Button();
            colorButton.BackColor = Color.FromName("Black");
            colorButton.Size = new Size(colorButtonSize, colorButtonSize);
            colorButton.Location = new Point(10, 10);
            colorButton.Click += new EventHandler(this.ColorButton_Click);
            this.Controls.Add(colorButton);

            string[] shapes = { "FreeDraw", "Line", "Rectangle", "Ellipse", "Triangle", "Eraser" };
            for (int i = 0; i < shapes.Length; i++)
            {
                Button shapeButton = new Button();
                shapeButton.Tag = shapes[i];
                shapeButton.Text = shapes[i];
                shapeButton.Location = new Point(60 + (i * 80), 10);
                shapeButton.Size = new Size(75, 23);
                shapeButton.Click += new EventHandler(this.ShapeButton_Click);
                this.Controls.Add(shapeButton);
            }

            Button endButton = new Button();
            endButton.BackColor = Color.Red;
            endButton.Text = "Finish";
            endButton.Size = new Size(colorButtonSize + 50, colorButtonSize);
            endButton.Location = new Point(60 + (shapes.Length * 80), 10);
            endButton.Click += new EventHandler(this.EndButton_Click);
            this.Controls.Add(endButton);
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
            ColorDialog dlg = new ColorDialog();
            dlg.Color = currentColor;

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK && dlg.Color != currentColor)
            {
                currentColor = dlg.Color;
            }
            Button? button = sender as Button;
            button.BackColor = currentColor;
        }

        private void ShapeButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            currentShape = clickedButton.Tag.ToString();
        }

        private async Task<string> translate(string text)
        {

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://google-translator9.p.rapidapi.com/v2"),
                Headers =
         {
             { "x-rapidapi-key", "f812bc03famsha491e92cf972a41p12327djsnca7a41cd834b" },
             { "x-rapidapi-host", "google-translator9.p.rapidapi.com" },
         },
                Content = new StringContent("{\"q\":\"" + text + "\",\"source\":\"tr\",\"target\":\"en\",\"format\":\"text\"}")
                {
                    Headers = { ContentType = new MediaTypeHeaderValue("application/json") }
                }
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var jsonDoc = JsonDocument.Parse(body);
                var translatedText = jsonDoc.RootElement
                                            .GetProperty("data")
                                            .GetProperty("translations")[0]
                                            .GetProperty("translatedText")
                                            .GetString();

                return translatedText;
            }
        }

        private void SaveCanvas()
        {
            string filePath = "canvas.png";
            canvas.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
        }

        private async void ShowGuessTimeForm()
        {
            SaveCanvas(); // Save the canvas before showing the guess page form
            string filePath = "canvas.png";
            string mainWord = await translate(word);
            Console.WriteLine(mainWord);
            Console.WriteLine(word);
            GuessTimeForm guessTimeForm = new GuessTimeForm(mainWord, playerTurn, player1Point, player2Point, player1Name, player2Name);
            guessTimeForm.Show();
            this.Hide();
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            ShowGuessTimeForm();
        }
    }
}
