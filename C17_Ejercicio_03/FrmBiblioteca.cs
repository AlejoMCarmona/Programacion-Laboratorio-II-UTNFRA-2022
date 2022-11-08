using C17_Entidades_02;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C17_Ejercicio_03
{
    public partial class FrmBiblioteca : Form
    {
        public FrmBiblioteca()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.RefrescarBiblioteca();
        }

        private void RefrescarBiblioteca()
        {
            List<Biblioteca> listaBiblioteca = null;

            try
            {
                listaBiblioteca = JuegoDAO.Leer();

                if (listaBiblioteca is not null)
                {
                    this.dtgvBiblioteca.DataSource = listaBiblioteca;
                    this.dtgvBiblioteca.Refresh();
                    this.dtgvBiblioteca.Update();
                }
            }
            catch (Exception ex)
            {
                LogException.MostrarExcepcion(ex);
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dtgvBiblioteca.RowCount == 0)
            {
                MessageBox.Show("No hay juegos para eliminar");
                return;
            }
            if (this.dtgvBiblioteca.SelectedRows.Count > 1)
            {
                MessageBox.Show("Seleccione un solo juego para eliminar");
                return;
            }

            string mensaje = "No se ha podido eliminar el juego";
            bool resultado = false;
            int codigoJuego = (int)this.dtgvBiblioteca.CurrentRow.Cells[0].Value;

            try
            {
                resultado = JuegoDAO.Eliminar(codigoJuego);
            }
            catch (SqlException ex)
            {
                LogException.MostrarExcepcion(ex);
            }
            catch (Exception ex)
            {
                LogException.MostrarExcepcion(ex);
            }

            if (resultado)
            {
                this.RefrescarBiblioteca();
                mensaje = "Juego eliminado correctamente.";
            }
            MessageBox.Show(mensaje);          
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FrmAlta formularioAlta = new FrmAlta();
            string mensaje = "No se pudo realizar el alta.";

            if (formularioAlta.ShowDialog() == DialogResult.OK)
            {
                mensaje = "¡Juego agregado con éxito!";
                this.RefrescarBiblioteca();
            }
            MessageBox.Show(mensaje);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dtgvBiblioteca.RowCount == 0)
            {
                MessageBox.Show("No hay juegos para modificar");
                return;
            }
            if (this.dtgvBiblioteca.SelectedRows.Count > 1)
            {
                MessageBox.Show("Seleccione un solo juego para modificar");
                return;
            }

            string mensaje = "No se pudo realizar la modificación";
            int codigoJuego = (int)this.dtgvBiblioteca.CurrentRow.Cells[0].Value;
            FrmAlta formularioAlta = new FrmAlta(codigoJuego);

            if (formularioAlta.ShowDialog() == DialogResult.OK)
            {
                mensaje = "¡Modificación realizada con éxito!";
                this.RefrescarBiblioteca();
            }
            MessageBox.Show(mensaje);
        }

    }
}
