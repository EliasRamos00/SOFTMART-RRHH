using System.Drawing;
using System.Windows.Forms;

namespace SOFTMART_RRHH
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pTitleBar = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.pSideBar = new System.Windows.Forms.Panel();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnMin = new FontAwesome.Sharp.IconButton();
            this.btnMax = new FontAwesome.Sharp.IconButton();
            this.btnErrorLog = new FontAwesome.Sharp.IconButton();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnHistorial = new FontAwesome.Sharp.IconButton();
            this.btnTodos = new FontAwesome.Sharp.IconButton();
            this.btnBajas = new FontAwesome.Sharp.IconButton();
            this.btnConsulta = new FontAwesome.Sharp.IconButton();
            this.btnAltasEmpleados = new FontAwesome.Sharp.IconButton();
            this.pTitleBar.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            this.pSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitleBar
            // 
            this.pTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pTitleBar.Controls.Add(this.lblInfo);
            this.pTitleBar.Controls.Add(this.btnMenu);
            this.pTitleBar.Controls.Add(this.tlpBotones);
            this.pTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitleBar.Location = new System.Drawing.Point(235, 0);
            this.pTitleBar.Name = "pTitleBar";
            this.pTitleBar.Size = new System.Drawing.Size(1045, 32);
            this.pTitleBar.TabIndex = 2;
            this.pTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pTitleBar_MouseDown);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Snow;
            this.lblInfo.Location = new System.Drawing.Point(483, 3);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(111, 15);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "TXT_INFORMACION";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpBotones
            // 
            this.tlpBotones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBotones.ColumnCount = 3;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.Controls.Add(this.btnClose, 2, 0);
            this.tlpBotones.Controls.Add(this.btnMin, 0, 0);
            this.tlpBotones.Controls.Add(this.btnMax, 1, 0);
            this.tlpBotones.Location = new System.Drawing.Point(871, 3);
            this.tlpBotones.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpBotones.Size = new System.Drawing.Size(171, 26);
            this.tlpBotones.TabIndex = 0;
            // 
            // pSideBar
            // 
            this.pSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.pSideBar.Controls.Add(this.btnErrorLog);
            this.pSideBar.Controls.Add(this.btnReset);
            this.pSideBar.Controls.Add(this.btnUsuarios);
            this.pSideBar.Controls.Add(this.btnHistorial);
            this.pSideBar.Controls.Add(this.lblInfo2);
            this.pSideBar.Controls.Add(this.btnTodos);
            this.pSideBar.Controls.Add(this.btnBajas);
            this.pSideBar.Controls.Add(this.btnConsulta);
            this.pSideBar.Controls.Add(this.btnAltasEmpleados);
            this.pSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSideBar.Location = new System.Drawing.Point(0, 0);
            this.pSideBar.Name = "pSideBar";
            this.pSideBar.Size = new System.Drawing.Size(235, 720);
            this.pSideBar.TabIndex = 1;
            // 
            // lblInfo2
            // 
            this.lblInfo2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo2.ForeColor = System.Drawing.Color.Snow;
            this.lblInfo2.Location = new System.Drawing.Point(56, 705);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(111, 15);
            this.lblInfo2.TabIndex = 5;
            this.lblInfo2.Text = "TXT_INFORMACION";
            this.lblInfo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pPrincipal
            // 
            this.pPrincipal.BackColor = System.Drawing.Color.GhostWhite;
            this.pPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pPrincipal.Location = new System.Drawing.Point(235, 32);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(1045, 688);
            this.pPrincipal.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 28;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(42, 38);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 28;
            this.btnClose.Location = new System.Drawing.Point(114, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMin.IconColor = System.Drawing.Color.White;
            this.btnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMin.IconSize = 28;
            this.btnMin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMin.Location = new System.Drawing.Point(0, 0);
            this.btnMin.Margin = new System.Windows.Forms.Padding(0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(57, 26);
            this.btnMin.TabIndex = 0;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMax.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnMax.IconColor = System.Drawing.Color.White;
            this.btnMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMax.IconSize = 28;
            this.btnMax.Location = new System.Drawing.Point(57, 0);
            this.btnMax.Margin = new System.Windows.Forms.Padding(0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(57, 32);
            this.btnMax.TabIndex = 1;
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnErrorLog
            // 
            this.btnErrorLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnErrorLog.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnErrorLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErrorLog.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErrorLog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnErrorLog.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft;
            this.btnErrorLog.IconColor = System.Drawing.Color.White;
            this.btnErrorLog.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnErrorLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnErrorLog.Location = new System.Drawing.Point(0, 578);
            this.btnErrorLog.Name = "btnErrorLog";
            this.btnErrorLog.Size = new System.Drawing.Size(235, 39);
            this.btnErrorLog.TabIndex = 7;
            this.btnErrorLog.Text = "Error Log";
            this.btnErrorLog.UseVisualStyleBackColor = false;
            this.btnErrorLog.Click += new System.EventHandler(this.btnErrorLog_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.IconChar = FontAwesome.Sharp.IconChar.Dungeon;
            this.btnReset.IconColor = System.Drawing.Color.White;
            this.btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReset.IconSize = 44;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(0, 635);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(235, 39);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Cerrar sesión";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.ShieldAlt;
            this.btnUsuarios.IconColor = System.Drawing.Color.White;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 488);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(235, 39);
            this.btnUsuarios.TabIndex = 7;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnHistorial.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHistorial.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft;
            this.btnHistorial.IconColor = System.Drawing.Color.White;
            this.btnHistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.Location = new System.Drawing.Point(0, 533);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(235, 39);
            this.btnHistorial.TabIndex = 6;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnTodos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodos.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTodos.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnTodos.IconColor = System.Drawing.Color.White;
            this.btnTodos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodos.Location = new System.Drawing.Point(0, 241);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(235, 39);
            this.btnTodos.TabIndex = 4;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = false;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnBajas
            // 
            this.btnBajas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnBajas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBajas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajas.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBajas.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnBajas.IconColor = System.Drawing.Color.White;
            this.btnBajas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBajas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBajas.Location = new System.Drawing.Point(0, 196);
            this.btnBajas.Name = "btnBajas";
            this.btnBajas.Size = new System.Drawing.Size(235, 39);
            this.btnBajas.TabIndex = 3;
            this.btnBajas.Text = "Bajas";
            this.btnBajas.UseVisualStyleBackColor = false;
            this.btnBajas.Click += new System.EventHandler(this.btnBajas_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnConsulta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsulta.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.btnConsulta.IconColor = System.Drawing.Color.White;
            this.btnConsulta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.Location = new System.Drawing.Point(0, 151);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(235, 39);
            this.btnConsulta.TabIndex = 1;
            this.btnConsulta.Text = "Activos";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnAltasEmpleados
            // 
            this.btnAltasEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(82)))), ((int)(((byte)(97)))));
            this.btnAltasEmpleados.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAltasEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltasEmpleados.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltasEmpleados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAltasEmpleados.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAltasEmpleados.IconColor = System.Drawing.Color.White;
            this.btnAltasEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAltasEmpleados.IconSize = 52;
            this.btnAltasEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltasEmpleados.Location = new System.Drawing.Point(0, 75);
            this.btnAltasEmpleados.Name = "btnAltasEmpleados";
            this.btnAltasEmpleados.Size = new System.Drawing.Size(235, 44);
            this.btnAltasEmpleados.TabIndex = 2;
            this.btnAltasEmpleados.Text = "Alta";
            this.btnAltasEmpleados.UseVisualStyleBackColor = false;
            this.btnAltasEmpleados.Click += new System.EventHandler(this.btnAltasEmpleados_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.pPrincipal);
            this.Controls.Add(this.pTitleBar);
            this.Controls.Add(this.pSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "z";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pTitleBar.ResumeLayout(false);
            this.pTitleBar.PerformLayout();
            this.tlpBotones.ResumeLayout(false);
            this.pSideBar.ResumeLayout(false);
            this.pSideBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pSideBar;
        private Panel pTitleBar;
        private Panel pPrincipal;
        private TableLayoutPanel tlpBotones;
        private FontAwesome.Sharp.IconButton btnMax;
        private FontAwesome.Sharp.IconButton btnMin;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnAltasEmpleados;
        private FontAwesome.Sharp.IconButton btnBajas;
        private FontAwesome.Sharp.IconButton btnConsulta;
        private FontAwesome.Sharp.IconButton btnTodos;
        private Label lblInfo;
        private Label lblInfo2;
        private FontAwesome.Sharp.IconButton btnHistorial;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnReset;
        private FontAwesome.Sharp.IconButton btnErrorLog;
    }
}
