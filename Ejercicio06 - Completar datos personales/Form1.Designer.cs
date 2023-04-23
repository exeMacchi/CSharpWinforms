namespace WinForm4
{
    partial class formPrincipal
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
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.Location = new System.Drawing.Point(35, 35);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(118, 26);
            this.lbApellido.TabIndex = 0;
            this.lbApellido.Text = "APELLIDO";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(46, 77);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(107, 26);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "NOMBRE";
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdad.Location = new System.Drawing.Point(78, 119);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(73, 26);
            this.lbEdad.TabIndex = 2;
            this.lbEdad.Text = "EDAD";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccion.Location = new System.Drawing.Point(24, 160);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(127, 26);
            this.lbDireccion.TabIndex = 3;
            this.lbDireccion.Text = "DIRECCIÓN";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(12, 214);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(139, 26);
            this.lbResultado.TabIndex = 4;
            this.lbResultado.Text = "RESULTADO";
            // 
            // tbApellido
            // 
            this.tbApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbApellido.BackColor = System.Drawing.SystemColors.Window;
            this.tbApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbApellido.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellido.Location = new System.Drawing.Point(159, 35);
            this.tbApellido.MaxLength = 50;
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(371, 29);
            this.tbApellido.TabIndex = 0;
            this.tbApellido.TextChanged += new System.EventHandler(this.tbApellido_TextChanged);
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombre.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(159, 74);
            this.tbNombre.MaxLength = 50;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(371, 29);
            this.tbNombre.TabIndex = 1;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // tbEdad
            // 
            this.tbEdad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEdad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbEdad.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEdad.Location = new System.Drawing.Point(159, 116);
            this.tbEdad.MaxLength = 3;
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(87, 29);
            this.tbEdad.TabIndex = 2;
            this.tbEdad.TextChanged += new System.EventHandler(this.tbEdad_TextChanged);
            this.tbEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEdad_KeyPress);
            // 
            // tbDireccion
            // 
            this.tbDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDireccion.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDireccion.Location = new System.Drawing.Point(159, 160);
            this.tbDireccion.MaxLength = 100;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(371, 29);
            this.tbDireccion.TabIndex = 3;
            this.tbDireccion.TextChanged += new System.EventHandler(this.tbDireccion_TextChanged);
            // 
            // tbResultado
            // 
            this.tbResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResultado.BackColor = System.Drawing.SystemColors.Window;
            this.tbResultado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbResultado.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResultado.Location = new System.Drawing.Point(12, 243);
            this.tbResultado.MaxLength = 100;
            this.tbResultado.Multiline = true;
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.ReadOnly = true;
            this.tbResultado.Size = new System.Drawing.Size(518, 151);
            this.tbResultado.TabIndex = 6;
            // 
            // btAceptar
            // 
            this.btAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btAceptar.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(100, 428);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(146, 35);
            this.btAceptar.TabIndex = 4;
            this.btAceptar.Text = "ACEPTAR";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            this.btAceptar.MouseLeave += new System.EventHandler(this.btAceptar_MouseLeave);
            this.btAceptar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btAceptar_MouseMove);
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btCancelar.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(293, 428);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(146, 35);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            this.btCancelar.MouseLeave += new System.EventHandler(this.btCancelar_MouseLeave);
            this.btCancelar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btCancelar_MouseMove);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(548, 486);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbApellido);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximumSize = new System.Drawing.Size(700, 600);
            this.MinimumSize = new System.Drawing.Size(566, 533);
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos personales";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
    }
}

