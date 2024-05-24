using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CizioApp
{
    public partial class Form2 : Form
    {
        private Dictionary<string, List<string>> categories;

        public Form2()
        {
            InitializeComponent();
            categories = new Dictionary<string, List<string>>()
            {
                { "Hayvanlar", new List<string> { "Kedi", "Köpek", "Aslan", "Kaplan" } },
                { "Eşyalar", new List<string> { "Kalem", "Bilgisayar", "Masa", "Sandalye" } },
                { "Meslekler", new List<string> { "Doktor", "Mühendis", "Öğretmen", "Polis" } },
                { "Yemekler", new List<string> { "Pizza", "Hamburger", "Makarna", "Salata" } }
            };

            cmbCategories.Items.AddRange(new object[] { "Hayvanlar", "Eşyalar", "Meslekler", "Yemekler" });
            cmbCategories.SelectedIndex = 0; // Varsayılan olarak ilk kategoriyi seç
        }

        private void btnOyunaBasla_Click(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategories.SelectedItem.ToString();
            string word = GetRandomWord(selectedCategory);

            PaintForm paintForm = new PaintForm("Player 1", word);
            paintForm.Show();
            this.Hide();
        }

        private string GetRandomWord(string category)
        {
            return categories[category][new Random().Next(categories[category].Count)];
        }
    }
}
