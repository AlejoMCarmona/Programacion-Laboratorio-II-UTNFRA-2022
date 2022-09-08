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
    public partial class FrmMiForm_00 : Form
    {
        public FrmMiForm_00()
        {
            InitializeComponent(); //podemos ponerle this.InitializeComponent() porque es un método propio del mismo, simplemente que está dentro del Designer.
        }

        private void FrmMiForm_00_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btn_saludar_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre = this.txtName.Text;

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("ERROR!!");
            }
            else
            {
                MessageBox.Show($"Hola {nombre}!", "Bienvenido!", MessageBoxButtons.OKCancel);
            }
        }

        private void btn_SaludarForm_Click(object sender, EventArgs e)
        {
            //Tomamos el nombre del textBox
            string nombre;
            nombre = this.txtName.Text;

            if (string.IsNullOrEmpty(nombre))
            {
                //Envío un mensaje de error por si no escribe nada
                MessageBox.Show("ERROR!!");
            }
            else
            {
                //Instanciamos un objeto del otro Form pasándole el parámetro del nombre:
                FrmSaludar frmSaludar = new FrmSaludar(nombre);

                //Lo muestro pero solo deja interactuar con el formulario creado:
                if (frmSaludar.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Le gusta su nombre!");
                } else
                {
                    MessageBox.Show("No le gusta su nombre :(");
                }
            }
        }
    }
}
