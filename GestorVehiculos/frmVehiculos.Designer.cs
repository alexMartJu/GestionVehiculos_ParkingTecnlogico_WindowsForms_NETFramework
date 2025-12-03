namespace GestorVehiculos
{
    partial class frmVehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehiculos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStripVehiculos = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripVehiculos = new System.Windows.Forms.ToolStrip();
            this.btnCrearToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditarToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminarToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCerrarToolStrip = new System.Windows.Forms.ToolStripButton();
            this.splitContainerTipos = new System.Windows.Forms.SplitContainer();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.btnFiltar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.grpFiltro = new System.Windows.Forms.GroupBox();
            this.menuStripVehiculos.SuspendLayout();
            this.toolStripVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTipos)).BeginInit();
            this.splitContainerTipos.Panel1.SuspendLayout();
            this.splitContainerTipos.Panel2.SuspendLayout();
            this.splitContainerTipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.grpDatos.SuspendLayout();
            this.grpFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripVehiculos
            // 
            this.menuStripVehiculos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.accionesToolStripMenuItem});
            this.menuStripVehiculos.Location = new System.Drawing.Point(0, 0);
            this.menuStripVehiculos.Name = "menuStripVehiculos";
            this.menuStripVehiculos.Size = new System.Drawing.Size(891, 24);
            this.menuStripVehiculos.TabIndex = 8;
            this.menuStripVehiculos.Text = "menuStripTipos";
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
            // toolStripVehiculos
            // 
            this.toolStripVehiculos.AutoSize = false;
            this.toolStripVehiculos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCrearToolStrip,
            this.toolStripSeparator1,
            this.btnEditarToolStrip,
            this.toolStripSeparator2,
            this.btnEliminarToolStrip,
            this.toolStripSeparator3,
            this.btnCerrarToolStrip});
            this.toolStripVehiculos.Location = new System.Drawing.Point(0, 24);
            this.toolStripVehiculos.Name = "toolStripVehiculos";
            this.toolStripVehiculos.Size = new System.Drawing.Size(891, 40);
            this.toolStripVehiculos.TabIndex = 9;
            this.toolStripVehiculos.Text = "toolStripTipos";
            // 
            // btnCrearToolStrip
            // 
            this.btnCrearToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCrearToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearToolStrip.Image")));
            this.btnCrearToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCrearToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCrearToolStrip.Name = "btnCrearToolStrip";
            this.btnCrearToolStrip.Size = new System.Drawing.Size(36, 37);
            this.btnCrearToolStrip.Text = "Crear Vehiculo";
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
            this.btnEditarToolStrip.Text = "Editar Vehiculo";
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
            this.btnEliminarToolStrip.Text = "Eliminar Vehiculo";
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
            this.splitContainerTipos.Panel2.Controls.Add(this.grpFiltro);
            this.splitContainerTipos.Panel2.Controls.Add(this.dgvVehiculos);
            this.splitContainerTipos.Size = new System.Drawing.Size(891, 459);
            this.splitContainerTipos.SplitterDistance = 301;
            this.splitContainerTipos.TabIndex = 10;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(6, 183);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(123, 17);
            this.lblTipo.TabIndex = 11;
            this.lblTipo.Text = "Tipos de Vehiculo *:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(9, 204);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(141, 25);
            this.cmbTipo.TabIndex = 10;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(9, 150);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(248, 25);
            this.txtModelo.TabIndex = 9;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(6, 129);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(57, 17);
            this.lblModelo.TabIndex = 8;
            this.lblModelo.Text = "Modelo:";
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
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "Vehiculos";
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
            this.btnEliminar.Text = "Eliminar Vehiculo";
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
            this.btnEditar.Text = "Editar Vehiculo";
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
            this.btnCrear.Text = "Crear Vehiculo";
            this.btnCrear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(9, 96);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(248, 25);
            this.txtMarca.TabIndex = 3;
            // 
            // lblTarifa
            // 
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.Location = new System.Drawing.Point(6, 75);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(48, 17);
            this.lblTarifa.TabIndex = 2;
            this.lblTarifa.Text = "Marca:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(9, 42);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(248, 25);
            this.txtMatricula.TabIndex = 1;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(6, 21);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(74, 17);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matricula *:";
            // 
            // btnFiltar
            // 
            this.btnFiltar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFiltar.FlatAppearance.BorderSize = 0;
            this.btnFiltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltar.ForeColor = System.Drawing.Color.White;
            this.btnFiltar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltar.Image")));
            this.btnFiltar.Location = new System.Drawing.Point(319, 33);
            this.btnFiltar.Name = "btnFiltar";
            this.btnFiltar.Size = new System.Drawing.Size(150, 40);
            this.btnFiltar.TabIndex = 4;
            this.btnFiltar.Text = " Filtrar";
            this.btnFiltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltar.UseVisualStyleBackColor = false;
            this.btnFiltar.Click += new System.EventHandler(this.btnFiltar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(9, 42);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(294, 25);
            this.txtFiltro.TabIndex = 3;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(6, 21);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(65, 17);
            this.lblFiltro.TabIndex = 2;
            this.lblFiltro.Text = "Matricula:";
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.AllowUserToAddRows = false;
            this.dgvVehiculos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvVehiculos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvVehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehiculos.BackgroundColor = System.Drawing.Color.White;
            this.dgvVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVehiculos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVehiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVehiculos.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvVehiculos.EnableHeadersVisualStyles = false;
            this.dgvVehiculos.Location = new System.Drawing.Point(3, 120);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.ReadOnly = true;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            this.dgvVehiculos.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculos.Size = new System.Drawing.Size(576, 325);
            this.dgvVehiculos.TabIndex = 1;
            this.dgvVehiculos.SelectionChanged += new System.EventHandler(this.dgvVehiculos_SelectionChanged);
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.lblTipo);
            this.grpDatos.Controls.Add(this.cmbTipo);
            this.grpDatos.Controls.Add(this.lblMatricula);
            this.grpDatos.Controls.Add(this.txtModelo);
            this.grpDatos.Controls.Add(this.txtMatricula);
            this.grpDatos.Controls.Add(this.lblModelo);
            this.grpDatos.Controls.Add(this.lblTarifa);
            this.grpDatos.Controls.Add(this.txtMarca);
            this.grpDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpDatos.Location = new System.Drawing.Point(10, 90);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(276, 252);
            this.grpDatos.TabIndex = 10;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del Vehiculo";
            // 
            // grpFiltro
            // 
            this.grpFiltro.Controls.Add(this.lblFiltro);
            this.grpFiltro.Controls.Add(this.btnFiltar);
            this.grpFiltro.Controls.Add(this.txtFiltro);
            this.grpFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpFiltro.Location = new System.Drawing.Point(47, 17);
            this.grpFiltro.Name = "grpFiltro";
            this.grpFiltro.Size = new System.Drawing.Size(486, 83);
            this.grpFiltro.TabIndex = 8;
            this.grpFiltro.TabStop = false;
            this.grpFiltro.Text = "Filtro de Búsqueda";
            // 
            // frmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(891, 523);
            this.Controls.Add(this.splitContainerTipos);
            this.Controls.Add(this.toolStripVehiculos);
            this.Controls.Add(this.menuStripVehiculos);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStripVehiculos;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parking Tecnológico - Vehiculos";
            this.menuStripVehiculos.ResumeLayout(false);
            this.menuStripVehiculos.PerformLayout();
            this.toolStripVehiculos.ResumeLayout(false);
            this.toolStripVehiculos.PerformLayout();
            this.splitContainerTipos.Panel1.ResumeLayout(false);
            this.splitContainerTipos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTipos)).EndInit();
            this.splitContainerTipos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grpFiltro.ResumeLayout(false);
            this.grpFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripVehiculos;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripVehiculos;
        private System.Windows.Forms.ToolStripButton btnCrearToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEditarToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEliminarToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnCerrarToolStrip;
        private System.Windows.Forms.SplitContainer splitContainerTipos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button btnFiltar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.GroupBox grpFiltro;
    }
}