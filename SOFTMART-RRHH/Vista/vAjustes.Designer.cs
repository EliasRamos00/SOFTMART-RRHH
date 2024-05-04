namespace SOFTMART_RRHH.Vista
{
    partial class vAjustes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPuestos = new System.Windows.Forms.TabPage();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnRecarga = new FontAwesome.Sharp.IconButton();
            this.dgvPuestos = new System.Windows.Forms.DataGridView();
            this.dgvPuestos_idPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPuestos_Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPuestos_Subarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPuestos_Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPuestos_hasChanged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabEdoCivil = new System.Windows.Forms.TabPage();
            this.btnAgregarEdoCivil = new FontAwesome.Sharp.IconButton();
            this.btnGuardarEdoCiv = new FontAwesome.Sharp.IconButton();
            this.btnEliminarEdosCiviles = new FontAwesome.Sharp.IconButton();
            this.btnRefreshEdoCiviles = new FontAwesome.Sharp.IconButton();
            this.dgvEdosCiviles = new System.Windows.Forms.DataGridView();
            this.dgvEdosCiviles_EstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEdosCiviles_hasChanged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabEscolaridad = new System.Windows.Forms.TabPage();
            this.btnAgregarEscola = new FontAwesome.Sharp.IconButton();
            this.btnGuardarEscola = new FontAwesome.Sharp.IconButton();
            this.btnEliminarEscola = new FontAwesome.Sharp.IconButton();
            this.btnRefreshEscola = new FontAwesome.Sharp.IconButton();
            this.dgvEscolaridades = new System.Windows.Forms.DataGridView();
            this.tabTienda = new System.Windows.Forms.TabPage();
            this.btnAgregarSucursal = new FontAwesome.Sharp.IconButton();
            this.btnGuardarSucursales = new FontAwesome.Sharp.IconButton();
            this.btnBorrarSucursal = new FontAwesome.Sharp.IconButton();
            this.btnRefreshSucursales = new FontAwesome.Sharp.IconButton();
            this.dgvTiendas = new System.Windows.Forms.DataGridView();
            this.dgvEscolaridades_idEscolaridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEscolaridades_Escolaridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEscolaridades_hasChanged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTiendas_Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTiendas_idSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTiendas_hasChanged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPrincipal.SuspendLayout();
            this.tabPuestos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).BeginInit();
            this.tabEdoCivil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdosCiviles)).BeginInit();
            this.tabEscolaridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscolaridades)).BeginInit();
            this.tabTienda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiendas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabPuestos);
            this.tabPrincipal.Controls.Add(this.tabEdoCivil);
            this.tabPrincipal.Controls.Add(this.tabEscolaridad);
            this.tabPrincipal.Controls.Add(this.tabTienda);
            this.tabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(1045, 676);
            this.tabPrincipal.TabIndex = 0;
            // 
            // tabPuestos
            // 
            this.tabPuestos.Controls.Add(this.btnAgregar);
            this.tabPuestos.Controls.Add(this.btnGuardar);
            this.tabPuestos.Controls.Add(this.btnEliminar);
            this.tabPuestos.Controls.Add(this.btnRecarga);
            this.tabPuestos.Controls.Add(this.dgvPuestos);
            this.tabPuestos.ForeColor = System.Drawing.Color.Black;
            this.tabPuestos.Location = new System.Drawing.Point(4, 22);
            this.tabPuestos.Name = "tabPuestos";
            this.tabPuestos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPuestos.Size = new System.Drawing.Size(1037, 650);
            this.tabPuestos.TabIndex = 0;
            this.tabPuestos.Text = "Puestos";
            this.tabPuestos.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAgregar.IconColor = System.Drawing.Color.White;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 35;
            this.btnAgregar.Location = new System.Drawing.Point(905, 156);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(107, 36);
            this.btnAgregar.TabIndex = 36;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 30;
            this.btnGuardar.Location = new System.Drawing.Point(905, 74);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 36);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 30;
            this.btnEliminar.Location = new System.Drawing.Point(905, 115);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 36);
            this.btnEliminar.TabIndex = 34;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRecarga
            // 
            this.btnRecarga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnRecarga.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRecarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecarga.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRecarga.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            this.btnRecarga.IconColor = System.Drawing.Color.White;
            this.btnRecarga.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRecarga.IconSize = 30;
            this.btnRecarga.Location = new System.Drawing.Point(905, 33);
            this.btnRecarga.Margin = new System.Windows.Forms.Padding(0);
            this.btnRecarga.Name = "btnRecarga";
            this.btnRecarga.Size = new System.Drawing.Size(107, 36);
            this.btnRecarga.TabIndex = 33;
            this.btnRecarga.UseVisualStyleBackColor = false;
            this.btnRecarga.Click += new System.EventHandler(this.btnRecarga_Click);
            // 
            // dgvPuestos
            // 
            this.dgvPuestos.AllowUserToAddRows = false;
            this.dgvPuestos.AllowUserToDeleteRows = false;
            this.dgvPuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvPuestos_idPuesto,
            this.dgvPuestos_Area,
            this.dgvPuestos_Subarea,
            this.dgvPuestos_Puesto,
            this.dgvPuestos_hasChanged});
            this.dgvPuestos.Location = new System.Drawing.Point(25, 35);
            this.dgvPuestos.Name = "dgvPuestos";
            this.dgvPuestos.RowHeadersVisible = false;
            this.dgvPuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPuestos.Size = new System.Drawing.Size(839, 588);
            this.dgvPuestos.TabIndex = 0;
            this.dgvPuestos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPuestos_CellEndEdit);
            // 
            // dgvPuestos_idPuesto
            // 
            this.dgvPuestos_idPuesto.DataPropertyName = "idPuesto";
            this.dgvPuestos_idPuesto.HeaderText = "idPuesto";
            this.dgvPuestos_idPuesto.Name = "dgvPuestos_idPuesto";
            this.dgvPuestos_idPuesto.Visible = false;
            // 
            // dgvPuestos_Area
            // 
            this.dgvPuestos_Area.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvPuestos_Area.DataPropertyName = "Area";
            this.dgvPuestos_Area.HeaderText = "Area";
            this.dgvPuestos_Area.Name = "dgvPuestos_Area";
            this.dgvPuestos_Area.Width = 54;
            // 
            // dgvPuestos_Subarea
            // 
            this.dgvPuestos_Subarea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvPuestos_Subarea.DataPropertyName = "Subarea";
            this.dgvPuestos_Subarea.HeaderText = "Departamento";
            this.dgvPuestos_Subarea.Name = "dgvPuestos_Subarea";
            this.dgvPuestos_Subarea.Width = 99;
            // 
            // dgvPuestos_Puesto
            // 
            this.dgvPuestos_Puesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvPuestos_Puesto.DataPropertyName = "Puesto";
            this.dgvPuestos_Puesto.HeaderText = "Puesto";
            this.dgvPuestos_Puesto.Name = "dgvPuestos_Puesto";
            // 
            // dgvPuestos_hasChanged
            // 
            this.dgvPuestos_hasChanged.DataPropertyName = "hasChanged";
            this.dgvPuestos_hasChanged.HeaderText = "hasChanged";
            this.dgvPuestos_hasChanged.Name = "dgvPuestos_hasChanged";
            this.dgvPuestos_hasChanged.Visible = false;
            // 
            // tabEdoCivil
            // 
            this.tabEdoCivil.Controls.Add(this.btnAgregarEdoCivil);
            this.tabEdoCivil.Controls.Add(this.btnGuardarEdoCiv);
            this.tabEdoCivil.Controls.Add(this.btnEliminarEdosCiviles);
            this.tabEdoCivil.Controls.Add(this.btnRefreshEdoCiviles);
            this.tabEdoCivil.Controls.Add(this.dgvEdosCiviles);
            this.tabEdoCivil.ForeColor = System.Drawing.Color.Black;
            this.tabEdoCivil.Location = new System.Drawing.Point(4, 22);
            this.tabEdoCivil.Name = "tabEdoCivil";
            this.tabEdoCivil.Size = new System.Drawing.Size(1037, 650);
            this.tabEdoCivil.TabIndex = 1;
            this.tabEdoCivil.Text = "Estados civiles";
            this.tabEdoCivil.UseVisualStyleBackColor = true;
            // 
            // btnAgregarEdoCivil
            // 
            this.btnAgregarEdoCivil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarEdoCivil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnAgregarEdoCivil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarEdoCivil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEdoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEdoCivil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarEdoCivil.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAgregarEdoCivil.IconColor = System.Drawing.Color.White;
            this.btnAgregarEdoCivil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarEdoCivil.IconSize = 35;
            this.btnAgregarEdoCivil.Location = new System.Drawing.Point(905, 153);
            this.btnAgregarEdoCivil.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarEdoCivil.Name = "btnAgregarEdoCivil";
            this.btnAgregarEdoCivil.Size = new System.Drawing.Size(107, 36);
            this.btnAgregarEdoCivil.TabIndex = 41;
            this.btnAgregarEdoCivil.UseVisualStyleBackColor = false;
            this.btnAgregarEdoCivil.Click += new System.EventHandler(this.btnAgregarEdoCivil_Click);
            // 
            // btnGuardarEdoCiv
            // 
            this.btnGuardarEdoCiv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarEdoCiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnGuardarEdoCiv.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardarEdoCiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEdoCiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEdoCiv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardarEdoCiv.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardarEdoCiv.IconColor = System.Drawing.Color.White;
            this.btnGuardarEdoCiv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarEdoCiv.IconSize = 30;
            this.btnGuardarEdoCiv.Location = new System.Drawing.Point(905, 71);
            this.btnGuardarEdoCiv.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuardarEdoCiv.Name = "btnGuardarEdoCiv";
            this.btnGuardarEdoCiv.Size = new System.Drawing.Size(107, 36);
            this.btnGuardarEdoCiv.TabIndex = 40;
            this.btnGuardarEdoCiv.UseVisualStyleBackColor = false;
            this.btnGuardarEdoCiv.Click += new System.EventHandler(this.btnGuardarEdoCiv_Click);
            // 
            // btnEliminarEdosCiviles
            // 
            this.btnEliminarEdosCiviles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarEdosCiviles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnEliminarEdosCiviles.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarEdosCiviles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEdosCiviles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEdosCiviles.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarEdosCiviles.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminarEdosCiviles.IconColor = System.Drawing.Color.White;
            this.btnEliminarEdosCiviles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarEdosCiviles.IconSize = 30;
            this.btnEliminarEdosCiviles.Location = new System.Drawing.Point(905, 112);
            this.btnEliminarEdosCiviles.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarEdosCiviles.Name = "btnEliminarEdosCiviles";
            this.btnEliminarEdosCiviles.Size = new System.Drawing.Size(107, 36);
            this.btnEliminarEdosCiviles.TabIndex = 39;
            this.btnEliminarEdosCiviles.UseVisualStyleBackColor = false;
            this.btnEliminarEdosCiviles.Click += new System.EventHandler(this.btnEliminarEdosCiviles_Click);
            // 
            // btnRefreshEdoCiviles
            // 
            this.btnRefreshEdoCiviles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshEdoCiviles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnRefreshEdoCiviles.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRefreshEdoCiviles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshEdoCiviles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshEdoCiviles.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefreshEdoCiviles.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            this.btnRefreshEdoCiviles.IconColor = System.Drawing.Color.White;
            this.btnRefreshEdoCiviles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefreshEdoCiviles.IconSize = 30;
            this.btnRefreshEdoCiviles.Location = new System.Drawing.Point(905, 30);
            this.btnRefreshEdoCiviles.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefreshEdoCiviles.Name = "btnRefreshEdoCiviles";
            this.btnRefreshEdoCiviles.Size = new System.Drawing.Size(107, 36);
            this.btnRefreshEdoCiviles.TabIndex = 38;
            this.btnRefreshEdoCiviles.UseVisualStyleBackColor = false;
            this.btnRefreshEdoCiviles.Click += new System.EventHandler(this.btnRefreshEdoCiviles_Click);
            // 
            // dgvEdosCiviles
            // 
            this.dgvEdosCiviles.AllowUserToAddRows = false;
            this.dgvEdosCiviles.AllowUserToDeleteRows = false;
            this.dgvEdosCiviles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEdosCiviles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEdosCiviles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvEdosCiviles_EstadoCivil,
            this.dgvEdosCiviles_hasChanged});
            this.dgvEdosCiviles.Location = new System.Drawing.Point(25, 32);
            this.dgvEdosCiviles.Name = "dgvEdosCiviles";
            this.dgvEdosCiviles.RowHeadersVisible = false;
            this.dgvEdosCiviles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEdosCiviles.Size = new System.Drawing.Size(839, 588);
            this.dgvEdosCiviles.TabIndex = 37;
            this.dgvEdosCiviles.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvEdosCiviles_CellBeginEdit);
            this.dgvEdosCiviles.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEdosCiviles_CellEndEdit);
            // 
            // dgvEdosCiviles_EstadoCivil
            // 
            this.dgvEdosCiviles_EstadoCivil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvEdosCiviles_EstadoCivil.DataPropertyName = "EdoCivil";
            this.dgvEdosCiviles_EstadoCivil.HeaderText = "Estado Civil";
            this.dgvEdosCiviles_EstadoCivil.Name = "dgvEdosCiviles_EstadoCivil";
            // 
            // dgvEdosCiviles_hasChanged
            // 
            this.dgvEdosCiviles_hasChanged.DataPropertyName = "hasChanged";
            this.dgvEdosCiviles_hasChanged.HeaderText = "hasChanged";
            this.dgvEdosCiviles_hasChanged.Name = "dgvEdosCiviles_hasChanged";
            this.dgvEdosCiviles_hasChanged.Visible = false;
            // 
            // tabEscolaridad
            // 
            this.tabEscolaridad.Controls.Add(this.btnAgregarEscola);
            this.tabEscolaridad.Controls.Add(this.btnGuardarEscola);
            this.tabEscolaridad.Controls.Add(this.btnEliminarEscola);
            this.tabEscolaridad.Controls.Add(this.btnRefreshEscola);
            this.tabEscolaridad.Controls.Add(this.dgvEscolaridades);
            this.tabEscolaridad.ForeColor = System.Drawing.Color.Black;
            this.tabEscolaridad.Location = new System.Drawing.Point(4, 22);
            this.tabEscolaridad.Name = "tabEscolaridad";
            this.tabEscolaridad.Size = new System.Drawing.Size(1037, 650);
            this.tabEscolaridad.TabIndex = 2;
            this.tabEscolaridad.Text = "Escolaridad";
            this.tabEscolaridad.UseVisualStyleBackColor = true;
            // 
            // btnAgregarEscola
            // 
            this.btnAgregarEscola.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarEscola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnAgregarEscola.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarEscola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEscola.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarEscola.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAgregarEscola.IconColor = System.Drawing.Color.White;
            this.btnAgregarEscola.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarEscola.IconSize = 35;
            this.btnAgregarEscola.Location = new System.Drawing.Point(905, 153);
            this.btnAgregarEscola.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarEscola.Name = "btnAgregarEscola";
            this.btnAgregarEscola.Size = new System.Drawing.Size(107, 36);
            this.btnAgregarEscola.TabIndex = 46;
            this.btnAgregarEscola.UseVisualStyleBackColor = false;
            this.btnAgregarEscola.Click += new System.EventHandler(this.btnAgregarEscola_Click);
            // 
            // btnGuardarEscola
            // 
            this.btnGuardarEscola.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarEscola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnGuardarEscola.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardarEscola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEscola.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardarEscola.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardarEscola.IconColor = System.Drawing.Color.White;
            this.btnGuardarEscola.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarEscola.IconSize = 30;
            this.btnGuardarEscola.Location = new System.Drawing.Point(905, 71);
            this.btnGuardarEscola.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuardarEscola.Name = "btnGuardarEscola";
            this.btnGuardarEscola.Size = new System.Drawing.Size(107, 36);
            this.btnGuardarEscola.TabIndex = 45;
            this.btnGuardarEscola.UseVisualStyleBackColor = false;
            this.btnGuardarEscola.Click += new System.EventHandler(this.btnGuardarEscola_Click);
            // 
            // btnEliminarEscola
            // 
            this.btnEliminarEscola.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarEscola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnEliminarEscola.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarEscola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEscola.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarEscola.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminarEscola.IconColor = System.Drawing.Color.White;
            this.btnEliminarEscola.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarEscola.IconSize = 30;
            this.btnEliminarEscola.Location = new System.Drawing.Point(905, 112);
            this.btnEliminarEscola.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarEscola.Name = "btnEliminarEscola";
            this.btnEliminarEscola.Size = new System.Drawing.Size(107, 36);
            this.btnEliminarEscola.TabIndex = 44;
            this.btnEliminarEscola.UseVisualStyleBackColor = false;
            this.btnEliminarEscola.Click += new System.EventHandler(this.btnEliminarEscola_Click);
            // 
            // btnRefreshEscola
            // 
            this.btnRefreshEscola.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshEscola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnRefreshEscola.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRefreshEscola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshEscola.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefreshEscola.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            this.btnRefreshEscola.IconColor = System.Drawing.Color.White;
            this.btnRefreshEscola.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefreshEscola.IconSize = 30;
            this.btnRefreshEscola.Location = new System.Drawing.Point(905, 30);
            this.btnRefreshEscola.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefreshEscola.Name = "btnRefreshEscola";
            this.btnRefreshEscola.Size = new System.Drawing.Size(107, 36);
            this.btnRefreshEscola.TabIndex = 43;
            this.btnRefreshEscola.UseVisualStyleBackColor = false;
            this.btnRefreshEscola.Click += new System.EventHandler(this.btnRefreshEscola_Click);
            // 
            // dgvEscolaridades
            // 
            this.dgvEscolaridades.AllowUserToAddRows = false;
            this.dgvEscolaridades.AllowUserToDeleteRows = false;
            this.dgvEscolaridades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEscolaridades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEscolaridades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvEscolaridades_idEscolaridad,
            this.dgvEscolaridades_Escolaridad,
            this.dgvEscolaridades_hasChanged});
            this.dgvEscolaridades.Location = new System.Drawing.Point(25, 32);
            this.dgvEscolaridades.Name = "dgvEscolaridades";
            this.dgvEscolaridades.RowHeadersVisible = false;
            this.dgvEscolaridades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEscolaridades.Size = new System.Drawing.Size(839, 588);
            this.dgvEscolaridades.TabIndex = 42;
            this.dgvEscolaridades.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEscolaridades_CellEndEdit);
            // 
            // tabTienda
            // 
            this.tabTienda.Controls.Add(this.btnAgregarSucursal);
            this.tabTienda.Controls.Add(this.btnGuardarSucursales);
            this.tabTienda.Controls.Add(this.btnBorrarSucursal);
            this.tabTienda.Controls.Add(this.btnRefreshSucursales);
            this.tabTienda.Controls.Add(this.dgvTiendas);
            this.tabTienda.ForeColor = System.Drawing.Color.Black;
            this.tabTienda.Location = new System.Drawing.Point(4, 22);
            this.tabTienda.Name = "tabTienda";
            this.tabTienda.Size = new System.Drawing.Size(1037, 650);
            this.tabTienda.TabIndex = 3;
            this.tabTienda.Text = "Sucursales";
            this.tabTienda.UseVisualStyleBackColor = true;
            // 
            // btnAgregarSucursal
            // 
            this.btnAgregarSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnAgregarSucursal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSucursal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarSucursal.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAgregarSucursal.IconColor = System.Drawing.Color.White;
            this.btnAgregarSucursal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarSucursal.IconSize = 35;
            this.btnAgregarSucursal.Location = new System.Drawing.Point(905, 153);
            this.btnAgregarSucursal.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarSucursal.Name = "btnAgregarSucursal";
            this.btnAgregarSucursal.Size = new System.Drawing.Size(107, 36);
            this.btnAgregarSucursal.TabIndex = 46;
            this.btnAgregarSucursal.UseVisualStyleBackColor = false;
            this.btnAgregarSucursal.Click += new System.EventHandler(this.btnAgregarSucursal_Click);
            // 
            // btnGuardarSucursales
            // 
            this.btnGuardarSucursales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarSucursales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnGuardarSucursales.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardarSucursales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarSucursales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarSucursales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardarSucursales.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardarSucursales.IconColor = System.Drawing.Color.White;
            this.btnGuardarSucursales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarSucursales.IconSize = 30;
            this.btnGuardarSucursales.Location = new System.Drawing.Point(905, 71);
            this.btnGuardarSucursales.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuardarSucursales.Name = "btnGuardarSucursales";
            this.btnGuardarSucursales.Size = new System.Drawing.Size(107, 36);
            this.btnGuardarSucursales.TabIndex = 45;
            this.btnGuardarSucursales.UseVisualStyleBackColor = false;
            this.btnGuardarSucursales.Click += new System.EventHandler(this.btnGuardarSucursales_Click);
            // 
            // btnBorrarSucursal
            // 
            this.btnBorrarSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnBorrarSucursal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBorrarSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarSucursal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBorrarSucursal.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnBorrarSucursal.IconColor = System.Drawing.Color.White;
            this.btnBorrarSucursal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorrarSucursal.IconSize = 30;
            this.btnBorrarSucursal.Location = new System.Drawing.Point(905, 112);
            this.btnBorrarSucursal.Margin = new System.Windows.Forms.Padding(0);
            this.btnBorrarSucursal.Name = "btnBorrarSucursal";
            this.btnBorrarSucursal.Size = new System.Drawing.Size(107, 36);
            this.btnBorrarSucursal.TabIndex = 44;
            this.btnBorrarSucursal.UseVisualStyleBackColor = false;
            this.btnBorrarSucursal.Click += new System.EventHandler(this.btnBorrarSucursal_Click);
            // 
            // btnRefreshSucursales
            // 
            this.btnRefreshSucursales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshSucursales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnRefreshSucursales.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRefreshSucursales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshSucursales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshSucursales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefreshSucursales.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            this.btnRefreshSucursales.IconColor = System.Drawing.Color.White;
            this.btnRefreshSucursales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefreshSucursales.IconSize = 30;
            this.btnRefreshSucursales.Location = new System.Drawing.Point(905, 30);
            this.btnRefreshSucursales.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefreshSucursales.Name = "btnRefreshSucursales";
            this.btnRefreshSucursales.Size = new System.Drawing.Size(107, 36);
            this.btnRefreshSucursales.TabIndex = 43;
            this.btnRefreshSucursales.UseVisualStyleBackColor = false;
            this.btnRefreshSucursales.Click += new System.EventHandler(this.btnRefreshSucursales_Click);
            // 
            // dgvTiendas
            // 
            this.dgvTiendas.AllowUserToAddRows = false;
            this.dgvTiendas.AllowUserToDeleteRows = false;
            this.dgvTiendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTiendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTiendas_Sucursal,
            this.dgvTiendas_idSucursal,
            this.dgvTiendas_hasChanged});
            this.dgvTiendas.Location = new System.Drawing.Point(25, 32);
            this.dgvTiendas.Name = "dgvTiendas";
            this.dgvTiendas.RowHeadersVisible = false;
            this.dgvTiendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTiendas.Size = new System.Drawing.Size(839, 588);
            this.dgvTiendas.TabIndex = 42;
            this.dgvTiendas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTiendas_CellEndEdit);
            // 
            // dgvEscolaridades_idEscolaridad
            // 
            this.dgvEscolaridades_idEscolaridad.DataPropertyName = "idEscolaridad";
            this.dgvEscolaridades_idEscolaridad.HeaderText = "idEscolaridad";
            this.dgvEscolaridades_idEscolaridad.Name = "dgvEscolaridades_idEscolaridad";
            this.dgvEscolaridades_idEscolaridad.Visible = false;
            // 
            // dgvEscolaridades_Escolaridad
            // 
            this.dgvEscolaridades_Escolaridad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvEscolaridades_Escolaridad.DataPropertyName = "Escolaridad";
            this.dgvEscolaridades_Escolaridad.HeaderText = "Escolaridad";
            this.dgvEscolaridades_Escolaridad.Name = "dgvEscolaridades_Escolaridad";
            // 
            // dgvEscolaridades_hasChanged
            // 
            this.dgvEscolaridades_hasChanged.DataPropertyName = "hasChanged";
            this.dgvEscolaridades_hasChanged.HeaderText = "hasChanged";
            this.dgvEscolaridades_hasChanged.Name = "dgvEscolaridades_hasChanged";
            this.dgvEscolaridades_hasChanged.Visible = false;
            // 
            // dgvTiendas_Sucursal
            // 
            this.dgvTiendas_Sucursal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvTiendas_Sucursal.DataPropertyName = "Sucursal";
            this.dgvTiendas_Sucursal.HeaderText = "Sucursal";
            this.dgvTiendas_Sucursal.Name = "dgvTiendas_Sucursal";
            // 
            // dgvTiendas_idSucursal
            // 
            this.dgvTiendas_idSucursal.DataPropertyName = "idSucursal";
            this.dgvTiendas_idSucursal.HeaderText = "idSucursal";
            this.dgvTiendas_idSucursal.Name = "dgvTiendas_idSucursal";
            this.dgvTiendas_idSucursal.Visible = false;
            // 
            // dgvTiendas_hasChanged
            // 
            this.dgvTiendas_hasChanged.DataPropertyName = "hasChanged";
            this.dgvTiendas_hasChanged.HeaderText = "hasChanged";
            this.dgvTiendas_hasChanged.Name = "dgvTiendas_hasChanged";
            this.dgvTiendas_hasChanged.Visible = false;
            // 
            // vAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.tabPrincipal);
            this.Name = "vAjustes";
            this.Size = new System.Drawing.Size(1045, 676);
            this.Load += new System.EventHandler(this.vAjustes_Load);
            this.tabPrincipal.ResumeLayout(false);
            this.tabPuestos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).EndInit();
            this.tabEdoCivil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdosCiviles)).EndInit();
            this.tabEscolaridad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscolaridades)).EndInit();
            this.tabTienda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabPuestos;
        private System.Windows.Forms.DataGridView dgvPuestos;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnRecarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPuestos_idPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPuestos_Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPuestos_Subarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPuestos_Puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPuestos_hasChanged;
        private System.Windows.Forms.TabPage tabEdoCivil;
        private FontAwesome.Sharp.IconButton btnAgregarEdoCivil;
        private FontAwesome.Sharp.IconButton btnGuardarEdoCiv;
        private FontAwesome.Sharp.IconButton btnEliminarEdosCiviles;
        private FontAwesome.Sharp.IconButton btnRefreshEdoCiviles;
        private System.Windows.Forms.DataGridView dgvEdosCiviles;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEdosCiviles_EstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEdosCiviles_hasChanged;
        private System.Windows.Forms.TabPage tabEscolaridad;
        private System.Windows.Forms.TabPage tabTienda;
        private FontAwesome.Sharp.IconButton btnAgregarEscola;
        private FontAwesome.Sharp.IconButton btnGuardarEscola;
        private FontAwesome.Sharp.IconButton btnEliminarEscola;
        private FontAwesome.Sharp.IconButton btnRefreshEscola;
        private System.Windows.Forms.DataGridView dgvEscolaridades;
        private FontAwesome.Sharp.IconButton btnAgregarSucursal;
        private FontAwesome.Sharp.IconButton btnGuardarSucursales;
        private FontAwesome.Sharp.IconButton btnBorrarSucursal;
        private FontAwesome.Sharp.IconButton btnRefreshSucursales;
        private System.Windows.Forms.DataGridView dgvTiendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEscolaridades_idEscolaridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEscolaridades_Escolaridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEscolaridades_hasChanged;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTiendas_Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTiendas_idSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTiendas_hasChanged;
    }
}
