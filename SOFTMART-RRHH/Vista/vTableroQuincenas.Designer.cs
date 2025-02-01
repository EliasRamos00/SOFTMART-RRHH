namespace SOFTMART_RRHH.Vista
{
    partial class vTableroQuincenas
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tbFiltroSueldos = new System.Windows.Forms.TextBox();
            this.lblBuscarSueldos = new System.Windows.Forms.Label();
            this.dgvSueldos = new System.Windows.Forms.DataGridView();
            this.dgvSueldos_idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSueldos_tieneCambios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSueldos_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSueldos_Fiscal1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSueldos_Bonificacion1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSueldos_Total1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSueldos_Fiscal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSueldos_Bonificacion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSueldos_Total2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSueldos_Diferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSueldos_QuincenaFutura = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCloseSueldos = new System.Windows.Forms.PictureBox();
            this.lblTituloSueldos = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbQuincenaAnterior = new System.Windows.Forms.ComboBox();
            this.dtpQuincenaAnterior = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpQuincenaActual = new System.Windows.Forms.DateTimePicker();
            this.cbQuincenaActual = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExpExc = new System.Windows.Forms.Label();
            this.lblImpExc = new System.Windows.Forms.Label();
            this.btnExportarExcel = new FontAwesome.Sharp.IconButton();
            this.btnImportarExcel = new FontAwesome.Sharp.IconButton();
            this.btnCerrarQuincena = new FontAwesome.Sharp.IconButton();
            this.btnGuardarCambios = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSueldos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseSueldos)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 6;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 239F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpPrincipal.Controls.Add(this.tbFiltroSueldos, 1, 3);
            this.tlpPrincipal.Controls.Add(this.lblBuscarSueldos, 1, 2);
            this.tlpPrincipal.Controls.Add(this.dgvSueldos, 1, 4);
            this.tlpPrincipal.Controls.Add(this.btnCloseSueldos, 0, 0);
            this.tlpPrincipal.Controls.Add(this.lblTituloSueldos, 1, 0);
            this.tlpPrincipal.Controls.Add(this.tableLayoutPanel1, 2, 3);
            this.tlpPrincipal.Controls.Add(this.tableLayoutPanel2, 3, 3);
            this.tlpPrincipal.Controls.Add(this.label2, 2, 2);
            this.tlpPrincipal.Controls.Add(this.label1, 3, 2);
            this.tlpPrincipal.Controls.Add(this.btnCerrarQuincena, 4, 3);
            this.tlpPrincipal.Controls.Add(this.btnBuscar, 1, 5);
            this.tlpPrincipal.Controls.Add(this.btnGuardarCambios, 4, 5);
            this.tlpPrincipal.Controls.Add(this.tableLayoutPanel4, 4, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 7;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.868839F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.981259F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.542002F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.6079F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1037, 650);
            this.tlpPrincipal.TabIndex = 2;
            // 
            // tbFiltroSueldos
            // 
            this.tbFiltroSueldos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFiltroSueldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltroSueldos.Location = new System.Drawing.Point(45, 99);
            this.tbFiltroSueldos.Name = "tbFiltroSueldos";
            this.tbFiltroSueldos.Size = new System.Drawing.Size(317, 26);
            this.tbFiltroSueldos.TabIndex = 2;
            this.tbFiltroSueldos.TextChanged += new System.EventHandler(this.tbFiltroSueldos_TextChanged);
            // 
            // lblBuscarSueldos
            // 
            this.lblBuscarSueldos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBuscarSueldos.AutoSize = true;
            this.lblBuscarSueldos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarSueldos.ForeColor = System.Drawing.Color.Black;
            this.lblBuscarSueldos.Location = new System.Drawing.Point(45, 75);
            this.lblBuscarSueldos.Name = "lblBuscarSueldos";
            this.lblBuscarSueldos.Size = new System.Drawing.Size(67, 21);
            this.lblBuscarSueldos.TabIndex = 1;
            this.lblBuscarSueldos.Text = "Buscar: ";
            // 
            // dgvSueldos
            // 
            this.dgvSueldos.AllowUserToAddRows = false;
            this.dgvSueldos.AllowUserToDeleteRows = false;
            this.dgvSueldos.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSueldos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSueldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSueldos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSueldos_idEmpleado,
            this.dgvSueldos_tieneCambios,
            this.dgvSueldos_Nombre,
            this.dgvSueldos_Fiscal1,
            this.dgvSueldos_Bonificacion1,
            this.dgvSueldos_Total1,
            this.dgvSueldos_Fiscal2,
            this.dgvSueldos_Bonificacion2,
            this.dgvSueldos_Total2,
            this.dgvSueldos_Diferencia,
            this.dgvSueldos_QuincenaFutura});
            this.tlpPrincipal.SetColumnSpan(this.dgvSueldos, 4);
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSueldos.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSueldos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSueldos.GridColor = System.Drawing.Color.Black;
            this.dgvSueldos.Location = new System.Drawing.Point(45, 134);
            this.dgvSueldos.MultiSelect = false;
            this.dgvSueldos.Name = "dgvSueldos";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSueldos.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSueldos.RowHeadersVisible = false;
            this.dgvSueldos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSueldos.Size = new System.Drawing.Size(960, 436);
            this.dgvSueldos.TabIndex = 6;
            this.dgvSueldos.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvSueldos_CellBeginEdit);
            this.dgvSueldos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSueldos_CellDoubleClick);
            this.dgvSueldos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSueldos_CellEndEdit);
            this.dgvSueldos.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSueldos_CellMouseEnter);
            this.dgvSueldos.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSueldos_CellMouseLeave);
            this.dgvSueldos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvSueldos_CellPainting);
            this.dgvSueldos.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.dgvSueldos_CellToolTipTextNeeded);
            // 
            // btnCloseSueldos
            // 
            this.btnCloseSueldos.BackgroundImage = global::SOFTMART_RRHH.Properties.Resources.icoClose;
            this.btnCloseSueldos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCloseSueldos.Location = new System.Drawing.Point(3, 3);
            this.btnCloseSueldos.Name = "btnCloseSueldos";
            this.btnCloseSueldos.Size = new System.Drawing.Size(36, 31);
            this.btnCloseSueldos.TabIndex = 26;
            this.btnCloseSueldos.TabStop = false;
            // 
            // lblTituloSueldos
            // 
            this.lblTituloSueldos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloSueldos.AutoSize = true;
            this.lblTituloSueldos.BackColor = System.Drawing.SystemColors.Control;
            this.tlpPrincipal.SetColumnSpan(this.lblTituloSueldos, 2);
            this.lblTituloSueldos.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSueldos.ForeColor = System.Drawing.Color.Black;
            this.lblTituloSueldos.Location = new System.Drawing.Point(47, 25);
            this.lblTituloSueldos.Margin = new System.Windows.Forms.Padding(5, 25, 0, 0);
            this.lblTituloSueldos.Name = "lblTituloSueldos";
            this.tlpPrincipal.SetRowSpan(this.lblTituloSueldos, 2);
            this.lblTituloSueldos.Size = new System.Drawing.Size(557, 39);
            this.lblTituloSueldos.TabIndex = 0;
            this.lblTituloSueldos.Text = "Sueldos Quincenales";
            this.lblTituloSueldos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cbQuincenaAnterior, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpQuincenaAnterior, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(368, 99);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(233, 35);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // cbQuincenaAnterior
            // 
            this.cbQuincenaAnterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbQuincenaAnterior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuincenaAnterior.Enabled = false;
            this.cbQuincenaAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuincenaAnterior.FormattingEnabled = true;
            this.cbQuincenaAnterior.Items.AddRange(new object[] {
            "1ER QUINCENA",
            "2DA QUINCENA"});
            this.cbQuincenaAnterior.Location = new System.Drawing.Point(119, 3);
            this.cbQuincenaAnterior.Name = "cbQuincenaAnterior";
            this.cbQuincenaAnterior.Size = new System.Drawing.Size(111, 24);
            this.cbQuincenaAnterior.TabIndex = 31;
            this.cbQuincenaAnterior.SelectedIndexChanged += new System.EventHandler(this.cbQuincenaAnterior_SelectedIndexChanged);
            // 
            // dtpQuincenaAnterior
            // 
            this.dtpQuincenaAnterior.CustomFormat = "MMM- yyyy";
            this.dtpQuincenaAnterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpQuincenaAnterior.Enabled = false;
            this.dtpQuincenaAnterior.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpQuincenaAnterior.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpQuincenaAnterior.Location = new System.Drawing.Point(3, 3);
            this.dtpQuincenaAnterior.Name = "dtpQuincenaAnterior";
            this.dtpQuincenaAnterior.ShowUpDown = true;
            this.dtpQuincenaAnterior.Size = new System.Drawing.Size(110, 27);
            this.dtpQuincenaAnterior.TabIndex = 30;
            this.dtpQuincenaAnterior.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpQuincenaAnterior.ValueChanged += new System.EventHandler(this.dtpQuincenaAnterior_ValueChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dtpQuincenaActual, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbQuincenaActual, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(607, 99);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(239, 35);
            this.tableLayoutPanel2.TabIndex = 33;
            // 
            // dtpQuincenaActual
            // 
            this.dtpQuincenaActual.CustomFormat = "MMM- yyyy";
            this.dtpQuincenaActual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpQuincenaActual.Enabled = false;
            this.dtpQuincenaActual.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpQuincenaActual.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpQuincenaActual.Location = new System.Drawing.Point(3, 3);
            this.dtpQuincenaActual.Name = "dtpQuincenaActual";
            this.dtpQuincenaActual.ShowUpDown = true;
            this.dtpQuincenaActual.Size = new System.Drawing.Size(113, 27);
            this.dtpQuincenaActual.TabIndex = 30;
            this.dtpQuincenaActual.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpQuincenaActual.ValueChanged += new System.EventHandler(this.dtpQuincenaActual_ValueChanged);
            this.dtpQuincenaActual.Enter += new System.EventHandler(this.dtpQuincenaActual_Enter);
            // 
            // cbQuincenaActual
            // 
            this.cbQuincenaActual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbQuincenaActual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuincenaActual.Enabled = false;
            this.cbQuincenaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuincenaActual.FormattingEnabled = true;
            this.cbQuincenaActual.Items.AddRange(new object[] {
            "1ER QUINCENA",
            "2DA QUINCENA"});
            this.cbQuincenaActual.Location = new System.Drawing.Point(122, 3);
            this.cbQuincenaActual.Name = "cbQuincenaActual";
            this.cbQuincenaActual.Size = new System.Drawing.Size(114, 24);
            this.cbQuincenaActual.TabIndex = 31;
            this.cbQuincenaActual.SelectedIndexChanged += new System.EventHandler(this.cbQuincenaActual_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 32);
            this.label2.TabIndex = 37;
            this.label2.Text = "ANTERIOR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(607, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 32);
            this.label1.TabIndex = 38;
            this.label1.Text = "ACTUAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExpExc
            // 
            this.lblExpExc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpExc.AutoSize = true;
            this.lblExpExc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpExc.ForeColor = System.Drawing.Color.Black;
            this.lblExpExc.Location = new System.Drawing.Point(3, 19);
            this.lblExpExc.Name = "lblExpExc";
            this.lblExpExc.Size = new System.Drawing.Size(70, 26);
            this.lblExpExc.TabIndex = 29;
            this.lblExpExc.Text = "Exportar Excel";
            this.lblExpExc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExpExc.Click += new System.EventHandler(this.lblExpExc_Click);
            // 
            // lblImpExc
            // 
            this.lblImpExc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImpExc.AutoSize = true;
            this.lblImpExc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpExc.ForeColor = System.Drawing.Color.Black;
            this.lblImpExc.Location = new System.Drawing.Point(79, 19);
            this.lblImpExc.Name = "lblImpExc";
            this.lblImpExc.Size = new System.Drawing.Size(71, 26);
            this.lblImpExc.TabIndex = 28;
            this.lblImpExc.Text = "Importar Excel";
            this.lblImpExc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(116)))), ((int)(((byte)(71)))));
            this.btnExportarExcel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarExcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExportarExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExportarExcel.IconColor = System.Drawing.Color.White;
            this.btnExportarExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportarExcel.IconSize = 28;
            this.btnExportarExcel.Location = new System.Drawing.Point(0, 55);
            this.btnExportarExcel.Margin = new System.Windows.Forms.Padding(0);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(76, 35);
            this.btnExportarExcel.TabIndex = 5;
            this.btnExportarExcel.UseVisualStyleBackColor = false;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnImportarExcel
            // 
            this.btnImportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportarExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(116)))), ((int)(((byte)(71)))));
            this.btnImportarExcel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnImportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportarExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarExcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImportarExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnImportarExcel.IconColor = System.Drawing.Color.White;
            this.btnImportarExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImportarExcel.IconSize = 28;
            this.btnImportarExcel.Location = new System.Drawing.Point(76, 55);
            this.btnImportarExcel.Margin = new System.Windows.Forms.Padding(0);
            this.btnImportarExcel.Name = "btnImportarExcel";
            this.btnImportarExcel.Size = new System.Drawing.Size(77, 35);
            this.btnImportarExcel.TabIndex = 27;
            this.btnImportarExcel.UseVisualStyleBackColor = false;
            this.btnImportarExcel.Click += new System.EventHandler(this.btnImportarExcel_Click);
            // 
            // btnCerrarQuincena
            // 
            this.btnCerrarQuincena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnCerrarQuincena.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrarQuincena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarQuincena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarQuincena.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrarQuincena.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnCerrarQuincena.IconColor = System.Drawing.Color.White;
            this.btnCerrarQuincena.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarQuincena.IconSize = 28;
            this.btnCerrarQuincena.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarQuincena.Location = new System.Drawing.Point(849, 96);
            this.btnCerrarQuincena.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrarQuincena.Name = "btnCerrarQuincena";
            this.btnCerrarQuincena.Size = new System.Drawing.Size(159, 34);
            this.btnCerrarQuincena.TabIndex = 35;
            this.btnCerrarQuincena.Text = "Cerrar Quincena";
            this.btnCerrarQuincena.UseVisualStyleBackColor = false;
            this.btnCerrarQuincena.Click += new System.EventHandler(this.btnCerrarQuincena_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnGuardarCambios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardarCambios.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnGuardarCambios.IconColor = System.Drawing.Color.White;
            this.btnGuardarCambios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarCambios.IconSize = 28;
            this.btnGuardarCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCambios.Location = new System.Drawing.Point(849, 573);
            this.btnGuardarCambios.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(159, 41);
            this.btnGuardarCambios.TabIndex = 40;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 28;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(42, 573);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(159, 41);
            this.btnBuscar.TabIndex = 39;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tableLayoutPanel4
            // 
            this.dgvSueldos_idEmpleado.DataPropertyName = "idEmpleado";
            this.dgvSueldos_idEmpleado.HeaderText = "idEmpleado";
            this.dgvSueldos_idEmpleado.Name = "dgvSueldos_idEmpleado";
            this.dgvSueldos_idEmpleado.Visible = false;
            // 
            // dgvSueldos_tieneCambios
            // 
            this.dgvSueldos_tieneCambios.DataPropertyName = "tieneCambios";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dgvSueldos_tieneCambios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSueldos_tieneCambios.HeaderText = "tieneCambios";
            this.dgvSueldos_tieneCambios.Name = "dgvSueldos_tieneCambios";
            this.dgvSueldos_tieneCambios.Visible = false;
            // 
            // dgvSueldos_Nombre
            // 
            this.dgvSueldos_Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvSueldos_Nombre.DataPropertyName = "Nombre";
            this.dgvSueldos_Nombre.HeaderText = "Nombre";
            this.dgvSueldos_Nombre.Name = "dgvSueldos_Nombre";
            this.dgvSueldos_Nombre.ReadOnly = true;
            // 
            // dgvSueldos_Fiscal1
            // 
            this.dgvSueldos_Fiscal1.DataPropertyName = "SueldoFiscal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Format = "C2";
            this.dgvSueldos_Fiscal1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSueldos_Fiscal1.HeaderText = "Fiscal";
            this.dgvSueldos_Fiscal1.Name = "dgvSueldos_Fiscal1";
            this.dgvSueldos_Fiscal1.ReadOnly = true;
            this.dgvSueldos_Fiscal1.Width = 80;
            // 
            // dgvSueldos_Bonificacion1
            // 
            this.dgvSueldos_Bonificacion1.DataPropertyName = "Bonificacion";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Format = "C2";
            this.dgvSueldos_Bonificacion1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSueldos_Bonificacion1.HeaderText = "Bonif.";
            this.dgvSueldos_Bonificacion1.Name = "dgvSueldos_Bonificacion1";
            this.dgvSueldos_Bonificacion1.ReadOnly = true;
            this.dgvSueldos_Bonificacion1.Width = 80;
            // 
            // dgvSueldos_Total1
            // 
            this.dgvSueldos_Total1.DataPropertyName = "SueldoTotal";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Format = "C2";
            this.dgvSueldos_Total1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSueldos_Total1.HeaderText = "Total";
            this.dgvSueldos_Total1.Name = "dgvSueldos_Total1";
            this.dgvSueldos_Total1.ReadOnly = true;
            this.dgvSueldos_Total1.Width = 80;
            // 
            // dgvSueldos_Fiscal2
            // 
            this.dgvSueldos_Fiscal2.DataPropertyName = "SueldoFiscalAux";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle6.Format = "C2";
            this.dgvSueldos_Fiscal2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSueldos_Fiscal2.HeaderText = "Fiscal";
            this.dgvSueldos_Fiscal2.Name = "dgvSueldos_Fiscal2";
            this.dgvSueldos_Fiscal2.Width = 80;
            // 
            // dgvSueldos_Bonificacion2
            // 
            this.dgvSueldos_Bonificacion2.DataPropertyName = "BonificacionAux";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle7.Format = "C2";
            this.dgvSueldos_Bonificacion2.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSueldos_Bonificacion2.HeaderText = "Bonif.";
            this.dgvSueldos_Bonificacion2.Name = "dgvSueldos_Bonificacion2";
            this.dgvSueldos_Bonificacion2.Width = 80;
            // 
            // dgvSueldos_Total2
            // 
            this.dgvSueldos_Total2.DataPropertyName = "SueldoTotalAux";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Format = "C2";
            this.dgvSueldos_Total2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSueldos_Total2.HeaderText = "Total";
            this.dgvSueldos_Total2.Name = "dgvSueldos_Total2";
            this.dgvSueldos_Total2.ReadOnly = true;
            this.dgvSueldos_Total2.Width = 83;
            // 
            // dgvSueldos_Diferencia
            // 
            this.dgvSueldos_Diferencia.DataPropertyName = "Diferencia";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Format = "C2";
            this.dgvSueldos_Diferencia.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSueldos_Diferencia.HeaderText = "Diff.";
            this.dgvSueldos_Diferencia.Name = "dgvSueldos_Diferencia";
            this.dgvSueldos_Diferencia.ReadOnly = true;
            this.dgvSueldos_Diferencia.Width = 83;
            // 
            // dgvSueldos_QuincenaFutura
            // 
            this.dgvSueldos_QuincenaFutura.DataPropertyName = "TieneRegistrosPosteriores";
            this.dgvSueldos_QuincenaFutura.HeaderText = "QuincenaFutura";
            this.dgvSueldos_QuincenaFutura.Name = "dgvSueldos_QuincenaFutura";
            this.dgvSueldos_QuincenaFutura.ReadOnly = true;
            this.dgvSueldos_QuincenaFutura.Visible = false;
            this.dgvSueldos_QuincenaFutura.Width = 60;
            // 
            // vTableroQuincenas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpPrincipal);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "vTableroQuincenas";
            this.Size = new System.Drawing.Size(1037, 650);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSueldos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseSueldos)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TextBox tbFiltroSueldos;
        private System.Windows.Forms.Label lblBuscarSueldos;
        private System.Windows.Forms.DataGridView dgvSueldos;
        private System.Windows.Forms.PictureBox btnCloseSueldos;
        private System.Windows.Forms.Label lblTituloSueldos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbQuincenaAnterior;
        private System.Windows.Forms.DateTimePicker dtpQuincenaAnterior;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cbQuincenaActual;
        private System.Windows.Forms.DateTimePicker dtpQuincenaActual;
        private System.Windows.Forms.Label lblExpExc;
        private FontAwesome.Sharp.IconButton btnExportarExcel;
        private FontAwesome.Sharp.IconButton btnCerrarQuincena;
        private System.Windows.Forms.Label lblImpExc;
        private FontAwesome.Sharp.IconButton btnImportarExcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnGuardarCambios;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSueldos_idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSueldos_tieneCambios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSueldos_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSueldos_Fiscal1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSueldos_Bonificacion1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSueldos_Total1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSueldos_Fiscal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSueldos_Bonificacion2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSueldos_Total2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSueldos_Diferencia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvSueldos_QuincenaFutura;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}
