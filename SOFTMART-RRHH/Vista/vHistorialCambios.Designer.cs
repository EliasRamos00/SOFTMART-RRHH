namespace SOFTMART_RRHH.Vista
{
    partial class vHistorialCambios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lblGeneral = new System.Windows.Forms.Label();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.dgvHistorial_idHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHistorial_Tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHistorial_FechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHistorial_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHistorial_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblColumn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAntes = new System.Windows.Forms.RichTextBox();
            this.txtDespues = new System.Windows.Forms.RichTextBox();
            this.btnRecarga = new FontAwesome.Sharp.IconButton();
            this.tlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
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
            this.tlpPrincipal.Controls.Add(this.btnClose, 0, 0);
            this.tlpPrincipal.Controls.Add(this.dgvHistorial, 1, 4);
            this.tlpPrincipal.Controls.Add(this.lblColumn, 2, 3);
            this.tlpPrincipal.Controls.Add(this.label1, 3, 3);
            this.tlpPrincipal.Controls.Add(this.txtAntes, 2, 4);
            this.tlpPrincipal.Controls.Add(this.txtDespues, 3, 4);
            this.tlpPrincipal.Controls.Add(this.btnRecarga, 4, 2);
            this.tlpPrincipal.Controls.Add(this.lblTitulo, 1, 0);
            this.tlpPrincipal.Controls.Add(this.lblGeneral, 1, 2);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 6;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.900565F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.900565F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.900565F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.29831F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1045, 675);
            this.tlpPrincipal.TabIndex = 1;
            this.tlpPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpPrincipal_Paint);
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
            // lblGeneral
            // 
            this.lblGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGeneral.AutoSize = true;
            this.tlpPrincipal.SetColumnSpan(this.lblGeneral, 3);
            this.lblGeneral.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblGeneral.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneral.ForeColor = System.Drawing.Color.Black;
            this.lblGeneral.Location = new System.Drawing.Point(45, 78);
            this.lblGeneral.Name = "lblGeneral";
            this.lblGeneral.Size = new System.Drawing.Size(827, 28);
            this.lblGeneral.TabIndex = 1;
            this.lblGeneral.Text = "GENERAL";
            this.lblGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.AllowUserToOrderColumns = true;
            this.dgvHistorial.AllowUserToResizeRows = false;
            this.dgvHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvHistorial_idHistorial,
            this.dgvHistorial_Tabla,
            this.dgvHistorial_FechaHora,
            this.dgvHistorial_Movimiento,
            this.dgvHistorial_Usuario});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorial.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHistorial.GridColor = System.Drawing.Color.Black;
            this.dgvHistorial.Location = new System.Drawing.Point(45, 149);
            this.dgvHistorial.MultiSelect = false;
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorial.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHistorial.RowHeadersVisible = false;
            this.dgvHistorial.RowHeadersWidth = 51;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Size = new System.Drawing.Size(386, 501);
            this.dgvHistorial.TabIndex = 6;
            this.dgvHistorial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorial_CellClick);
            this.dgvHistorial.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorial_CellEnter);
            this.dgvHistorial.SelectionChanged += new System.EventHandler(this.dgvHistorial_SelectionChanged);
            // 
            // dgvHistorial_idHistorial
            // 
            this.dgvHistorial_idHistorial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvHistorial_idHistorial.DataPropertyName = "idHistorial";
            this.dgvHistorial_idHistorial.HeaderText = "idHistorial";
            this.dgvHistorial_idHistorial.MinimumWidth = 6;
            this.dgvHistorial_idHistorial.Name = "dgvHistorial_idHistorial";
            this.dgvHistorial_idHistorial.ReadOnly = true;
            this.dgvHistorial_idHistorial.Visible = false;
            this.dgvHistorial_idHistorial.Width = 125;
            // 
            // dgvHistorial_Tabla
            // 
            this.dgvHistorial_Tabla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dgvHistorial_Tabla.DataPropertyName = "Tabla";
            this.dgvHistorial_Tabla.HeaderText = "Tabla";
            this.dgvHistorial_Tabla.MinimumWidth = 6;
            this.dgvHistorial_Tabla.Name = "dgvHistorial_Tabla";
            this.dgvHistorial_Tabla.ReadOnly = true;
            this.dgvHistorial_Tabla.Width = 6;
            // 
            // dgvHistorial_FechaHora
            // 
            this.dgvHistorial_FechaHora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvHistorial_FechaHora.DataPropertyName = "FechaHora";
            this.dgvHistorial_FechaHora.HeaderText = "Fecha y Hora";
            this.dgvHistorial_FechaHora.MinimumWidth = 6;
            this.dgvHistorial_FechaHora.Name = "dgvHistorial_FechaHora";
            this.dgvHistorial_FechaHora.ReadOnly = true;
            // 
            // dgvHistorial_Movimiento
            // 
            this.dgvHistorial_Movimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dgvHistorial_Movimiento.DataPropertyName = "Movimiento";
            this.dgvHistorial_Movimiento.HeaderText = "Movimiento";
            this.dgvHistorial_Movimiento.MinimumWidth = 6;
            this.dgvHistorial_Movimiento.Name = "dgvHistorial_Movimiento";
            this.dgvHistorial_Movimiento.ReadOnly = true;
            this.dgvHistorial_Movimiento.Width = 6;
            // 
            // dgvHistorial_Usuario
            // 
            this.dgvHistorial_Usuario.DataPropertyName = "Usuario";
            this.dgvHistorial_Usuario.HeaderText = "Usuario";
            this.dgvHistorial_Usuario.MinimumWidth = 6;
            this.dgvHistorial_Usuario.Name = "dgvHistorial_Usuario";
            this.dgvHistorial_Usuario.ReadOnly = true;
            this.dgvHistorial_Usuario.Width = 125;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.GhostWhite;
            this.tlpPrincipal.SetColumnSpan(this.lblTitulo, 3);
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(47, 14);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.tlpPrincipal.SetRowSpan(this.lblTitulo, 2);
            this.lblTitulo.Size = new System.Drawing.Size(825, 60);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "HISTORIAL CAMBIOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblColumn
            // 
            this.lblColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblColumn.AutoSize = true;
            this.lblColumn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumn.ForeColor = System.Drawing.Color.Black;
            this.lblColumn.Location = new System.Drawing.Point(437, 122);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(54, 24);
            this.lblColumn.TabIndex = 3;
            this.lblColumn.Text = "Antes";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(731, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Despues";
            // 
            // txtAntes
            // 
            this.txtAntes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAntes.Location = new System.Drawing.Point(437, 149);
            this.txtAntes.Name = "txtAntes";
            this.txtAntes.ReadOnly = true;
            this.txtAntes.Size = new System.Drawing.Size(288, 501);
            this.txtAntes.TabIndex = 32;
            this.txtAntes.Text = "";
            // 
            // txtDespues
            // 
            this.tlpPrincipal.SetColumnSpan(this.txtDespues, 2);
            this.txtDespues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDespues.Location = new System.Drawing.Point(731, 149);
            this.txtDespues.Name = "txtDespues";
            this.txtDespues.ReadOnly = true;
            this.txtDespues.Size = new System.Drawing.Size(288, 501);
            this.txtDespues.TabIndex = 33;
            this.txtDespues.Text = "";
            // 
            // btnRecarga
            // 
            this.btnRecarga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnRecarga.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRecarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecarga.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecarga.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRecarga.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            this.btnRecarga.IconColor = System.Drawing.Color.White;
            this.btnRecarga.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRecarga.IconSize = 34;
            this.btnRecarga.Location = new System.Drawing.Point(905, 74);
            this.btnRecarga.Margin = new System.Windows.Forms.Padding(0);
            this.btnRecarga.Name = "btnRecarga";
            this.btnRecarga.Size = new System.Drawing.Size(117, 36);
            this.btnRecarga.TabIndex = 27;
            this.btnRecarga.UseVisualStyleBackColor = false;
            this.btnRecarga.Click += new System.EventHandler(this.btnRecarga_Click);
            // 
            // vHistorialCambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.tlpPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "vHistorialCambios";
            this.Size = new System.Drawing.Size(836, 540);
            this.Load += new System.EventHandler(this.vHistorialCambios_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblGeneral;
        private System.Windows.Forms.Label lblColumn;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private FontAwesome.Sharp.IconButton btnRecarga;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHistorial_idHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHistorial_Tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHistorial_FechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHistorial_Movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHistorial_Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtAntes;
        private System.Windows.Forms.RichTextBox txtDespues;
        //private ScintillaNET.Scintilla txtAntes;
        //private ScintillaNET.Scintilla txtDespues;
    }
}
