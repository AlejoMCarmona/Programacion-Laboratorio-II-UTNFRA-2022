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
    public partial class FrmSalu : Form
    {
        public FrmSalu()
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

            MessageBox.Show($"¡Hola, Windows Forms!\n\nSoy {nombre} {apellido}.", "Saludo");
        }
    }
}
