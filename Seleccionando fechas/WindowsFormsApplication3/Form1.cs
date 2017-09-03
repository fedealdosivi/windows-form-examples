using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        DateTime DiaSeleccionado;
        DateTime DiaSeleccionado2;
        List<DateTime> listaDeDias;
        

        public List<DateTime> ListaDeDias
        {
            get { return listaDeDias; }
            set { listaDeDias = value; }
        }

        public DateTime DiaSeleccionado21
        {
            get { return DiaSeleccionado2; }
            set { DiaSeleccionado2 = value; }
        }

        public DateTime DiaSeleccionado1
        {
            get { return DiaSeleccionado; }
            set { DiaSeleccionado = value; }
        }

        public Form1()
        {
            InitializeComponent();
            DiaSeleccionado = new DateTime();
            listaDeDias = new List<DateTime>();

            monthCalendar1.MaxSelectionCount = 60;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Comparo las dos fechas pasadas por parametros

        private int compararFechas(DateTime fecha1, DateTime fecha2)
        {
            int rta = 0;

            if (fecha1.Date.Equals(fecha2.Date))
            {
                rta = 1;
            }

            return rta;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //le asigno la fecha a las variables de tipo DateTime
            DiaSeleccionado = dateTimePicker1.Value;
            DiaSeleccionado2 = dateTimePicker2.Value;

            //Paso la fecha1 a string para printearla en un mensaje
            string linea = DiaSeleccionado.ToString();

            MessageBox.Show("El dia seleccionado aparece en el nombre de la ventana porque estoy re loco", linea);
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            //Invoca la funcion para comparar
            int rta = compararFechas(DiaSeleccionado, DiaSeleccionado2);

            if (rta == 1)
                MessageBox.Show("Las fechas son iguales");
            else
                MessageBox.Show("Las fechas son distintas");

            
        }

        private void btnAceptarMonth_Click(object sender, EventArgs e)
        {

            DateTime firstDay = new DateTime();
            DateTime lastDay = new DateTime();

            firstDay = monthCalendar1.SelectionStart;
            lastDay = monthCalendar1.SelectionEnd;
            string printeo="";
            List<DateTime> listaDiaspapa=new List<DateTime>();

            while (firstDay <= lastDay)
            {
                printeo =printeo + firstDay.ToShortDateString();
                listaDiaspapa.Add(firstDay);
                firstDay = firstDay.AddDays(1);
            }

            listBox1.DataSource = null;
            listBox1.DataSource = listaDiaspapa;

            MessageBox.Show(printeo);


            /*
            string seleccion;
            seleccion = monthCalendar1.SelectionRange.End.ToShortDateString();
            MessageBox.Show(seleccion);
            /*DateTime dia1 = new DateTime();
            int i=0;

            while(i<monthCalendar1.s)
            {

            }

            listaDeDias.Add(dia1.Date);*/
        }

        private void btnACEPTARORA_Click(object sender, EventArgs e)
        {
            DateTime hora = DateTime.Today;
            
            

            DateTime horaseleccionada = new DateTime();
            horaseleccionada = Convert.ToDateTime(cmbHora.Text);
            //horaseleccionada = DateTime.ParseExact(cmbHora.Text, "d", null);

            string printeo = horaseleccionada.ToShortTimeString();
            string printeo2 = hora.ToShortTimeString();

            if (hora.Minute < horaseleccionada.Hour)
            {
                MessageBox.Show("Llegaste tarde");
                MessageBox.Show(printeo);
                MessageBox.Show(printeo2);

            }
            else
            {
                MessageBox.Show("bien");
            }
        }
    }
}
