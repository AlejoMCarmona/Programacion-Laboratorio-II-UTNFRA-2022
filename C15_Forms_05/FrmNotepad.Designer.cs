
namespace C15_Forms_05
{
    partial class FrmNotepad
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnsArchivo = new System.Windows.Forms.MenuStrip();
            this.tsrArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.ssrCaracteres = new System.Windows.Forms.StatusStrip();
            this.tsrCaracteres = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsCaracteres = new System.Windows.Forms.ToolStripStatusLabel();
            this.rtxNotepad = new System.Windows.Forms.RichTextBox();
            this.mnsArchivo.SuspendLayout();
            this.ssrCaracteres.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsArchivo
            // 
            this.mnsArchivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrArchivo});
            this.mnsArchivo.Location = new System.Drawing.Point(0, 0);
            this.mnsArchivo.Name = "mnsArchivo";
            this.mnsArchivo.Size = new System.Drawing.Size(784, 24);
            this.mnsArchivo.TabIndex = 0;
            this.mnsArchivo.Text = "Archivo";
            // 
            // tsrArchivo
            // 
            this.tsrArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAbrir,
            this.tsGuardar,
            this.tsGuardarComo});
            this.tsrArchivo.Name = "tsrArchivo";
            this.tsrArchivo.Size = new System.Drawing.Size(60, 20);
            this.tsrArchivo.Text = "Archivo";
            // 
            // tsAbrir
            // 
            this.tsAbrir.Name = "tsAbrir";
            this.tsAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsAbrir.Size = new System.Drawing.Size(222, 22);
            this.tsAbrir.Text = "Abrir";
            this.tsAbrir.Click += new System.EventHandler(this.tsAbrir_Click);
            // 
            // tsGuardar
            // 
            this.tsGuardar.Name = "tsGuardar";
            this.tsGuardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsGuardar.Size = new System.Drawing.Size(222, 22);
            this.tsGuardar.Text = "Guardar";
            this.tsGuardar.Click += new System.EventHandler(this.tsGuardar_Click);
            // 
            // tsGuardarComo
            // 
            this.tsGuardarComo.Name = "tsGuardarComo";
            this.tsGuardarComo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsGuardarComo.Size = new System.Drawing.Size(222, 22);
            this.tsGuardarComo.Text = "Guardar como";
            this.tsGuardarComo.Click += new System.EventHandler(this.tsGuardarComo_Click);
            // 
            // ssrCaracteres
            // 
            this.ssrCaracteres.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrCaracteres,
            this.tsCaracteres});
            this.ssrCaracteres.Location = new System.Drawing.Point(0, 439);
            this.ssrCaracteres.Name = "ssrCaracteres";
            this.ssrCaracteres.Size = new System.Drawing.Size(784, 22);
            this.ssrCaracteres.TabIndex = 1;
            this.ssrCaracteres.Text = "statusStrip1";
            // 
            // tsrCaracteres
            // 
            this.tsrCaracteres.Name = "tsrCaracteres";
            this.tsrCaracteres.Size = new System.Drawing.Size(60, 17);
            this.tsrCaracteres.Text = "caracteres";
            // 
            // tsCaracteres
            // 
            this.tsCaracteres.Name = "tsCaracteres";
            this.tsCaracteres.Size = new System.Drawing.Size(0, 17);
            // 
            // rtxNotepad
            // 
            this.rtxNotepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxNotepad.Location = new System.Drawing.Point(0, 24);
            this.rtxNotepad.Name = "rtxNotepad";
            this.rtxNotepad.Size = new System.Drawing.Size(784, 415);
            this.rtxNotepad.TabIndex = 2;
            this.rtxNotepad.Text = "";
            this.rtxNotepad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxNotepad_KeyDown);
            // 
            // FrmNotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.rtxNotepad);
            this.Controls.Add(this.ssrCaracteres);
            this.Controls.Add(this.mnsArchivo);
            this.MainMenuStrip = this.mnsArchivo;
            this.Name = "FrmNotepad";
            this.Text = "Notepad";
            this.Load += new System.EventHandler(this.FrmNotepad_Load);
            this.mnsArchivo.ResumeLayout(false);
            this.mnsArchivo.PerformLayout();
            this.ssrCaracteres.ResumeLayout(false);
            this.ssrCaracteres.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsrMenu;
        private System.Windows.Forms.ToolStripMenuItem tsrAbrir;
        private System.Windows.Forms.ToolStripMenuItem tsrGuardar;
        private System.Windows.Forms.ToolStripMenuItem tsrGuardarComo;
        private System.Windows.Forms.ToolStripMenuItem tsrArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsAbrir;
        private System.Windows.Forms.ToolStripMenuItem tsGuardar;
        private System.Windows.Forms.ToolStripMenuItem tsGuardarComo;
        private System.Windows.Forms.StatusStrip ssrCaracteres;
        private System.Windows.Forms.ToolStripStatusLabel tsrCaracteres;
        private System.Windows.Forms.ToolStripStatusLabel tsCaracteres;
        private System.Windows.Forms.RichTextBox rtxNotepad;
    }
}

