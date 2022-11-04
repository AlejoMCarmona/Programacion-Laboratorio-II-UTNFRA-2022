using C15_EntidadesCentralita_06;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C15_FormsCentralita_06
{
    public partial class FrmLlamador : Form
    {
        private Centralita centralita;

        public FrmLlamador(Centralita centralita)
        {
            this.centralita = centralita;
            InitializeComponent();
        }

        public Centralita Centralita 
        {
            get { return this.centralita; } 
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            this.cmbFranja.DataSource = Enum.GetValues(typeof(eFranja));
            this.txtNroOrigen.Text = "1109122018";
        }

        private void CargarNumero (int numero)
        {
            this.CargarNumero(numero.ToString());
        }

        private void CargarNumero(string simbolo)
        {
            if (this.txtNroDestino.Text == "Nro Destino")
            {
                this.txtNroDestino.Text = simbolo;
                return;
            }
            this.txtNroDestino.Text += simbolo; ;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.CargarNumero(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.CargarNumero(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.CargarNumero(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.CargarNumero(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.CargarNumero(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.CargarNumero(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.CargarNumero(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.CargarNumero(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.CargarNumero(9);
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            this.CargarNumero("*");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.CargarNumero(0);
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            this.CargarNumero("#");
        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if (this.txtNroDestino.Text[0].Equals('#'))
            {
                this.cmbFranja.Enabled = true;

            } else
            {
                this.cmbFranja.Enabled = false;
            }          
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text = "Nro Destino";
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Llamada llamada;
            Random r = new Random();

            if (this.txtNroDestino.Text.Length == 10 || (this.txtNroDestino.Text.Length == 11 && this.txtNroDestino.Text[0].Equals('#')))
            {
                float duracion = (float)(r.NextDouble() * (50 - 1) + 1);
                string destino = this.txtNroDestino.Text;
                string origen = this.txtNroOrigen.Text;

                if (this.cmbFranja.Enabled)
                {
                    eFranja franja;
                    Enum.TryParse<eFranja>(cmbFranja.SelectedValue.ToString(), out franja);                   
                    llamada = new Provincial(franja, duracion, destino, origen);
                } else
                {
                    float costo = (float)(r.NextDouble() * (5.6 - 0.5) + 0.5);
                    llamada = new Local(duracion, destino, origen, costo);
                }

                try
                {
                    _ = centralita + llamada;
                    MessageBox.Show("¡Llamada realizada!");
                } catch (CentralitaException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                MessageBox.Show("¡Ingrese un número válido!");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
