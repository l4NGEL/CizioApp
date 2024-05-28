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
            
            string word = txtCategory.Text;

            PaintForm paintForm = new PaintForm(player1Name, word);
            paintForm.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
