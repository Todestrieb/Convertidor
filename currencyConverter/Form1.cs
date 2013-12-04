using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertidor
{
    public partial class currencyConverter : Form
    {
        public currencyConverter()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tipoCambio conversor = new tipoCambio();

            string resultado = Convert.ToString(conversor.conversionPesoADolar(pesosForma.Text.Trim(), tipoCambioForma.Text.Trim()));

            if (resultado.ToString().Length > 15)
                resultado = resultado.Substring(0, 15);

            dolaresForma.Text = resultado;
        }

        private void currencyConverter_Load(object sender, EventArgs e)
        {

        }
    }
}
