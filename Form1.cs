using System;
using System.Windows.Forms;

namespace CizioApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            Form2 girisFormu = new Form2();
            girisFormu.Show();
            this.Hide();
        }

        private void btnNasilOynanir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nas�l Oynan�r bilgileri burada g�sterilecek.", "Nas�l Oynan�r");
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
