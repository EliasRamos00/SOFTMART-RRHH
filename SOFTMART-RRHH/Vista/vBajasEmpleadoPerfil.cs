using SOFTMART_RRHH.Controlador;
using SOFTMART_RRHH.Modelo;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace SOFTMART_RRHH.Vista
{
    public partial class vBajasEmpleadoPerfil : UserControl
    {
        #region VARIABLES GLOBALES
        int idEmpleado = 0;
        #endregion
        #region CONSTRUCTORES
        public vBajasEmpleadoPerfil()
        {
            InitializeComponent();
        }
        public vBajasEmpleadoPerfil(int idEmpleado)
        {
            InitializeComponent();
            this.idEmpleado = idEmpleado;
        }
        #endregion
        #region MÉTODOS
        private void CargarInformacionEmpleado()
        {
            DataTable dtTemp = MEmpleados.ObtenerEmpleadoInformacionById(idEmpleado);
            lblNombre.Text = dtTemp.Rows[0]["ApellPaterno"].ToString() + " " + dtTemp.Rows[0]["ApellMaterno"].ToString() + " " + dtTemp.Rows[0]["Nombre"].ToString();
            lblContrato.Text = dtTemp.Rows[0]["NumContrato"].ToString();
            lblTienda.Text = dtTemp.Rows[0]["Sucursal"].ToString();
            try { pbFoto.ImageLocation = "\\\\" + ConfigurationManager.AppSettings["IP"] + dtTemp.Rows[0]["Fotografia"].ToString(); } catch { }
        }
        #endregion
        #region EVENTOS
        private void vBajasEmpleadoPerfil_Load(object sender, EventArgs e)
        {
            CargarInformacionEmpleado();
        }
        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("¿Estas seguro de dar de baja a "+lblNombre.Text+" ?", "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    CBajasPersonal.BajaPersonal(dtpFechaBaja, tbPatron, tbFiniquito, tbComentarios, idEmpleado);
                    LibAux.PopUp("¡Éxito!", "El empleado ha sido dado de baja con éxito.", LibAux.TipoNotif.Success);
                }
                catch (Exception ex)
                {
                    LibAux.ErrorLog(ex);
                    if (ex.Message.Contains("UK"))
                    {
                        LibAux.PopUp("¡Atención!", "Este empleado ya fue dado de baja.", LibAux.TipoNotif.Error);
                    }
                    else
                    {
                        LibAux.PopUp("¡Atención!", "Ha ocurrido un error al dar de baja al empleado." + ex.Message, LibAux.TipoNotif.Error);
                    }


                }
                this.Hide();

            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion
    }
}
