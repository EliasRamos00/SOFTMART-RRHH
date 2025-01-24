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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tbFiltroSueldos = new System.Windows.Forms.TextBox();
            this.lblBuscarSueldos = new System.Windows.Forms.Label();
            this.lblColumnSueldos = new System.Windows.Forms.Label();
            this.cbFiltroSueldos = new System.Windows.Forms.ComboBox();
            this.dgvSueldos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiscal1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonificacion1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiscal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonificacion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuincenaFutura = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCloseSueldos = new System.Windows.Forms.PictureBox();
            this.lblTituloSueldos = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbQuincenaAnterior = new System.Windows.Forms.ComboBox();
            this.dtpQuincenaAnterior = new System.Windows.Forms.DateTimePicker();
            this.btnExportarExcel = new FontAwesome.Sharp.IconButton();
            this.lblExpExc = new System.Windows.Forms.Label();
            this.lblImpExc = new System.Windows.Forms.Label();
            this.btnImportarExcel = new FontAwesome.Sharp.IconButton();
            this.btnCerrarQuincena = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpQuincenaActual = new System.Windows.Forms.DateTimePicker();
            this.cbQuincenaActual = new System.Windows.Forms.ComboBox();
            this.tlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSueldos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseSueldos)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 10;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.82132F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.87148F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9060023F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.614213F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpPrincipal.Controls.Add(this.tbFiltroSueldos, 1, 3);
            this.tlpPrincipal.Controls.Add(this.lblBuscarSueldos, 1, 2);
            this.tlpPrincipal.Controls.Add(this.lblColumnSueldos, 2, 2);
            this.tlpPrincipal.Controls.Add(this.cbFiltroSueldos, 2, 3);
            this.tlpPrincipal.Controls.Add(this.dgvSueldos, 1, 4);
            this.tlpPrincipal.Controls.Add(this.btnCloseSueldos, 0, 0);
            this.tlpPrincipal.Controls.Add(this.lblTituloSueldos, 1, 0);
            this.tlpPrincipal.Controls.Add(this.tableLayoutPanel1, 2, 5);
            this.tlpPrincipal.Controls.Add(this.btnExportarExcel, 7, 3);
            this.tlpPrincipal.Controls.Add(this.lblExpExc, 7, 2);
            this.tlpPrincipal.Controls.Add(this.lblImpExc, 5, 2);
            this.tlpPrincipal.Controls.Add(this.btnImportarExcel, 5, 3);
            this.tlpPrincipal.Controls.Add(this.btnCerrarQuincena, 8, 3);
            this.tlpPrincipal.Controls.Add(this.tableLayoutPanel2, 4, 5);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 7;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.850746F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.959032F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.517691F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.30093F));
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
            this.tbFiltroSueldos.Size = new System.Drawing.Size(328, 26);
            this.tbFiltroSueldos.TabIndex = 2;
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
            // lblColumnSueldos
            // 
            this.lblColumnSueldos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblColumnSueldos.AutoSize = true;
            this.lblColumnSueldos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnSueldos.ForeColor = System.Drawing.Color.Black;
            this.lblColumnSueldos.Location = new System.Drawing.Point(379, 75);
            this.lblColumnSueldos.Name = "lblColumnSueldos";
            this.lblColumnSueldos.Size = new System.Drawing.Size(79, 21);
            this.lblColumnSueldos.TabIndex = 3;
            this.lblColumnSueldos.Text = "Columna";
            // 
            // cbFiltroSueldos
            // 
            this.cbFiltroSueldos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFiltroSueldos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroSueldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltroSueldos.FormattingEnabled = true;
            this.cbFiltroSueldos.Location = new System.Drawing.Point(379, 99);
            this.cbFiltroSueldos.Name = "cbFiltroSueldos";
            this.cbFiltroSueldos.Size = new System.Drawing.Size(239, 28);
            this.cbFiltroSueldos.TabIndex = 4;
            // 
            // dgvSueldos
            // 
            this.dgvSueldos.AllowUserToAddRows = false;
            this.dgvSueldos.AllowUserToDeleteRows = false;
            this.dgvSueldos.AllowUserToOrderColumns = true;
            this.dgvSueldos.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSueldos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSueldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSueldos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Fiscal1,
            this.Bonificacion1,
            this.Total1,
            this.Fiscal2,
            this.Bonificacion2,
            this.Total2,
            this.Diferencia,
            this.QuincenaFutura});
            this.tlpPrincipal.SetColumnSpan(this.dgvSueldos, 8);
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSueldos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSueldos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSueldos.GridColor = System.Drawing.Color.Black;
            this.dgvSueldos.Location = new System.Drawing.Point(45, 134);
            this.dgvSueldos.MultiSelect = false;
            this.dgvSueldos.Name = "dgvSueldos";
            this.dgvSueldos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSueldos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSueldos.RowHeadersVisible = false;
            this.dgvSueldos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSueldos.Size = new System.Drawing.Size(951, 436);
            this.dgvSueldos.TabIndex = 6;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Fiscal1
            // 
            this.Fiscal1.HeaderText = "Fiscal";
            this.Fiscal1.Name = "Fiscal1";
            this.Fiscal1.ReadOnly = true;
            this.Fiscal1.Width = 80;
            // 
            // Bonificacion1
            // 
            this.Bonificacion1.HeaderText = "Bonificación";
            this.Bonificacion1.Name = "Bonificacion1";
            this.Bonificacion1.ReadOnly = true;
            this.Bonificacion1.Width = 80;
            // 
            // Total1
            // 
            this.Total1.HeaderText = "Total";
            this.Total1.Name = "Total1";
            this.Total1.ReadOnly = true;
            this.Total1.Width = 80;
            // 
            // Fiscal2
            // 
            this.Fiscal2.HeaderText = "Fiscal";
            this.Fiscal2.Name = "Fiscal2";
            this.Fiscal2.ReadOnly = true;
            this.Fiscal2.Width = 80;
            // 
            // Bonificacion2
            // 
            this.Bonificacion2.HeaderText = "Bonificación";
            this.Bonificacion2.Name = "Bonificacion2";
            this.Bonificacion2.ReadOnly = true;
            this.Bonificacion2.Width = 80;
            // 
            // Total2
            // 
            this.Total2.HeaderText = "Total";
            this.Total2.Name = "Total2";
            this.Total2.ReadOnly = true;
            this.Total2.Width = 80;
            // 
            // Diferencia
            // 
            this.Diferencia.HeaderText = "Diferencia";
            this.Diferencia.Name = "Diferencia";
            this.Diferencia.ReadOnly = true;
            this.Diferencia.Width = 80;
            // 
            // QuincenaFutura
            // 
            this.QuincenaFutura.HeaderText = "QuincenaFutura";
            this.QuincenaFutura.Name = "QuincenaFutura";
            this.QuincenaFutura.ReadOnly = true;
            this.QuincenaFutura.Width = 60;
            // 
            // btnCloseSueldos
            // 
            this.btnCloseSueldos.BackgroundImage = global::SOFTMART_RRHH.Properties.Resources.icoClose;
            this.btnCloseSueldos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCloseSueldos.Location = new System.Drawing.Point(3, 3);
            this.btnCloseSueldos.Name = "btnCloseSueldos";
            this.btnCloseSueldos.Size = new System.Drawing.Size(36, 32);
            this.btnCloseSueldos.TabIndex = 26;
            this.btnCloseSueldos.TabStop = false;
            // 
            // lblTituloSueldos
            // 
            this.lblTituloSueldos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloSueldos.AutoSize = true;
            this.lblTituloSueldos.BackColor = System.Drawing.Color.GhostWhite;
            this.tlpPrincipal.SetColumnSpan(this.lblTituloSueldos, 2);
            this.lblTituloSueldos.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSueldos.ForeColor = System.Drawing.Color.Black;
            this.lblTituloSueldos.Location = new System.Drawing.Point(47, 25);
            this.lblTituloSueldos.Margin = new System.Windows.Forms.Padding(5, 25, 0, 0);
            this.lblTituloSueldos.Name = "lblTituloSueldos";
            this.tlpPrincipal.SetRowSpan(this.lblTituloSueldos, 2);
            this.lblTituloSueldos.Size = new System.Drawing.Size(574, 39);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(379, 576);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(230, 25);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // cbQuincenaAnterior
            // 
            this.cbQuincenaAnterior.FormattingEnabled = true;
            this.cbQuincenaAnterior.Location = new System.Drawing.Point(118, 3);
            this.cbQuincenaAnterior.Name = "cbQuincenaAnterior";
            this.cbQuincenaAnterior.Size = new System.Drawing.Size(109, 21);
            this.cbQuincenaAnterior.TabIndex = 31;
            // 
            // dtpQuincenaAnterior
            // 
            this.dtpQuincenaAnterior.CustomFormat = "MMM-yyyy";
            this.dtpQuincenaAnterior.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpQuincenaAnterior.Location = new System.Drawing.Point(3, 3);
            this.dtpQuincenaAnterior.Name = "dtpQuincenaAnterior";
            this.dtpQuincenaAnterior.Size = new System.Drawing.Size(109, 22);
            this.dtpQuincenaAnterior.TabIndex = 30;
            this.dtpQuincenaAnterior.Value = new System.DateTime(2025, 1, 7, 0, 0, 0, 0);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
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
            this.btnExportarExcel.Location = new System.Drawing.Point(792, 96);
            this.btnExportarExcel.Margin = new System.Windows.Forms.Padding(0);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(63, 35);
            this.btnExportarExcel.TabIndex = 5;
            this.btnExportarExcel.UseVisualStyleBackColor = false;
            // 
            // lblExpExc
            // 
            this.lblExpExc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpExc.AutoSize = true;
            this.lblExpExc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpExc.ForeColor = System.Drawing.Color.Black;
            this.lblExpExc.Location = new System.Drawing.Point(793, 70);
            this.lblExpExc.Name = "lblExpExc";
            this.lblExpExc.Size = new System.Drawing.Size(59, 26);
            this.lblExpExc.TabIndex = 29;
            this.lblExpExc.Text = "Exportar Excel";
            // 
            // lblImpExc
            // 
            this.lblImpExc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImpExc.AutoSize = true;
            this.lblImpExc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpExc.ForeColor = System.Drawing.Color.Black;
            this.lblImpExc.Location = new System.Drawing.Point(677, 70);
            this.lblImpExc.Name = "lblImpExc";
            this.lblImpExc.Size = new System.Drawing.Size(62, 26);
            this.lblImpExc.TabIndex = 28;
            this.lblImpExc.Text = "Importar Excel";
            this.lblImpExc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnImportarExcel
            // 
            this.btnImportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
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
            this.btnImportarExcel.Location = new System.Drawing.Point(675, 96);
            this.btnImportarExcel.Margin = new System.Windows.Forms.Padding(0);
            this.btnImportarExcel.Name = "btnImportarExcel";
            this.btnImportarExcel.Size = new System.Drawing.Size(67, 35);
            this.btnImportarExcel.TabIndex = 27;
            this.btnImportarExcel.UseVisualStyleBackColor = false;
            // 
            // btnCerrarQuincena
            // 
            this.btnCerrarQuincena.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCerrarQuincena.IconColor = System.Drawing.Color.Black;
            this.btnCerrarQuincena.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarQuincena.Location = new System.Drawing.Point(858, 99);
            this.btnCerrarQuincena.Name = "btnCerrarQuincena";
            this.btnCerrarQuincena.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarQuincena.TabIndex = 34;
            this.btnCerrarQuincena.Text = "iconButton2";
            this.btnCerrarQuincena.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tlpPrincipal.SetColumnSpan(this.tableLayoutPanel2, 4);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dtpQuincenaActual, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbQuincenaActual, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(629, 576);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(223, 35);
            this.tableLayoutPanel2.TabIndex = 33;
            // 
            // dtpQuincenaActual
            // 
            this.dtpQuincenaActual.CustomFormat = "MMM-yyyy";
            this.dtpQuincenaActual.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpQuincenaActual.Location = new System.Drawing.Point(3, 3);
            this.dtpQuincenaActual.Name = "dtpQuincenaActual";
            this.dtpQuincenaActual.Size = new System.Drawing.Size(104, 22);
            this.dtpQuincenaActual.TabIndex = 30;
            this.dtpQuincenaActual.Value = new System.DateTime(2025, 1, 7, 0, 0, 0, 0);
            // 
            // cbQuincenaActual
            // 
            this.cbQuincenaActual.FormattingEnabled = true;
            this.cbQuincenaActual.Location = new System.Drawing.Point(114, 3);
            this.cbQuincenaActual.Name = "cbQuincenaActual";
            this.cbQuincenaActual.Size = new System.Drawing.Size(102, 21);
            this.cbQuincenaActual.TabIndex = 31;
            // 
            // vTableroQuincenas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TextBox tbFiltroSueldos;
        private System.Windows.Forms.Label lblBuscarSueldos;
        private System.Windows.Forms.Label lblColumnSueldos;
        private System.Windows.Forms.ComboBox cbFiltroSueldos;
        private System.Windows.Forms.DataGridView dgvSueldos;
        private System.Windows.Forms.PictureBox btnCloseSueldos;
        private System.Windows.Forms.Label lblTituloSueldos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbQuincenaAnterior;
        private System.Windows.Forms.DateTimePicker dtpQuincenaAnterior;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cbQuincenaActual;
        private System.Windows.Forms.DateTimePicker dtpQuincenaActual;
        private FontAwesome.Sharp.IconButton btnExportarExcel;
        private System.Windows.Forms.Label lblExpExc;
        private System.Windows.Forms.Label lblImpExc;
        private FontAwesome.Sharp.IconButton btnImportarExcel;
        private FontAwesome.Sharp.IconButton btnCerrarQuincena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiscal1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bonificacion1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiscal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bonificacion2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diferencia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn QuincenaFutura;
    }
}
