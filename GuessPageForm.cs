using Cizio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CizioApp
{
    public partial class GuessPageForm : Form
    {
        private string imagePath;
        private string word;
        private int playerTurn;
        private int player1Point;
        private int player2Point;


        public GuessPageForm(string imagePath, string word, int playerTurn, int player1Point, int player2Point)
        {
            InitializeComponent();
            this.imagePath = imagePath;
            this.word = word;
            this.playerTurn = playerTurn;
            this.player1Point = player1Point;
            this.player2Point = player2Point;
            LoadImage();
        }

        private void LoadImage()
        {
            if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
            {
                pictureBox.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("Image not found or invalid path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int point = 10;

        private void BtnSubmitGuess_Click(object sender, EventArgs e)
        {
            string guess = txtGuess.Text;

            txtGuess.Text = "";
            // Process guess here

            


            if (word == guess)
            {
                if (playerTurn % 2 == 0)
                {
                    player1Point += point;
                }
                else
                {
                    player2Point += point;
                }

                CorrectAnswerForm correctAnswerForm = new CorrectAnswerForm(point);
                correctAnswerForm.Show();
            }
            else
            {
                point -= 2;
                if(point > 4)
                {
                    WrongAnswerForm wrongAnswerForm = new WrongAnswerForm(point);
                    wrongAnswerForm.Show();
                }
                else
                {
                    WordNotFound wordNotFoundPage = new WordNotFound();
                    wordNotFoundPage.Show();
                    this.Close();
                }
                
            }
        }
    }
}
