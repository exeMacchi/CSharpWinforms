namespace WinForm2
{
    partial class frmPerfilPersona
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lviewElementos = new System.Windows.Forms.ListView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblPreguntaChocolate = new System.Windows.Forms.Label();
            this.cbxChocolate = new System.Windows.Forms.CheckBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.rbtnGMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnGFemenino = new System.Windows.Forms.RadioButton();
            this.rbtnGOtro = new System.Windows.Forms.RadioButton();
            this.combxColorFav = new System.Windows.Forms.ComboBox();
            this.lblColorFav = new System.Windows.Forms.Label();
            this.btVerPerfil = new System.Windows.Forms.Button();
            this.btAceptarPerfil = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(160, 64);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(366, 22);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lviewElementos
            // 
            this.lviewElementos.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lviewElementos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lviewElementos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lviewElementos.HideSelection = false;
            this.lviewElementos.Location = new System.Drawing.Point(158, 220);
            this.lviewElementos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lviewElementos.Name = "lviewElementos";
            this.lviewElementos.Size = new System.Drawing.Size(366, 244);
            this.lviewElementos.TabIndex = 8;
            this.lviewElementos.UseCompatibleStateImageBehavior = false;
            this.lviewElementos.View = System.Windows.Forms.View.List;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(177, 6);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(222, 45);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Perfil personal";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(105, 67);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(160, 98);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(366, 22);
            this.dtpFechaNacimiento.TabIndex = 1;
            this.dtpFechaNacimiento.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(40, 101);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(116, 13);
            this.lblFechaNacimiento.TabIndex = 6;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lblPreguntaChocolate
            // 
            this.lblPreguntaChocolate.AutoSize = true;
            this.lblPreguntaChocolate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreguntaChocolate.Location = new System.Drawing.Point(31, 129);
            this.lblPreguntaChocolate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreguntaChocolate.Name = "lblPreguntaChocolate";
            this.lblPreguntaChocolate.Size = new System.Drawing.Size(125, 13);
            this.lblPreguntaChocolate.TabIndex = 7;
            this.lblPreguntaChocolate.Text = "¿Te gusta el chocolate?";
            // 
            // cbxChocolate
            // 
            this.cbxChocolate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxChocolate.AutoSize = true;
            this.cbxChocolate.Location = new System.Drawing.Point(160, 130);
            this.cbxChocolate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxChocolate.Name = "cbxChocolate";
            this.cbxChocolate.Size = new System.Drawing.Size(15, 14);
            this.cbxChocolate.TabIndex = 2;
            this.cbxChocolate.UseVisualStyleBackColor = true;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(112, 153);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 13);
            this.lblGenero.TabIndex = 9;
            this.lblGenero.Text = "Género";
            // 
            // rbtnGMasculino
            // 
            this.rbtnGMasculino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnGMasculino.AutoSize = true;
            this.rbtnGMasculino.Checked = true;
            this.rbtnGMasculino.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnGMasculino.Location = new System.Drawing.Point(160, 152);
            this.rbtnGMasculino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnGMasculino.Name = "rbtnGMasculino";
            this.rbtnGMasculino.Size = new System.Drawing.Size(78, 17);
            this.rbtnGMasculino.TabIndex = 3;
            this.rbtnGMasculino.TabStop = true;
            this.rbtnGMasculino.Text = "Masculino";
            this.rbtnGMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnGFemenino
            // 
            this.rbtnGFemenino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnGFemenino.AutoSize = true;
            this.rbtnGFemenino.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnGFemenino.Location = new System.Drawing.Point(244, 152);
            this.rbtnGFemenino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnGFemenino.Name = "rbtnGFemenino";
            this.rbtnGFemenino.Size = new System.Drawing.Size(76, 17);
            this.rbtnGFemenino.TabIndex = 4;
            this.rbtnGFemenino.Text = "Femenino";
            this.rbtnGFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnGOtro
            // 
            this.rbtnGOtro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnGOtro.AutoSize = true;
            this.rbtnGOtro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnGOtro.Location = new System.Drawing.Point(326, 152);
            this.rbtnGOtro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnGOtro.Name = "rbtnGOtro";
            this.rbtnGOtro.Size = new System.Drawing.Size(49, 17);
            this.rbtnGOtro.TabIndex = 5;
            this.rbtnGOtro.TabStop = true;
            this.rbtnGOtro.Text = "Otro";
            this.rbtnGOtro.UseVisualStyleBackColor = true;
            // 
            // combxColorFav
            // 
            this.combxColorFav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combxColorFav.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combxColorFav.FormattingEnabled = true;
            this.combxColorFav.Items.AddRange(new object[] {
            "Amarillo",
            "Azul",
            "Blanco",
            "Naranja",
            "Negro",
            "Rojo",
            "Rosa",
            "Verde"});
            this.combxColorFav.Location = new System.Drawing.Point(160, 176);
            this.combxColorFav.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.combxColorFav.Name = "combxColorFav";
            this.combxColorFav.Size = new System.Drawing.Size(366, 21);
            this.combxColorFav.TabIndex = 6;
            this.combxColorFav.TextChanged += new System.EventHandler(this.combxColorFav_TextChanged);
            // 
            // lblColorFav
            // 
            this.lblColorFav.AutoSize = true;
            this.lblColorFav.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorFav.Location = new System.Drawing.Point(15, 179);
            this.lblColorFav.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColorFav.Name = "lblColorFav";
            this.lblColorFav.Size = new System.Drawing.Size(140, 13);
            this.lblColorFav.TabIndex = 14;
            this.lblColorFav.Text = "¿Cuál es tu color favorito?";
            // 
            // btVerPerfil
            // 
            this.btVerPerfil.BackColor = System.Drawing.Color.SteelBlue;
            this.btVerPerfil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btVerPerfil.FlatAppearance.BorderSize = 3;
            this.btVerPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btVerPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btVerPerfil.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btVerPerfil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerPerfil.Location = new System.Drawing.Point(34, 220);
            this.btVerPerfil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btVerPerfil.Name = "btVerPerfil";
            this.btVerPerfil.Size = new System.Drawing.Size(120, 52);
            this.btVerPerfil.TabIndex = 7;
            this.btVerPerfil.Text = "VER PERFIL";
            this.btVerPerfil.UseVisualStyleBackColor = false;
            this.btVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // btAceptarPerfil
            // 
            this.btAceptarPerfil.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAceptarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btAceptarPerfil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptarPerfil.Location = new System.Drawing.Point(32, 420);
            this.btAceptarPerfil.Name = "btAceptarPerfil";
            this.btAceptarPerfil.Size = new System.Drawing.Size(120, 43);
            this.btAceptarPerfil.TabIndex = 15;
            this.btAceptarPerfil.Text = "AGREGAR";
            this.btAceptarPerfil.UseVisualStyleBackColor = true;
            this.btAceptarPerfil.Click += new System.EventHandler(this.btAceptarPerfil_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(32, 371);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(119, 43);
            this.btCancelar.TabIndex = 16;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // frmPerfilPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(574, 475);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptarPerfil);
            this.Controls.Add(this.btVerPerfil);
            this.Controls.Add(this.lblColorFav);
            this.Controls.Add(this.combxColorFav);
            this.Controls.Add(this.rbtnGOtro);
            this.Controls.Add(this.rbtnGFemenino);
            this.Controls.Add(this.rbtnGMasculino);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.cbxChocolate);
            this.Controls.Add(this.lblPreguntaChocolate);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lviewElementos);
            this.Controls.Add(this.txtNombre);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(590, 514);
            this.MinimumSize = new System.Drawing.Size(578, 493);
            this.Name = "frmPerfilPersona";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil personal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListView lviewElementos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblPreguntaChocolate;
        private System.Windows.Forms.CheckBox cbxChocolate;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.RadioButton rbtnGMasculino;
        private System.Windows.Forms.RadioButton rbtnGFemenino;
        private System.Windows.Forms.RadioButton rbtnGOtro;
        private System.Windows.Forms.ComboBox combxColorFav;
        private System.Windows.Forms.Label lblColorFav;
        private System.Windows.Forms.Button btVerPerfil;
        private System.Windows.Forms.Button btAceptarPerfil;
        private System.Windows.Forms.Button btCancelar;
    }
}

