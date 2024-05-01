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
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.tabPrincipal.SuspendLayout();
            this.tabPuestos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabPuestos);
            this.tabPrincipal.Controls.Add(this.tabUsuarios);
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
            // tabUsuarios
            // 
            this.tabUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Size = new System.Drawing.Size(1037, 650);
            this.tabUsuarios.TabIndex = 1;
            this.tabUsuarios.Text = "Usuarios";
            this.tabUsuarios.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.TabPage tabUsuarios;
    }
}
