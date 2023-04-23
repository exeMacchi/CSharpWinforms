namespace WinForm05
{
    partial class Form1
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
            this.lvContenidoFichero = new System.Windows.Forms.ListView();
            this.btFuente = new System.Windows.Forms.Button();
            this.btColorLetra = new System.Windows.Forms.Button();
            this.ofdFichero = new System.Windows.Forms.OpenFileDialog();
            this.btFicheroTexto = new System.Windows.Forms.Button();
            this.fdFuente = new System.Windows.Forms.FontDialog();
            this.cdColorFuente = new System.Windows.Forms.ColorDialog();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvContenidoFichero
            // 
            this.lvContenidoFichero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvContenidoFichero.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvContenidoFichero.Enabled = false;
            this.lvContenidoFichero.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvContenidoFichero.ForeColor = System.Drawing.Color.Black;
            this.lvContenidoFichero.HideSelection = false;
            this.lvContenidoFichero.Location = new System.Drawing.Point(12, 12);
            this.lvContenidoFichero.Name = "lvContenidoFichero";
            this.lvContenidoFichero.Size = new System.Drawing.Size(990, 398);
            this.lvContenidoFichero.TabIndex = 0;
            this.lvContenidoFichero.Tag = "";
            this.lvContenidoFichero.TileSize = new System.Drawing.Size(5000, 38);
            this.lvContenidoFichero.UseCompatibleStateImageBehavior = false;
            this.lvContenidoFichero.View = System.Windows.Forms.View.List;
            // 
            // btFuente
            // 
            this.btFuente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btFuente.ForeColor = System.Drawing.Color.Black;
            this.btFuente.Location = new System.Drawing.Point(620, 416);
            this.btFuente.Name = "btFuente";
            this.btFuente.Size = new System.Drawing.Size(169, 38);
            this.btFuente.TabIndex = 1;
            this.btFuente.Text = "Cambiar la fuente...";
            this.btFuente.UseVisualStyleBackColor = true;
            this.btFuente.Click += new System.EventHandler(this.btFuente_Click);
            // 
            // btColorLetra
            // 
            this.btColorLetra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btColorLetra.Location = new System.Drawing.Point(795, 416);
            this.btColorLetra.Name = "btColorLetra";
            this.btColorLetra.Size = new System.Drawing.Size(207, 38);
            this.btColorLetra.TabIndex = 2;
            this.btColorLetra.Text = "Cambiar color de la fuente...";
            this.btColorLetra.UseVisualStyleBackColor = true;
            this.btColorLetra.Click += new System.EventHandler(this.btColorLetra_Click);
            // 
            // btFicheroTexto
            // 
            this.btFicheroTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btFicheroTexto.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFicheroTexto.Location = new System.Drawing.Point(12, 416);
            this.btFicheroTexto.Name = "btFicheroTexto";
            this.btFicheroTexto.Size = new System.Drawing.Size(130, 38);
            this.btFicheroTexto.TabIndex = 3;
            this.btFicheroTexto.Text = "Examinar...";
            this.btFicheroTexto.UseVisualStyleBackColor = true;
            this.btFicheroTexto.Click += new System.EventHandler(this.btFicheroTexto_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 466);
            this.Controls.Add(this.btFicheroTexto);
            this.Controls.Add(this.btColorLetra);
            this.Controls.Add(this.btFuente);
            this.Controls.Add(this.lvContenidoFichero);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Cuadro de diálogo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvContenidoFichero;
        private System.Windows.Forms.Button btFuente;
        private System.Windows.Forms.Button btColorLetra;
        private System.Windows.Forms.OpenFileDialog ofdFichero;
        private System.Windows.Forms.Button btFicheroTexto;
        private System.Windows.Forms.FontDialog fdFuente;
        private System.Windows.Forms.ColorDialog cdColorFuente;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

