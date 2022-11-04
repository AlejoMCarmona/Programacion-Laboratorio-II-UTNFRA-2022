using C15_EntidadesCentralita_06;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C15_FormsCentralita_06
{
    public partial class FrmMenu : Form
    {
        private Centralita centralita;

        public FrmMenu()
        {
            this.centralita = new Centralita("Centralita");
            InitializeComponent();
        }

        private void btnLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador llamador = new FrmLlamador(centralita);
            llamador.ShowDialog();
            // this.centralita = llamador.Centralita; => es innecesario
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar formularioMostrar = new FrmMostrar(centralita);
            formularioMostrar.TipoLlamada = eTipoLlamada.Todas;
            formularioMostrar.ShowDialog();
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar formularioMostrar = new FrmMostrar(centralita);
            formularioMostrar.TipoLlamada = eTipoLlamada.Local;
            formularioMostrar.ShowDialog();
        }

        private void btnProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar formularioMostrar = new FrmMostrar(centralita);
            formularioMostrar.TipoLlamada = eTipoLlamada.Provincial;
            formularioMostrar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
