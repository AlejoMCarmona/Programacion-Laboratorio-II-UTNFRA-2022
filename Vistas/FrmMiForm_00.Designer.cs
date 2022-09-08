
namespace Vistas
{
    partial class FrmMiForm_00
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
            this.btn_saludar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btn_SaludarForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_saludar
            // 
            this.btn_saludar.Location = new System.Drawing.Point(39, 188);
            this.btn_saludar.Name = "btn_saludar";
            this.btn_saludar.Size = new System.Drawing.Size(203, 162);
            this.btn_saludar.TabIndex = 0;
            this.btn_saludar.Text = "Saludar por MessageBox";
            this.btn_saludar.UseVisualStyleBackColor = true;
            this.btn_saludar.Click += new System.EventHandler(this.btn_saludar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(134, 119);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(108, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Ingrese su nombre:";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(248, 116);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(101, 23);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btn_SaludarForm
            // 
            this.btn_SaludarForm.Location = new System.Drawing.Point(261, 188);
            this.btn_SaludarForm.Name = "btn_SaludarForm";
            this.btn_SaludarForm.Size = new System.Drawing.Size(203, 162);
            this.btn_SaludarForm.TabIndex = 3;
            this.btn_SaludarForm.Text = "Saludar desde otro Form";
            this.btn_SaludarForm.UseVisualStyleBackColor = true;
            this.btn_SaludarForm.Click += new System.EventHandler(this.btn_SaludarForm_Click);
            // 
            // FrmMiForm_00
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 473);
            this.Controls.Add(this.btn_SaludarForm);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btn_saludar);
            this.Name = "FrmMiForm_00";
            this.Text = "FrmMiForm_00";
            this.Load += new System.EventHandler(this.FrmMiForm_00_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_saludar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btn_SaludarForm;
    }
}