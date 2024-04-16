namespace SOFTMART_RRHH.Vista
{
    partial class vUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.dgvUsuarios_idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsuarios_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsuarios_idPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsuarios_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsuarios_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsuarios_hasChanged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsuarios_RolCB = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvUsuarios_Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnRecarga = new FontAwesome.Sharp.IconButton();
            this.tlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 6;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.03441F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.91345F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.06048F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.99166F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpPrincipal.Controls.Add(this.btnClose, 0, 0);
            this.tlpPrincipal.Controls.Add(this.lblTitulo, 1, 1);
            this.tlpPrincipal.Controls.Add(this.dgvUsuarios, 2, 4);
            this.tlpPrincipal.Controls.Add(this.tableLayoutPanel1, 4, 4);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 6;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.543946F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.140488F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.908372F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.4072F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1393, 832);
            this.tlpPrincipal.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::SOFTMART_RRHH.Properties.Resources.icoClose;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(4, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 39);
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
            this.tlpPrincipal.SetColumnSpan(this.lblTitulo, 4);
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(63, 78);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(7, 31, 0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.tlpPrincipal.SetRowSpan(this.lblTitulo, 2);
            this.lblTitulo.Size = new System.Drawing.Size(1255, 57);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "USUARIOS DEL SISTEMA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToOrderColumns = true;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvUsuarios_idUsuario,
            this.dgvUsuarios_Nombre,
            this.dgvUsuarios_idPersona,
            this.dgvUsuarios_Usuario,
            this.dgvUsuarios_password,
            this.dgvUsuarios_hasChanged,
            this.dgvUsuarios_RolCB,
            this.dgvUsuarios_Rol});
            this.tlpPrincipal.SetColumnSpan(this.dgvUsuarios, 2);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.GridColor = System.Drawing.Color.Black;
            this.dgvUsuarios.Location = new System.Drawing.Point(224, 183);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(939, 618);
            this.dgvUsuarios.TabIndex = 6;
            this.dgvUsuarios.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvUsuarios_CellBeginEdit);
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellDoubleClick);
            this.dgvUsuarios.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellEndEdit);
            this.dgvUsuarios.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvUsuarios_DataError);
            // 
            // dgvUsuarios_idUsuario
            // 
            this.dgvUsuarios_idUsuario.DataPropertyName = "idUsuario";
            this.dgvUsuarios_idUsuario.HeaderText = "idUsuario";
            this.dgvUsuarios_idUsuario.MinimumWidth = 6;
            this.dgvUsuarios_idUsuario.Name = "dgvUsuarios_idUsuario";
            this.dgvUsuarios_idUsuario.Visible = false;
            this.dgvUsuarios_idUsuario.Width = 125;
            // 
            // dgvUsuarios_Nombre
            // 
            this.dgvUsuarios_Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvUsuarios_Nombre.DataPropertyName = "Nombre";
            this.dgvUsuarios_Nombre.HeaderText = "Nombre";
            this.dgvUsuarios_Nombre.MinimumWidth = 6;
            this.dgvUsuarios_Nombre.Name = "dgvUsuarios_Nombre";
            // 
            // dgvUsuarios_idPersona
            // 
            this.dgvUsuarios_idPersona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvUsuarios_idPersona.DataPropertyName = "idPersona";
            this.dgvUsuarios_idPersona.HeaderText = "idPersona";
            this.dgvUsuarios_idPersona.MinimumWidth = 6;
            this.dgvUsuarios_idPersona.Name = "dgvUsuarios_idPersona";
            this.dgvUsuarios_idPersona.Visible = false;
            // 
            // dgvUsuarios_Usuario
            // 
            this.dgvUsuarios_Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvUsuarios_Usuario.DataPropertyName = "Usuario";
            this.dgvUsuarios_Usuario.HeaderText = "Usuario";
            this.dgvUsuarios_Usuario.MinimumWidth = 6;
            this.dgvUsuarios_Usuario.Name = "dgvUsuarios_Usuario";
            this.dgvUsuarios_Usuario.Width = 86;
            // 
            // dgvUsuarios_password
            // 
            this.dgvUsuarios_password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvUsuarios_password.DataPropertyName = "password";
            this.dgvUsuarios_password.HeaderText = "Contraseña";
            this.dgvUsuarios_password.MinimumWidth = 6;
            this.dgvUsuarios_password.Name = "dgvUsuarios_password";
            this.dgvUsuarios_password.Width = 108;
            // 
            // dgvUsuarios_hasChanged
            // 
            this.dgvUsuarios_hasChanged.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvUsuarios_hasChanged.DataPropertyName = "hasChanged";
            this.dgvUsuarios_hasChanged.HeaderText = "hasChanged";
            this.dgvUsuarios_hasChanged.MinimumWidth = 6;
            this.dgvUsuarios_hasChanged.Name = "dgvUsuarios_hasChanged";
            this.dgvUsuarios_hasChanged.Visible = false;
            this.dgvUsuarios_hasChanged.Width = 125;
            // 
            // dgvUsuarios_RolCB
            // 
            this.dgvUsuarios_RolCB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvUsuarios_RolCB.DataPropertyName = "Rol";
            this.dgvUsuarios_RolCB.HeaderText = "Rol";
            this.dgvUsuarios_RolCB.MinimumWidth = 6;
            this.dgvUsuarios_RolCB.Name = "dgvUsuarios_RolCB";
            this.dgvUsuarios_RolCB.Width = 36;
            // 
            // dgvUsuarios_Rol
            // 
            this.dgvUsuarios_Rol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvUsuarios_Rol.DataPropertyName = "Rol";
            this.dgvUsuarios_Rol.HeaderText = "Rol";
            this.dgvUsuarios_Rol.MinimumWidth = 6;
            this.dgvUsuarios_Rol.Name = "dgvUsuarios_Rol";
            this.dgvUsuarios_Rol.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.btnAgregar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnGuardar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnEliminar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnRecarga, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1171, 183);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(143, 202);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAgregar.IconColor = System.Drawing.Color.White;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 35;
            this.btnAgregar.Location = new System.Drawing.Point(0, 154);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(143, 44);
            this.btnAgregar.TabIndex = 32;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 30;
            this.btnGuardar.Location = new System.Drawing.Point(0, 53);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(143, 44);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 30;
            this.btnEliminar.Location = new System.Drawing.Point(0, 103);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(143, 44);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRecarga
            // 
            this.btnRecarga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnRecarga.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRecarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecarga.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecarga.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRecarga.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            this.btnRecarga.IconColor = System.Drawing.Color.White;
            this.btnRecarga.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRecarga.IconSize = 30;
            this.btnRecarga.Location = new System.Drawing.Point(0, 3);
            this.btnRecarga.Margin = new System.Windows.Forms.Padding(0);
            this.btnRecarga.Name = "btnRecarga";
            this.btnRecarga.Size = new System.Drawing.Size(143, 44);
            this.btnRecarga.TabIndex = 27;
            this.btnRecarga.UseVisualStyleBackColor = false;
            this.btnRecarga.Click += new System.EventHandler(this.btnRecarga_Click);
            // 
            // vUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.tlpPrincipal);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "vUsuarios";
            this.Size = new System.Drawing.Size(1393, 832);
            this.Load += new System.EventHandler(this.vUsuarios_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnRecarga;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUsuarios_idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUsuarios_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUsuarios_idPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUsuarios_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUsuarios_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUsuarios_hasChanged;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvUsuarios_RolCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUsuarios_Rol;
    }
}
