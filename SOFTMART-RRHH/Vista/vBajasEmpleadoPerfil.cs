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
        string patronAnterior, finiquitoAnterior, comentariosAnterior;
        DateTime fechaAnterior;

        int idEmpleado = 0;
        int idBaja = 0;
        bool estaModificando = false;
        bool esConsulta = false;

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
            btnGuardar.Hide();
            btnActualizar.Hide();

        }
        public vBajasEmpleadoPerfil(int idBaja, LibAux.CRUD CRUD)
        {
            InitializeComponent();
            this.idBaja = idBaja;
            this.idEmpleado = MBajas.ObtenerIdEmpleadoByIdBaja(idBaja);
            CargarInformacionBaja();
            CamposSoloLectura(true);
            btnDarBaja.Text = "Revocar baja.";
            this.esConsulta = true;
            this.btnGuardar.Visible = true;
            this.btnGuardar.Enabled = false;

        }

        private void CamposSoloLectura(bool @bool)
        {
            this.dtpFechaBaja.Enabled = !@bool;
            this.tbPatron.Enabled = !@bool;
            this.tbComentarios.Enabled = !@bool;
            this.tbFiniquito.Enabled = !@bool;
        }
        #endregion
        #region MÉTODOS
        private void CargarInformacionEmpleado()
        {
            DataTable dtTemp = MEmpleados.ObtenerEmpleadoInformacionById(idEmpleado);
            lblNombre.Text = dtTemp.Rows[0]["ApellPaterno"].ToString() + " " + dtTemp.Rows[0]["ApellMaterno"].ToString() + " " + dtTemp.Rows[0]["Nombre"].ToString();
            lblContrato.Text = dtTemp.Rows[0]["NumContrato"].ToString();
            lblTienda.Text = dtTemp.Rows[0]["Sucursal"].ToString();
            try { pbFoto.ImageLocation = "\\\\" + Properties.Settings.Default.Ip + dtTemp.Rows[0]["Fotografia"].ToString(); } catch { }
        }
        private void CargarInformacionBaja()
        {
            DataTable dtTemp = MBajas.ObtenerInformacionBaja(idBaja);

            tbPatron.Text = dtTemp.Rows[0]["UltimoPatron"].ToString();
            tbFiniquito.Text = dtTemp.Rows[0]["Finiquito"].ToString();
            dtpFechaBaja.Value = Convert.ToDateTime(dtTemp.Rows[0]["FechaTermino"].ToString());
            tbComentarios.Text = dtTemp.Rows[0]["Comentarios"].ToString();

        }
        #endregion
        #region EVENTOS
        private void vBajasEmpleadoPerfil_Load(object sender, EventArgs e)
        {
            CargarInformacionEmpleado();
        }
        private void btnDarBaja_Click(object sender, EventArgs e)
        {

            if (esConsulta)
            {
                if (System.Windows.Forms.MessageBox.Show("¿Estas seguro de revocar la baja a " + lblNombre.Text + " ?", "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        CBajasPersonal.EliminarBaja(idBaja);
                        LibAux.PopUp("¡Éxito!", "Se revocó la baja con éxito.", LibAux.TipoNotif.Success);
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        LibAux.ErrorLog(ex);
                        LibAux.PopUp("¡Atención!", "Ocurrió un error al revocar la baja.", LibAux.TipoNotif.Error);
                    }
                }

            }
            else
            {

                if (System.Windows.Forms.MessageBox.Show("¿Estas seguro de dar de baja a " + lblNombre.Text + " ?", "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        CBajasPersonal.BajaPersonal(dtpFechaBaja, tbPatron, tbFiniquito, tbComentarios, idEmpleado);
                        LibAux.PopUp("¡Éxito!", "El empleado ha sido dado de baja con éxito.", LibAux.TipoNotif.Success);
                        this.Hide();
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
                }
                this.Hide();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (estaModificando)
            {
                LibAux.PopUp("¡Atención!", "Edición cancelada. Se regresaron los valores anteriores.", LibAux.TipoNotif.Info);
                tbPatron.Text = patronAnterior;
                tbComentarios.Text = comentariosAnterior;
                tbFiniquito.Text = finiquitoAnterior;
                dtpFechaBaja.Value = fechaAnterior;

                btnActualizar.Text = "Actualizar";
                estaModificando = !estaModificando;
                this.btnGuardar.Enabled = false;
                CamposSoloLectura(true);
            }
            else
            {
                this.patronAnterior = tbPatron.Text;
                this.comentariosAnterior = tbComentarios.Text;
                this.finiquitoAnterior = tbFiniquito.Text;
                this.fechaAnterior = dtpFechaBaja.Value;

                btnActualizar.Text = "Cancelar edición.";
                estaModificando = !estaModificando;
                this.btnGuardar.Enabled = true;
                CamposSoloLectura(false);

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (esConsulta && estaModificando)
            {
                try
                {
                    object Fecha, Finiquito, Comentario, Patron;
                    Fecha = dtpFechaBaja.Value;
                    Finiquito = tbFiniquito.Text;
                    Comentario = tbComentarios.Text;
                    Patron = tbPatron.Text;

                    MBajas.ActualizarBaja(Fecha, Finiquito, Comentario, Patron, idBaja);
                    LibAux.PopUp("¡Éxito!", "La baja a sido modificada con éxito.", LibAux.TipoNotif.Success);
                    this.btnGuardar.Enabled = false;
                    this.btnActualizar.Text = "Actualizar";
                    CamposSoloLectura(true);

                }
                catch (Exception ex)
                {
                    LibAux.ErrorLog(ex);
                    LibAux.PopUp("¡Atención!", "Ha ocurrido un error al modificar la baja." + ex.Message, LibAux.TipoNotif.Error);
                }
            }
        }
    }
}
