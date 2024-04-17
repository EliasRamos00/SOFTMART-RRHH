using MySqlConnector;
using SOFTMART_RRHH.Controlador;
using SOFTMART_RRHH.Modelo;
using SOFTMART_RRHH.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using static SOFTMART_RRHH.Modelo.LibAux;

namespace SOFTMART_RRHH.Vista
{
    public partial class vPersonal : UserControl
    {
        #region VARIABLES GLOBALES
        public string oldCurp { get; private set; }
        public event EventHandler BtnEliminar;
        public event EventHandler BtnHistorial;
        public int idEmpleado = 0;
        public int idPersona = 0;

        string FotografiaDestino = "\\Fotos_Personal\\";
        string INEDestino = "\\Fotos_INE\\";

        string fotografiaOrigen_Ruta = "";
        string INEOrigen_Ruta = "";

        bool esFotoNueva = false, esINENueva = false;

        string INE;

        bool estaModificando = false;
        bool existióPersona = false;

        #endregion
        #region CONSTRUCTORES
        public vPersonal()
        {
            InitializeComponent();
        }
        public vPersonal(CRUD crud, int idEmpleado = 0, int idPersona = 0)
        {
            InitializeComponent();

            EsConsultor();
            this.idEmpleado = idEmpleado;
            this.idPersona = idPersona;
            switch (crud)
            {
                case CRUD.SELECT:
                    lblMov.Text = "CONSULTAR";
                    lblMov.ForeColor = LibAux.libColores[eColores.Consulta];
                    btnGuardar.Enabled = false;
                    break;
                case CRUD.INSERT:
                    lblMov.Text = "ALTA";
                    lblMov.ForeColor = LibAux.libColores[eColores.Alta];
                    btnLimpiar.Visible = true;
                    break;
                case CRUD.UPDATE:
                    lblMov.Text = "MODIFICACIÓN";
                    lblMov.ForeColor = LibAux.libColores[eColores.Modificacion];
                    break;
                case CRUD.DELETE:
                    lblMov.Text = "BAJA";
                    lblMov.ForeColor = LibAux.libColores[eColores.Baja];
                    break;
                default:
                    lblMov.Text = "?????";
                    lblMov.ForeColor = LibAux.libColores[eColores.Baja];
                    break;
            }
        }

        private void EsConsultor()
        {
            if (Properties.Settings.Default.Rol.Contains("CONSULT")) {
                btnActualizar.Enabled = false;
                btnGuardar.Enabled = false;
                btnHistorial.Enabled = false;
                btnDarBaja.Enabled = false;
            }
        }
        #endregion
        #region MÉTODOS
        private void CargarInformacion()
        {
            DataTable info = MEmpleados.ObtenerEmpleadoInformacionById(idEmpleado);
            CargarInformaciónPersona(info);
            CargarInformacionEmpleado(info);

        }
        private void CargarInformaciónPersona(DataTable infoPersona)
        {
            if (infoPersona != null)
            {
                tbApePat.Text = infoPersona.Rows[0]["ApellPaterno"].ToString();
                tbApeMat.Text = infoPersona.Rows[0]["ApellMaterno"].ToString();
                tbNombres.Text = infoPersona.Rows[0]["Nombre"].ToString();
                tbRFC.Text = infoPersona.Rows[0]["RFC"].ToString();
                cbEdoCivil.Text = infoPersona.Rows[0]["EdoCivil"].ToString();
                tbLugarNac.Text = infoPersona.Rows[0]["LugarNac"].ToString();
                dtpFechaNac.Value = Convert.ToDateTime(infoPersona.Rows[0]["FechaNac"]);
                tbEspecialidad.Text = infoPersona.Rows[0]["Especialidad"].ToString();
                tbEstado.Text = infoPersona.Rows[0]["Estado"].ToString();
                tbCiudad.Text = infoPersona.Rows[0]["Ciudad"].ToString();
                tbColonia.Text = infoPersona.Rows[0]["Colonia"].ToString();
                tbCalleNum.Text = infoPersona.Rows[0]["CalleNum"].ToString();
                tbCP.Text = infoPersona.Rows[0]["CodigoPostal"].ToString();
                tbTelefono.Text = infoPersona.Rows[0]["Valor"].ToString();
                cbEscolaridad.Text = infoPersona.Rows[0]["Escolaridad"].ToString();
                tbCURP.Text = infoPersona.Rows[0]["CURP"].ToString();
                tb_InfoEmerg.Text = infoPersona.Rows[0]["InfoEmer"].ToString();
                tbNSS.Text = infoPersona.Rows[0]["NumSeguroSocial"].ToString();
                INE = "\\\\" + ConfigurationManager.AppSettings["IP"] + infoPersona.Rows[0]["INE"].ToString();
                if (infoPersona.Rows[0]["Genero"].ToString() == "Masculino")
                {
                    rBMasc.Checked = true;
                }
                else
                {
                    rBFem.Checked = true;
                }
                try { pbPersona.ImageLocation = "\\\\"+ ConfigurationManager.AppSettings["IP"] + infoPersona.Rows[0]["Fotografia"].ToString(); } catch { }
            }
        }
        private void CargarInformacionEmpleado(DataTable infoEmpleado)
        {
            cbSueldo.Text = infoEmpleado.Rows[0]["Sueldo"].ToString();
            dtpFechaIngreso.Value = Convert.ToDateTime(infoEmpleado.Rows[0]["FechaInicio"]);
            cBEmpleadoTemporada.Checked = Convert.ToBoolean(infoEmpleado.Rows[0]["esEmpleadoTemp"]);
            cbTienda.Text = infoEmpleado.Rows[0]["Sucursal"].ToString();
            cbArea.Text = infoEmpleado.Rows[0]["Area"].ToString();
            cbSubarea.Text = infoEmpleado.Rows[0]["SubArea"].ToString();
            cbPuesto.Text = infoEmpleado.Rows[0]["Puesto"].ToString();
            tbNumContrato.Text = infoEmpleado.Rows[0]["NumContrato"].ToString();
            tbComentarios.Text = infoEmpleado.Rows[0]["Comentarios"].ToString();
        }
        private void ConsultarExistenciaPersona()
        {
            if (!estaModificando)
            {
                DataTable InfoPersona = MPersonas.ObtenerPersonaInformacionByCURP(tbCURP.Text);
                if (InfoPersona.Rows.Count != 0) // SI OBTIENE INFORMACION ENTONCES LA CARGA EN LOS CAMPOS.
                {
                    existióPersona = true;
                    CargarInformaciónPersona(InfoPersona);
                    CamposSoloLecturaPersona(true);
                }
                if (existióPersona && InfoPersona.Rows.Count == 0)
                {
                    LimpiarCamposPersona();
                    CamposSoloLecturaPersona(false);
                }
            }
        }
        private void CargarEdosCiviles()
        {
            cbEdoCivil.DataSource = MEstadosCiviles.ObtenerEdosCiviles();
            cbEdoCivil.DisplayMember = "EdoCivil";
            cbEdoCivil.ValueMember = "EdoCivil";
            cbEdoCivil.SelectedIndex = -1;
        }
        private void CargarEscolaridades()
        {
            cbEscolaridad.DataSource = MEscolaridades.ObtenerEscolaridades();
            cbEscolaridad.DisplayMember = "Escolaridad";
            cbEscolaridad.ValueMember = "idEscolaridad";
            cbEscolaridad.SelectedIndex = -1;
        }
        private void CargarAreas()
        {
            cbArea.DataSource = MPuestos.ObtenerAreasPuestos();
            cbArea.DisplayMember = "Area";
            cbArea.ValueMember = "Area";
            cbArea.SelectedIndex = -1;
        }
        private void CargarSubAreas()
        {
            cbSubarea.DataSource = MPuestos.ObtenerSubAreasPuestos(cbArea.Text);
            cbSubarea.DisplayMember = "SubArea";
            cbSubarea.ValueMember = "SubArea";
            cbSubarea.SelectedIndex = -1;
        }
        private void CargarPuestos()
        {
            cbPuesto.DataSource = MPuestos.ObtenerPuestos(cbArea.Text, cbSubarea.Text);
            cbPuesto.DisplayMember = "Puesto";
            cbPuesto.ValueMember = "idPuesto";
            cbPuesto.SelectedIndex = -1;
        }

        private void CargarSucursales()
        {
            cbTienda.DataSource = MSucursales.ObtenerSucursales();
            cbTienda.DisplayMember = "Sucursal";
            cbTienda.ValueMember = "idSucursal";
            cbTienda.SelectedIndex = -1;
        }
        private void CamposSoloLecturaPersona(bool @bool)
        {
            if (lblMov.Text != "ALTA")
                tbCURP.ReadOnly = @bool;

            tbApePat.ReadOnly = @bool;
            tbApeMat.ReadOnly = @bool;
            tbNombres.ReadOnly = @bool;
            tbRFC.ReadOnly = @bool;
            tbEspecialidad.ReadOnly = @bool;
            tbEstado.ReadOnly = @bool;
            tbCiudad.ReadOnly = @bool;
            tbColonia.ReadOnly = @bool;
            tbCalleNum.ReadOnly = @bool;
            tbCP.ReadOnly = @bool;
            tbTelefono.ReadOnly = @bool;
            tbNSS.ReadOnly = @bool;
            tb_InfoEmerg.ReadOnly = @bool;

            //btnSubirINE.Enabled = !@bool;
            //btnSubirFoto.Enabled = !@bool;
            cbEdoCivil.Enabled = !@bool;
            cbEscolaridad.Enabled = !@bool;
            dtpFechaNac.Enabled = !@bool;
            tbLugarNac.Enabled = !@bool;
            gBGenre.Enabled = !@bool;
        }
        private void CamposSoloLecturaEmpleado(bool @bool)
        {
            tbComentarios.ReadOnly = @bool;
            tbNumContrato.ReadOnly = @bool;
            cBEmpleadoTemporada.Enabled = !@bool;
            cbSueldo.Enabled = !@bool;
            cbTienda.Enabled = !@bool;
            cbArea.Enabled = !@bool;
            cbPuesto.Enabled = !@bool;
            dtpFechaIngreso.Enabled = !@bool;
            cbSubarea.Enabled = !@bool;
        }
        private void LimpiarCamposPersona()
        {
            existióPersona = false;
            tbApePat.Text = "";
            tbApeMat.Text = "";
            tbNombres.Text = "";
            tbRFC.Text = "";
            cbEdoCivil.SelectedIndex = -1;
            tbLugarNac.Text = "";
            dtpFechaNac.Value = new DateTime(2000, 1, 1);
            tbEspecialidad.Text = "";
            tbEstado.Text = "";
            tbCiudad.Text = "";
            tbColonia.Text = "";
            tbCalleNum.Text = "";
            tbCP.Text = "";
            tbTelefono.Text = "";
            tb_InfoEmerg.Text = "";
            tbNSS.Text = "";
            cbEscolaridad.SelectedIndex = -1;
            pbPersona.Image = null;
        }

        private void LimpiarCamposEmpleado()
        {
            tbNumContrato.Text = "";
            tbRFC.Text = "";
            tbComentarios.Text = "";

            cbTienda.SelectedIndex = -1;
            cbArea.SelectedIndex = -1;
            cbSubarea.SelectedIndex = -1;
            cbPuesto.SelectedIndex = -1;
            cbSueldo.Text = "";         
        }

        #endregion
        #region EVENTOS   
        private void vAltaPersonal_Load(object sender, EventArgs e)
        {
            CargarSucursales();
            //CargarPuestos();
            CargarAreas();
            CargarEscolaridades();
            CargarEdosCiviles();
            if (idEmpleado != 0) //Si el idEmpleado es != 0 entonces quiere decir que se trata de una consulta / modificación.
            {
                btnHistorial.Visible = true;
                btnActualizar.Visible = true;
                btnDarBaja.Visible = true;
                btnSubirFoto.Text = "Ver Fotografia";
                btnSubirINE.Text = "Ver INE";
                CargarInformacion();
                CamposSoloLecturaPersona(true);
                CamposSoloLecturaEmpleado(true);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void rBMasc_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //------- SE OBTIENE LA INFORMACIÓN DEL FORMULARIO --------
            //INFORMACION DE CONTACTO
            string telefono;
            telefono = tbTelefono.Text;

            //INFORMACION DE DOMICILIO
            object Estado, Ciudad, Colonia, CP, CalleNum;
            Estado = tbEstado.Text;
            Ciudad = tbCiudad.Text;
            Colonia = tbColonia.Text;
            CP = tbCP.Text;
            CalleNum = tbCalleNum.Text;

            //INFORMACION DE PERSONA
            object Nombres, ApePat, ApeMat, RFC, CURP,
                LugarNac, Genero, fotografiaDestino, fotografiaOrigen, idEscolaridad, Especialidad, EdoCivil, NSS, InfoEmer, INE_Origen, INE_Destino;

            Nombres = tbNombres.Text;
            ApePat = tbApePat.Text;
            ApeMat = tbApeMat.Text;
            RFC = tbRFC.Text;
            CURP = tbCURP.Text;
            LugarNac = tbLugarNac.Text;
            Genero = rBMasc.Checked == true ? "Masculino" : "Femenino";
            DateTime FechaNac = dtpFechaNac.Value;
            try { idEscolaridad = cbEscolaridad.SelectedValue.ToString(); } catch { idEscolaridad = ""; }
            Especialidad = tbEspecialidad.Text;
            EdoCivil = cbEdoCivil.Text;
            NSS = tbNSS.Text;
            InfoEmer = tb_InfoEmerg.Text;

            if (esFotoNueva)
            {
                fotografiaDestino = Path.Combine(FotografiaDestino, tbCURP.Text + DateTime.Now.ToString("_yyyy-MM-dd_HH-mm-ss_") + ".jpg");
                fotografiaOrigen = fotografiaOrigen_Ruta;
            }
            else
            {
                fotografiaDestino = "";
                fotografiaOrigen = "";
            }

            if (esINENueva)
            {
                INE_Destino = Path.Combine(INEDestino, "INE_" + tbCURP.Text + DateTime.Now.ToString("_yyyy-MM-dd_HH-mm-ss_") + ".jpg");
                INE_Origen = INEOrigen_Ruta;
            }
            else
            {
                INE_Destino = "";
                INE_Origen = "";
            }

            //INE_Destino = Path.Combine(INEDestino, "INE_" + tbCURP.Text + DateTime.Now.ToString("_yyyy-MM-dd_HH-mm-ss_") + ".jpg");

            //INFORMACIÓN DE EMPLEADO
            object NumContrato, idSucursal, idPuesto, esTemporal, sueldo, comentarios;
            NumContrato = tbNumContrato.Text;
            try { idSucursal = cbTienda.SelectedValue.ToString(); } catch { idSucursal = ""; }
            try { idPuesto = cbPuesto.SelectedValue.ToString(); } catch { idPuesto = ""; }
            esTemporal = cBEmpleadoTemporada.Checked;
            sueldo = cbSueldo.Text != "" ? Convert.ToDecimal(cbSueldo.Text).ToString("0.00") : "";
            comentarios = tbComentarios.Text;

            if (estaModificando) //Si no es una modificación... es una inserción.
            {
                int idPersona = MPersonas.ObtenerIdPersonaByIdEmpleado(idEmpleado);

                if (CAltaPersonal.CModificarPersonal("TELEFONO", telefono, Estado, Ciudad, Colonia, CP, CalleNum, Nombres, ApePat, ApeMat, RFC,
                 CURP, LugarNac, Genero, FechaNac, fotografiaDestino, idEscolaridad, Especialidad, NumContrato, idSucursal, idPuesto, dtpFechaIngreso.Value, EdoCivil, esTemporal, sueldo, idEmpleado, idPersona, NSS, InfoEmer, fotografiaOrigen, INE_Origen, INE_Destino, comentarios))
                {
                    INEOrigen_Ruta = "";
                    fotografiaOrigen_Ruta = "";
                    esFotoNueva = false;
                    esINENueva = false;
                    btnSubirFoto.Text = "Ver Fotografia";
                    btnSubirINE.Text = "Ver INE";
                    estaModificando = false;
                    CargarInformacion();
                    lblMov.Text = "CONSULTA";
                    lblMov.ForeColor = LibAux.libColores[eColores.Consulta];
                    btnActualizar.Text = "Actualizar";
                    CamposSoloLecturaPersona(true);
                    CamposSoloLecturaEmpleado(true);
                }
            }
            else
            {
                CAltaPersonal.CInsertarPersonal("TELEFONO", telefono, Estado, Ciudad, Colonia, CP, CalleNum, Nombres, ApePat, ApeMat, RFC,
                CURP, LugarNac, Genero, FechaNac, fotografiaDestino, idEscolaridad, Especialidad, NumContrato, idSucursal, idPuesto, dtpFechaIngreso.Value, EdoCivil, esTemporal, sueldo, existióPersona, NSS, InfoEmer, fotografiaOrigen, INE_Origen, INE_Destino, comentarios);
            }


        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idEmpleado != 0 && estaModificando == false)
            {
                btnSubirFoto.Text = "Subir Fotografia";
                btnSubirINE.Text = "Subir INE";
                estaModificando = true;
                oldCurp = tbCURP.Text;
                lblMov.Text = "MODIFICACIÓN";
                lblMov.ForeColor = LibAux.libColores[eColores.Modificacion];
                btnActualizar.Text = "Cancelar edición";
                //UPDATE$
                CamposSoloLecturaPersona(false);
                CamposSoloLecturaEmpleado(false);
            }
            else if (estaModificando == true)
            {
                btnSubirFoto.Text = "Ver Fotografia";
                btnSubirINE.Text = "Ver INE";
                estaModificando = false;
                CargarInformacion();
                lblMov.Text = "CONSULTA";
                lblMov.ForeColor = LibAux.libColores[eColores.Consulta];
                btnActualizar.Text = "Actualizar";
                PopUp("Edición cancelada", "Edición cancelada. se regresaron los valores anteriores.", TipoNotif.Info);
                CamposSoloLecturaPersona(true);
                CamposSoloLecturaEmpleado(true);
            }
            btnGuardar.Enabled = estaModificando;
        }
        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            MostrarVentanaEliminacion(EventArgs.Empty);
        }
        private void tbCURP_KeyUp(object sender, KeyEventArgs e)
        {
            ConsultarExistenciaPersona();
        }
        public virtual void MostrarVentanaEliminacion(EventArgs e)
        {
            BtnEliminar?.Invoke(this, e);
        }
        #endregion

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (lblMov.Text == "ALTA")
            {
                LimpiarCamposPersona();
                LimpiarCamposEmpleado();
            }
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            if (btnSubirFoto.Text.Contains("Subir"))
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "IMAGE FILE | *.jpg;*.jpeg;*.png";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    esFotoNueva = true;
                    fotografiaOrigen_Ruta = Path.Combine(open.InitialDirectory, open.FileName);
                    pbPersona.Image = Image.FromFile(fotografiaOrigen_Ruta);
                }

            }
            else if (btnSubirFoto.Text.Contains("Ver"))
            {
                try
                {
                    Process.Start(@"" + pbPersona.ImageLocation.ToString() + "");
                }
                catch (Exception ex)
                {
                    ErrorLog(ex);
                    if (ex.Message.Contains("El sistema no puede encontrar el archivo especificado"))
                    {
                        PopUp("Identificación no encontrada", "Esta persona no tiene fotografia registrada.", TipoNotif.Info);
                    }
                    else
                    {
                        PopUp("Error desconocido", ex.Message, TipoNotif.Info);
                    }

                }
            }
        }

        private void lblFechaIngreso_Click(object sender, EventArgs e)
        {

        }

        private void rBFem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void tlpPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void pbPersona_Click(object sender, EventArgs e)
        {

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            BtnHistorial?.Invoke(this, e);
        }

        private void cbSubarea_DropDown(object sender, EventArgs e)
        {
            CargarSubAreas();
        }

        private void cbPuesto_DropDown(object sender, EventArgs e)
        {
            CargarPuestos();
        }

        private void cbArea_DropDown(object sender, EventArgs e)
        {
            CargarAreas();
        }

        private void cbSubarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarPuestos();
            cbPuesto.SelectedIndex = -1;
        }

        private void cbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarSubAreas();
            cbSubarea.SelectedIndex = -1;
            cbPuesto.SelectedIndex = -1;
        }

        private void btnSubirINE_Click(object sender, EventArgs e)
        {

            if (btnSubirINE.Text.Contains("Subir"))
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "IMAGE FILE | *.jpg;*.jpeg;*.png";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    INEOrigen_Ruta = Path.Combine(open.InitialDirectory, open.FileName);
                    esINENueva = true;
                }
            }
            else if (btnSubirINE.Text.Contains("Ver"))
            {
                try
                {
                    Process.Start(@"" + INE + "");
                }
                catch (Exception ex)
                {
                    ErrorLog(ex);
                    if (ex.Message.Contains("archivo"))
                    {
                        PopUp("Identificación no encontrada", "Esta persona no tiene INE registrada.", TipoNotif.Info);
                    }

                    else
                    {
                        PopUp("Error desconocido", ex.Message, TipoNotif.Info);
                    }
                }


            }
        }
    }
}
