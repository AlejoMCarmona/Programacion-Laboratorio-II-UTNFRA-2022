using C15_EntidadesIO_05;
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

namespace C15_Forms_05
{
    public partial class FrmNotepad : Form
    {
        private string archivoActual;
        private PuntoTXT puntoTXT;
        private PuntoJSON<string> puntoJSON;
        private PuntoXML<string> puntoXML;

        public FrmNotepad()
        {
            this.archivoActual = "";
            this.puntoJSON = new PuntoJSON<string>();
            this.puntoXML = new PuntoXML<string>();
            this.puntoTXT = new PuntoTXT();
            InitializeComponent();
        }

        private void FrmNotepad_Load(object sender, EventArgs e)
        {
            this.tsrCaracteres.Text = "0 caracteres";
        }

        private void rtxNotepad_KeyDown(object sender, KeyEventArgs e)
        {
            this.tsrCaracteres.Text = rtxNotepad.Text.Length.ToString() + " caracteres";
        }

        private void tsAbrir_Click(object sender, EventArgs e)
        {
            this.AbrirArchivo();
        }

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.archivoActual) && File.Exists(this.archivoActual))
            {
                this.Guardar();
            }
            else
            {
                this.GuardarComo();
            }        
        }

        private void tsGuardarComo_Click(object sender, EventArgs e)
        {
            this.GuardarComo();
        }

        private void AbrirArchivo()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Archivos de texto (.txt)|*.txt|Archivos JSON (.json)|*.json|Archivos XML (.xml)|*.xml";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(openFile.FileName);
                string contenido = "";

                try
                {
                    switch (extension)
                    {
                        case ".json":
                            contenido = puntoJSON.Leer(openFile.FileName);
                            break;
                        case ".xml":
                            contenido = puntoXML.Leer(openFile.FileName);
                            break;
                        case ".txt":
                            contenido = puntoTXT.Leer(openFile.FileName);
                            break;
                    }

                    this.rtxNotepad.Text = contenido;
                }
                catch (Exception ex)
                {
                    LogException.MostrarExcepcion(ex);
                }
            }
        }

        private void Guardar()
        {
            string extension = Path.GetExtension(this.archivoActual);

            try
            {
                switch (extension)
                {
                    case ".json":
                        puntoJSON.Guardar(this.archivoActual, this.rtxNotepad.Text);
                        break;
                    case ".xml":
                        puntoXML.Guardar(this.archivoActual, this.rtxNotepad.Text);
                        break;
                    case ".txt":
                        puntoTXT.Guardar(this.archivoActual, this.rtxNotepad.Text);
                        break;
                }
            }
            catch (ArchivoIncorrectoException ex)
            {
                LogException.MostrarExcepcion(ex);
            }
            catch (Exception ex)
            {
                LogException.MostrarExcepcion(ex);
            }          
        }

        private void GuardarComo()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Archivos de texto (.txt)|*.txt|Archivos JSON (.json)|*.json|Archivos XML (.xml)|*.xml";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(saveFile.FileName);

                try
                {
                    switch (extension)
                    {
                        case ".json":
                            puntoJSON.GuardarComo(saveFile.FileName, this.rtxNotepad.Text);
                            break;
                        case ".xml":
                            puntoXML.GuardarComo(saveFile.FileName, this.rtxNotepad.Text);
                            break;
                        case ".txt":
                            puntoTXT.GuardarComo(this.archivoActual, this.rtxNotepad.Text);
                            break;
                    }

                    this.archivoActual = saveFile.FileName;
                }
                catch (ArchivoIncorrectoException ex)
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
}
