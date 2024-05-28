using System;
using System.Windows.Forms;

namespace CizioApp
{
    public partial class GuessTimeForm : Form
    {
        public GuessTimeForm()
        {
            InitializeComponent();
        }

        private void btnSubmitGuess_Click(object sender, EventArgs e)
        {
            string imagePath = "canvas.png"; // Burada dosya yolunu belirtiyoruz
            this.Hide();
            GuessPageForm guessPageForm = new GuessPageForm(imagePath);
            guessPageForm.Show();
        }

        private void GuessTimeForm_Load(object sender, EventArgs e)
        {
        }
    }
}
