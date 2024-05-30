using System;
using System.Windows.Forms;

namespace CizioApp
{
    public partial class GuessTimeForm : Form
    {

        private string word;
        private int playerTurn;
        private int player1Point;
        private int player2Point;


        public GuessTimeForm()
        {
            InitializeComponent();
        }

        public GuessTimeForm(string word, int playerTurn, int player1Point, int player2Point)
        {
            InitializeComponent();
            this.word = word;
            this.playerTurn = playerTurn;
            this.player1Point = player1Point;
            this.player2Point = player2Point;
        }

        private void btnSubmitGuess_Click(object sender, EventArgs e)
        {
            string imagePath = "canvas.png"; // Burada dosya yolunu belirtiyoruz
            this.Hide();
            GuessPageForm guessPageForm = new GuessPageForm(imagePath, word, playerTurn, player1Point, player2Point);
            guessPageForm.Show();
        }

        private void GuessTimeForm_Load(object sender, EventArgs e)
        {
        }
    }
}
