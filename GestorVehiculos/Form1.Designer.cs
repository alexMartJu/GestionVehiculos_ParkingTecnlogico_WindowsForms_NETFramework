namespace GestorVehiculos
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblMenu = new System.Windows.Forms.Label();
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parkingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPrincipal = new System.Windows.Forms.ToolStrip();
            this.btnVehiculosToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTiposToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCerrarToolStrip = new System.Windows.Forms.ToolStripButton();
            this.btnAbrirVehiculos = new System.Windows.Forms.Button();
            this.btnAbrirTiposVehiculo = new System.Windows.Forms.Button();
            this.menuStripPrincipal.SuspendLayout();
            this.toolStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(0, 93);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(617, 65);
            this.lblMenu.TabIndex = 5;
            this.lblMenu.Text = "Parking Tecnológico";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.parkingToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(617, 24);
            this.menuStripPrincipal.TabIndex = 6;
            this.menuStripPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // parkingToolStripMenuItem
            // 
            this.parkingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehiculosToolStripMenuItem,
            this.tiposToolStripMenuItem});
            this.parkingToolStripMenuItem.Name = "parkingToolStripMenuItem";
            this.parkingToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.parkingToolStripMenuItem.Text = "Parking";
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.vehiculosToolStripMenuItem.Text = "Vehiculos";
            this.vehiculosToolStripMenuItem.Click += new System.EventHandler(this.vehiculosToolStripMenuItem_Click);
            // 
            // tiposToolStripMenuItem
            // 
            this.tiposToolStripMenuItem.Name = "tiposToolStripMenuItem";
            this.tiposToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.tiposToolStripMenuItem.Text = "Tipos";
            this.tiposToolStripMenuItem.Click += new System.EventHandler(this.tiposToolStripMenuItem_Click);
            // 
            // toolStripPrincipal
            // 
            this.toolStripPrincipal.AutoSize = false;
            this.toolStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVehiculosToolStrip,
            this.toolStripSeparator1,
            this.btnTiposToolStrip,
            this.toolStripSeparator2,
            this.btnCerrarToolStrip});
            this.toolStripPrincipal.Location = new System.Drawing.Point(0, 24);
            this.toolStripPrincipal.Name = "toolStripPrincipal";
            this.toolStripPrincipal.Size = new System.Drawing.Size(617, 40);
            this.toolStripPrincipal.TabIndex = 7;
            this.toolStripPrincipal.Text = "toolStripPrincipal";
            // 
            // btnVehiculosToolStrip
            // 
            this.btnVehiculosToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVehiculosToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("btnVehiculosToolStrip.Image")));
            this.btnVehiculosToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnVehiculosToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVehiculosToolStrip.Name = "btnVehiculosToolStrip";
            this.btnVehiculosToolStrip.Size = new System.Drawing.Size(36, 37);
            this.btnVehiculosToolStrip.Text = "Abrir Formulario de Vehiculos";
            this.btnVehiculosToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVehiculosToolStrip.Click += new System.EventHandler(this.btnVehiculosToolStrip_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // btnTiposToolStrip
            // 
            this.btnTiposToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTiposToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("btnTiposToolStrip.Image")));
            this.btnTiposToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTiposToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTiposToolStrip.Name = "btnTiposToolStrip";
            this.btnTiposToolStrip.Size = new System.Drawing.Size(36, 37);
            this.btnTiposToolStrip.Text = "Abrir Formulario de Tipos de Vehiculo";
            this.btnTiposToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTiposToolStrip.Click += new System.EventHandler(this.btnTiposToolStrip_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // btnCerrarToolStrip
            // 
            this.btnCerrarToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCerrarToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarToolStrip.Image")));
            this.btnCerrarToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCerrarToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrarToolStrip.Name = "btnCerrarToolStrip";
            this.btnCerrarToolStrip.Size = new System.Drawing.Size(36, 37);
            this.btnCerrarToolStrip.Text = "Cerrar Formulario";
            this.btnCerrarToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCerrarToolStrip.Click += new System.EventHandler(this.btnCerrarToolStrip_Click);
            // 
            // btnAbrirVehiculos
            // 
            this.btnAbrirVehiculos.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAbrirVehiculos.FlatAppearance.BorderSize = 0;
            this.btnAbrirVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrirVehiculos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirVehiculos.ForeColor = System.Drawing.Color.White;
            this.btnAbrirVehiculos.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirVehiculos.Image")));
            this.btnAbrirVehiculos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAbrirVehiculos.Location = new System.Drawing.Point(212, 190);
            this.btnAbrirVehiculos.Name = "btnAbrirVehiculos";
            this.btnAbrirVehiculos.Size = new System.Drawing.Size(88, 92);
            this.btnAbrirVehiculos.TabIndex = 8;
            this.btnAbrirVehiculos.Text = "Abrir Formulario Vehiculos";
            this.btnAbrirVehiculos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbrirVehiculos.UseVisualStyleBackColor = false;
            this.btnAbrirVehiculos.Click += new System.EventHandler(this.btnAbrirVehiculos_Click);
            // 
            // btnAbrirTiposVehiculo
            // 
            this.btnAbrirTiposVehiculo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAbrirTiposVehiculo.FlatAppearance.BorderSize = 0;
            this.btnAbrirTiposVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrirTiposVehiculo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirTiposVehiculo.ForeColor = System.Drawing.Color.White;
            this.btnAbrirTiposVehiculo.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirTiposVehiculo.Image")));
            this.btnAbrirTiposVehiculo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAbrirTiposVehiculo.Location = new System.Drawing.Point(333, 190);
            this.btnAbrirTiposVehiculo.Name = "btnAbrirTiposVehiculo";
            this.btnAbrirTiposVehiculo.Size = new System.Drawing.Size(88, 92);
            this.btnAbrirTiposVehiculo.TabIndex = 9;
            this.btnAbrirTiposVehiculo.Text = "Abrir Form. Tipos Vehiculo";
            this.btnAbrirTiposVehiculo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbrirTiposVehiculo.UseVisualStyleBackColor = false;
            this.btnAbrirTiposVehiculo.Click += new System.EventHandler(this.btnAbrirTiposVehiculo_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(617, 320);
            this.Controls.Add(this.btnAbrirTiposVehiculo);
            this.Controls.Add(this.btnAbrirVehiculos);
            this.Controls.Add(this.toolStripPrincipal);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.menuStripPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parking Tecnológico - Menú Principal";
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.toolStripPrincipal.ResumeLayout(false);
            this.toolStripPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parkingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripPrincipal;
        private System.Windows.Forms.ToolStripButton btnVehiculosToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnTiposToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnCerrarToolStrip;
        private System.Windows.Forms.Button btnAbrirVehiculos;
        private System.Windows.Forms.Button btnAbrirTiposVehiculo;
    }
}

