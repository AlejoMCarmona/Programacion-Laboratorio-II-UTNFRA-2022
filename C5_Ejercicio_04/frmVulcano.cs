using C5_Entidades_04;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C5_Ejercicio_04
{
    public partial class frmVulcano : Form
    {
        public frmVulcano()
        {
            InitializeComponent();
        }

        //TODO: preguntar si habia forma de hacer esto sin repetir código
        private void btnConvertFahrenheit_Click(object sender, EventArgs e)
        {
            double temperaturaFahrenheit;
            bool valida = double.TryParse(this.txtFahrenheit.Text, out temperaturaFahrenheit);
            Fahrenheit fahrenheit;

            if (valida)
            {
                fahrenheit = new Fahrenheit(temperaturaFahrenheit);
                this.txtFahrenheitaAFahrenheit.Text = temperaturaFahrenheit.ToString();
                this.txtFahrenheitACelsius.Text = Math.Round(((Celsius)fahrenheit).Temperatura, 4).ToString(); 
                this.txtFahrenheitAKelvin.Text = Math.Round(((Kelvin)fahrenheit).Temperatura, 4).ToString();
            } else
            {
                this.txtFahrenheit.Text = "ERROR!";
            }
        }

        private void btnCelsius_Click(object sender, EventArgs e)
        {
            double temperaturaCelsius;
            bool valida = double.TryParse(this.txtCelsius.Text, out temperaturaCelsius);
            Celsius celsius;

            if (valida)
            {
                celsius = new Celsius(temperaturaCelsius);
                this.txtCelsiusACelsius.Text = temperaturaCelsius.ToString();
                this.txtCelsiusAFahrenheit.Text = Math.Round(((Fahrenheit)celsius).Temperatura, 4).ToString();
                this.txtCelsiusAKelvin.Text = Math.Round(((Kelvin)celsius).Temperatura, 4).ToString();
            }
            else
            {
                this.txtCelsius.Text = "ERROR!";
            }
        }

        private void btnConvertKevin_Click(object sender, EventArgs e)
        {
            double temperaturaKelvin;
            bool valida = double.TryParse(this.txtKelvin.Text, out temperaturaKelvin);
            Kelvin kelvin;

            if (valida)
            {
                kelvin = new Kelvin(temperaturaKelvin);
                this.txtKelvinAKelvin.Text = temperaturaKelvin.ToString();
                this.txtKelvinAFahrenheit.Text = Math.Round(((Fahrenheit)kelvin).Temperatura, 4).ToString();
                this.txtKelvinACelsius.Text = Math.Round(((Celsius)kelvin).Temperatura, 4).ToString(); 
            }
            else
            {
                this.txtKelvin.Text = "ERROR!";
            }
        }
    }
}
