using Billetes_V2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C5_Ejercicio_03
{
    public partial class frmConversor : Form
    {
        private bool cotizacionEditable;

        public frmConversor()
        {
            InitializeComponent();
        }

        private void frmConversor_Load(object sender, EventArgs e)
        {
            this.cotizacionEditable = true;
            this.txtCotizacionDolar.Text = Dolar.GetCotizacion().ToString();
            this.txtCotizacionEuro.Text = Euro.GetCotizacion().ToString();
            this.txtCotizacionPeso.Text = Peso.GetCotizacion().ToString();
        }

        private void txtCotizacionDolar_Leave(object sender, EventArgs e) //LostFocus
        {
            if (this.txtCotizacionDolar.Text != Dolar.GetCotizacion().ToString() || !double.TryParse(this.txtCotizacionDolar.Text, out _))
            {
                this.txtCotizacionDolar.Text = Dolar.GetCotizacion().ToString();
            }
        }

        private void txtCotizacionEuro_Leave(object sender, EventArgs e)
        {
            double cotizacion;
            bool esValida = double.TryParse(this.txtCotizacionEuro.Text, out cotizacion);

            if (!esValida)
            {
                this.txtCotizacionEuro.Focus();
                this.txtCotizacionEuro.ForeColor = Color.Red;
            } else
            {
                this.txtCotizacionEuro.ForeColor = Color.Black;
                Euro.SetCotizacion(cotizacion);
            }
        }

        private void txtCotizacionPeso_Leave(object sender, EventArgs e)
        {
            double cotizacion;
            bool esValida = double.TryParse(this.txtCotizacionPeso.Text, out cotizacion);

            if (!esValida)
            {
                this.txtCotizacionPeso.Focus();
                this.txtCotizacionPeso.ForeColor = Color.Red;
            }
            else
            {
                this.txtCotizacionPeso.ForeColor = Color.Black;
                Peso.SetCotizacion(cotizacion);
            }
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            Euro euro;
            double cantidadEuro;
            bool esValido = double.TryParse(this.txtEuro.Text, out cantidadEuro);

            if (esValido)
            {
                euro = new Euro(cantidadEuro);
                this.txtEuroAEuro.Text = this.txtEuro.Text;
                this.txtEuroADolar.Text = Math.Round(((Dolar)euro).GetCantidad(), 4).ToString();
                this.txtEuroAPeso.Text = Math.Round(((Peso)euro).GetCantidad(), 4).ToString();
            } else
            {
                this.txtEuro.Text = "ERROR";
            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            Dolar dolar;
            double cantidadDolar;
            bool esValido = double.TryParse(this.txtDolar.Text, out cantidadDolar);

            if (esValido)
            {
                dolar = new Dolar(cantidadDolar);
                this.txtDolarADolar.Text = this.txtDolar.Text;
                this.txtDolarAEuro.Text = Math.Round(((Euro)dolar).GetCantidad(), 4).ToString();
                this.txtDolarAPeso.Text = Math.Round(((Peso)dolar).GetCantidad(), 4).ToString();
            }
            else
            {
                this.txtPeso.Text = "ERROR";
            }
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            Peso peso;
            double cantidadPeso;
            bool esValido = double.TryParse(this.txtPeso.Text, out cantidadPeso);

            if (esValido)
            {
                peso = new Peso(cantidadPeso);
                this.txtPesoAPeso.Text = this.txtDolar.Text;
                this.txtPesoAEuro.Text = Math.Round(((Euro)peso).GetCantidad(), 4).ToString();
                this.txtPesoADolar.Text = Math.Round(((Dolar)peso).GetCantidad(), 4).ToString();
            }
            else
            {
                this.txtPeso.Text = "ERROR";
            }
        }

        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            string mensaje = "Bloquear";
            if (this.cotizacionEditable)
            {
                mensaje = "Desbloquear";
            }

            this.cotizacionEditable = !this.cotizacionEditable;
            this.txtCotizacionEuro.Enabled = !this.txtCotizacionEuro.Enabled;
            this.txtCotizacionDolar.Enabled = !this.txtCotizacionDolar.Enabled;
            this.txtCotizacionPeso.Enabled = !this.txtCotizacionPeso.Enabled;
            this.btnLockCotizacion.Text = mensaje;
        }
    }
}
