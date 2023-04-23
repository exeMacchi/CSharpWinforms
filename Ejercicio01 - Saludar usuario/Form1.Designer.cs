namespace WinForm1
{
    partial class frmVentana
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
            this.btSaludar = new System.Windows.Forms.Button();
            this.lbBoton = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSaludar
            // 
            this.btSaludar.Location = new System.Drawing.Point(151, 158);
            this.btSaludar.Margin = new System.Windows.Forms.Padding(4);
            this.btSaludar.Name = "btSaludar";
            this.btSaludar.Size = new System.Drawing.Size(257, 92);
            this.btSaludar.TabIndex = 0;
            this.btSaludar.Text = "SALUDAR";
            this.btSaludar.UseVisualStyleBackColor = true;
            this.btSaludar.Click += new System.EventHandler(this.btSaludar_Click);
            // 
            // lbBoton
            // 
            this.lbBoton.AutoSize = true;
            this.lbBoton.Location = new System.Drawing.Point(118, 137);
            this.lbBoton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBoton.Name = "lbBoton";
            this.lbBoton.Size = new System.Drawing.Size(336, 17);
            this.lbBoton.TabIndex = 1;
            this.lbBoton.Text = "Haga click en el botón para que lo salude";
            this.lbBoton.Click += new System.EventHandler(this.lbBoton_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(185, 62);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(352, 23);
            this.tbNombre.TabIndex = 2;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            this.tbNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNombre_KeyDown);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(25, 65);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(152, 17);
            this.lbNombre.TabIndex = 3;
            this.lbNombre.Text = "Escriba su nombre:";
            // 
            // frmVentana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(564, 280);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbBoton);
            this.Controls.Add(this.btSaludar);
            this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmVentana";
            this.ShowIcon = false;
            this.Text = "Saludar al usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVentana_FormClosing);
            this.Load += new System.EventHandler(this.frmVentana_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSaludar;
        private System.Windows.Forms.Label lbBoton;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbNombre;
    }
}

