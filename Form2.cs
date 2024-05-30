using Cizio;

namespace CizioApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOyunaBasla_Click(object sender, EventArgs e)
        {
            string player1Name = txtPlayer1.Text;
            string player2Name = txtPlayer2.Text;


            SelectWordPage selectForm = new SelectWordPage(player1Name, player2Name);
            selectForm.Show();
            this.Hide();
        }

       
    }
}
