using C5_Entidades_02;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C5_Ejercicio_02
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            string pais = this.lstPaises.Text;
            string direccion = this.txtDireccion.Text;
            int edad = (int)this.nudEdad.Value;
            string genero = "";
            string[] cursos = new string[grpGenero.Controls.Count];
            bool hayCursos = false;
            int contadorCursos = 0;
            StringBuilder mensaje = new StringBuilder();

            foreach (RadioButton rdo in grpGenero.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    genero = rdo.Text;
                    break;
                }
            }

            foreach (CheckBox curso in grpCursos.Controls.OfType<CheckBox>())
            {
                if (curso.Checked)
                {
                    hayCursos = true;
                    cursos[contadorCursos] = curso.Text;
                }
                contadorCursos++;
            }

            if (hayCursos && !String.IsNullOrEmpty(nombre) && !String.IsNullOrEmpty(direccion) && !String.IsNullOrEmpty(genero) && !String.IsNullOrEmpty(pais) && edad > 17)
            {
                Ingresante ingresante = new Ingresante(nombre, direccion, genero, pais, edad, cursos);
                MessageBox.Show(ingresante.Mostrar());
            } else
            {
                MessageBox.Show("ERROR. Debe ingresar datos válidos.");
            }
        }
    }
}
