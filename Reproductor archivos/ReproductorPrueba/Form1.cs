using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReproductorPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Abrir";
            open.Filter = "All Files|*.*";
            //open.Filter = "mp3|*.mp3";
            open.AddExtension = true;

            axWindowsMediaPlayer1.uiMode = "mini";

            try
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    axWindowsMediaPlayer1.URL=(open.FileName);
                    
                }
            }              

            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message.ToString(),"Sos un boludo papa", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sos un boludo papa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                int p = 5;
                int rta = p / i;

                MessageBox.Show(System.Convert.ToString( rta));
            }
            catch(Exception exa)
            {
                MessageBox.Show(exa.Message.ToString(),"Sos un boludo?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
