namespace WinForms02
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
            this.btSumar = new System.Windows.Forms.Button();
            this.btRestar = new System.Windows.Forms.Button();
            this.btMultiplicar = new System.Windows.Forms.Button();
            this.btDividir = new System.Windows.Forms.Button();
            this.tbNumero1 = new System.Windows.Forms.TextBox();
            this.tbNumero2 = new System.Windows.Forms.TextBox();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.lbNumero1 = new System.Windows.Forms.Label();
            this.lbNumero2 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSumar
            // 
            this.btSumar.Font = new System.Drawing.Font("Cascadia Code", 17F);
            this.btSumar.Location = new System.Drawing.Point(88, 145);
            this.btSumar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSumar.Name = "btSumar";
            this.btSumar.Size = new System.Drawing.Size(80, 70);
            this.btSumar.TabIndex = 2;
            this.btSumar.Text = "+";
            this.btSumar.UseVisualStyleBackColor = true;
            this.btSumar.Click += new System.EventHandler(this.btSumar_Click);
            // 
            // btRestar
            // 
            this.btRestar.Font = new System.Drawing.Font("Cascadia Code", 17F);
            this.btRestar.Location = new System.Drawing.Point(172, 145);
            this.btRestar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btRestar.Name = "btRestar";
            this.btRestar.Size = new System.Drawing.Size(80, 70);
            this.btRestar.TabIndex = 3;
            this.btRestar.Text = "-";
            this.btRestar.UseVisualStyleBackColor = true;
            this.btRestar.Click += new System.EventHandler(this.btRestar_Click);
            // 
            // btMultiplicar
            // 
            this.btMultiplicar.Font = new System.Drawing.Font("Cascadia Code", 17F);
            this.btMultiplicar.Location = new System.Drawing.Point(88, 220);
            this.btMultiplicar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btMultiplicar.Name = "btMultiplicar";
            this.btMultiplicar.Size = new System.Drawing.Size(80, 70);
            this.btMultiplicar.TabIndex = 4;
            this.btMultiplicar.Text = "x";
            this.btMultiplicar.UseVisualStyleBackColor = true;
            this.btMultiplicar.Click += new System.EventHandler(this.lbMultiplicar_Click);
            // 
            // btDividir
            // 
            this.btDividir.Font = new System.Drawing.Font("Cascadia Code", 14F);
            this.btDividir.Location = new System.Drawing.Point(172, 220);
            this.btDividir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btDividir.Name = "btDividir";
            this.btDividir.Size = new System.Drawing.Size(80, 70);
            this.btDividir.TabIndex = 5;
            this.btDividir.Text = "/";
            this.btDividir.UseVisualStyleBackColor = true;
            this.btDividir.Click += new System.EventHandler(this.btDividir_Click);
            // 
            // tbNumero1
            // 
            this.tbNumero1.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero1.Location = new System.Drawing.Point(88, 54);
            this.tbNumero1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNumero1.Name = "tbNumero1";
            this.tbNumero1.Size = new System.Drawing.Size(164, 23);
            this.tbNumero1.TabIndex = 0;
            this.tbNumero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNumero1.TextChanged += new System.EventHandler(this.tbNumero1_TextChanged);
            this.tbNumero1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumero1_KeyPress);
            // 
            // tbNumero2
            // 
            this.tbNumero2.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero2.Location = new System.Drawing.Point(88, 108);
            this.tbNumero2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNumero2.Name = "tbNumero2";
            this.tbNumero2.Size = new System.Drawing.Size(164, 23);
            this.tbNumero2.TabIndex = 1;
            this.tbNumero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNumero2.TextChanged += new System.EventHandler(this.tbNumero2_TextChanged);
            this.tbNumero2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumero2_KeyPress);
            // 
            // tbResultado
            // 
            this.tbResultado.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResultado.Location = new System.Drawing.Point(88, 332);
            this.tbResultado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.ReadOnly = true;
            this.tbResultado.Size = new System.Drawing.Size(164, 29);
            this.tbResultado.TabIndex = 6;
            this.tbResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbNumero1
            // 
            this.lbNumero1.AutoSize = true;
            this.lbNumero1.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero1.Location = new System.Drawing.Point(135, 34);
            this.lbNumero1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNumero1.Name = "lbNumero1";
            this.lbNumero1.Size = new System.Drawing.Size(72, 18);
            this.lbNumero1.TabIndex = 7;
            this.lbNumero1.Text = "Número 1";
            // 
            // lbNumero2
            // 
            this.lbNumero2.AutoSize = true;
            this.lbNumero2.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero2.Location = new System.Drawing.Point(135, 88);
            this.lbNumero2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNumero2.Name = "lbNumero2";
            this.lbNumero2.Size = new System.Drawing.Size(72, 18);
            this.lbNumero2.TabIndex = 8;
            this.lbNumero2.Text = "Número 2";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(125, 309);
            this.lbResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(91, 21);
            this.lbResultado.TabIndex = 9;
            this.lbResultado.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 415);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbNumero2);
            this.Controls.Add(this.lbNumero1);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.tbNumero2);
            this.Controls.Add(this.tbNumero1);
            this.Controls.Add(this.btDividir);
            this.Controls.Add(this.btMultiplicar);
            this.Controls.Add(this.btRestar);
            this.Controls.Add(this.btSumar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(364, 454);
            this.MinimumSize = new System.Drawing.Size(364, 454);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSumar;
        private System.Windows.Forms.Button btRestar;
        private System.Windows.Forms.Button btMultiplicar;
        private System.Windows.Forms.Button btDividir;
        private System.Windows.Forms.TextBox tbNumero1;
        private System.Windows.Forms.TextBox tbNumero2;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.Label lbNumero1;
        private System.Windows.Forms.Label lbNumero2;
        private System.Windows.Forms.Label lbResultado;
    }
}

