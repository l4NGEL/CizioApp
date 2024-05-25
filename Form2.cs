using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CizioApp
{
    public partial class Form2 : Form
    {
        private Dictionary<string, List<string>> categories;

        public Form2()
        {
            InitializeComponent();
            
        }

        private void btnOyunaBasla_Click(object sender, EventArgs e)
        {
            string word = txtCategory.Text; 
            PaintForm paintForm = new PaintForm("Player 1", word);
            paintForm.Show();
            this.Hide();
        }

    }
}
