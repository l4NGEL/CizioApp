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

    public partial class SelectWordPage : Form
    {
        private string player1Name;
        private string player2Name;
        private string drawingPlayer;
        private int playerTurn = 0;
        private int player1Point = 0, player2Point = 0;

        public SelectWordPage()
        {
            InitializeComponent();
        }

        public SelectWordPage(string player1Name, string player2Name)
        {
            InitializeComponent();
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public SelectWordPage(string player1Name, string player2Name, int playerTurn, int player1Point, int player2Point)
        {
            InitializeComponent();
            this.player1Name = player1Name;
            this.player2Name = player2Name;
            this.playerTurn = playerTurn;
            this.player1Point = player1Point;
            this.player2Point = player2Point;
        }

        private void SelectWordPage_Load(object sender, EventArgs e)
        {
            if(playerTurn%2 == 0)
            {
                drawingPlayer = player1Name;
            }else
            {
                drawingPlayer = player2Name;
            }
        }
    }
}
