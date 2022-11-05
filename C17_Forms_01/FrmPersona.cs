using C17_Entidades_01;
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

namespace C17_Forms_01
{
    public partial class FrmPersona : Form
    {
        private PersonaDAO personaDAO;
        //private List<Persona> listaPersonas;

        public FrmPersona()
        {
            this.personaDAO = new PersonaDAO();
            //this.listaPersonas = new List<Persona>();
            InitializeComponent();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            List<Persona> listaPersonas = null;

            try
            {
                listaPersonas = personaDAO.Leer();
                if (listaPersonas is not null)
                {
                    this.CargarListaPersonas(listaPersonas);
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

        private void CargarListaPersonas(List<Persona> listaPersonas)
        {
            this.lstPersonas.Items.Clear();
            foreach (Persona persona in listaPersonas)
            {
                this.lstPersonas.Items.Add(persona.ID);
            }
        }

        private void lstPersonas_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstPersonas.SelectedItem is null)
            {
                return;
            }

            Persona personaSeleccionada = null;

            try
            {
                personaSeleccionada = personaDAO.LeerPorID((int)this.lstPersonas.SelectedItem);
            }
            catch (SqlException ex)
            {
                LogException.MostrarExcepcion(ex);
            }
            catch (Exception ex)
            {
                LogException.MostrarExcepcion(ex);
            }

            if (personaSeleccionada is not null)
            {
                this.txtNombre.Text = personaSeleccionada.Nombre;
                this.txtApellido.Text = personaSeleccionada.Apellido;
            } else
            {
                MessageBox.Show("No se pudo encontrar a la persona buscada con ese ID.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.lstPersonas.SelectedItem is null || String.IsNullOrEmpty(this.txtNombre.Text) || String.IsNullOrEmpty(this.txtApellido.Text))
            {
                MessageBox.Show("ERROR: Debe elegir un ID para modificarlo.");
                return;
            }

            Persona personaModificacion = new Persona((int)this.lstPersonas.SelectedItem, this.txtNombre.Text, this.txtApellido.Text);

            try
            {
                if (personaDAO.ModificarPorID(personaModificacion))
                {
                    MessageBox.Show("Modificado con éxito");
                }
                else
                {
                    MessageBox.Show("No se ha podido modificar");
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtNombre.Text) || String.IsNullOrEmpty(this.txtApellido.Text))
            {
                MessageBox.Show("ERROR: Debe completar los campos 'Nombre' y 'Apellido' para agregar una persona.");
                return;
            }

            try
            {
                if (personaDAO.Guardar(new Persona(this.txtNombre.Text, this.txtApellido.Text)))
                {
                    MessageBox.Show("La persona se ha agregado correctamente");
                } else
                {
                    MessageBox.Show("No se pudo agregar a la persona");
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstPersonas.SelectedItem is null)
            {
                MessageBox.Show("ERROR: Debe seleccionar a una persona de la lista para eliminarla.");
                return;
            }

            try
            {
                if (personaDAO.Borrar((int)this.lstPersonas.SelectedItem))
                {
                    MessageBox.Show("La persona se ha eliminado con éxito");
                }
                else
                {
                    MessageBox.Show("La persona no se ha podido eliminar");
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
    }
}
