using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SOFTMART_RRHH.Vista;
using SOFTMART_RRHH.Modelo;
using System.Windows.Controls;
using System.Diagnostics;
using System.Reflection;


namespace SOFTMART_RRHH
{
    public partial class frmPrincipal : Form
    {
        #region VARIABLES GLOBALES        
        vConsulta vConsulta = new vConsulta();
        vAjustes vAjustes = new vAjustes();
        vPersonal vAltaPersonal = new vPersonal(LibAux.CRUD.INSERT);
        vBajas vBajas = new vBajas();
        vTodos vTodos = new vTodos();
        vHistorialCambios vCambios = new vHistorialCambios();
        vUsuarios vUsuarios = new vUsuarios();
        vErrorLog vErrorLog = new vErrorLog();

        #endregion
        #region CONSTRUCTORES
        public frmPrincipal()
        {
            InitializeComponent();
            SetToolTips();

            AdjuntarUC_frmPrincipal(vAltaPersonal);
            AdjuntarUC_frmPrincipal(vBajas);
            AdjuntarUC_frmPrincipal(vCambios);
            AdjuntarUC_frmPrincipal(vConsulta);
            AdjuntarUC_frmPrincipal(vTodos);
            AdjuntarUC_frmPrincipal(vUsuarios);
            AdjuntarUC_frmPrincipal(vErrorLog);
            AdjuntarUC_frmPrincipal(vAjustes);

            //Eventos de los U.C.
            vConsulta.DobleClickEmpleado += MostrarEmpleado;
            vTodos.DobleClickEmpleado += MostrarEmpleado;
            vBajas.DobleClickBaja += MostrarBaja;

        }
        private void EsAdmin(bool @bool)
        {
            btnUsuarios.Visible = @bool;
            btnHistorial.Visible = @bool;
            btnErrorLog.Visible = @bool;
        }
        private void SetToolTips()
        {
            new System.Windows.Forms.ToolTip().SetToolTip(this.btnMenu, "Menu");
            new System.Windows.Forms.ToolTip().SetToolTip(this.btnClose, "Cerrar");
            new System.Windows.Forms.ToolTip().SetToolTip(this.btnMax, "Maximizar");
            new System.Windows.Forms.ToolTip().SetToolTip(this.btnMin, "Minimizar");

            new System.Windows.Forms.ToolTip().SetToolTip(this.btnAltasEmpleados, "Alta");
            new System.Windows.Forms.ToolTip().SetToolTip(this.btnConsulta, "Activos");
            new System.Windows.Forms.ToolTip().SetToolTip(this.btnBajas, "Bajas");
            new System.Windows.Forms.ToolTip().SetToolTip(this.btnTodos, "Todos");

            new System.Windows.Forms.ToolTip().SetToolTip(this.btnUsuarios, "Usuarios");
            new System.Windows.Forms.ToolTip().SetToolTip(this.btnErrorLog, "ErrorLog");
            new System.Windows.Forms.ToolTip().SetToolTip(this.btnHistorial, "Historial");
            new System.Windows.Forms.ToolTip().SetToolTip(this.btnReset, "Cerrar sesión");

        }
        private void AdjuntarUC_frmPrincipal(System.Windows.Forms.UserControl UserControl)
        {
            pPrincipal.Controls.Add(UserControl);
            UserControl.Dock = DockStyle.Fill;
            UserControl.Visible = false;
        }
        private void MostrarUC(System.Windows.Forms.UserControl UserControl)
        {
            UserControl.BringToFront();
            UserControl.Visible = true;
        }
        #endregion
        #region MÉTODOS
        /// <summary>
        /// Evento que salta cuando se hace doble click en el grid de consulta para abrir el perfil del empleado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MostrarEmpleado(object sender, EventArgs e)
        {
            int idEmpleado = 0, idPersona = 0, vTodos = 0;
            if (sender.ToString().Contains("vTodos"))
            {
                idEmpleado = ((vTodos)sender).idEmpleado;
                idPersona = ((vTodos)sender).idPersona;
                vTodos = 1;

            }
            else if (sender.ToString().Contains("vConsulta"))
            {
                idEmpleado = ((vConsulta)sender).idEmpleado;
                idPersona = ((vConsulta)sender).idPersona;
            }
            vPersonal perfil = new vPersonal(LibAux.CRUD.SELECT, idEmpleado, idPersona, vTodos);
            perfil.BtnEliminar += MostrarVentanaElim;
            perfil.BtnHistorial += MostarVentanaHistorial;

            pPrincipal.Controls.Add(perfil);
            perfil.Dock = DockStyle.Fill;
            perfil.BringToFront();
        }
        /// <summary>
        ///  evento btnEliminar de vPersonal que muestra el perfil para eliminación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MostrarVentanaElim(object sender, EventArgs e)
        {
            int idEmpleado = ((vPersonal)sender).idEmpleado;
            vBajasEmpleadoPerfil vBajasEmpleadoPerfil = new vBajasEmpleadoPerfil(idEmpleado);
            pPrincipal.Controls.Add(vBajasEmpleadoPerfil);
            vBajasEmpleadoPerfil.Dock = DockStyle.Fill;
            vBajasEmpleadoPerfil.BringToFront();
        }
        /// <summary>
        ///  evento Historial de vPersonal que muestra el perfil para eliminación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MostarVentanaHistorial(object sender, EventArgs e)
        {
            int idPersona = ((vPersonal)sender).idPersona;
            vHistorialCambios HistorialCambios = new vHistorialCambios(idPersona);
            pPrincipal.Controls.Add(HistorialCambios);
            HistorialCambios.Dock = DockStyle.Fill;
            HistorialCambios.BringToFront();
        }

        private void MostrarBaja(object sender, EventArgs e)
        {
            int idBaja = ((vBajas)sender).idBaja;
            vBajasEmpleadoPerfil frmBajaEmpleado = new vBajasEmpleadoPerfil(idBaja, LibAux.CRUD.SELECT);
            pPrincipal.Controls.Add(frmBajaEmpleado);
            frmBajaEmpleado.Dock = DockStyle.Fill;
            frmBajaEmpleado.BringToFront();
        }


        #endregion
        #region EVENTOS
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            string productVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;
            lblInfo.Text = "USUARIO: " + Properties.Settings.Default.User + " - " + Properties.Settings.Default.Rol + ".";
            lblInfo2.Text = Application.ProductName + " " + productVersion + ".";
            lblBD.Text = Properties.Settings.Default.BD.ToString();

            if (!Properties.Settings.Default.Rol.Contains("ADM"))
            {
                EsAdmin(false);
            }
        }
        /// <summary>
        /// DRAG WINDOW EVENTS
        /// </summary>
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            MostrarUC(vConsulta);
        }
        private void btnAltasEmpleados_Click(object sender, EventArgs e)
        {
            MostrarUC(vAltaPersonal);
        }
        private void btnBajas_Click(object sender, EventArgs e)
        {
            MostrarUC(vBajas);
        }
        private void btnTodos_Click(object sender, EventArgs e)
        {
            MostrarUC(vTodos);
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pSideBar.Size.Width > 200)
            {
                pSideBar.Size = new System.Drawing.Size(60, 720);
            }
            else
            {
                pSideBar.Size = new System.Drawing.Size(235, 720);
            }
        }
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState.Equals(FormWindowState.Normal))
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            MostrarUC(vCambios);
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            MostrarUC(vUsuarios);
        }
        private void btnErrorLog_Click(object sender, EventArgs e)
        {
            MostrarUC(vErrorLog);
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            MostrarUC(vAjustes);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            frm_Login log = new frm_Login();
            log.Show();
            this.Close();
        }
        private void pTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region SCRIPTS USADOS PARA LA IMPORTACIÓN MASIVA DE INFORMACIÓN
        //private void btnImportacion_Click(object sender, EventArgs e)
        //{
        //    // Ruta del archivo CSV                        
        //    OpenFileDialog openFileDialog1 = new OpenFileDialog();

        //    openFileDialog1.InitialDirectory = "c:\\";
        //    openFileDialog1.Filter = "ALL FILES|*.*";
        //    openFileDialog1.FilterIndex = 0;
        //    openFileDialog1.RestoreDirectory = true;

        //    if (openFileDialog1.ShowDialog() != DialogResult.OK)
        //    {
        //        return;
        //    }

        //    string selectedFileName = openFileDialog1.FileName;
        //    // Lee el archivo CSV y carga los datos en un DataTable
        //    DataTable dt = ReadCsvToDataTable(selectedFileName);

        //    //PrintDataTable(dataTable);
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        string apellPaterno = row["APELLIDO PATERNO"].ToString();
        //        string apellMaterno = row["APELLIDO MATERNO"].ToString();
        //        string nombre = row["NOMBRES"].ToString();
        //        string nss = row["NSS"].ToString();
        //        string curp = row["CURP"].ToString();
        //        string rfc = row["RFC"].ToString();
        //        string puesto = row["puesto"].ToString();
        //        string contrato = row["contrato"].ToString();
        //        object fechainicio = row["fechaInicio"].ToString();
        //        object fechanacimiento = row["fechanacimiento"].ToString();
        //        string tienda = row["tienda"].ToString();

        //        object fechabaja = row["fechabaja"].ToString();
        //        object Finiquito = row["Finiquito"].ToString();
        //        object ComentarioBaja = row["ComentarioBaja"].ToString();

        //        object patron = row["ultimoPatron"].ToString();

        //        try { 

        //        //SI EXISTE, ENTONCES SE MODIFICA CON LA NUEVA INFORMACION QUE PUEDA TENER, SINO, SOLAMENTE SE INSERTA.
        //        if (esPersonaExistente(nombre, apellPaterno, apellMaterno)) //MODIFICA EXISTENTE
        //        {
        //            ModificaExistente(apellPaterno, apellMaterno, nombre, nss, curp, rfc, "", "", "", fechanacimiento, "");
        //            if (fechabaja != DBNull.Value)
        //            {
        //                InsertaEmpleadoContratoNuevo(idEmpleado, puesto, contrato, fechainicio, tienda, fechabaja, Finiquito, ComentarioBaja, patron);
        //            }
        //        }
        //        else {  //INSERTA NUEVO
        //            InsertaNuevo(apellPaterno, apellMaterno, nombre, nss, curp, rfc, puesto, contrato, fechainicio, fechanacimiento, tienda,fechabaja,Finiquito,ComentarioBaja, patron);
        //        }

        //        }catch (Exception ex){
        //            if (!ex.Message.Contains("Index")) {                        
        //            }
        //        }
        //        idPersona = -1;

        //    }

        //}
        //private void InsertaEmpleadoContratoNuevo(int idEmpleado, string puesto, string contrato, object fechainicio, string tienda, object fechabaja, object finiquito, object comentarioBaja, object patron)
        //{
        //    if (fechabaja.ToString() != "")
        //    {
        //        fechabaja = Convert.ToDateTime(fechabaja);
        //    }
        //    if (fechainicio.ToString() != "")
        //    {
        //        fechainicio = Convert.ToDateTime(fechainicio);
        //    }
        //    List<Param> @params = new List<Param> {
        //        new Param("vNombres",""),
        //        new Param("vApellPaterno",""),
        //        new Param("vApellMaterno",""),
        //        new Param("vNSS",""),
        //        new Param("vCURP",""),
        //        new Param("vRFC",""),
        //        new Param("vIdPersona",idPersona),
        //        new Param("vFechaNac",""),
        //        new Param("vFechaInicio",fechainicio),
        //        new Param("vTienda",tienda),
        //        new Param("vContrato",contrato),
        //        new Param("vidEmpleado",idEmpleado),
        //        new Param("vFechaBaja",fechabaja),
        //        new Param("vFiniquito",finiquito),
        //        new Param("vComentarioBaja",comentarioBaja),
        //        new Param("vPatron",""),
        //        new Param("vPuesto",puesto),
        //        new Param("vCRUD","NuevoContrato")
        //    };
        //    LibAux.EjecutarProcedimiento("XX", @params);
        //}
        //private void InsertaNuevo(string apellPaterno, string apellMaterno, string nombre, string nss, string curp, string rfc, string puesto, string contrato, object fechainicio, object fechanacimiento, string tienda, object fechabaja, object finiquito, object comentarioBaja, object patron)
        //{
        //    if (fechanacimiento.ToString() != "")
        //    {
        //        fechanacimiento = Convert.ToDateTime(fechanacimiento);
        //    }
        //    if (fechainicio.ToString() != "")
        //    {
        //        fechainicio = Convert.ToDateTime(fechainicio);
        //    }
        //    if (fechabaja.ToString() != "")
        //    {
        //        fechabaja = Convert.ToDateTime(fechabaja);
        //    }

        //    List<Param> @params = new List<Param> {
        //        new Param("vNombres",nombre),
        //        new Param("vApellPaterno",apellPaterno),
        //        new Param("vApellMaterno",apellMaterno),
        //        new Param("vNSS",nss),
        //        new Param("vCURP",curp),
        //        new Param("vRFC",rfc),
        //        new Param("vFechaNac",fechanacimiento),
        //        new Param("vFechaInicio",fechainicio),
        //        new Param("vFechaBaja",fechabaja),
        //        new Param("vTienda",tienda),
        //        new Param("vContrato",contrato),
        //        new Param("vidPersona",""),
        //        new Param("vFiniquito",finiquito),
        //        new Param("vComentarioBaja",comentarioBaja),
        //        new Param("vPuesto",puesto),
        //        new Param("vPatron",patron),
        //        new Param("vCRUD","INSERT")
        //    };
        //    LibAux.EjecutarProcedimiento("XX", @params);

        //}
        //private void ModificaExistente(string apellPaterno, string apellMaterno, string nombre, string nss, string curp, string rfc, string puesto, string contrato, object fechainicio, object fechanacimiento, string tienda)
        //{

        //    if (fechanacimiento.ToString() != "") {
        //        fechanacimiento = Convert.ToDateTime(fechanacimiento);
        //    }
        //    if (fechainicio.ToString() != "")
        //    {
        //        fechainicio = Convert.ToDateTime(fechainicio);
        //    }

        //    List<Param> @params = new List<Param> {
        //        new Param("vNombres",nombre),
        //        new Param("vApellPaterno",apellPaterno),
        //        new Param("vApellMaterno",apellMaterno),
        //        new Param("vNSS",nss),
        //        new Param("vCURP",curp),
        //        new Param("vRFC",rfc),
        //        new Param("vFechaNac",fechanacimiento),
        //        new Param("vFechaInicio",""),
        //        new Param("vTienda",""),
        //        new Param("vContrato",""),
        //        new Param("vidPersona",idPersona),                
        //        new Param("vFiniquito",""),
        //        new Param("vFechabaja",""),
        //        new Param("vComentarioBaja",""),
        //        new Param("vPuesto",""),
        //        new Param("vPatron",""),
        //        new Param("vCRUD","UPDATE")
        //    };

        //    if (curp != "") {
        //        string a = "a";
        //    }


        //    LibAux.EjecutarProcedimiento("XX", @params);
        //}
        //private bool esPersonaExistente(string nombre, string apellPaterno, string apellMaterno)
        //{
        //    try {
        //        List<Param> @params = new List<Param> {
        //        new Param("vNombres",nombre),
        //        new Param("vApellPaterno",apellPaterno),
        //        new Param("vApellMaterno",apellMaterno),

        //    };
        //        DataTable temp = LibAux.EjecutarSentencia("SELECT idPersona FROM Personas WHERE Nombre = @vNombres AND ApellPaterno = @vApellPaterno AND ApellMaterno = @vApellMaterno;", @params);
        //        idPersona = Convert.ToInt16(temp.Rows[0][0].ToString());
        //        if (idPersona > 0)
        //        {
        //            return true;
        //        }
        //        else {
        //            return false;
        //        }

        //    } catch {
        //        return false;
        //    }
        //}
        //private bool esEmpleadoExistenteConContratoActivo(string nombre, string apellPaterno, string apellMaterno)
        //{
        //    try
        //    {
        //        List<Param> @params = new List<Param> {
        //        new Param("vNombres",nombre),
        //        new Param("vApellPaterno",apellPaterno),
        //        new Param("vApellMaterno",apellMaterno),
        //        };
        //        DataTable temp = LibAux.EjecutarSentencia("SELECT idEmpleado FROM Empleados E, Personas P WHERE E.fechaTermino IS NULL AND Nombre = @vNombres AND ApellPaterno = @vApellPaterno AND ApellMaterno = @vApellMaterno;", @params);
        //        idEmpleado = Convert.ToInt16(temp.Rows[0][0].ToString());
        //        if (idEmpleado > 0)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }

        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
        //static DataTable ReadCsvToDataTable(string filePath)
        //{
        //    DataTable dataTable = new DataTable();

        //    using (TextFieldParser parser = new TextFieldParser(filePath))
        //    {
        //        parser.TextFieldType = FieldType.Delimited;
        //        parser.SetDelimiters(",");

        //        // Lee la primera fila para establecer las columnas del DataTable
        //        string[] headers = parser.ReadFields();
        //        foreach (string header in headers)
        //        {
        //            dataTable.Columns.Add(header);
        //        }

        //        // Lee el resto de las filas y agrega los datos al DataTable
        //        while (!parser.EndOfData)
        //        {
        //            string[] fields = parser.ReadFields();
        //            dataTable.Rows.Add(fields);
        //        }
        //    }

        //    return dataTable;
        //}        
        #endregion


        //Generacion de numeros de contrato para los que no tengan.
        //private void btnImportacion_Click(object sender, EventArgs e)
        //{
        //    int contador = 40000;
        //    DataTable dtTemp = LibAux.EjecutarSentencia("SELECT * FROM empleados where NumContrato IS NULL");

        //    for (int i = 0; i < dtTemp.Rows.Count; i++)
        //    {
        //        string idEmpleado = dtTemp.Rows[i][0].ToString();
        //        List<Param> @params = new List<Param>
        //        {
        //            new Param("vidEmpleado",idEmpleado),
        //            new Param("vNumContrato",contador)

        //        };
        //        LibAux.EjecutarSentencia("UPDATE Empleados SET numContrato = @vNumContrato WHERE idEmpleado = @vidEmpleado; ", @params);
        //        contador++;
        //    }
        //    MessageBox.Show("Listo");
        //}

    }
}
