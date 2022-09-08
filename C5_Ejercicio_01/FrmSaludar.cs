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
            this.cmbMaterias.Text = "Matemática";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            StringBuilder mensaje = new StringBuilder();
            string nombre = this.txtNombre.Text;
            string apellido = this.txtApellido.Text;
            string materia = this.cmbMaterias.Text;
            bool error = false;

            if (String.IsNullOrWhiteSpace(nombre))
            {
                mensaje.AppendLine("Nombre");
                error = true;
            }
            if (String.IsNullOrWhiteSpace(apellido))
            {
                mensaje.Append("Apellido");
                error = true;
            }

            if (error)
            {
                MessageBox.Show($"Se deben completar los siguientes campos:\n{mensaje.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                mensaje.Append($"Soy {nombre} {apellido} y mi materia favorita es {materia}");
                FrmSaludo frmSaludo = new FrmSaludo("Saludo", mensaje.ToString());
                frmSaludo.ShowDialog(); //de forma modal
            }
        }
    }
}
