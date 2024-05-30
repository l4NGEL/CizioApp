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
    public partial class PointStatusForm : Form
    {
        private string player1Name;
        private string player2Name;
        private int player1Point;
        private int player2Point;

        public PointStatusForm()
        {
            InitializeComponent();
        }

        public PointStatusForm(string player1Name, string player2Name, int player1Point, int player2Point)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
            this.player1Point = player1Point;
            this.player2Point = player2Point;
        }

        private void btnNewWord_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PointStatusForm_Load(object sender, EventArgs e)
        {
            label2.Text = player1Name;
            label3.Text = player2Name;
            label4.Text = player1Point.ToString();
            label5.Text = player2Point.ToString();
        }
    }
}
