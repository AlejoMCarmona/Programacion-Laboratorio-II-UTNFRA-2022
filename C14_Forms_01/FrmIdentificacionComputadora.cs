using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace C14_Forms_01
{
    public partial class FrmIdentificacionComputadora : Form
    {
        public FrmIdentificacionComputadora()
        {
            InitializeComponent();
        }

        private void FrmIdentificacionComputadora_Load(object sender, System.EventArgs e)
        {
            this.Text = this.Text.Replace("[USUARIO]", Environment.UserName);
            this.lblSistemaOperativo.Text += " " + Environment.OSVersion;
            this.lblNombreMaquina.Text += Environment.MachineName;
            this.lblCantProcesadores.Text += " " + Environment.ProcessorCount + " procesadores lógicos";
            this.lblDirectorioActual.Text += Environment.NewLine + Environment.CurrentDirectory;
            this.ConfigurarArquitectura();
            this.ConfigurarEspacioTotalYDisponible();
            this.ConfigurarLogoSistemaOperativo();
        }

        private void ConfigurarLogoSistemaOperativo()
        {
            Bitmap imagenSO = null;

            if (OperatingSystem.IsWindows())
            {
                imagenSO = Properties.Resources.windows;
            } else if (OperatingSystem.IsMacOS())
            {
                imagenSO = Properties.Resources.mac;
            } else if (OperatingSystem.IsLinux()) 
            {
                imagenSO = Properties.Resources.linux;
            }
            
            this.picboxSistemaOperativo.Image = imagenSO;
        }

        private void ConfigurarArquitectura()
        {
            string arquitectura = " 64 bits";

            if (!Environment.Is64BitOperatingSystem)
            {
                arquitectura = " 32 bits";
            }

            this.lblArquitectura.Text += arquitectura;
        }

        private void ConfigurarEspacioTotalYDisponible()
        {
            DriveInfo[] discos = DriveInfo.GetDrives();
            double espacioTotal = 0;
            double espacioDisponible = 0;

            foreach (DriveInfo disco in discos)
            {
                if (disco.IsReady)
                {
                    espacioTotal += disco.TotalSize;
                    espacioDisponible += disco.AvailableFreeSpace;
                }
            }

            this.lblEspacioTotal.Text += " " + Math.Round(espacioTotal / 1073741824) + " Gigabytes";
            this.lblEspacioDisponible.Text += " " + Math.Round(espacioDisponible / 1073741824) + " Gigabytes";
        }
    }
}
