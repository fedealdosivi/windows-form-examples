using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginAutomatico
{
    public partial class LOGEO : Form
    {

        string txtusuario;

        public string Txtusuario
        {
            get { return txtusuario; }
            set { txtusuario = value; }
        }
        string txtpw;

        public string Txtpw
        {
            get { return txtpw; }
            set { txtpw = value; }
        }

        public LOGEO()
        {
            InitializeComponent();           
        }

        private void LOGEO_Load(object sender, EventArgs e)
        {
            if (txbUsuario.Text != "" && txbContrasenia.Text != "")
            {
                txtpw = txbContrasenia.Text;
                txtusuario = txbUsuario.Text;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jodete pelotudo");
        }
    }
}
