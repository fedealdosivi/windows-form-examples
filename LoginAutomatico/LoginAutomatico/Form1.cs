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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                HtmlDocument doc = webBrowser1.Document;
                HtmlElement username = doc.GetElementById("txtusuario");
                HtmlElement pw = doc.GetElementById("txtclave");
                HtmlElement ingresar = doc.GetElementById("btnlogin");

                string user = "";
                string psw = "";
                user = user + "3"; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; user += "9"; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw = psw + "g"; psw += "a"; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; user += "6"; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; user += "7"; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; user += "1"; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += "t"; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += "o"; user += "5"; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += "l"; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += "o"; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; user += "7"; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += "c"; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; user += "2"; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += "o"; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += ""; psw += "";

                username.SetAttribute("value", "39671572");
                pw.SetAttribute("value", "gatoloco");
                ingresar.InvokeMember("click");
            }

            catch
            {
            }

        }
    }
}
