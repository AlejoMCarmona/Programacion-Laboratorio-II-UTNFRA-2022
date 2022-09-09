
namespace C5_Ejercicio_02
{
    partial class frmRegistro
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
            this.grpDetallesUsuario = new System.Windows.Forms.GroupBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.Apellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.rdoNoBinario = new System.Windows.Forms.RadioButton();
            this.rdoFemenino = new System.Windows.Forms.RadioButton();
            this.rdoMasculino = new System.Windows.Forms.RadioButton();
            this.grpCursos = new System.Windows.Forms.GroupBox();
            this.chkJavascript = new System.Windows.Forms.CheckBox();
            this.chkCPlusPlus = new System.Windows.Forms.CheckBox();
            this.chkCSharp = new System.Windows.Forms.CheckBox();
            this.lstPaises = new System.Windows.Forms.ListBox();
            this.lblPaises = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.grpDetallesUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.grpGenero.SuspendLayout();
            this.grpCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDetallesUsuario
            // 
            this.grpDetallesUsuario.Controls.Add(this.lblEdad);
            this.grpDetallesUsuario.Controls.Add(this.nudEdad);
            this.grpDetallesUsuario.Controls.Add(this.Apellido);
            this.grpDetallesUsuario.Controls.Add(this.lblNombre);
            this.grpDetallesUsuario.Controls.Add(this.txtDireccion);
            this.grpDetallesUsuario.Controls.Add(this.txtNombre);
            this.grpDetallesUsuario.Location = new System.Drawing.Point(12, 32);
            this.grpDetallesUsuario.Name = "grpDetallesUsuario";
            this.grpDetallesUsuario.Size = new System.Drawing.Size(200, 133);
            this.grpDetallesUsuario.TabIndex = 0;
            this.grpDetallesUsuario.TabStop = false;
            this.grpDetallesUsuario.Text = "Detalles del usuario";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(7, 95);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 8;
            this.lblEdad.Text = "Edad";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(84, 93);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(110, 23);
            this.nudEdad.TabIndex = 7;
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(7, 68);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(57, 15);
            this.Apellido.TabIndex = 6;
            this.Apellido.Text = "Dirección";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(84, 64);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(110, 23);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(110, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // grpGenero
            // 
            this.grpGenero.Controls.Add(this.rdoNoBinario);
            this.grpGenero.Controls.Add(this.rdoFemenino);
            this.grpGenero.Controls.Add(this.rdoMasculino);
            this.grpGenero.Location = new System.Drawing.Point(236, 32);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Size = new System.Drawing.Size(142, 110);
            this.grpGenero.TabIndex = 1;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Género";
            // 
            // rdoNoBinario
            // 
            this.rdoNoBinario.AutoSize = true;
            this.rdoNoBinario.Location = new System.Drawing.Point(24, 74);
            this.rdoNoBinario.Name = "rdoNoBinario";
            this.rdoNoBinario.Size = new System.Drawing.Size(81, 19);
            this.rdoNoBinario.TabIndex = 11;
            this.rdoNoBinario.TabStop = true;
            this.rdoNoBinario.Text = "No Binario";
            this.rdoNoBinario.UseVisualStyleBackColor = true;
            // 
            // rdoFemenino
            // 
            this.rdoFemenino.AutoSize = true;
            this.rdoFemenino.Location = new System.Drawing.Point(24, 49);
            this.rdoFemenino.Name = "rdoFemenino";
            this.rdoFemenino.Size = new System.Drawing.Size(78, 19);
            this.rdoFemenino.TabIndex = 10;
            this.rdoFemenino.TabStop = true;
            this.rdoFemenino.Text = "Femenino";
            this.rdoFemenino.UseVisualStyleBackColor = true;
            // 
            // rdoMasculino
            // 
            this.rdoMasculino.AutoSize = true;
            this.rdoMasculino.Location = new System.Drawing.Point(24, 24);
            this.rdoMasculino.Name = "rdoMasculino";
            this.rdoMasculino.Size = new System.Drawing.Size(80, 19);
            this.rdoMasculino.TabIndex = 9;
            this.rdoMasculino.TabStop = true;
            this.rdoMasculino.Text = "Masculino";
            this.rdoMasculino.UseVisualStyleBackColor = true;
            // 
            // grpCursos
            // 
            this.grpCursos.Controls.Add(this.chkJavascript);
            this.grpCursos.Controls.Add(this.chkCPlusPlus);
            this.grpCursos.Controls.Add(this.chkCSharp);
            this.grpCursos.Location = new System.Drawing.Point(236, 148);
            this.grpCursos.Name = "grpCursos";
            this.grpCursos.Size = new System.Drawing.Size(142, 104);
            this.grpCursos.TabIndex = 2;
            this.grpCursos.TabStop = false;
            this.grpCursos.Text = "Cursos";
            // 
            // chkJavascript
            // 
            this.chkJavascript.AutoSize = true;
            this.chkJavascript.Location = new System.Drawing.Point(24, 69);
            this.chkJavascript.Name = "chkJavascript";
            this.chkJavascript.Size = new System.Drawing.Size(77, 19);
            this.chkJavascript.TabIndex = 14;
            this.chkJavascript.Text = "Javascript";
            this.chkJavascript.UseVisualStyleBackColor = true;
            // 
            // chkCPlusPlus
            // 
            this.chkCPlusPlus.AutoSize = true;
            this.chkCPlusPlus.Location = new System.Drawing.Point(24, 48);
            this.chkCPlusPlus.Name = "chkCPlusPlus";
            this.chkCPlusPlus.Size = new System.Drawing.Size(50, 19);
            this.chkCPlusPlus.TabIndex = 13;
            this.chkCPlusPlus.Text = "C++";
            this.chkCPlusPlus.UseVisualStyleBackColor = true;
            // 
            // chkCSharp
            // 
            this.chkCSharp.AutoSize = true;
            this.chkCSharp.Location = new System.Drawing.Point(24, 27);
            this.chkCSharp.Name = "chkCSharp";
            this.chkCSharp.Size = new System.Drawing.Size(41, 19);
            this.chkCSharp.TabIndex = 12;
            this.chkCSharp.Text = "C#";
            this.chkCSharp.UseVisualStyleBackColor = true;
            // 
            // lstPaises
            // 
            this.lstPaises.FormattingEnabled = true;
            this.lstPaises.ItemHeight = 15;
            this.lstPaises.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.lstPaises.Location = new System.Drawing.Point(12, 196);
            this.lstPaises.Name = "lstPaises";
            this.lstPaises.Size = new System.Drawing.Size(194, 109);
            this.lstPaises.TabIndex = 15;
            // 
            // lblPaises
            // 
            this.lblPaises.AutoSize = true;
            this.lblPaises.Location = new System.Drawing.Point(12, 179);
            this.lblPaises.Name = "lblPaises";
            this.lblPaises.Size = new System.Drawing.Size(28, 15);
            this.lblPaises.TabIndex = 16;
            this.lblPaises.Text = "País";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(261, 284);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(118, 23);
            this.btnIngresar.TabIndex = 17;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 318);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblPaises);
            this.Controls.Add(this.lstPaises);
            this.Controls.Add(this.grpCursos);
            this.Controls.Add(this.grpGenero);
            this.Controls.Add(this.grpDetallesUsuario);
            this.Name = "frmRegistro";
            this.Text = "Registro";
            this.grpDetallesUsuario.ResumeLayout(false);
            this.grpDetallesUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            this.grpCursos.ResumeLayout(false);
            this.grpCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDetallesUsuario;
        private System.Windows.Forms.GroupBox grpGenero;
        private System.Windows.Forms.GroupBox grpCursos;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.RadioButton rdoNoBinario;
        private System.Windows.Forms.RadioButton rdoFemenino;
        private System.Windows.Forms.RadioButton rdoMasculino;
        private System.Windows.Forms.CheckBox chkJavascript;
        private System.Windows.Forms.CheckBox chkCPlusPlus;
        private System.Windows.Forms.CheckBox chkCSharp;
        private System.Windows.Forms.ListBox lstPaises;
        private System.Windows.Forms.Label lblPaises;
        private System.Windows.Forms.Button btnIngresar;
    }
}

