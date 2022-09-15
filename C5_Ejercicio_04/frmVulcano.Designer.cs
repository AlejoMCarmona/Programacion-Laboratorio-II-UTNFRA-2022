
namespace C5_Ejercicio_04
{
    partial class frmVulcano
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
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblKelvin = new System.Windows.Forms.Label();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtKelvin = new System.Windows.Forms.TextBox();
            this.txtFahrenheitaAFahrenheit = new System.Windows.Forms.TextBox();
            this.txtFahrenheitACelsius = new System.Windows.Forms.TextBox();
            this.txtFahrenheitAKelvin = new System.Windows.Forms.TextBox();
            this.txtCelsiusAFahrenheit = new System.Windows.Forms.TextBox();
            this.txtKelvinAFahrenheit = new System.Windows.Forms.TextBox();
            this.txtCelsiusACelsius = new System.Windows.Forms.TextBox();
            this.txtKelvinACelsius = new System.Windows.Forms.TextBox();
            this.txtCelsiusAKelvin = new System.Windows.Forms.TextBox();
            this.txtKelvinAKelvin = new System.Windows.Forms.TextBox();
            this.btnConvertFahrenheit = new System.Windows.Forms.Button();
            this.btnCelsius = new System.Windows.Forms.Button();
            this.btnConvertKevin = new System.Windows.Forms.Button();
            this.lblFahrenheitA = new System.Windows.Forms.Label();
            this.lblCelsiusA = new System.Windows.Forms.Label();
            this.lblKelvinA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFahrenheit.Location = new System.Drawing.Point(15, 32);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(77, 20);
            this.lblFahrenheit.TabIndex = 0;
            this.lblFahrenheit.Text = "Fahrenheit";
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCelsius.Location = new System.Drawing.Point(15, 62);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(54, 20);
            this.lblCelsius.TabIndex = 1;
            this.lblCelsius.Text = "Celsius";
            // 
            // lblKelvin
            // 
            this.lblKelvin.AutoSize = true;
            this.lblKelvin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKelvin.Location = new System.Drawing.Point(15, 92);
            this.lblKelvin.Name = "lblKelvin";
            this.lblKelvin.Size = new System.Drawing.Size(49, 20);
            this.lblKelvin.TabIndex = 2;
            this.lblKelvin.Text = "Kelvin";
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(111, 33);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(121, 23);
            this.txtFahrenheit.TabIndex = 3;
            this.txtFahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(111, 62);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(121, 23);
            this.txtCelsius.TabIndex = 4;
            this.txtCelsius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKelvin
            // 
            this.txtKelvin.Location = new System.Drawing.Point(111, 92);
            this.txtKelvin.Name = "txtKelvin";
            this.txtKelvin.Size = new System.Drawing.Size(121, 23);
            this.txtKelvin.TabIndex = 5;
            this.txtKelvin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFahrenheitaAFahrenheit
            // 
            this.txtFahrenheitaAFahrenheit.Location = new System.Drawing.Point(359, 33);
            this.txtFahrenheitaAFahrenheit.Name = "txtFahrenheitaAFahrenheit";
            this.txtFahrenheitaAFahrenheit.ReadOnly = true;
            this.txtFahrenheitaAFahrenheit.Size = new System.Drawing.Size(121, 23);
            this.txtFahrenheitaAFahrenheit.TabIndex = 6;
            this.txtFahrenheitaAFahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFahrenheitACelsius
            // 
            this.txtFahrenheitACelsius.Location = new System.Drawing.Point(486, 34);
            this.txtFahrenheitACelsius.Name = "txtFahrenheitACelsius";
            this.txtFahrenheitACelsius.ReadOnly = true;
            this.txtFahrenheitACelsius.Size = new System.Drawing.Size(121, 23);
            this.txtFahrenheitACelsius.TabIndex = 7;
            this.txtFahrenheitACelsius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFahrenheitAKelvin
            // 
            this.txtFahrenheitAKelvin.Location = new System.Drawing.Point(613, 34);
            this.txtFahrenheitAKelvin.Name = "txtFahrenheitAKelvin";
            this.txtFahrenheitAKelvin.ReadOnly = true;
            this.txtFahrenheitAKelvin.Size = new System.Drawing.Size(121, 23);
            this.txtFahrenheitAKelvin.TabIndex = 8;
            this.txtFahrenheitAKelvin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCelsiusAFahrenheit
            // 
            this.txtCelsiusAFahrenheit.Location = new System.Drawing.Point(359, 62);
            this.txtCelsiusAFahrenheit.Name = "txtCelsiusAFahrenheit";
            this.txtCelsiusAFahrenheit.ReadOnly = true;
            this.txtCelsiusAFahrenheit.Size = new System.Drawing.Size(121, 23);
            this.txtCelsiusAFahrenheit.TabIndex = 9;
            this.txtCelsiusAFahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKelvinAFahrenheit
            // 
            this.txtKelvinAFahrenheit.Location = new System.Drawing.Point(359, 92);
            this.txtKelvinAFahrenheit.Name = "txtKelvinAFahrenheit";
            this.txtKelvinAFahrenheit.ReadOnly = true;
            this.txtKelvinAFahrenheit.Size = new System.Drawing.Size(121, 23);
            this.txtKelvinAFahrenheit.TabIndex = 10;
            this.txtKelvinAFahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCelsiusACelsius
            // 
            this.txtCelsiusACelsius.Location = new System.Drawing.Point(486, 63);
            this.txtCelsiusACelsius.Name = "txtCelsiusACelsius";
            this.txtCelsiusACelsius.ReadOnly = true;
            this.txtCelsiusACelsius.Size = new System.Drawing.Size(121, 23);
            this.txtCelsiusACelsius.TabIndex = 11;
            this.txtCelsiusACelsius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKelvinACelsius
            // 
            this.txtKelvinACelsius.Location = new System.Drawing.Point(486, 93);
            this.txtKelvinACelsius.Name = "txtKelvinACelsius";
            this.txtKelvinACelsius.ReadOnly = true;
            this.txtKelvinACelsius.Size = new System.Drawing.Size(121, 23);
            this.txtKelvinACelsius.TabIndex = 12;
            this.txtKelvinACelsius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCelsiusAKelvin
            // 
            this.txtCelsiusAKelvin.Location = new System.Drawing.Point(613, 63);
            this.txtCelsiusAKelvin.Name = "txtCelsiusAKelvin";
            this.txtCelsiusAKelvin.ReadOnly = true;
            this.txtCelsiusAKelvin.Size = new System.Drawing.Size(121, 23);
            this.txtCelsiusAKelvin.TabIndex = 13;
            this.txtCelsiusAKelvin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKelvinAKelvin
            // 
            this.txtKelvinAKelvin.Location = new System.Drawing.Point(613, 93);
            this.txtKelvinAKelvin.Name = "txtKelvinAKelvin";
            this.txtKelvinAKelvin.ReadOnly = true;
            this.txtKelvinAKelvin.Size = new System.Drawing.Size(121, 23);
            this.txtKelvinAKelvin.TabIndex = 14;
            this.txtKelvinAKelvin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConvertFahrenheit
            // 
            this.btnConvertFahrenheit.Location = new System.Drawing.Point(238, 34);
            this.btnConvertFahrenheit.Name = "btnConvertFahrenheit";
            this.btnConvertFahrenheit.Size = new System.Drawing.Size(115, 23);
            this.btnConvertFahrenheit.TabIndex = 15;
            this.btnConvertFahrenheit.Text = "->";
            this.btnConvertFahrenheit.UseVisualStyleBackColor = true;
            this.btnConvertFahrenheit.Click += new System.EventHandler(this.btnConvertFahrenheit_Click);
            // 
            // btnCelsius
            // 
            this.btnCelsius.Location = new System.Drawing.Point(238, 61);
            this.btnCelsius.Name = "btnCelsius";
            this.btnCelsius.Size = new System.Drawing.Size(115, 23);
            this.btnCelsius.TabIndex = 16;
            this.btnCelsius.Text = "->";
            this.btnCelsius.UseVisualStyleBackColor = true;
            this.btnCelsius.Click += new System.EventHandler(this.btnCelsius_Click);
            // 
            // btnConvertKevin
            // 
            this.btnConvertKevin.Location = new System.Drawing.Point(238, 92);
            this.btnConvertKevin.Name = "btnConvertKevin";
            this.btnConvertKevin.Size = new System.Drawing.Size(115, 23);
            this.btnConvertKevin.TabIndex = 17;
            this.btnConvertKevin.Text = "->";
            this.btnConvertKevin.UseVisualStyleBackColor = true;
            this.btnConvertKevin.Click += new System.EventHandler(this.btnConvertKevin_Click);
            // 
            // lblFahrenheitA
            // 
            this.lblFahrenheitA.AutoSize = true;
            this.lblFahrenheitA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFahrenheitA.Location = new System.Drawing.Point(377, 9);
            this.lblFahrenheitA.Name = "lblFahrenheitA";
            this.lblFahrenheitA.Size = new System.Drawing.Size(77, 20);
            this.lblFahrenheitA.TabIndex = 18;
            this.lblFahrenheitA.Text = "Fahrenheit";
            // 
            // lblCelsiusA
            // 
            this.lblCelsiusA.AutoSize = true;
            this.lblCelsiusA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCelsiusA.Location = new System.Drawing.Point(516, 9);
            this.lblCelsiusA.Name = "lblCelsiusA";
            this.lblCelsiusA.Size = new System.Drawing.Size(54, 20);
            this.lblCelsiusA.TabIndex = 19;
            this.lblCelsiusA.Text = "Celsius";
            // 
            // lblKelvinA
            // 
            this.lblKelvinA.AutoSize = true;
            this.lblKelvinA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKelvinA.Location = new System.Drawing.Point(650, 9);
            this.lblKelvinA.Name = "lblKelvinA";
            this.lblKelvinA.Size = new System.Drawing.Size(49, 20);
            this.lblKelvinA.TabIndex = 20;
            this.lblKelvinA.Text = "Kelvin";
            // 
            // frmVulcano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 130);
            this.Controls.Add(this.lblKelvinA);
            this.Controls.Add(this.lblCelsiusA);
            this.Controls.Add(this.lblFahrenheitA);
            this.Controls.Add(this.btnConvertKevin);
            this.Controls.Add(this.btnCelsius);
            this.Controls.Add(this.btnConvertFahrenheit);
            this.Controls.Add(this.txtKelvinAKelvin);
            this.Controls.Add(this.txtCelsiusAKelvin);
            this.Controls.Add(this.txtKelvinACelsius);
            this.Controls.Add(this.txtCelsiusACelsius);
            this.Controls.Add(this.txtKelvinAFahrenheit);
            this.Controls.Add(this.txtCelsiusAFahrenheit);
            this.Controls.Add(this.txtFahrenheitAKelvin);
            this.Controls.Add(this.txtFahrenheitACelsius);
            this.Controls.Add(this.txtFahrenheitaAFahrenheit);
            this.Controls.Add(this.txtKelvin);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.lblKelvin);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.lblFahrenheit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVulcano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vulcano";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Label lblKelvin;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtKelvin;
        private System.Windows.Forms.TextBox txtFahrenheitaAFahrenheit;
        private System.Windows.Forms.TextBox txtFahrenheitACelsius;
        private System.Windows.Forms.TextBox txtFahrenheitAKelvin;
        private System.Windows.Forms.TextBox txtCelsiusAFahrenheit;
        private System.Windows.Forms.TextBox txtKelvinAFahrenheit;
        private System.Windows.Forms.TextBox txtCelsiusACelsius;
        private System.Windows.Forms.TextBox txtKelvinACelsius;
        private System.Windows.Forms.TextBox txtCelsiusAKelvin;
        private System.Windows.Forms.TextBox txtKelvinAKelvin;
        private System.Windows.Forms.Button btnConvertFahrenheit;
        private System.Windows.Forms.Button btnCelsius;
        private System.Windows.Forms.Button btnConvertKevin;
        private System.Windows.Forms.Label lblFahrenheitA;
        private System.Windows.Forms.Label lblCelsiusA;
        private System.Windows.Forms.Label lblKelvinA;
    }
}

