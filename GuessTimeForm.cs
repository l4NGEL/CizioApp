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
        private string player1Name;
        private string player2Name;
        private Bitmap canvas;




        public GuessTimeForm()
        {
            InitializeComponent();
        }

        public GuessTimeForm(string word, int playerTurn, int player1Point, int player2Point, string player1Name, string player2Name, Bitmap canvas)
        {
            InitializeComponent();
            this.word = word;
            this.playerTurn = playerTurn;
            this.player1Point = player1Point;
            this.player2Point = player2Point;
            this.player1Name = player1Name;
            this.player2Name = player2Name;
            this.canvas = canvas;
        }

        private void btnSubmitGuess_Click(object sender, EventArgs e)
        {
            string imagePath = "canvas" +playerTurn+ ".png"; // Burada dosya yolunu belirtiyoruz
            this.Hide();
            GuessPageForm guessPageForm = new GuessPageForm(imagePath, word, playerTurn, player1Point, player2Point, player1Name, player2Name, canvas);
            guessPageForm.Show();
        }

       
    }
}
