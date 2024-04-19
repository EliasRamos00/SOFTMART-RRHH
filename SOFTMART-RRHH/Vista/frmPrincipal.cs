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
            if (Properties.Settings.Default.Rol.Contains("ADM"))
            {
                EsAdmin(true);
            }
            else
            {
                EsAdmin(false);
            }

            //Eventos de los U.C.
            vConsulta.DobleClickEmpleado += MostrarEmpleado;
            vTodos.DobleClickEmpleado += MostrarEmpleado;
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
            int idEmpleado = 0, idPersona = 0;
            if (sender.ToString().Contains("vTodos"))
            {
                idEmpleado = ((vTodos)sender).idEmpleado;
                idPersona = ((vTodos)sender).idPersona;

            }
            else if (sender.ToString().Contains("vConsulta"))
            {
                idEmpleado = ((vConsulta)sender).idEmpleado;
                idPersona = ((vConsulta)sender).idPersona;
            }
            vPersonal perfil = new vPersonal(LibAux.CRUD.SELECT, idEmpleado, idPersona);
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

        #endregion
        #region EVENTOS
        private void frmPrincipal_Load(object sender, EventArgs e)
        {                      
            string productVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;

            lblInfo.Text = "USUARIO: " + Properties.Settings.Default.User + " - " + Properties.Settings.Default.Rol + ".";
            lblInfo2.Text = Application.ProductName + " " + productVersion + ".";
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
    }
}
