using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MenuCreacionFormsDinamicos
{
    public partial class Form1 : Form
    {
        int left = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                left = CreateTxt(left);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        private void buttonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                left = CreateButtn(left);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private int CreateTxt(int left)
        {
            TextBox txt = new TextBox();
            this.Controls.Add(txt);
            txt.Top = left * 25;
            txt.Left = 100;
            txt.Text = "TextBox" + txt.Left.ToString();
            left = left + 1;
            return left;
        }

        private int CreateButtn(int left)
        {
            Button btn = new Button();
            this.Controls.Add(btn);
            btn.Top = left * 25;
            btn.Left = 100;
            btn.Text = "Button" + btn.Left.ToString();
            left = left + 1;
            return left;
        }
    }
}
