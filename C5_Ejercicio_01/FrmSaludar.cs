using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C5_Ejercicio_01
{
    public partial class FrmSaludar : Form
    {
        public FrmSaludar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            string apellido = this.txtApellido.Text;
            string mensaje = $"Soy {nombre} {apellido}";

            FrmSaludo frmSaludo = new FrmSaludo("Saludo", $"Soy {nombre} {apellido}");
            frmSaludo.Show();
        }
    }
}
