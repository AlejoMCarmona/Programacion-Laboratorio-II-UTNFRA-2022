using C10_Entidades_01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C10_Ejercicio_1
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double kilometros;
            double litros;

            try
            {
                if (String.IsNullOrEmpty(this.txtKilometros.Text) || String.IsNullOrEmpty(this.txtLitros.Text))
                {
                    throw new ParametrosVaciosException();
                }

                kilometros = double.Parse(this.txtKilometros.Text);
                litros = double.Parse(this.txtLitros.Text);
                this.rtx.Text = Calculador.Calcular(kilometros, litros).ToString();
            }
            catch (ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
