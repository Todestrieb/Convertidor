using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertidor
{
    class tipoCambio
    {


        public double conversionPesoADolar(string peso, string cambio) 
        {
            DialogResult mensaje;
            double pesoConvertido;
            double cambioConvertido;

            

            if (peso != "" && cambio != "")
            {
                if (peso != "0" && cambio != "0")
                {
                    if (Double.TryParse(peso, out pesoConvertido) && Double.TryParse(cambio, out cambioConvertido))
                    {
                        return pesoConvertido / cambioConvertido;
                    }
                    else
                    {
                        mensaje = MessageBox.Show("Valores inválidos");
                        return 0;
                    }
                }
                else
                {
                       
                    mensaje = MessageBox.Show("Valores en cero");
                    return 0;
                }
            }
            else
            {
                mensaje = MessageBox.Show("Campos vacíos");
                return 0;
            }
       
        }
    }
}

