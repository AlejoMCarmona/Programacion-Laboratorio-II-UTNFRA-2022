
namespace C5_Ejercicio_05
{
    partial class frmConversor
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
            this.txtDecimalAConvert = new System.Windows.Forms.TextBox();
            this.lblBinarioADecimal = new System.Windows.Forms.Label();
            this.btnDecimalABinario = new System.Windows.Forms.Button();
            this.btnBinarioADecimal = new System.Windows.Forms.Button();
            this.lblDecimalABinario = new System.Windows.Forms.Label();
            this.txtBinarioAConvert = new System.Windows.Forms.TextBox();
            this.txtBinarioADecimal = new System.Windows.Forms.TextBox();
            this.txtDecimalABinario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDecimalAConvert
            // 
            this.txtDecimalAConvert.Location = new System.Drawing.Point(140, 55);
            this.txtDecimalAConvert.Name = "txtDecimalAConvert";
            this.txtDecimalAConvert.Size = new System.Drawing.Size(100, 23);
            this.txtDecimalAConvert.TabIndex = 0;
            // 
            // lblBinarioADecimal
            // 
            this.lblBinarioADecimal.AutoSize = true;
            this.lblBinarioADecimal.Location = new System.Drawing.Point(18, 29);
            this.lblBinarioADecimal.Name = "lblBinarioADecimal";
            this.lblBinarioADecimal.Size = new System.Drawing.Size(98, 15);
            this.lblBinarioADecimal.TabIndex = 2;
            this.lblBinarioADecimal.Text = "Binario a decimal";
            // 
            // btnDecimalABinario
            // 
            this.btnDecimalABinario.Location = new System.Drawing.Point(246, 54);
            this.btnDecimalABinario.Name = "btnDecimalABinario";
            this.btnDecimalABinario.Size = new System.Drawing.Size(75, 23);
            this.btnDecimalABinario.TabIndex = 1;
            this.btnDecimalABinario.Text = "->";
            this.btnDecimalABinario.UseVisualStyleBackColor = true;
            this.btnDecimalABinario.Click += new System.EventHandler(this.btnDecimalABinario_Click);
            // 
            // btnBinarioADecimal
            // 
            this.btnBinarioADecimal.Location = new System.Drawing.Point(246, 25);
            this.btnBinarioADecimal.Name = "btnBinarioADecimal";
            this.btnBinarioADecimal.Size = new System.Drawing.Size(75, 23);
            this.btnBinarioADecimal.TabIndex = 3;
            this.btnBinarioADecimal.Text = "->";
            this.btnBinarioADecimal.UseVisualStyleBackColor = true;
            this.btnBinarioADecimal.Click += new System.EventHandler(this.btnBinarioADecimal_Click);
            // 
            // lblDecimalABinario
            // 
            this.lblDecimalABinario.AutoSize = true;
            this.lblDecimalABinario.Location = new System.Drawing.Point(18, 58);
            this.lblDecimalABinario.Name = "lblDecimalABinario";
            this.lblDecimalABinario.Size = new System.Drawing.Size(99, 15);
            this.lblDecimalABinario.TabIndex = 4;
            this.lblDecimalABinario.Text = "Decimal a binario";
            // 
            // txtBinarioAConvert
            // 
            this.txtBinarioAConvert.Location = new System.Drawing.Point(140, 26);
            this.txtBinarioAConvert.Name = "txtBinarioAConvert";
            this.txtBinarioAConvert.Size = new System.Drawing.Size(100, 23);
            this.txtBinarioAConvert.TabIndex = 5;
            // 
            // txtBinarioADecimal
            // 
            this.txtBinarioADecimal.Location = new System.Drawing.Point(335, 25);
            this.txtBinarioADecimal.Name = "txtBinarioADecimal";
            this.txtBinarioADecimal.Size = new System.Drawing.Size(100, 23);
            this.txtBinarioADecimal.TabIndex = 6;
            // 
            // txtDecimalABinario
            // 
            this.txtDecimalABinario.Location = new System.Drawing.Point(335, 54);
            this.txtDecimalABinario.Name = "txtDecimalABinario";
            this.txtDecimalABinario.Size = new System.Drawing.Size(100, 23);
            this.txtDecimalABinario.TabIndex = 7;
            // 
            // frmConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 101);
            this.Controls.Add(this.txtDecimalABinario);
            this.Controls.Add(this.txtBinarioADecimal);
            this.Controls.Add(this.txtBinarioAConvert);
            this.Controls.Add(this.lblDecimalABinario);
            this.Controls.Add(this.btnBinarioADecimal);
            this.Controls.Add(this.lblBinarioADecimal);
            this.Controls.Add(this.btnDecimalABinario);
            this.Controls.Add(this.txtDecimalAConvert);
            this.Name = "frmConversor";
            this.Text = "Conversor Numérico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDecimalAConvert;
        private System.Windows.Forms.Label lblBinarioADecimal;
        private System.Windows.Forms.Button btnDecimalABinario;
        private System.Windows.Forms.Button btnBinarioADecimal;
        private System.Windows.Forms.Label lblDecimalABinario;
        private System.Windows.Forms.TextBox txtBinarioAConvert;
        private System.Windows.Forms.TextBox txtBinarioADecimal;
        private System.Windows.Forms.TextBox txtDecimalABinario;
    }
}

