namespace WinForm01
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
            this.btPulsar = new System.Windows.Forms.Button();
            this.lbPulsar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btPulsar
            // 
            this.btPulsar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btPulsar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btPulsar.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPulsar.Location = new System.Drawing.Point(86, 62);
            this.btPulsar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btPulsar.Name = "btPulsar";
            this.btPulsar.Size = new System.Drawing.Size(177, 74);
            this.btPulsar.TabIndex = 0;
            this.btPulsar.Text = "Presióname";
            this.btPulsar.UseVisualStyleBackColor = false;
            this.btPulsar.Click += new System.EventHandler(this.btPulsar_Click);
            // 
            // lbPulsar
            // 
            this.lbPulsar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPulsar.AutoSize = true;
            this.lbPulsar.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPulsar.Location = new System.Drawing.Point(82, 170);
            this.lbPulsar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPulsar.Name = "lbPulsar";
            this.lbPulsar.Size = new System.Drawing.Size(181, 21);
            this.lbPulsar.TabIndex = 1;
            this.lbPulsar.Text = "¡Presiona el botón!";
            this.lbPulsar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPulsar.SizeChanged += new System.EventHandler(this.lbPulsar_SizeChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 248);
            this.Controls.Add(this.lbPulsar);
            this.Controls.Add(this.btPulsar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Contador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPulsar;
        private System.Windows.Forms.Label lbPulsar;
    }
}

