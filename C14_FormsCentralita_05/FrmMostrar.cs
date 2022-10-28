using C14_EntidadesCentralita_05;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C14_FormsCentralita_05
{
    public partial class FrmMostrar : Form
    {
        private eTipoLlamada tipoLlamada;
        private Centralita centralita;

        public eTipoLlamada TipoLlamada 
        {
            set { 
                this.tipoLlamada = value; 
            }
        }

        public FrmMostrar(Centralita centralita)
        {
            this.centralita = centralita;
            InitializeComponent();
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            this.CargarDatos();
        }

        private void CargarDatos()
        {
            double facturacion = 0;
            string mensaje = "Facturación ";

            switch (this.tipoLlamada)
            {
                case eTipoLlamada.Local:
                    mensaje += "local: ";
                    facturacion = centralita.GananciasPorLocal;
                    break;
                case eTipoLlamada.Provincial:
                    mensaje += "provincial: ";
                    facturacion = centralita.GananciasPorProvincial;
                    break;
                case eTipoLlamada.Todas:
                    mensaje += "total: ";
                    facturacion = centralita.GananciasPorTotal;
                    break;
            }

            facturacion = Math.Round(facturacion, 4);
            this.rtxInformacion.Text = mensaje + facturacion.ToString();
        }
    }
}
