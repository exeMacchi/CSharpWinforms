namespace Ejercicio05___Crear_perfil_persona
{
    partial class frmVentanaPrincipal
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
            this.menstrpPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ltvwPersonas = new System.Windows.Forms.ListView();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btAgregarNuevoPerfil = new System.Windows.Forms.Button();
            this.menstrpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menstrpPrincipal
            // 
            this.menstrpPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menstrpPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menstrpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menstrpPrincipal.Name = "menstrpPrincipal";
            this.menstrpPrincipal.Size = new System.Drawing.Size(463, 24);
            this.menstrpPrincipal.TabIndex = 0;
            this.menstrpPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPerfilToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // nuevoPerfilToolStripMenuItem
            // 
            this.nuevoPerfilToolStripMenuItem.Name = "nuevoPerfilToolStripMenuItem";
            this.nuevoPerfilToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.nuevoPerfilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoPerfilToolStripMenuItem.Text = "Nuevo perfil";
            this.nuevoPerfilToolStripMenuItem.Click += new System.EventHandler(this.nuevoPerfilToolStripMenuItem_Click);
            // 
            // ltvwPersonas
            // 
            this.ltvwPersonas.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.ltvwPersonas.HideSelection = false;
            this.ltvwPersonas.Location = new System.Drawing.Point(12, 106);
            this.ltvwPersonas.Name = "ltvwPersonas";
            this.ltvwPersonas.Size = new System.Drawing.Size(439, 216);
            this.ltvwPersonas.TabIndex = 1;
            this.ltvwPersonas.UseCompatibleStateImageBehavior = false;
            this.ltvwPersonas.View = System.Windows.Forms.View.List;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(12, 84);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(148, 19);
            this.lbTitulo.TabIndex = 2;
            this.lbTitulo.Text = "Personas registradas";
            // 
            // btAgregarNuevoPerfil
            // 
            this.btAgregarNuevoPerfil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarNuevoPerfil.Location = new System.Drawing.Point(348, 27);
            this.btAgregarNuevoPerfil.Name = "btAgregarNuevoPerfil";
            this.btAgregarNuevoPerfil.Size = new System.Drawing.Size(103, 73);
            this.btAgregarNuevoPerfil.TabIndex = 3;
            this.btAgregarNuevoPerfil.Text = "Nuevo perfil";
            this.btAgregarNuevoPerfil.UseVisualStyleBackColor = true;
            this.btAgregarNuevoPerfil.Click += new System.EventHandler(this.btAgregarNuevoPerfil_Click);
            // 
            // frmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(463, 334);
            this.Controls.Add(this.btAgregarNuevoPerfil);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.ltvwPersonas);
            this.Controls.Add(this.menstrpPrincipal);
            this.MainMenuStrip = this.menstrpPrincipal;
            this.Name = "frmVentanaPrincipal";
            this.ShowIcon = false;
            this.Text = "frmVentanaPrincipal";
            this.menstrpPrincipal.ResumeLayout(false);
            this.menstrpPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menstrpPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoPerfilToolStripMenuItem;
        private System.Windows.Forms.ListView ltvwPersonas;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btAgregarNuevoPerfil;
    }
}