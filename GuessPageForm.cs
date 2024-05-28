using System;
using System.Drawing;
using System.Windows.Forms;

namespace CizioApp
{
    public partial class GuessPageForm : Form
    {
        private string imagePath;

        public GuessPageForm(string imagePath)
        {
            InitializeComponent();
            this.imagePath = imagePath;
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

        private void BtnSubmitGuess_Click(object sender, EventArgs e)
        {
            string guess = txtGuess.Text;
            // Process guess here
            MessageBox.Show($"Your guess: {guess}");
        }
    }
}
