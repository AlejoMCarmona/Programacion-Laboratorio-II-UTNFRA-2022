using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C15_Forms_01
{
    public partial class FrmAltaModificacion : Form
    {
        public FrmAltaModificacion(string titulo, string textoObjeto, string textoBotonConfirmar)
        {
            InitializeComponent();
            this.Text = titulo;
            this.txtObjeto.Text = textoObjeto;
            this.btnConfirmar.Text = textoBotonConfirmar;
        }

        public string Objeto 
        {
            get 
            {
                return this.txtObjeto.Text;
            }  
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.ConfirmarOperacion();
        }

        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.ConfirmarOperacion();
            }
            else if (e.KeyChar == (char)27)
            {
                this.CancelarOperacion();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.CancelarOperacion();
        }

        private void ConfirmarOperacion()
        {
            if (String.IsNullOrEmpty(this.Objeto))
            {
                MessageBox.Show("ADVERTENCIA: ¡El texto se encuentra vacío!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelarOperacion()
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
