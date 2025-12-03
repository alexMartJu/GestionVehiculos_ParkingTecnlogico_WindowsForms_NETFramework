namespace GestorVehiculos
{
    partial class frmTipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStripTipos = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTipos = new System.Windows.Forms.ToolStrip();
            this.btnCrearToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditarToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminarToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCerrarToolStrip = new System.Windows.Forms.ToolStripButton();
            this.splitContainerTipos = new System.Windows.Forms.SplitContainer();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvTipos = new System.Windows.Forms.DataGridView();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.menuStripTipos.SuspendLayout();
            this.toolStripTipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTipos)).BeginInit();
            this.splitContainerTipos.Panel1.SuspendLayout();
            this.splitContainerTipos.Panel2.SuspendLayout();
            this.splitContainerTipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipos)).BeginInit();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripTipos
            // 
            this.menuStripTipos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.accionesToolStripMenuItem});
            this.menuStripTipos.Location = new System.Drawing.Point(0, 0);
            this.menuStripTipos.Name = "menuStripTipos";
            this.menuStripTipos.Size = new System.Drawing.Size(891, 24);
            this.menuStripTipos.TabIndex = 7;
            this.menuStripTipos.Text = "menuStripTipos";
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
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.accionesToolStripMenuItem.Text = "Acciones";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.crearToolStripMenuItem.Text = "Crear";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // toolStripTipos
            // 
            this.toolStripTipos.AutoSize = false;
            this.toolStripTipos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCrearToolStrip,
            this.toolStripSeparator1,
            this.btnEditarToolStrip,
            this.toolStripSeparator2,
            this.btnEliminarToolStrip,
            this.toolStripSeparator3,
            this.btnCerrarToolStrip});
            this.toolStripTipos.Location = new System.Drawing.Point(0, 24);
            this.toolStripTipos.Name = "toolStripTipos";
            this.toolStripTipos.Size = new System.Drawing.Size(891, 40);
            this.toolStripTipos.TabIndex = 8;
            this.toolStripTipos.Text = "toolStripTipos";
            // 
            // btnCrearToolStrip
            // 
            this.btnCrearToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCrearToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearToolStrip.Image")));
            this.btnCrearToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCrearToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCrearToolStrip.Name = "btnCrearToolStrip";
            this.btnCrearToolStrip.Size = new System.Drawing.Size(36, 37);
            this.btnCrearToolStrip.Text = "Crear Tipo de Vehiculo";
            this.btnCrearToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCrearToolStrip.Click += new System.EventHandler(this.btnCrearToolStrip_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // btnEditarToolStrip
            // 
            this.btnEditarToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditarToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarToolStrip.Image")));
            this.btnEditarToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditarToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditarToolStrip.Name = "btnEditarToolStrip";
            this.btnEditarToolStrip.Size = new System.Drawing.Size(36, 37);
            this.btnEditarToolStrip.Text = "Editar Tipo de Vehiculo";
            this.btnEditarToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditarToolStrip.Click += new System.EventHandler(this.btnEditarToolStrip_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // btnEliminarToolStrip
            // 
            this.btnEliminarToolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminarToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarToolStrip.Image")));
            this.btnEliminarToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEliminarToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminarToolStrip.Name = "btnEliminarToolStrip";
            this.btnEliminarToolStrip.Size = new System.Drawing.Size(36, 37);
            this.btnEliminarToolStrip.Text = "Eliminar Tipo de Vehiculo";
            this.btnEliminarToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminarToolStrip.Click += new System.EventHandler(this.btnEliminarToolStrip_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
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
            // splitContainerTipos
            // 
            this.splitContainerTipos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerTipos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTipos.Location = new System.Drawing.Point(0, 64);
            this.splitContainerTipos.Name = "splitContainerTipos";
            // 
            // splitContainerTipos.Panel1
            // 
            this.splitContainerTipos.Panel1.BackColor = System.Drawing.Color.LightBlue;
            this.splitContainerTipos.Panel1.Controls.Add(this.grpDatos);
            this.splitContainerTipos.Panel1.Controls.Add(this.lblInfo);
            this.splitContainerTipos.Panel1.Controls.Add(this.btnEliminar);
            this.splitContainerTipos.Panel1.Controls.Add(this.btnEditar);
            this.splitContainerTipos.Panel1.Controls.Add(this.btnCrear);
            // 
            // splitContainerTipos.Panel2
            // 
            this.splitContainerTipos.Panel2.BackColor = System.Drawing.Color.LightBlue;
            this.splitContainerTipos.Panel2.Controls.Add(this.dgvTipos);
            this.splitContainerTipos.Size = new System.Drawing.Size(891, 459);
            this.splitContainerTipos.SplitterDistance = 301;
            this.splitContainerTipos.TabIndex = 9;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(0, 17);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(297, 65);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Tipos de Vehiculos";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(198, 353);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnEliminar.Size = new System.Drawing.Size(88, 92);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar Tipo Vehic.";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(104, 353);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnEditar.Size = new System.Drawing.Size(88, 92);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar Tipo Vehiculo";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Image = ((System.Drawing.Image)(resources.GetObject("btnCrear.Image")));
            this.btnCrear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCrear.Location = new System.Drawing.Point(10, 353);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnCrear.Size = new System.Drawing.Size(88, 92);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Crear Tipo Vehiculo";
            this.btnCrear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtTarifa
            // 
            this.txtTarifa.Location = new System.Drawing.Point(9, 121);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(248, 25);
            this.txtTarifa.TabIndex = 3;
            // 
            // lblTarifa
            // 
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.Location = new System.Drawing.Point(6, 100);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(52, 17);
            this.lblTarifa.TabIndex = 2;
            this.lblTarifa.Text = "Tarifa *:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(9, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(248, 25);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre *:";
            // 
            // dgvTipos
            // 
            this.dgvTipos.AllowUserToAddRows = false;
            this.dgvTipos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle45.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvTipos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle45;
            this.dgvTipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipos.BackgroundColor = System.Drawing.Color.White;
            this.dgvTipos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTipos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle46.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle46;
            this.dgvTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTipos.DefaultCellStyle = dataGridViewCellStyle47;
            this.dgvTipos.EnableHeadersVisualStyles = false;
            this.dgvTipos.Location = new System.Drawing.Point(3, 71);
            this.dgvTipos.Name = "dgvTipos";
            this.dgvTipos.ReadOnly = true;
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.White;
            this.dgvTipos.RowsDefaultCellStyle = dataGridViewCellStyle48;
            this.dgvTipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipos.Size = new System.Drawing.Size(576, 325);
            this.dgvTipos.TabIndex = 1;
            this.dgvTipos.SelectionChanged += new System.EventHandler(this.dgvTipos_SelectionChanged);
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.lblTarifa);
            this.grpDatos.Controls.Add(this.txtTarifa);
            this.grpDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpDatos.Location = new System.Drawing.Point(10, 134);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(276, 167);
            this.grpDatos.TabIndex = 7;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del Tipo de Vehiculo";
            // 
            // frmTipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(891, 523);
            this.Controls.Add(this.splitContainerTipos);
            this.Controls.Add(this.toolStripTipos);
            this.Controls.Add(this.menuStripTipos);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStripTipos;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parking Tecnológico - Tipos de Vehiculo";
            this.menuStripTipos.ResumeLayout(false);
            this.menuStripTipos.PerformLayout();
            this.toolStripTipos.ResumeLayout(false);
            this.toolStripTipos.PerformLayout();
            this.splitContainerTipos.Panel1.ResumeLayout(false);
            this.splitContainerTipos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTipos)).EndInit();
            this.splitContainerTipos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipos)).EndInit();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTipos;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripTipos;
        private System.Windows.Forms.ToolStripButton btnCrearToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEditarToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEliminarToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnCerrarToolStrip;
        private System.Windows.Forms.SplitContainer splitContainerTipos;
        private System.Windows.Forms.DataGridView dgvTipos;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox grpDatos;
    }
}