using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace C15_Forms_01
{
    public partial class FrmListaSuper : Form
    {
        private List<string> listaSupermercado;

        public FrmListaSuper()
        {
            this.listaSupermercado = new List<string>();
            InitializeComponent();
        }

        private void FrmListaSuper_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.btnAgregar, "Agregar objeto");
            toolTip.SetToolTip(this.btnEliminar, "Eliminar objeto");
            toolTip.SetToolTip(this.btnModificar, "Modificar objeto");

            try
            {
                this.listaSupermercado = Serializador<List<string>>.DeserializarXML($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}{Path.DirectorySeparatorChar}listaSupermercado.xml");
            }
            catch (Exception ex)
            {
                LogException.MostrarExcepcion(ex);
            }
            this.CargarListBox();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaModificacion frmAltaModificacion = new FrmAltaModificacion("Agregar objeto", "", "Agregar");
            if (frmAltaModificacion.ShowDialog() == DialogResult.OK) 
            {
                string objeto = frmAltaModificacion.Objeto;
                this.listaSupermercado.Add(objeto);
                this.CargarListBox();   
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstObjetos.SelectedItem is null)
            {
                MessageBox.Show("Debe seleccionar un item de la lista para borrarlo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            this.listaSupermercado.Remove(this.lstObjetos.SelectedItem.ToString());
            this.CargarListBox();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.lstObjetos.SelectedItem is null)
            {
                MessageBox.Show("Debe seleccionar un item de la lista para modificarlo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            
            FrmAltaModificacion frmAltaModificacion = new FrmAltaModificacion("Modificar objeto", this.lstObjetos.SelectedItem.ToString(), "Modificar");
            if (frmAltaModificacion.ShowDialog() == DialogResult.OK)
            {
                int indice = this.listaSupermercado.IndexOf(this.lstObjetos.SelectedItem.ToString());
                this.listaSupermercado[indice] = frmAltaModificacion.Objeto;
                this.CargarListBox();
            }
        }

        private void CargarListBox()
        {
            this.lstObjetos.DataSource = null;
            this.lstObjetos.DataSource = listaSupermercado;
        }

        private void FrmListaSuper_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Serializador<List<string>>.SerializarXML(this.listaSupermercado, $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}{Path.DirectorySeparatorChar}listaSupermercado.xml");
            }
            catch (Exception ex)
            {
                LogException.MostrarExcepcion(ex);
            }
        }
    }
}
