using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmSaludar : Form
    {
        public FrmSaludar()
        {
            InitializeComponent();
        }

        public FrmSaludar(string nombre) : this()
        {
            this.lblSaludo.Text = "Hola " + nombre + "!"; 
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //si hago click en aceptar:
            string equipo;
            equipo = this.cboEquipo.Text;

            MessageBox.Show($"Usted es hincha de {equipo}");

            //DialogResult = DialogResult.OK; no aplica para el ejemplo
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //si hago click en cancelar:
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
