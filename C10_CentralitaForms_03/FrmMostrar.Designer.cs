
namespace C10_CentralitaForms_03
{
    partial class FrmMostrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtxInformacion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtxInformacion
            // 
            this.rtxInformacion.Location = new System.Drawing.Point(12, 12);
            this.rtxInformacion.Name = "rtxInformacion";
            this.rtxInformacion.ReadOnly = true;
            this.rtxInformacion.Size = new System.Drawing.Size(276, 217);
            this.rtxInformacion.TabIndex = 0;
            this.rtxInformacion.Text = "";
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 241);
            this.Controls.Add(this.rtxInformacion);
            this.Name = "FrmMostrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información";
            this.Load += new System.EventHandler(this.FrmMostrar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxInformacion;
    }
}