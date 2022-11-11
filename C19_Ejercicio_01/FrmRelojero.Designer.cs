
namespace C19_Ejercicio_01
{
    partial class FrmRelojero
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
            this.components = new System.ComponentModel.Container();
            this.lblHora = new System.Windows.Forms.Label();
            this.rtx = new System.Windows.Forms.RichTextBox();
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(12, 20);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(10, 15);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = ".";
            // 
            // rtx
            // 
            this.rtx.Location = new System.Drawing.Point(12, 54);
            this.rtx.Name = "rtx";
            this.rtx.Size = new System.Drawing.Size(207, 194);
            this.rtx.TabIndex = 1;
            this.rtx.Text = "";
            // 
            // tmrHora
            // 
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
            // 
            // FrmRelojero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 262);
            this.Controls.Add(this.rtx);
            this.Controls.Add(this.lblHora);
            this.Name = "FrmRelojero";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmRelojero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.RichTextBox rtx;
        private System.Windows.Forms.Timer tmrHora;
    }
}

