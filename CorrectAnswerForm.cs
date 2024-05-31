using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cizio
{
    public partial class CorrectAnswerForm : Form
    {

        private int point;
        private int player1Point;
        private int player2Point;
        private int playerTurn;
        private string player1Name;
        private string player2Name;



        public CorrectAnswerForm()
        {
            InitializeComponent();
        }


        public CorrectAnswerForm(int point, int player1Point, int player2Point, int playerTurn, string player1Name, string player2Name)
        {
            InitializeComponent();
            this.point = point;
            this.player1Point = player1Point;
            this.player2Point = player2Point;
            this.playerTurn = playerTurn;
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        private void CorrectAnswerForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Your point: " + point;
        }

        private void btnNewWord_Click(object sender, EventArgs e)
        {
            SelectWordPage selectForm = new SelectWordPage(player1Name, player2Name, playerTurn, player1Point, player2Point);
            selectForm.Show();
            this.Close();
        }

        private void btnSubmitGuess_Click(object sender, EventArgs e)
        {
            PointStatusForm pointStatus = new PointStatusForm(player1Name, player2Name, player1Point, player2Point);
            pointStatus.Show();
        }
    }
}
