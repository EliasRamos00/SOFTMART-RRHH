namespace SOFTMART_RRHH.Vista
{
    partial class vErrorLog
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
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.dgvErrorLog = new System.Windows.Forms.DataGridView();
            this.lblErrorLog = new System.Windows.Forms.Label();
            this.btnFolder = new FontAwesome.Sharp.IconButton();
            this.btnRecarga = new FontAwesome.Sharp.IconButton();
            this.txt = new System.Windows.Forms.RichTextBox();
            this.dgvErrorLog_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvError_Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorLog)).BeginInit();
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
            this.tlpPrincipal.Controls.Add(this.dgvErrorLog, 1, 4);
            this.tlpPrincipal.Controls.Add(this.lblErrorLog, 1, 1);
            this.tlpPrincipal.Controls.Add(this.btnFolder, 4, 1);
            this.tlpPrincipal.Controls.Add(this.btnRecarga, 4, 2);
            this.tlpPrincipal.Controls.Add(this.txt, 2, 4);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpPrincipal.ForeColor = System.Drawing.Color.Black;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 6;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.900565F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.900565F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.900565F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.29831F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1045, 676);
            this.tlpPrincipal.TabIndex = 1;
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
            // dgvErrorLog
            // 
            this.dgvErrorLog.AllowUserToAddRows = false;
            this.dgvErrorLog.AllowUserToDeleteRows = false;
            this.dgvErrorLog.AllowUserToOrderColumns = true;
            this.dgvErrorLog.AllowUserToResizeRows = false;
            this.dgvErrorLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrorLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvErrorLog_Nombre,
            this.dgvError_Path});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvErrorLog.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvErrorLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvErrorLog.GridColor = System.Drawing.Color.Black;
            this.dgvErrorLog.Location = new System.Drawing.Point(45, 149);
            this.dgvErrorLog.MultiSelect = false;
            this.dgvErrorLog.Name = "dgvErrorLog";
            this.dgvErrorLog.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvErrorLog.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvErrorLog.RowHeadersVisible = false;
            this.dgvErrorLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvErrorLog.Size = new System.Drawing.Size(386, 502);
            this.dgvErrorLog.TabIndex = 6;
            this.dgvErrorLog.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvErrorLog_CellEnter);
            // 
            // lblErrorLog
            // 
            this.lblErrorLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorLog.AutoSize = true;
            this.lblErrorLog.BackColor = System.Drawing.Color.GhostWhite;
            this.tlpPrincipal.SetColumnSpan(this.lblErrorLog, 2);
            this.lblErrorLog.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorLog.ForeColor = System.Drawing.Color.Black;
            this.lblErrorLog.Location = new System.Drawing.Point(47, 63);
            this.lblErrorLog.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblErrorLog.Name = "lblErrorLog";
            this.tlpPrincipal.SetRowSpan(this.lblErrorLog, 2);
            this.lblErrorLog.Size = new System.Drawing.Size(678, 47);
            this.lblErrorLog.TabIndex = 0;
            this.lblErrorLog.Text = "ERROR LOG";
            this.lblErrorLog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnFolder
            // 
            this.btnFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.btnFolder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolder.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFolder.IconChar = FontAwesome.Sharp.IconChar.FolderBlank;
            this.btnFolder.IconColor = System.Drawing.Color.White;
            this.btnFolder.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnFolder.IconSize = 28;
            this.btnFolder.Location = new System.Drawing.Point(905, 38);
            this.btnFolder.Margin = new System.Windows.Forms.Padding(0);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(117, 36);
            this.btnFolder.TabIndex = 28;
            this.btnFolder.UseVisualStyleBackColor = false;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
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
            // txt
            // 
            this.txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPrincipal.SetColumnSpan(this.txt, 3);
            this.txt.Location = new System.Drawing.Point(437, 149);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(582, 502);
            this.txt.TabIndex = 29;
            this.txt.Text = "";
            // 
            // dgvErrorLog_Nombre
            // 
            this.dgvErrorLog_Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvErrorLog_Nombre.DataPropertyName = "Nombre";
            this.dgvErrorLog_Nombre.HeaderText = "Nombre";
            this.dgvErrorLog_Nombre.Name = "dgvErrorLog_Nombre";
            this.dgvErrorLog_Nombre.ReadOnly = true;
            // 
            // dgvError_Path
            // 
            this.dgvError_Path.HeaderText = "Path";
            this.dgvError_Path.Name = "dgvError_Path";
            this.dgvError_Path.ReadOnly = true;
            this.dgvError_Path.Visible = false;
            // 
            // vErrorLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.tlpPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "vErrorLog";
            this.Size = new System.Drawing.Size(1045, 676);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.DataGridView dgvErrorLog;
        private FontAwesome.Sharp.IconButton btnFolder;
        private FontAwesome.Sharp.IconButton btnRecarga;
        private System.Windows.Forms.Label lblErrorLog;
        private System.Windows.Forms.RichTextBox txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvErrorLog_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvError_Path;
    }
}
