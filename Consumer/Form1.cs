using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consumer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cliente = new ServiceReference1.WebService1SoapClient();
            int dia = dateTimePicker1.Value.Day;
            int mes = dateTimePicker1.Value.Month;
            string resultado = cliente.Datos(dia, mes);
            label1.Text = resultado;
        }
    }
}
