﻿namespace SOFTMART_RRHH.Vista
{
    partial class vConsulta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblColumn = new System.Windows.Forms.Label();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.dgvConsultaEmpleados = new System.Windows.Forms.DataGridView();
            this.dgvConsultaEmpleados_idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvConsultaEmpleados_idPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvConsultaEmpleados_DiasAntiguedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvConsultaEmpleados_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvConsultaEmpleados_NumContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvConsultaEmpleados_Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvConsultaEmpleados_Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvConsultaEmpleados_FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvConsultaEmpleados_Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvConsultaEmpleados_FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvConsultaEmpleados_Antiguedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvConsultaEmpleados_Inactivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnExcel = new FontAwesome.Sharp.IconButton();
            this.btnRecarga = new FontAwesome.Sharp.IconButton();
            this.ChBFechaFiltro = new System.Windows.Forms.CheckBox();
            this.dtpFechaFiltro = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMin = new System.Windows.Forms.Label();
            this.cbInicio = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbFinal = new System.Windows.Forms.ComboBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.rowCounting = new System.Windows.Forms.Label();
            this.tlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 6;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tlpPrincipal.Controls.Add(this.tbFiltro, 1, 3);
            this.tlpPrincipal.Controls.Add(this.lblBuscar, 1, 2);
            this.tlpPrincipal.Controls.Add(this.lblColumn, 2, 2);
            this.tlpPrincipal.Controls.Add(this.cbFiltro, 2, 3);
            this.tlpPrincipal.Controls.Add(this.dgvConsultaEmpleados, 1, 4);
            this.tlpPrincipal.Controls.Add(this.btnClose, 0, 0);
            this.tlpPrincipal.Controls.Add(this.lblTitulo, 1, 0);
            this.tlpPrincipal.Controls.Add(this.btnExcel, 4, 3);
            this.tlpPrincipal.Controls.Add(this.btnRecarga, 3, 3);
            this.tlpPrincipal.Controls.Add(this.ChBFechaFiltro, 3, 1);
            this.tlpPrincipal.Controls.Add(this.dtpFechaFiltro, 4, 1);
            this.tlpPrincipal.Controls.Add(this.tableLayoutPanel1, 3, 2);
            this.tlpPrincipal.Controls.Add(this.tableLayoutPanel2, 4, 2);
            this.tlpPrincipal.Controls.Add(this.rowCounting, 4, 5);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 6;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.538087F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.13128F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.900753F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.30093F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1045, 676);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // tbFiltro
            // 
            this.tbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltro.Location = new System.Drawing.Point(45, 113);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(386, 26);
            this.tbFiltro.TabIndex = 2;
            this.tbFiltro.TextChanged += new System.EventHandler(this.tbFiltro_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.Black;
            this.lblBuscar.Location = new System.Drawing.Point(45, 89);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(67, 21);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Buscar: ";
            // 
            // lblColumn
            // 
            this.lblColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblColumn.AutoSize = true;
            this.lblColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumn.ForeColor = System.Drawing.Color.Black;
            this.lblColumn.Location = new System.Drawing.Point(437, 90);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(79, 20);
            this.lblColumn.TabIndex = 3;
            this.lblColumn.Text = "Columna";
            // 
            // cbFiltro
            // 
            this.cbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Location = new System.Drawing.Point(437, 113);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(288, 28);
            this.cbFiltro.TabIndex = 4;
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            // 
            // dgvConsultaEmpleados
            // 
            this.dgvConsultaEmpleados.AllowUserToAddRows = false;
            this.dgvConsultaEmpleados.AllowUserToDeleteRows = false;
            this.dgvConsultaEmpleados.AllowUserToOrderColumns = true;
            this.dgvConsultaEmpleados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvConsultaEmpleados_idEmpleado,
            this.dgvConsultaEmpleados_idPersona,
            this.dgvConsultaEmpleados_DiasAntiguedad,
            this.dgvConsultaEmpleados_Nombre,
            this.dgvConsultaEmpleados_NumContrato,
            this.dgvConsultaEmpleados_Sucursal,
            this.dgvConsultaEmpleados_Puesto,
            this.dgvConsultaEmpleados_FechaNacimiento,
            this.dgvConsultaEmpleados_Edad,
            this.dgvConsultaEmpleados_FechaInicio,
            this.dgvConsultaEmpleados_Antiguedad,
            this.dgvConsultaEmpleados_Inactivo});
            this.tlpPrincipal.SetColumnSpan(this.dgvConsultaEmpleados, 4);
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsultaEmpleados.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvConsultaEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsultaEmpleados.GridColor = System.Drawing.Color.Black;
            this.dgvConsultaEmpleados.Location = new System.Drawing.Point(45, 149);
            this.dgvConsultaEmpleados.MultiSelect = false;
            this.dgvConsultaEmpleados.Name = "dgvConsultaEmpleados";
            this.dgvConsultaEmpleados.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvConsultaEmpleados.RowHeadersVisible = false;
            this.dgvConsultaEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaEmpleados.Size = new System.Drawing.Size(974, 503);
            this.dgvConsultaEmpleados.TabIndex = 6;
            this.dgvConsultaEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaEmpleados_CellDoubleClick);
            // 
            // dgvConsultaEmpleados_idEmpleado
            // 
            this.dgvConsultaEmpleados_idEmpleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvConsultaEmpleados_idEmpleado.DataPropertyName = "idEmpleado";
            this.dgvConsultaEmpleados_idEmpleado.HeaderText = "idEmpleado";
            this.dgvConsultaEmpleados_idEmpleado.Name = "dgvConsultaEmpleados_idEmpleado";
            this.dgvConsultaEmpleados_idEmpleado.ReadOnly = true;
            this.dgvConsultaEmpleados_idEmpleado.Visible = false;
            // 
            // dgvConsultaEmpleados_idPersona
            // 
            this.dgvConsultaEmpleados_idPersona.DataPropertyName = "idPersona";
            this.dgvConsultaEmpleados_idPersona.HeaderText = "idPersona";
            this.dgvConsultaEmpleados_idPersona.Name = "dgvConsultaEmpleados_idPersona";
            this.dgvConsultaEmpleados_idPersona.ReadOnly = true;
            this.dgvConsultaEmpleados_idPersona.Visible = false;
            // 
            // dgvConsultaEmpleados_DiasAntiguedad
            // 
            this.dgvConsultaEmpleados_DiasAntiguedad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvConsultaEmpleados_DiasAntiguedad.DataPropertyName = "AntiguedadDias";
            this.dgvConsultaEmpleados_DiasAntiguedad.HeaderText = "DiasAntiguedad";
            this.dgvConsultaEmpleados_DiasAntiguedad.Name = "dgvConsultaEmpleados_DiasAntiguedad";
            this.dgvConsultaEmpleados_DiasAntiguedad.ReadOnly = true;
            this.dgvConsultaEmpleados_DiasAntiguedad.Visible = false;
            this.dgvConsultaEmpleados_DiasAntiguedad.Width = 40;
            // 
            // dgvConsultaEmpleados_Nombre
            // 
            this.dgvConsultaEmpleados_Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvConsultaEmpleados_Nombre.DataPropertyName = "Nombre";
            this.dgvConsultaEmpleados_Nombre.HeaderText = "Nombre";
            this.dgvConsultaEmpleados_Nombre.Name = "dgvConsultaEmpleados_Nombre";
            this.dgvConsultaEmpleados_Nombre.ReadOnly = true;
            // 
            // dgvConsultaEmpleados_NumContrato
            // 
            this.dgvConsultaEmpleados_NumContrato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvConsultaEmpleados_NumContrato.DataPropertyName = "NumContrato";
            this.dgvConsultaEmpleados_NumContrato.HeaderText = "NumContrato";
            this.dgvConsultaEmpleados_NumContrato.Name = "dgvConsultaEmpleados_NumContrato";
            this.dgvConsultaEmpleados_NumContrato.ReadOnly = true;
            // 
            // dgvConsultaEmpleados_Sucursal
            // 
            this.dgvConsultaEmpleados_Sucursal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvConsultaEmpleados_Sucursal.DataPropertyName = "Sucursal";
            this.dgvConsultaEmpleados_Sucursal.HeaderText = "Sucursal";
            this.dgvConsultaEmpleados_Sucursal.Name = "dgvConsultaEmpleados_Sucursal";
            this.dgvConsultaEmpleados_Sucursal.ReadOnly = true;
            // 
            // dgvConsultaEmpleados_Puesto
            // 
            this.dgvConsultaEmpleados_Puesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvConsultaEmpleados_Puesto.DataPropertyName = "Puesto";
            this.dgvConsultaEmpleados_Puesto.HeaderText = "Puesto";
            this.dgvConsultaEmpleados_Puesto.Name = "dgvConsultaEmpleados_Puesto";
            this.dgvConsultaEmpleados_Puesto.ReadOnly = true;
            // 
            // dgvConsultaEmpleados_FechaNacimiento
            // 
            this.dgvConsultaEmpleados_FechaNacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvConsultaEmpleados_FechaNacimiento.DataPropertyName = "FechaNac";
            dataGridViewCellStyle2.Format = "dd-MMM-yyyy";
            dataGridViewCellStyle2.NullValue = null;
            this.dgvConsultaEmpleados_FechaNacimiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsultaEmpleados_FechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.dgvConsultaEmpleados_FechaNacimiento.Name = "dgvConsultaEmpleados_FechaNacimiento";
            this.dgvConsultaEmpleados_FechaNacimiento.ReadOnly = true;
            // 
            // dgvConsultaEmpleados_Edad
            // 
            this.dgvConsultaEmpleados_Edad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvConsultaEmpleados_Edad.DataPropertyName = "Edad";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvConsultaEmpleados_Edad.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConsultaEmpleados_Edad.HeaderText = "Edad";
            this.dgvConsultaEmpleados_Edad.Name = "dgvConsultaEmpleados_Edad";
            this.dgvConsultaEmpleados_Edad.ReadOnly = true;
            this.dgvConsultaEmpleados_Edad.Width = 60;
            // 
            // dgvConsultaEmpleados_FechaInicio
            // 
            this.dgvConsultaEmpleados_FechaInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvConsultaEmpleados_FechaInicio.DataPropertyName = "FechaInicio";
            dataGridViewCellStyle4.Format = "dd-MMM-yyyy";
            dataGridViewCellStyle4.NullValue = null;
            this.dgvConsultaEmpleados_FechaInicio.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvConsultaEmpleados_FechaInicio.HeaderText = "Fecha Inicio";
            this.dgvConsultaEmpleados_FechaInicio.Name = "dgvConsultaEmpleados_FechaInicio";
            this.dgvConsultaEmpleados_FechaInicio.ReadOnly = true;
            // 
            // dgvConsultaEmpleados_Antiguedad
            // 
            this.dgvConsultaEmpleados_Antiguedad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvConsultaEmpleados_Antiguedad.DataPropertyName = "Antiguedad";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvConsultaEmpleados_Antiguedad.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvConsultaEmpleados_Antiguedad.HeaderText = "Antiguedad";
            this.dgvConsultaEmpleados_Antiguedad.Name = "dgvConsultaEmpleados_Antiguedad";
            this.dgvConsultaEmpleados_Antiguedad.ReadOnly = true;
            this.dgvConsultaEmpleados_Antiguedad.Width = 104;
            // 
            // dgvConsultaEmpleados_Inactivo
            // 
            this.dgvConsultaEmpleados_Inactivo.DataPropertyName = "estaActivo";
            this.dgvConsultaEmpleados_Inactivo.HeaderText = "Activos";
            this.dgvConsultaEmpleados_Inactivo.Name = "dgvConsultaEmpleados_Inactivo";
            this.dgvConsultaEmpleados_Inactivo.ReadOnly = true;
            this.dgvConsultaEmpleados_Inactivo.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::SOFTMART_RRHH.Properties.Resources.icoClose;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(3, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 32);
            this.btnClose.TabIndex = 26;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.GhostWhite;
            this.tlpPrincipal.SetColumnSpan(this.lblTitulo, 2);
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(47, 25);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(5, 25, 0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.tlpPrincipal.SetRowSpan(this.lblTitulo, 2);
            this.lblTitulo.Size = new System.Drawing.Size(681, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "EMPLEADOS ACTIVOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(116)))), ((int)(((byte)(71)))));
            this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExcel.IconColor = System.Drawing.Color.White;
            this.btnExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExcel.IconSize = 28;
            this.btnExcel.Location = new System.Drawing.Point(905, 110);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(117, 36);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnRecarga
            // 
            this.btnRecarga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnRecarga.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRecarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecarga.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRecarga.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            this.btnRecarga.IconColor = System.Drawing.Color.White;
            this.btnRecarga.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRecarga.IconSize = 30;
            this.btnRecarga.Location = new System.Drawing.Point(758, 110);
            this.btnRecarga.Margin = new System.Windows.Forms.Padding(0);
            this.btnRecarga.Name = "btnRecarga";
            this.btnRecarga.Size = new System.Drawing.Size(117, 36);
            this.btnRecarga.TabIndex = 6;
            this.btnRecarga.UseVisualStyleBackColor = false;
            this.btnRecarga.Click += new System.EventHandler(this.btnRecarga_Click);
            // 
            // ChBFechaFiltro
            // 
            this.ChBFechaFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChBFechaFiltro.AutoSize = true;
            this.ChBFechaFiltro.Checked = true;
            this.ChBFechaFiltro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChBFechaFiltro.Location = new System.Drawing.Point(731, 41);
            this.ChBFechaFiltro.Name = "ChBFechaFiltro";
            this.ChBFechaFiltro.Size = new System.Drawing.Size(141, 22);
            this.ChBFechaFiltro.TabIndex = 27;
            this.ChBFechaFiltro.Text = "Tomar la fecha de hoy";
            this.ChBFechaFiltro.UseVisualStyleBackColor = true;
            this.ChBFechaFiltro.Visible = false;
            this.ChBFechaFiltro.CheckedChanged += new System.EventHandler(this.ChBFechaFiltro_CheckedChanged);
            // 
            // dtpFechaFiltro
            // 
            this.dtpFechaFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaFiltro.Enabled = false;
            this.dtpFechaFiltro.Location = new System.Drawing.Point(878, 42);
            this.dtpFechaFiltro.Name = "dtpFechaFiltro";
            this.dtpFechaFiltro.Size = new System.Drawing.Size(141, 20);
            this.dtpFechaFiltro.TabIndex = 28;
            this.dtpFechaFiltro.Visible = false;
            this.dtpFechaFiltro.ValueChanged += new System.EventHandler(this.dtpFechaFiltro_ValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblMin, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbInicio, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(731, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(141, 38);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblMin, 2);
            this.lblMin.Location = new System.Drawing.Point(3, 0);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(96, 13);
            this.lblMin.TabIndex = 2;
            this.lblMin.Text = "Antiguedad minima";
            // 
            // cbInicio
            // 
            this.cbInicio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbInicio.AutoCompleteCustomSource.AddRange(new string[] {
            "1 MES",
            "3 MESES",
            "6 MESES",
            "8 MESES",
            "1 AÑO",
            "2 AÑOS",
            "4 AÑOS",
            "6 AÑOS"});
            this.tableLayoutPanel1.SetColumnSpan(this.cbInicio, 2);
            this.cbInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInicio.FormattingEnabled = true;
            this.cbInicio.Items.AddRange(new object[] {
            "0 Año(s), 0 Mes(es)",
            "0 Año(s), 1 Mes(es)",
            "0 Año(s), 3 Mes(es)",
            "0 Año(s), 6 Mes(es)",
            "0 Año(s), 8 Mes(es)",
            "1 Año(s), 0 Mes(es)",
            "2 Año(s), 0 Mes(es)",
            "3 Año(s), 0 Mes(es)",
            "4 Año(s), 0 Mes(es)",
            "5 Año(s), 0 Mes(es)"});
            this.cbInicio.Location = new System.Drawing.Point(27, 16);
            this.cbInicio.Name = "cbInicio";
            this.cbInicio.Size = new System.Drawing.Size(111, 21);
            this.cbInicio.TabIndex = 4;
            this.cbInicio.SelectedIndexChanged += new System.EventHandler(this.cbInicio_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cbFinal, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblMax, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(878, 69);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(141, 38);
            this.tableLayoutPanel2.TabIndex = 30;
            // 
            // cbFinal
            // 
            this.cbFinal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel2.SetColumnSpan(this.cbFinal, 2);
            this.cbFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFinal.FormattingEnabled = true;
            this.cbFinal.Items.AddRange(new object[] {
            "0 Año(s), 1 Mes(es)",
            "0 Año(s), 3 Mes(es)",
            "0 Año(s), 6 Mes(es)",
            "0 Año(s), 8 Mes(es)",
            "1 Año(s), 0 Mes(es)",
            "2 Año(s), 0 Mes(es)",
            "3 Año(s), 0 Mes(es)",
            "4 Año(s), 0 Mes(es)",
            "5 Año(s), 0 Mes(es)",
            "99 Año(s), 0 Mes(es)"});
            this.cbFinal.Location = new System.Drawing.Point(27, 16);
            this.cbFinal.Name = "cbFinal";
            this.cbFinal.Size = new System.Drawing.Size(111, 21);
            this.cbFinal.TabIndex = 32;
            this.cbFinal.SelectedIndexChanged += new System.EventHandler(this.cbFinal_SelectedIndexChanged);
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lblMax, 2);
            this.lblMax.Location = new System.Drawing.Point(3, 0);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(99, 13);
            this.lblMax.TabIndex = 2;
            this.lblMax.Text = "Antiguedad maxima";
            // 
            // rowCounting
            // 
            this.rowCounting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rowCounting.AutoSize = true;
            this.rowCounting.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowCounting.Location = new System.Drawing.Point(878, 658);
            this.rowCounting.Name = "rowCounting";
            this.rowCounting.Size = new System.Drawing.Size(141, 15);
            this.rowCounting.TabIndex = 31;
            this.rowCounting.Text = "Registros : 0";
            this.rowCounting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.tlpPrincipal);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "vConsulta";
            this.Size = new System.Drawing.Size(1045, 676);
            this.Load += new System.EventHandler(this.vConsulta_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnExcel;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblColumn;
        private System.Windows.Forms.DataGridView dgvConsultaEmpleados;
        private System.Windows.Forms.PictureBox btnClose;
        private FontAwesome.Sharp.IconButton btnRecarga;
        private System.Windows.Forms.CheckBox ChBFechaFiltro;
        private System.Windows.Forms.DateTimePicker dtpFechaFiltro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.ComboBox cbInicio;
        private System.Windows.Forms.ComboBox cbFinal;
        private System.Windows.Forms.Label rowCounting;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvConsultaEmpleados_idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvConsultaEmpleados_idPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvConsultaEmpleados_DiasAntiguedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvConsultaEmpleados_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvConsultaEmpleados_NumContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvConsultaEmpleados_Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvConsultaEmpleados_Puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvConsultaEmpleados_FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvConsultaEmpleados_Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvConsultaEmpleados_FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvConsultaEmpleados_Antiguedad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvConsultaEmpleados_Inactivo;
    }
}
