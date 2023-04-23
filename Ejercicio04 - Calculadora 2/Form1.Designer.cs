namespace WinForm03
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
            this.tbNumero1 = new System.Windows.Forms.TextBox();
            this.tbNumero2 = new System.Windows.Forms.TextBox();
            this.lbNumero1 = new System.Windows.Forms.Label();
            this.lbNumero2 = new System.Windows.Forms.Label();
            this.rbSumar = new System.Windows.Forms.RadioButton();
            this.rbRestar = new System.Windows.Forms.RadioButton();
            this.rbMultiplicar = new System.Windows.Forms.RadioButton();
            this.rbDividir = new System.Windows.Forms.RadioButton();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.lvHistorial = new System.Windows.Forms.ListView();
            this.lbHistorial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNumero1
            // 
            this.tbNumero1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero1.Location = new System.Drawing.Point(40, 38);
            this.tbNumero1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNumero1.Name = "tbNumero1";
            this.tbNumero1.Size = new System.Drawing.Size(259, 26);
            this.tbNumero1.TabIndex = 0;
            this.tbNumero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNumero1.TextChanged += new System.EventHandler(this.tbNumero1_TextChanged);
            this.tbNumero1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumero1_KeyPress);
            // 
            // tbNumero2
            // 
            this.tbNumero2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero2.Location = new System.Drawing.Point(40, 99);
            this.tbNumero2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNumero2.Name = "tbNumero2";
            this.tbNumero2.Size = new System.Drawing.Size(259, 26);
            this.tbNumero2.TabIndex = 1;
            this.tbNumero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNumero2.TextChanged += new System.EventHandler(this.tbNumero2_TextChanged);
            this.tbNumero2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumero2_KeyPress);
            // 
            // lbNumero1
            // 
            this.lbNumero1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNumero1.AutoSize = true;
            this.lbNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero1.Location = new System.Drawing.Point(122, 16);
            this.lbNumero1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNumero1.Name = "lbNumero1";
            this.lbNumero1.Size = new System.Drawing.Size(86, 20);
            this.lbNumero1.TabIndex = 2;
            this.lbNumero1.Text = "Número 1";
            // 
            // lbNumero2
            // 
            this.lbNumero2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNumero2.AutoSize = true;
            this.lbNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero2.Location = new System.Drawing.Point(122, 77);
            this.lbNumero2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNumero2.Name = "lbNumero2";
            this.lbNumero2.Size = new System.Drawing.Size(86, 20);
            this.lbNumero2.TabIndex = 3;
            this.lbNumero2.Text = "Número 2";
            // 
            // rbSumar
            // 
            this.rbSumar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbSumar.AutoSize = true;
            this.rbSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSumar.Location = new System.Drawing.Point(40, 144);
            this.rbSumar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbSumar.Name = "rbSumar";
            this.rbSumar.Size = new System.Drawing.Size(74, 24);
            this.rbSumar.TabIndex = 4;
            this.rbSumar.Text = "Sumar";
            this.rbSumar.UseVisualStyleBackColor = true;
            this.rbSumar.CheckedChanged += new System.EventHandler(this.rbSumar_CheckedChanged);
            // 
            // rbRestar
            // 
            this.rbRestar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbRestar.AutoSize = true;
            this.rbRestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRestar.Location = new System.Drawing.Point(40, 171);
            this.rbRestar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbRestar.Name = "rbRestar";
            this.rbRestar.Size = new System.Drawing.Size(75, 24);
            this.rbRestar.TabIndex = 5;
            this.rbRestar.Text = "Restar";
            this.rbRestar.UseVisualStyleBackColor = true;
            this.rbRestar.CheckedChanged += new System.EventHandler(this.rbRestar_CheckedChanged);
            // 
            // rbMultiplicar
            // 
            this.rbMultiplicar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbMultiplicar.AutoSize = true;
            this.rbMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMultiplicar.Location = new System.Drawing.Point(40, 198);
            this.rbMultiplicar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbMultiplicar.Name = "rbMultiplicar";
            this.rbMultiplicar.Size = new System.Drawing.Size(97, 24);
            this.rbMultiplicar.TabIndex = 6;
            this.rbMultiplicar.Text = "Multiplicar";
            this.rbMultiplicar.UseVisualStyleBackColor = true;
            this.rbMultiplicar.CheckedChanged += new System.EventHandler(this.rbMultiplicar_CheckedChanged);
            // 
            // rbDividir
            // 
            this.rbDividir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbDividir.AutoSize = true;
            this.rbDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDividir.Location = new System.Drawing.Point(40, 225);
            this.rbDividir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbDividir.Name = "rbDividir";
            this.rbDividir.Size = new System.Drawing.Size(69, 24);
            this.rbDividir.TabIndex = 7;
            this.rbDividir.Text = "Dividir";
            this.rbDividir.UseVisualStyleBackColor = true;
            this.rbDividir.CheckedChanged += new System.EventHandler(this.rbDividir_CheckedChanged);
            // 
            // tbResultado
            // 
            this.tbResultado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResultado.Location = new System.Drawing.Point(40, 299);
            this.tbResultado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.ReadOnly = true;
            this.tbResultado.Size = new System.Drawing.Size(259, 29);
            this.tbResultado.TabIndex = 8;
            this.tbResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbResultado
            // 
            this.lbResultado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(114, 273);
            this.lbResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(103, 24);
            this.lbResultado.TabIndex = 9;
            this.lbResultado.Text = "Resultado";
            // 
            // btCalcular
            // 
            this.btCalcular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(144, 147);
            this.btCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(155, 102);
            this.btCalcular.TabIndex = 10;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // lvHistorial
            // 
            this.lvHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lvHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvHistorial.HideSelection = false;
            this.lvHistorial.Location = new System.Drawing.Point(21, 362);
            this.lvHistorial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvHistorial.Name = "lvHistorial";
            this.lvHistorial.Size = new System.Drawing.Size(278, 71);
            this.lvHistorial.TabIndex = 11;
            this.lvHistorial.UseCompatibleStateImageBehavior = false;
            this.lvHistorial.View = System.Windows.Forms.View.List;
            // 
            // lbHistorial
            // 
            this.lbHistorial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbHistorial.AutoSize = true;
            this.lbHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHistorial.Location = new System.Drawing.Point(17, 340);
            this.lbHistorial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHistorial.Name = "lbHistorial";
            this.lbHistorial.Size = new System.Drawing.Size(75, 20);
            this.lbHistorial.TabIndex = 12;
            this.lbHistorial.Text = "Historial";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 456);
            this.Controls.Add(this.lbHistorial);
            this.Controls.Add(this.lvHistorial);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.rbDividir);
            this.Controls.Add(this.rbMultiplicar);
            this.Controls.Add(this.rbRestar);
            this.Controls.Add(this.rbSumar);
            this.Controls.Add(this.lbNumero2);
            this.Controls.Add(this.lbNumero1);
            this.Controls.Add(this.tbNumero2);
            this.Controls.Add(this.tbNumero1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(342, 656);
            this.MinimumSize = new System.Drawing.Size(342, 493);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumero1;
        private System.Windows.Forms.TextBox tbNumero2;
        private System.Windows.Forms.Label lbNumero1;
        private System.Windows.Forms.Label lbNumero2;
        private System.Windows.Forms.RadioButton rbSumar;
        private System.Windows.Forms.RadioButton rbRestar;
        private System.Windows.Forms.RadioButton rbMultiplicar;
        private System.Windows.Forms.RadioButton rbDividir;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.ListView lvHistorial;
        private System.Windows.Forms.Label lbHistorial;
    }
}

