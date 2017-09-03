using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CambiarColor
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

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();


            try
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string selected = null;
                    selected = dialog.Color.Name;
                    MessageBox.Show("Color seleccionado:"+ selected);

                    this.BackColor = dialog.Color;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        
        }

        private void btnCambiarFuente_Click(object sender, EventArgs e)
        {
            FontDialog fdialog=new FontDialog();

            try
            {
                if (fdialog.ShowDialog() == DialogResult.OK)
                {
                    string font = fdialog.Font.Name;
                    float fontSize = fdialog.Font.Size;
                    string style =System.Convert.ToString( fdialog.Font.Style);

                    MessageBox.Show("Usted selecciono: "+ font +" Tamaño: "+ fontSize + "Estilo: " + style);

                    this.Font = fdialog.Font;
                    btnCambiar.Font = fdialog.Font;
                    btnCambiarFuente.Font = fdialog.Font;
                    btnImprimir.Font = fdialog.Font;

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDialog pdialog = new PrintDialog();

            try
            {
                if (pdialog.ShowDialog() == DialogResult.OK)
                {

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
