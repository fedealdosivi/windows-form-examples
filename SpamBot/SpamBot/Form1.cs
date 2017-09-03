using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpamBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;//Al tocar iniciar arranca a ejecutarse el codigo del timer
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;//Al tocar parar el timer deja de ejecutarse
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Manda el texto que hay en el textbox

            try
            {
                SendKeys.Send(txbSpamText.Text);
                SendKeys.Send("{Enter}");
            }
            catch
            {
                throw new Exception();
            }

        }
    }
}
