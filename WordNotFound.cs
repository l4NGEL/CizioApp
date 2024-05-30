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
    public partial class WordNotFound : Form
    {
        private int point;
        private int player1Point;
        private int player2Point;
        private int playerTurn;
        private string player1Name;
        private string player2Name;

        public WordNotFound()
        {
            InitializeComponent();
        }

        public WordNotFound(int point, int player1Point, int player2Point, int playerTurn, string player1Name, string player2Name)
        {
            InitializeComponent();
            this.point = point;
            this.player1Point = player1Point;
            this.player2Point = player2Point;
            this.playerTurn = playerTurn;
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        private void btnNewWord_Click(object sender, EventArgs e)
        {
            SelectWordPage selectionPage = new SelectWordPage(player1Name, player2Name, playerTurn, player1Point, player2Point);
            selectionPage.Show();
            this.Close();
        }

        private void WordNotFound_Load(object sender, EventArgs e)
        {
            if(playerTurn == 4)
            {
                PointStatusForm pointStatusForm = new PointStatusForm(player1Name, player2Name, player1Point, player2Point);
                pointStatusForm.Show();
                this.Close();
            }
        }
    }
}
