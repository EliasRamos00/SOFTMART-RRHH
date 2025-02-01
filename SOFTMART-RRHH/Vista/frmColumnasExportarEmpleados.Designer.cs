namespace SOFTMART_RRHH.Vista
{
    partial class frmColumnasExportarEmpleados
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
            this.cbApePat = new System.Windows.Forms.CheckBox();
            this.cbCodigoPostal = new System.Windows.Forms.CheckBox();
            this.cbNumContrato = new System.Windows.Forms.CheckBox();
            this.cbCURP = new System.Windows.Forms.CheckBox();
            this.cbGenero = new System.Windows.Forms.CheckBox();
            this.cbArea = new System.Windows.Forms.CheckBox();
            this.cbRFC = new System.Windows.Forms.CheckBox();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.cbEscolaridad = new System.Windows.Forms.CheckBox();
            this.cbEspecialidad = new System.Windows.Forms.CheckBox();
            this.cbCiudad = new System.Windows.Forms.CheckBox();
            this.cbSueldo = new System.Windows.Forms.CheckBox();
            this.cbDepto = new System.Windows.Forms.CheckBox();
            this.cbEdoCivil = new System.Windows.Forms.CheckBox();
            this.cbFechaNac = new System.Windows.Forms.CheckBox();
            this.cbTienda = new System.Windows.Forms.CheckBox();
            this.cbCalleNum = new System.Windows.Forms.CheckBox();
            this.cbApeMat = new System.Windows.Forms.CheckBox();
            this.cbNumSegSocial = new System.Windows.Forms.CheckBox();
            this.cbColonia = new System.Windows.Forms.CheckBox();
            this.cbInfoEmerg = new System.Windows.Forms.CheckBox();
            this.cbPuesto = new System.Windows.Forms.CheckBox();
            this.cbLugarNac = new System.Windows.Forms.CheckBox();
            this.cbTelefono = new System.Windows.Forms.CheckBox();
            this.cbFechaIngreso = new System.Windows.Forms.CheckBox();
            this.cbNombre = new System.Windows.Forms.CheckBox();
            this.cbAntiguedad = new System.Windows.Forms.CheckBox();
            this.gBLaboral = new System.Windows.Forms.GroupBox();
            this.tlpLaboral = new System.Windows.Forms.TableLayoutPanel();
            this.cbEmpleadoTemporada = new System.Windows.Forms.CheckBox();
            this.cbComentarios = new System.Windows.Forms.CheckBox();
            this.gBPersonal = new System.Windows.Forms.GroupBox();
            this.tlpPersonal = new System.Windows.Forms.TableLayoutPanel();
            this.cbNombreCompleto = new System.Windows.Forms.CheckBox();
            this.cbFoto = new System.Windows.Forms.CheckBox();
            this.cbINE = new System.Windows.Forms.CheckBox();
            this.cBDomiciliar = new System.Windows.Forms.GroupBox();
            this.tlpDomiciliar = new System.Windows.Forms.TableLayoutPanel();
            this.lblInstruct = new System.Windows.Forms.Label();
            this.btnExcel = new FontAwesome.Sharp.IconButton();
            this.listboxOrden = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.gBLaboral.SuspendLayout();
            this.tlpLaboral.SuspendLayout();
            this.gBPersonal.SuspendLayout();
            this.tlpPersonal.SuspendLayout();
            this.cBDomiciliar.SuspendLayout();
            this.tlpDomiciliar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbApePat
            // 
            this.cbApePat.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbApePat.AutoSize = true;
            this.cbApePat.Checked = true;
            this.cbApePat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbApePat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbApePat.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbApePat.Location = new System.Drawing.Point(3, 3);
            this.cbApePat.Name = "cbApePat";
            this.cbApePat.Size = new System.Drawing.Size(174, 35);
            this.cbApePat.TabIndex = 0;
            this.cbApePat.Text = "Apellido Paterno";
            this.cbApePat.UseVisualStyleBackColor = true;
            // 
            // cbCodigoPostal
            // 
            this.cbCodigoPostal.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbCodigoPostal.AutoSize = true;
            this.cbCodigoPostal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCodigoPostal.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodigoPostal.Location = new System.Drawing.Point(3, 40);
            this.cbCodigoPostal.Name = "cbCodigoPostal";
            this.cbCodigoPostal.Size = new System.Drawing.Size(173, 32);
            this.cbCodigoPostal.TabIndex = 3;
            this.cbCodigoPostal.Text = "Codigo Postal";
            this.cbCodigoPostal.UseVisualStyleBackColor = true;
            // 
            // cbNumContrato
            // 
            this.cbNumContrato.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbNumContrato.AutoSize = true;
            this.cbNumContrato.Checked = true;
            this.cbNumContrato.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNumContrato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbNumContrato.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNumContrato.Location = new System.Drawing.Point(3, 44);
            this.cbNumContrato.Name = "cbNumContrato";
            this.cbNumContrato.Size = new System.Drawing.Size(173, 35);
            this.cbNumContrato.TabIndex = 3;
            this.cbNumContrato.Text = "Num. de Contrato";
            this.cbNumContrato.UseVisualStyleBackColor = true;
            // 
            // cbCURP
            // 
            this.cbCURP.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbCURP.AutoSize = true;
            this.cbCURP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCURP.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCURP.Location = new System.Drawing.Point(3, 44);
            this.cbCURP.Name = "cbCURP";
            this.cbCURP.Size = new System.Drawing.Size(174, 35);
            this.cbCURP.TabIndex = 3;
            this.cbCURP.Text = "CURP";
            this.cbCURP.UseVisualStyleBackColor = true;
            // 
            // cbGenero
            // 
            this.cbGenero.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbGenero.AutoSize = true;
            this.cbGenero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbGenero.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenero.Location = new System.Drawing.Point(3, 85);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(174, 35);
            this.cbGenero.TabIndex = 6;
            this.cbGenero.Text = "Genero";
            this.cbGenero.UseVisualStyleBackColor = true;
            // 
            // cbArea
            // 
            this.cbArea.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbArea.AutoSize = true;
            this.cbArea.Checked = true;
            this.cbArea.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbArea.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArea.Location = new System.Drawing.Point(3, 85);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(173, 35);
            this.cbArea.TabIndex = 6;
            this.cbArea.Text = "Area";
            this.cbArea.UseVisualStyleBackColor = true;
            // 
            // cbRFC
            // 
            this.cbRFC.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbRFC.AutoSize = true;
            this.cbRFC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbRFC.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRFC.Location = new System.Drawing.Point(3, 126);
            this.cbRFC.Name = "cbRFC";
            this.cbRFC.Size = new System.Drawing.Size(173, 35);
            this.cbRFC.TabIndex = 9;
            this.cbRFC.Text = "RFC";
            this.cbRFC.UseVisualStyleBackColor = true;
            // 
            // cbEstado
            // 
            this.cbEstado.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbEstado.AutoSize = true;
            this.cbEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEstado.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.Location = new System.Drawing.Point(3, 3);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(173, 31);
            this.cbEstado.TabIndex = 0;
            this.cbEstado.Text = "Estado";
            this.cbEstado.UseVisualStyleBackColor = true;
            // 
            // cbEscolaridad
            // 
            this.cbEscolaridad.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbEscolaridad.AutoSize = true;
            this.cbEscolaridad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEscolaridad.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEscolaridad.Location = new System.Drawing.Point(3, 3);
            this.cbEscolaridad.Name = "cbEscolaridad";
            this.cbEscolaridad.Size = new System.Drawing.Size(173, 35);
            this.cbEscolaridad.TabIndex = 0;
            this.cbEscolaridad.Text = "Escolaridad";
            this.cbEscolaridad.UseVisualStyleBackColor = true;
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbEspecialidad.AutoSize = true;
            this.cbEspecialidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEspecialidad.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEspecialidad.Location = new System.Drawing.Point(182, 3);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(173, 35);
            this.cbEspecialidad.TabIndex = 1;
            this.cbEspecialidad.Text = "Especialidad";
            this.cbEspecialidad.UseVisualStyleBackColor = true;
            // 
            // cbCiudad
            // 
            this.cbCiudad.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbCiudad.AutoSize = true;
            this.cbCiudad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCiudad.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCiudad.Location = new System.Drawing.Point(182, 3);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(173, 31);
            this.cbCiudad.TabIndex = 1;
            this.cbCiudad.Text = "Ciudad";
            this.cbCiudad.UseVisualStyleBackColor = true;
            // 
            // cbSueldo
            // 
            this.cbSueldo.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbSueldo.AutoSize = true;
            this.cbSueldo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSueldo.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSueldo.Location = new System.Drawing.Point(182, 126);
            this.cbSueldo.Name = "cbSueldo";
            this.cbSueldo.Size = new System.Drawing.Size(173, 35);
            this.cbSueldo.TabIndex = 10;
            this.cbSueldo.Text = "Sueldo";
            this.cbSueldo.UseVisualStyleBackColor = true;
            // 
            // cbDepto
            // 
            this.cbDepto.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbDepto.AutoSize = true;
            this.cbDepto.Checked = true;
            this.cbDepto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDepto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDepto.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepto.Location = new System.Drawing.Point(182, 85);
            this.cbDepto.Name = "cbDepto";
            this.cbDepto.Size = new System.Drawing.Size(173, 35);
            this.cbDepto.TabIndex = 7;
            this.cbDepto.Text = "Departamento";
            this.cbDepto.UseVisualStyleBackColor = true;
            // 
            // cbEdoCivil
            // 
            this.cbEdoCivil.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbEdoCivil.AutoSize = true;
            this.cbEdoCivil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEdoCivil.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEdoCivil.Location = new System.Drawing.Point(183, 85);
            this.cbEdoCivil.Name = "cbEdoCivil";
            this.cbEdoCivil.Size = new System.Drawing.Size(174, 35);
            this.cbEdoCivil.TabIndex = 7;
            this.cbEdoCivil.Text = "Estado Civil";
            this.cbEdoCivil.UseVisualStyleBackColor = true;
            // 
            // cbFechaNac
            // 
            this.cbFechaNac.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbFechaNac.AutoSize = true;
            this.cbFechaNac.Checked = true;
            this.cbFechaNac.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFechaNac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbFechaNac.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFechaNac.Location = new System.Drawing.Point(183, 44);
            this.cbFechaNac.Name = "cbFechaNac";
            this.cbFechaNac.Size = new System.Drawing.Size(174, 35);
            this.cbFechaNac.TabIndex = 4;
            this.cbFechaNac.Text = "Fecha de Nac.";
            this.cbFechaNac.UseVisualStyleBackColor = true;
            // 
            // cbTienda
            // 
            this.cbTienda.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbTienda.AutoSize = true;
            this.cbTienda.Checked = true;
            this.cbTienda.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTienda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTienda.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTienda.Location = new System.Drawing.Point(182, 44);
            this.cbTienda.Name = "cbTienda";
            this.cbTienda.Size = new System.Drawing.Size(173, 35);
            this.cbTienda.TabIndex = 4;
            this.cbTienda.Text = "Sucursal";
            this.cbTienda.UseVisualStyleBackColor = true;
            // 
            // cbCalleNum
            // 
            this.cbCalleNum.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbCalleNum.AutoSize = true;
            this.cbCalleNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCalleNum.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCalleNum.Location = new System.Drawing.Point(182, 40);
            this.cbCalleNum.Name = "cbCalleNum";
            this.cbCalleNum.Size = new System.Drawing.Size(173, 32);
            this.cbCalleNum.TabIndex = 4;
            this.cbCalleNum.Text = "Calle y Numero";
            this.cbCalleNum.UseVisualStyleBackColor = true;
            // 
            // cbApeMat
            // 
            this.cbApeMat.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbApeMat.AutoSize = true;
            this.cbApeMat.Checked = true;
            this.cbApeMat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbApeMat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbApeMat.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbApeMat.Location = new System.Drawing.Point(183, 3);
            this.cbApeMat.Name = "cbApeMat";
            this.cbApeMat.Size = new System.Drawing.Size(174, 35);
            this.cbApeMat.TabIndex = 1;
            this.cbApeMat.Text = "Apellido Materno";
            this.cbApeMat.UseVisualStyleBackColor = true;
            // 
            // cbNumSegSocial
            // 
            this.cbNumSegSocial.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbNumSegSocial.AutoSize = true;
            this.cbNumSegSocial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbNumSegSocial.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNumSegSocial.Location = new System.Drawing.Point(361, 3);
            this.cbNumSegSocial.Name = "cbNumSegSocial";
            this.cbNumSegSocial.Size = new System.Drawing.Size(175, 35);
            this.cbNumSegSocial.TabIndex = 2;
            this.cbNumSegSocial.Text = "Num. de Seg. Social";
            this.cbNumSegSocial.UseVisualStyleBackColor = true;
            // 
            // cbColonia
            // 
            this.cbColonia.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbColonia.AutoSize = true;
            this.cbColonia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbColonia.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbColonia.Location = new System.Drawing.Point(361, 3);
            this.cbColonia.Name = "cbColonia";
            this.cbColonia.Size = new System.Drawing.Size(175, 31);
            this.cbColonia.TabIndex = 2;
            this.cbColonia.Text = "Colonia";
            this.cbColonia.UseVisualStyleBackColor = true;
            // 
            // cbInfoEmerg
            // 
            this.cbInfoEmerg.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbInfoEmerg.AutoSize = true;
            this.cbInfoEmerg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbInfoEmerg.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInfoEmerg.Location = new System.Drawing.Point(361, 126);
            this.cbInfoEmerg.Name = "cbInfoEmerg";
            this.cbInfoEmerg.Size = new System.Drawing.Size(175, 35);
            this.cbInfoEmerg.TabIndex = 11;
            this.cbInfoEmerg.Text = "Info. Emerg.";
            this.cbInfoEmerg.UseVisualStyleBackColor = true;
            // 
            // cbPuesto
            // 
            this.cbPuesto.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbPuesto.AutoSize = true;
            this.cbPuesto.Checked = true;
            this.cbPuesto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPuesto.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPuesto.Location = new System.Drawing.Point(361, 85);
            this.cbPuesto.Name = "cbPuesto";
            this.cbPuesto.Size = new System.Drawing.Size(175, 35);
            this.cbPuesto.TabIndex = 8;
            this.cbPuesto.Text = "Puesto";
            this.cbPuesto.UseVisualStyleBackColor = true;
            // 
            // cbLugarNac
            // 
            this.cbLugarNac.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbLugarNac.AutoSize = true;
            this.cbLugarNac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbLugarNac.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLugarNac.Location = new System.Drawing.Point(363, 85);
            this.cbLugarNac.Name = "cbLugarNac";
            this.cbLugarNac.Size = new System.Drawing.Size(176, 35);
            this.cbLugarNac.TabIndex = 8;
            this.cbLugarNac.Text = "Lugar de Nac.";
            this.cbLugarNac.UseVisualStyleBackColor = true;
            // 
            // cbTelefono
            // 
            this.cbTelefono.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbTelefono.AutoSize = true;
            this.cbTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTelefono.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTelefono.Location = new System.Drawing.Point(363, 44);
            this.cbTelefono.Name = "cbTelefono";
            this.cbTelefono.Size = new System.Drawing.Size(176, 35);
            this.cbTelefono.TabIndex = 5;
            this.cbTelefono.Text = "Telefono";
            this.cbTelefono.UseVisualStyleBackColor = true;
            // 
            // cbFechaIngreso
            // 
            this.cbFechaIngreso.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbFechaIngreso.AutoSize = true;
            this.cbFechaIngreso.Checked = true;
            this.cbFechaIngreso.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFechaIngreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFechaIngreso.Location = new System.Drawing.Point(361, 44);
            this.cbFechaIngreso.Name = "cbFechaIngreso";
            this.cbFechaIngreso.Size = new System.Drawing.Size(175, 35);
            this.cbFechaIngreso.TabIndex = 5;
            this.cbFechaIngreso.Text = "Fecha Ingreso";
            this.cbFechaIngreso.UseVisualStyleBackColor = true;
            // 
            // cbNombre
            // 
            this.cbNombre.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbNombre.AutoSize = true;
            this.cbNombre.Checked = true;
            this.cbNombre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbNombre.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNombre.Location = new System.Drawing.Point(363, 3);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(176, 35);
            this.cbNombre.TabIndex = 2;
            this.cbNombre.Text = "Nombre (s)";
            this.cbNombre.UseVisualStyleBackColor = true;
            // 
            // cbAntiguedad
            // 
            this.cbAntiguedad.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbAntiguedad.AutoSize = true;
            this.cbAntiguedad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbAntiguedad.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAntiguedad.Location = new System.Drawing.Point(182, 167);
            this.cbAntiguedad.Name = "cbAntiguedad";
            this.cbAntiguedad.Size = new System.Drawing.Size(173, 36);
            this.cbAntiguedad.TabIndex = 13;
            this.cbAntiguedad.Text = "Antiguedad";
            this.cbAntiguedad.UseVisualStyleBackColor = true;
            // 
            // gBLaboral
            // 
            this.gBLaboral.Controls.Add(this.tlpLaboral);
            this.gBLaboral.Location = new System.Drawing.Point(34, 351);
            this.gBLaboral.Name = "gBLaboral";
            this.gBLaboral.Size = new System.Drawing.Size(545, 225);
            this.gBLaboral.TabIndex = 3;
            this.gBLaboral.TabStop = false;
            this.gBLaboral.Text = "Info. Laboral";
            // 
            // tlpLaboral
            // 
            this.tlpLaboral.ColumnCount = 3;
            this.tlpLaboral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpLaboral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpLaboral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpLaboral.Controls.Add(this.cbEmpleadoTemporada, 3, 4);
            this.tlpLaboral.Controls.Add(this.cbComentarios, 0, 4);
            this.tlpLaboral.Controls.Add(this.cbEscolaridad, 0, 0);
            this.tlpLaboral.Controls.Add(this.cbEspecialidad, 1, 0);
            this.tlpLaboral.Controls.Add(this.cbNumSegSocial, 2, 0);
            this.tlpLaboral.Controls.Add(this.cbAntiguedad, 0, 4);
            this.tlpLaboral.Controls.Add(this.cbNumContrato, 0, 1);
            this.tlpLaboral.Controls.Add(this.cbInfoEmerg, 2, 3);
            this.tlpLaboral.Controls.Add(this.cbTienda, 1, 1);
            this.tlpLaboral.Controls.Add(this.cbSueldo, 1, 3);
            this.tlpLaboral.Controls.Add(this.cbPuesto, 2, 2);
            this.tlpLaboral.Controls.Add(this.cbRFC, 0, 3);
            this.tlpLaboral.Controls.Add(this.cbFechaIngreso, 2, 1);
            this.tlpLaboral.Controls.Add(this.cbArea, 0, 2);
            this.tlpLaboral.Controls.Add(this.cbDepto, 1, 2);
            this.tlpLaboral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLaboral.Location = new System.Drawing.Point(3, 16);
            this.tlpLaboral.Name = "tlpLaboral";
            this.tlpLaboral.RowCount = 5;
            this.tlpLaboral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0008F));
            this.tlpLaboral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0008F));
            this.tlpLaboral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0008F));
            this.tlpLaboral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9988F));
            this.tlpLaboral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9988F));
            this.tlpLaboral.Size = new System.Drawing.Size(539, 206);
            this.tlpLaboral.TabIndex = 0;
            // 
            // cbEmpleadoTemporada
            // 
            this.cbEmpleadoTemporada.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbEmpleadoTemporada.AutoSize = true;
            this.cbEmpleadoTemporada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEmpleadoTemporada.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpleadoTemporada.Location = new System.Drawing.Point(361, 167);
            this.cbEmpleadoTemporada.Name = "cbEmpleadoTemporada";
            this.cbEmpleadoTemporada.Size = new System.Drawing.Size(175, 36);
            this.cbEmpleadoTemporada.TabIndex = 14;
            this.cbEmpleadoTemporada.Text = "Es de temporada";
            this.cbEmpleadoTemporada.UseVisualStyleBackColor = true;
            // 
            // cbComentarios
            // 
            this.cbComentarios.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbComentarios.AutoSize = true;
            this.cbComentarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbComentarios.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbComentarios.Location = new System.Drawing.Point(3, 167);
            this.cbComentarios.Name = "cbComentarios";
            this.cbComentarios.Size = new System.Drawing.Size(173, 36);
            this.cbComentarios.TabIndex = 12;
            this.cbComentarios.Text = "Comentarios";
            this.cbComentarios.UseVisualStyleBackColor = true;
            // 
            // gBPersonal
            // 
            this.gBPersonal.Controls.Add(this.tlpPersonal);
            this.gBPersonal.Location = new System.Drawing.Point(28, 46);
            this.gBPersonal.Name = "gBPersonal";
            this.gBPersonal.Size = new System.Drawing.Size(548, 184);
            this.gBPersonal.TabIndex = 1;
            this.gBPersonal.TabStop = false;
            this.gBPersonal.Text = "Info. Personal";
            // 
            // tlpPersonal
            // 
            this.tlpPersonal.ColumnCount = 3;
            this.tlpPersonal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPersonal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPersonal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPersonal.Controls.Add(this.cbNombreCompleto, 0, 3);
            this.tlpPersonal.Controls.Add(this.cbFoto, 0, 3);
            this.tlpPersonal.Controls.Add(this.cbINE, 0, 3);
            this.tlpPersonal.Controls.Add(this.cbApePat, 0, 0);
            this.tlpPersonal.Controls.Add(this.cbApeMat, 1, 0);
            this.tlpPersonal.Controls.Add(this.cbNombre, 2, 0);
            this.tlpPersonal.Controls.Add(this.cbCURP, 0, 1);
            this.tlpPersonal.Controls.Add(this.cbFechaNac, 1, 1);
            this.tlpPersonal.Controls.Add(this.cbTelefono, 2, 1);
            this.tlpPersonal.Controls.Add(this.cbGenero, 0, 2);
            this.tlpPersonal.Controls.Add(this.cbEdoCivil, 1, 2);
            this.tlpPersonal.Controls.Add(this.cbLugarNac, 2, 2);
            this.tlpPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPersonal.Location = new System.Drawing.Point(3, 16);
            this.tlpPersonal.Name = "tlpPersonal";
            this.tlpPersonal.RowCount = 4;
            this.tlpPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tlpPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tlpPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tlpPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tlpPersonal.Size = new System.Drawing.Size(542, 165);
            this.tlpPersonal.TabIndex = 0;
            // 
            // cbNombreCompleto
            // 
            this.cbNombreCompleto.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbNombreCompleto.AutoSize = true;
            this.cbNombreCompleto.Checked = true;
            this.cbNombreCompleto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNombreCompleto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbNombreCompleto.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNombreCompleto.Location = new System.Drawing.Point(3, 126);
            this.cbNombreCompleto.Name = "cbNombreCompleto";
            this.cbNombreCompleto.Size = new System.Drawing.Size(174, 36);
            this.cbNombreCompleto.TabIndex = 9;
            this.cbNombreCompleto.Text = "Nombre Completo";
            this.cbNombreCompleto.UseVisualStyleBackColor = true;
            // 
            // cbFoto
            // 
            this.cbFoto.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbFoto.AutoSize = true;
            this.cbFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbFoto.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFoto.Location = new System.Drawing.Point(183, 126);
            this.cbFoto.Name = "cbFoto";
            this.cbFoto.Size = new System.Drawing.Size(174, 36);
            this.cbFoto.TabIndex = 10;
            this.cbFoto.Text = "tiene Foto";
            this.cbFoto.UseVisualStyleBackColor = true;
            // 
            // cbINE
            // 
            this.cbINE.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbINE.AutoSize = true;
            this.cbINE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbINE.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbINE.Location = new System.Drawing.Point(363, 126);
            this.cbINE.Name = "cbINE";
            this.cbINE.Size = new System.Drawing.Size(176, 36);
            this.cbINE.TabIndex = 11;
            this.cbINE.Text = "tiene INE";
            this.cbINE.UseVisualStyleBackColor = true;
            // 
            // cBDomiciliar
            // 
            this.cBDomiciliar.Controls.Add(this.tlpDomiciliar);
            this.cBDomiciliar.Location = new System.Drawing.Point(31, 251);
            this.cBDomiciliar.Name = "cBDomiciliar";
            this.cBDomiciliar.Size = new System.Drawing.Size(545, 94);
            this.cBDomiciliar.TabIndex = 2;
            this.cBDomiciliar.TabStop = false;
            this.cBDomiciliar.Text = "Info. Domiciliar";
            // 
            // tlpDomiciliar
            // 
            this.tlpDomiciliar.ColumnCount = 3;
            this.tlpDomiciliar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDomiciliar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDomiciliar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDomiciliar.Controls.Add(this.cbEstado, 0, 0);
            this.tlpDomiciliar.Controls.Add(this.cbCiudad, 1, 0);
            this.tlpDomiciliar.Controls.Add(this.cbColonia, 2, 0);
            this.tlpDomiciliar.Controls.Add(this.cbCodigoPostal, 0, 1);
            this.tlpDomiciliar.Controls.Add(this.cbCalleNum, 1, 1);
            this.tlpDomiciliar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDomiciliar.Location = new System.Drawing.Point(3, 16);
            this.tlpDomiciliar.Name = "tlpDomiciliar";
            this.tlpDomiciliar.RowCount = 2;
            this.tlpDomiciliar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDomiciliar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDomiciliar.Size = new System.Drawing.Size(539, 75);
            this.tlpDomiciliar.TabIndex = 0;
            // 
            // lblInstruct
            // 
            this.lblInstruct.AutoSize = true;
            this.lblInstruct.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruct.Location = new System.Drawing.Point(28, 19);
            this.lblInstruct.Name = "lblInstruct";
            this.lblInstruct.Size = new System.Drawing.Size(258, 15);
            this.lblInstruct.TabIndex = 0;
            this.lblInstruct.Text = "Selecciona la información que desees exportar.";
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(82)))), ((int)(((byte)(97)))));
            this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExcel.IconColor = System.Drawing.Color.White;
            this.btnExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExcel.IconSize = 38;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(188, 613);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(201, 47);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.Text = "Exportar";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // listboxOrden
            // 
            this.listboxOrden.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxOrden.FormattingEnabled = true;
            this.listboxOrden.ItemHeight = 21;
            this.listboxOrden.Location = new System.Drawing.Point(6, 19);
            this.listboxOrden.Name = "listboxOrden";
            this.listboxOrden.Size = new System.Drawing.Size(253, 487);
            this.listboxOrden.TabIndex = 5;
            this.listboxOrden.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListBoxColumnas_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listboxOrden);
            this.groupBox1.Location = new System.Drawing.Point(615, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 530);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orden de las columnas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(612, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selecciona y mueve con las flechas el orden de las columnas.";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(877, 103);
            this.btnDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(53, 34);
            this.btnDown.TabIndex = 8;
            this.btnDown.Text = "▼";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(877, 65);
            this.btnUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(53, 34);
            this.btnUp.TabIndex = 9;
            this.btnUp.Text = "▲";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // frmColumnasExportarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 672);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.lblInstruct);
            this.Controls.Add(this.cBDomiciliar);
            this.Controls.Add(this.gBPersonal);
            this.Controls.Add(this.gBLaboral);
            this.Name = "frmColumnasExportarEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportación a Excel";
            this.gBLaboral.ResumeLayout(false);
            this.tlpLaboral.ResumeLayout(false);
            this.tlpLaboral.PerformLayout();
            this.gBPersonal.ResumeLayout(false);
            this.tlpPersonal.ResumeLayout(false);
            this.tlpPersonal.PerformLayout();
            this.cBDomiciliar.ResumeLayout(false);
            this.tlpDomiciliar.ResumeLayout(false);
            this.tlpDomiciliar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbApePat;
        private System.Windows.Forms.CheckBox cbCodigoPostal;
        private System.Windows.Forms.CheckBox cbNumContrato;
        private System.Windows.Forms.CheckBox cbCURP;
        private System.Windows.Forms.CheckBox cbGenero;
        private System.Windows.Forms.CheckBox cbArea;
        private System.Windows.Forms.CheckBox cbRFC;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.CheckBox cbEscolaridad;
        private System.Windows.Forms.CheckBox cbEspecialidad;
        private System.Windows.Forms.CheckBox cbCiudad;
        private System.Windows.Forms.CheckBox cbSueldo;
        private System.Windows.Forms.CheckBox cbDepto;
        private System.Windows.Forms.CheckBox cbEdoCivil;
        private System.Windows.Forms.CheckBox cbFechaNac;
        private System.Windows.Forms.CheckBox cbTienda;
        private System.Windows.Forms.CheckBox cbCalleNum;
        private System.Windows.Forms.CheckBox cbApeMat;
        private System.Windows.Forms.CheckBox cbNumSegSocial;
        private System.Windows.Forms.CheckBox cbColonia;
        private System.Windows.Forms.CheckBox cbInfoEmerg;
        private System.Windows.Forms.CheckBox cbPuesto;
        private System.Windows.Forms.CheckBox cbLugarNac;
        private System.Windows.Forms.CheckBox cbTelefono;
        private System.Windows.Forms.CheckBox cbFechaIngreso;
        private System.Windows.Forms.CheckBox cbNombre;
        private System.Windows.Forms.CheckBox cbAntiguedad;
        private System.Windows.Forms.GroupBox gBLaboral;
        private System.Windows.Forms.TableLayoutPanel tlpLaboral;
        private System.Windows.Forms.GroupBox gBPersonal;
        private System.Windows.Forms.TableLayoutPanel tlpPersonal;
        private System.Windows.Forms.GroupBox cBDomiciliar;
        private System.Windows.Forms.TableLayoutPanel tlpDomiciliar;
        private System.Windows.Forms.Label lblInstruct;
        private FontAwesome.Sharp.IconButton btnExcel;
        private System.Windows.Forms.CheckBox cbComentarios;
        private System.Windows.Forms.CheckBox cbEmpleadoTemporada;
        private System.Windows.Forms.CheckBox cbNombreCompleto;
        private System.Windows.Forms.CheckBox cbFoto;
        private System.Windows.Forms.CheckBox cbINE;
        private System.Windows.Forms.ListBox listboxOrden;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
    }
}