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
    public partial class WrongAnswerForm : Form
    {
        private int point;


        public WrongAnswerForm()
        {
            InitializeComponent();


        }

        public WrongAnswerForm(int point)
        {
            InitializeComponent();
            this.point = point;
            timer1.Tick += Timer_Tick;
            timer1.Interval = 750;
            timer1.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //Bu kısımda 45 dakikada hangi işlemlerin tekrar etmesini istiyorsam o işlemleri yazıyoruz. 
            timer1.Stop();
            // Timer tetiklendiğinde yapılacak işlemler buraya yazılır
            this.Close();
        }

        private void WrongAnswerForm_Load(object sender, EventArgs e)
        {
            label2.Text = "Your point: -" + (10 - point);
        }

       
    }
}
