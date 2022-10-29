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

namespace C14_Forms_03
{
    public partial class FrmNotepad : Form
    {
        private string archivoActual;

        public FrmNotepad()
        {
            this.archivoActual = "";
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
            } else
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
            openFile.Filter = "Text Files | *.txt";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = null;

                try
                {
                    sr = new StreamReader(openFile.FileName);
                    this.rtxNotepad.Text = sr.ReadToEnd();
                    this.archivoActual = openFile.FileName;
                }
                catch (Exception ex)
                {
                    this.MostrarExcepcion(ex);
                }
                finally
                {
                    if (sr is not null)
                    {
                        sr.Close();
                    }
                }
            }
        }

        private void Guardar()
        {
            if (!String.IsNullOrEmpty(this.archivoActual) && File.Exists(this.archivoActual))
            {
                StreamWriter sw = null;

                try
                {
                    sw = new StreamWriter(this.archivoActual);
                    sw.WriteLine(this.rtxNotepad.Text);
                }
                catch (Exception ex)
                {
                    this.MostrarExcepcion(ex);
                }
                finally
                {
                    if (sw is not null)
                    {
                        sw.Close();
                        sw.Dispose();
                    }
                }
            }
        }

        private void GuardarComo()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text Files | *.txt";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = null;

                try
                {
                    sw = new StreamWriter(saveFile.FileName);
                    sw.WriteLine(this.rtxNotepad.Text);
                    this.archivoActual = saveFile.FileName;
                }
                catch (Exception ex)
                {
                    this.MostrarExcepcion(ex);
                }
                finally
                {
                    if (sw is not null)
                    {
                        sw.Close();
                        sw.Dispose();
                    }
                }
            }
        }

        private void MostrarExcepcion(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Error: {ex.Message}");
            sb.Append($"Detalle: {ex.StackTrace}");

            MessageBox.Show(sb.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
