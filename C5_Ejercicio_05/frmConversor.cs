using C5_Entidades_05;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C5_Ejercicio_05
{
    public partial class frmConversor : Form
    {
        public frmConversor()
        {
            InitializeComponent();
        }

        private void btnBinarioADecimal_Click(object sender, EventArgs e)
        {
            string binarioConvertidoADecimal;
            bool resultadoConversion = this.ConvertirNumero(this.txtBinarioAConvert, out binarioConvertidoADecimal);

            if (resultadoConversion)
            {
                this.txtBinarioADecimal.Text = binarioConvertidoADecimal;
            } else
            {
                this.txtBinarioAConvert.Text = "ERROR";
            }
        }

        private void btnDecimalABinario_Click(object sender, EventArgs e)
        {
            string decimalConvertidoABinario;
            bool resultadoConversion = this.ConvertirNumero(this.txtDecimalAConvert, out decimalConvertidoABinario, false);

            if (resultadoConversion)
            {
                this.txtDecimalABinario.Text = decimalConvertidoABinario;
            }
            else
            {
                this.txtDecimalAConvert.Text = "ERROR";
            }
        }

        private bool ConvertirNumero(TextBox txtNumero, out string numero, bool esUnBinario = true)
        {
            double numeroIntroducido;
            bool numeroValido = double.TryParse(txtNumero.Text, out numeroIntroducido);
            bool retorno = false;
            numero = "";

            if (numeroValido && numeroIntroducido - Math.Floor(numeroIntroducido) == 0) //si es un número double, y además no tiene decimales
            {
                retorno = true;
                if (esUnBinario)
                {
                    numero = Conversor.ConvertirBinarioADecimal(numeroIntroducido).ToString();
                    if (numero.CompareTo("-1") == 0)
                    {
                        retorno = false;
                    }
                } else
                {
                    numero = Conversor.ConvertirDecimalABinario(numeroIntroducido);
                }
            }

            return retorno;
        }
    }
}
