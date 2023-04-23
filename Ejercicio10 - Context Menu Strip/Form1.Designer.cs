namespace WinForm07
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
            this.components = new System.ComponentModel.Container();
            this.ltbxContenido = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.borrarLíneaSeleccionadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirFicheroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarNuevoFicheroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltbxContenido
            // 
            this.ltbxContenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltbxContenido.ContextMenuStrip = this.contextMenuStrip1;
            this.ltbxContenido.FormattingEnabled = true;
            this.ltbxContenido.ItemHeight = 16;
            this.ltbxContenido.Location = new System.Drawing.Point(12, 31);
            this.ltbxContenido.Name = "ltbxContenido";
            this.ltbxContenido.Size = new System.Drawing.Size(458, 404);
            this.ltbxContenido.TabIndex = 0;
            this.ltbxContenido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ltbxContenido_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarLíneaSeleccionadaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(246, 28);
            // 
            // borrarLíneaSeleccionadaToolStripMenuItem
            // 
            this.borrarLíneaSeleccionadaToolStripMenuItem.Name = "borrarLíneaSeleccionadaToolStripMenuItem";
            this.borrarLíneaSeleccionadaToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.borrarLíneaSeleccionadaToolStripMenuItem.Text = "Borrar línea seleccionada";
            this.borrarLíneaSeleccionadaToolStripMenuItem.Click += new System.EventHandler(this.borrarLíneaSeleccionadaToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(482, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirFicheroToolStripMenuItem,
            this.guardarNuevoFicheroToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // abrirFicheroToolStripMenuItem
            // 
            this.abrirFicheroToolStripMenuItem.Name = "abrirFicheroToolStripMenuItem";
            this.abrirFicheroToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.abrirFicheroToolStripMenuItem.Text = "Abrir fichero";
            this.abrirFicheroToolStripMenuItem.Click += new System.EventHandler(this.abrirFicheroToolStripMenuItem_Click);
            // 
            // guardarNuevoFicheroToolStripMenuItem
            // 
            this.guardarNuevoFicheroToolStripMenuItem.Name = "guardarNuevoFicheroToolStripMenuItem";
            this.guardarNuevoFicheroToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.guardarNuevoFicheroToolStripMenuItem.Text = "Guardar nuevo fichero";
            this.guardarNuevoFicheroToolStripMenuItem.Click += new System.EventHandler(this.guardarNuevoFicheroToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.ltbxContenido);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "ContextMenuStrip";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltbxContenido;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem borrarLíneaSeleccionadaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirFicheroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarNuevoFicheroToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

