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

        public CorrectAnswerForm()
        {
            InitializeComponent();
        }


        public CorrectAnswerForm(int point)
        {
            InitializeComponent();
            this.point = point;
        }

        private void CorrectAnswerForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Your point: " + point;
        }

        private void btnNewWord_Click(object sender, EventArgs e)
        {
            SelectWordPage selectForm = new SelectWordPage();
            selectForm.Show();
            this.Close();
        }
    }
}
