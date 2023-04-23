namespace WinForm06
{
    partial class frmVentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btAbrirVentana = new System.Windows.Forms.Button();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btAbrirVentana
            // 
            this.btAbrirVentana.Location = new System.Drawing.Point(27, 21);
            this.btAbrirVentana.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAbrirVentana.Name = "btAbrirVentana";
            this.btAbrirVentana.Size = new System.Drawing.Size(182, 87);
            this.btAbrirVentana.TabIndex = 0;
            this.btAbrirVentana.Text = "Ingresar valores RGB";
            this.btAbrirVentana.UseVisualStyleBackColor = true;
            this.btAbrirVentana.Click += new System.EventHandler(this.btAbrirVentana_Click);
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(27, 132);
            this.tbResultado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.ReadOnly = true;
            this.tbResultado.Size = new System.Drawing.Size(182, 20);
            this.tbResultado.TabIndex = 1;
            this.tbResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 188);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.btAbrirVentana);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(252, 227);
            this.MinimumSize = new System.Drawing.Size(252, 227);
            this.Name = "frmVentanaPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RGBToHex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAbrirVentana;
        private System.Windows.Forms.TextBox tbResultado;
    }
}

