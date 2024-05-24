using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CizioApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnStartPaint_Click(object sender, EventArgs e)
        {
            // Rastgele bir kelime seçimi
            List<string> words = new List<string> { "Kedi", "Köpek", "Aslan", "Kaplan", "Kalem", "Bilgisayar", "Masa", "Sandalye", "Doktor", "Mühendis", "Öğretmen", "Polis", "Pizza", "Hamburger", "Makarna", "Salata" };
            Random rand = new Random();
            string selectedWord = words[rand.Next(words.Count)];

            PaintForm paintForm = new PaintForm("Player 1", selectedWord);
            paintForm.Show();
            this.Hide();
        }
    }
}
