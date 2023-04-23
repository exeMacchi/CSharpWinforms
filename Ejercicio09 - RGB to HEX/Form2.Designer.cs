namespace Ejercicio09___RGB_to_HEX
{
    partial class frmVentanaRGB
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
            this.components = new System.ComponentModel.Container();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.tbRojo = new System.Windows.Forms.TextBox();
            this.tbVerde = new System.Windows.Forms.TextBox();
            this.tbAzul = new System.Windows.Forms.TextBox();
            this.lbRojo = new System.Windows.Forms.Label();
            this.lbVerde = new System.Windows.Forms.Label();
            this.lbAzul = new System.Windows.Forms.Label();
            this.btConfirmarRGB = new System.Windows.Forms.Button();
            this.ttMensajeEmergente = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(35, 23);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(241, 22);
            this.lbTitulo.TabIndex = 7;
            this.lbTitulo.Text = "Introduzca los valores RGB";
            // 
            // tbRojo
            // 
            this.tbRojo.Location = new System.Drawing.Point(103, 66);
            this.tbRojo.MaxLength = 3;
            this.tbRojo.Name = "tbRojo";
            this.tbRojo.Size = new System.Drawing.Size(143, 20);
            this.tbRojo.TabIndex = 1;
            this.tbRojo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRojo.TextChanged += new System.EventHandler(this.tbRojo_TextChanged);
            this.tbRojo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRojo_KeyPress);
            // 
            // tbVerde
            // 
            this.tbVerde.Location = new System.Drawing.Point(103, 102);
            this.tbVerde.MaxLength = 3;
            this.tbVerde.Name = "tbVerde";
            this.tbVerde.Size = new System.Drawing.Size(143, 20);
            this.tbVerde.TabIndex = 2;
            this.tbVerde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbVerde.TextChanged += new System.EventHandler(this.tbVerde_TextChanged);
            this.tbVerde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbVerde_KeyPress);
            // 
            // tbAzul
            // 
            this.tbAzul.Location = new System.Drawing.Point(103, 141);
            this.tbAzul.MaxLength = 3;
            this.tbAzul.Name = "tbAzul";
            this.tbAzul.Size = new System.Drawing.Size(143, 20);
            this.tbAzul.TabIndex = 3;
            this.tbAzul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAzul.TextChanged += new System.EventHandler(this.tbAzul_TextChanged);
            this.tbAzul.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAzul_KeyPress);
            // 
            // lbRojo
            // 
            this.lbRojo.AutoSize = true;
            this.lbRojo.ForeColor = System.Drawing.Color.DarkRed;
            this.lbRojo.Location = new System.Drawing.Point(54, 69);
            this.lbRojo.Name = "lbRojo";
            this.lbRojo.Size = new System.Drawing.Size(29, 13);
            this.lbRojo.TabIndex = 11;
            this.lbRojo.Text = "Rojo";
            // 
            // lbVerde
            // 
            this.lbVerde.AutoSize = true;
            this.lbVerde.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbVerde.Location = new System.Drawing.Point(48, 105);
            this.lbVerde.Name = "lbVerde";
            this.lbVerde.Size = new System.Drawing.Size(35, 13);
            this.lbVerde.TabIndex = 12;
            this.lbVerde.Text = "Verde";
            // 
            // lbAzul
            // 
            this.lbAzul.AutoSize = true;
            this.lbAzul.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbAzul.Location = new System.Drawing.Point(56, 144);
            this.lbAzul.Name = "lbAzul";
            this.lbAzul.Size = new System.Drawing.Size(27, 13);
            this.lbAzul.TabIndex = 13;
            this.lbAzul.Text = "Azul";
            // 
            // btConfirmarRGB
            // 
            this.btConfirmarRGB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btConfirmarRGB.Location = new System.Drawing.Point(39, 187);
            this.btConfirmarRGB.Name = "btConfirmarRGB";
            this.btConfirmarRGB.Size = new System.Drawing.Size(237, 71);
            this.btConfirmarRGB.TabIndex = 4;
            this.btConfirmarRGB.Text = "CONVERTIR";
            this.btConfirmarRGB.UseVisualStyleBackColor = true;
            this.btConfirmarRGB.Click += new System.EventHandler(this.btConfirmarRGB_Click);
            // 
            // ttMensajeEmergente
            // 
            this.ttMensajeEmergente.AutoPopDelay = 5000;
            this.ttMensajeEmergente.InitialDelay = 250;
            this.ttMensajeEmergente.ReshowDelay = 100;
            // 
            // frmVentanaRGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 283);
            this.Controls.Add(this.btConfirmarRGB);
            this.Controls.Add(this.lbAzul);
            this.Controls.Add(this.lbVerde);
            this.Controls.Add(this.lbRojo);
            this.Controls.Add(this.tbAzul);
            this.Controls.Add(this.tbVerde);
            this.Controls.Add(this.tbRojo);
            this.Controls.Add(this.lbTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(323, 322);
            this.Name = "frmVentanaRGB";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RGBToHEX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TextBox tbRojo;
        private System.Windows.Forms.TextBox tbVerde;
        private System.Windows.Forms.TextBox tbAzul;
        private System.Windows.Forms.Label lbRojo;
        private System.Windows.Forms.Label lbVerde;
        private System.Windows.Forms.Label lbAzul;
        private System.Windows.Forms.Button btConfirmarRGB;
        private System.Windows.Forms.ToolTip ttMensajeEmergente;
    }
}