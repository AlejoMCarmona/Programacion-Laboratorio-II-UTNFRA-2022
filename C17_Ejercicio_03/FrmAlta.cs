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
    public partial class FrmAlta : Form
    {
        private int codigoJuego;

        public FrmAlta(int codigoJuego) : this()
        {
            this.codigoJuego = codigoJuego;
            this.btnGuardar.Text = "Modificar";
            this.cmbUsuarios.Enabled = false;
            this.PintarForm();
        }

        public FrmAlta()
        {
            InitializeComponent();
            this.nupPrecio.Maximum = 10000;
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            if (this.cmbUsuarios.Enabled)
            {
                try
                {
                    this.cmbUsuarios.DataSource = UsuarioDAO.Leer();
                    this.cmbUsuarios.SelectedItem = this.cmbUsuarios.Items[0];
                }
                catch (Exception ex)
                {
                    LogException.MostrarExcepcion(ex);
                    this.Close();                }
            }
        }

        private void PintarForm()
        {
            Juego juego = null;

            try
            {
                juego = JuegoDAO.LeerPorID(this.codigoJuego);

                if (juego is not null)
                {
                    this.txtNombre.Text = juego.Nombre.ToString();
                    this.txtGenero.Text = juego.Genero.ToString();
                    this.nupPrecio.Text = juego.Precio.ToString();
                    this.cmbUsuarios.Items.Add(juego.CodigoUsuario);
                    this.cmbUsuarios.SelectedItem = this.cmbUsuarios.Items[0];
                }
            }
            catch (SqlException ex)
            {
                LogException.MostrarExcepcion(ex);
            }
            catch (Exception ex)
            {
                LogException.MostrarExcepcion(ex);
            }          
        }

        protected virtual void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            string genero = this.txtGenero.Text;
            double precio = (double)this.nupPrecio.Value;
            Juego juego = null;
            bool resultado = false;

            if (!String.IsNullOrEmpty(nombre) && !String.IsNullOrEmpty(genero) && precio >= 0)
            {
                try
                {
                    if (this.cmbUsuarios.Enabled)
                    {
                        int codigoUsuario = ((Usuario)this.cmbUsuarios.SelectedItem).CodigoUsuario;
                        juego = new Juego(nombre, precio, genero, codigoUsuario);
                        resultado = JuegoDAO.Guardar(juego);
                    }
                    else
                    {
                        juego = new Juego(nombre, precio, genero, this.codigoJuego, 0);
                        resultado = JuegoDAO.Modificar(juego);
                    }
                    if (resultado)
                    {
                        DialogResult = DialogResult.OK;
                    }
                }
                catch (SqlException ex)
                {
                    LogException.MostrarExcepcion(ex);
                }
                catch (Exception ex)
                {
                    LogException.MostrarExcepcion(ex);
                }

                this.Close();
            } else
            {
                MessageBox.Show("Complete todos los campos correctamente!");
            }
        }
    }
}
