using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CizioApp
{
    public partial class Form3 : Form
    {


        string foreignWord;

        public Form3(string v)
        {
            InitializeComponent();

            foreignWord = v;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblCizen.Text = foreignWord;
        }
    }
}
