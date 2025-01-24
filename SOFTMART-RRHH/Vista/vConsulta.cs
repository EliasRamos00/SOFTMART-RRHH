
using NPOI.SS.Formula.Functions;
using SOFTMART_RRHH.Controlador;
using SOFTMART_RRHH.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFTMART_RRHH.Vista
{
    public partial class vConsulta : UserControl
    {
        #region VARIABLES GLOBALES
        public int idEmpleado { get; private set; }
        public int idPersona { get; private set; }
        public event EventHandler DobleClickEmpleado;
        public int DiasAntigu, MesesAntigu, AniosAntigu;
        DataTable dtEmpledosActivos;
        #endregion
        #region CONSTRUCTORES
        public vConsulta()
        {
            InitializeComponent();
            //Set Double buffering on the Grid using reflection and the bindingflags enum.
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            dgvConsultaEmpleados, new object[] { true });
            CargarColumnas();
        }
        #endregion
        #region MÉTODOS       
        private async void CargarEmpleadosActivos()
        {
            frmCarga carga = new frmCarga();
            carga.Show();

            dtEmpledosActivos = MEmpleados.ObtenerEmpleadosActivosReporte();  // OBTIENE LA LISTA DE EMPLEADOS ACTIVOS
            await Task.Run(() => CalcularAntiguedad()); // CALCULA LA ANTIGUEDAD EN UN HILO APARTE
            dgvConsultaEmpleados.DataSource = dtEmpledosActivos;

            carga.Hide();
            rowCounting.Text = "Registros : " + dgvConsultaEmpleados.Rows.Count.ToString();

        }
        private void CargarColumnas()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

            foreach (DataGridViewColumn col in dgvConsultaEmpleados.Columns)
            {
                if (col.HeaderText == "Num. Contrato" || col.HeaderText == "NombreCompleto" || col.HeaderText == "NumContrato" || col.HeaderText == "Sucursal" || col.HeaderText == "Puesto" || col.HeaderText == "Edad" || col.HeaderText == "Antiguedad")
                {
                    if (!keyValuePairs.ContainsKey(col.HeaderText))
                    {
                        keyValuePairs.Add(col.Name, col.HeaderText);
                    }
                }
            }
            keyValuePairs.Add("Temp", "Empleados de Temporada");
            keyValuePairs.Add("EAPF", "Empleados activos por fechas");


            cbFiltro.DataSource = keyValuePairs.ToList();
            cbFiltro.DisplayMember = "Value";
            cbFiltro.ValueMember = "Key";
        }
        private string CalcularDiferencia(DateTime FechaIni, DateTime FechaFin)
        {
            int MesAnter = FechaFin.Month;
            while (MesAnter == FechaFin.Month)
            {
                FechaIni = FechaIni.AddDays(-1);
                FechaFin = FechaFin.AddDays(-1);
            }

            int anios = 0, meses = 0, dias = 0;

            // obtiene los años.
            while (FechaFin.CompareTo(FechaIni) >= 0)
            {
                anios++;
                FechaFin = FechaFin.AddYears(-1);
            }
            FechaFin = FechaFin.AddYears(1);
            anios--;


            // obtiene los dias y los meses
            MesAnter = FechaFin.Month;
            while (FechaFin.CompareTo(FechaIni) >= 0)
            {
                dias++;
                FechaFin = FechaFin.AddDays(-1);
                if ((FechaFin.CompareTo(FechaIni) >= 0) && (MesAnter != FechaFin.Month))
                {
                    meses++;
                    dias = 0;
                    MesAnter = FechaFin.Month;
                }
            }
            dias--;

            DiasAntigu = dias;
            MesesAntigu = meses;
            AniosAntigu = anios;
            if (anios <= -1)
            {
                return "N/A";
            }
            return (anios.ToString() + " Año(s)" +
                                ", " + meses.ToString() + " Mes(es)" +
                                ", " + dias.ToString() + " Dia(s)");

        }
        private void CalcularAntiguedad()
        {
            DateTime fechaInicio;
            if(dtEmpledosActivos != null)
            {
                foreach (DataRow row in dtEmpledosActivos.Rows)
                {
                    if (row["FechaInicio"] != DBNull.Value)
                    {
                        try
                        {
                            fechaInicio = Convert.ToDateTime(row["FechaInicio"].ToString());
                            row["Antiguedad"] = CalcularDiferencia(fechaInicio, dtpFechaFiltro.Value);
                        }
                        catch
                        {

                        }

                    }
                }
            }
            
        }
        private void FiltrarInformacion()
        {

            try
            {
                if (cbFiltro.Text == "Antiguedad")
                {                   
                    int diasInicio = TomarDiasComboBox(cbInicio) - 13;
                    int diasFinal = TomarDiasComboBox(cbFinal) + 13;
                    ((DataTable)dgvConsultaEmpleados.DataSource).DefaultView.RowFilter = string.Format("AntiguedadDias >= " + diasInicio + " AND AntiguedadDias <= " + diasFinal + "AND antiguedad NOT LIKE 'N/A'");


                }else if (cbFiltro.Text == "Empleados activos por fechas")
                {
                    //Antes de hacer este filtro se tienen que obtener los empleados dados de baja
                    ((DataTable)dgvConsultaEmpleados.DataSource).DefaultView.RowFilter = string.Format(
                        "FechaInicio >= #{0}# AND FechaInicio <= #{1}#",
                        dtpInicio.Value.ToString("yyyy-MM-dd 00:00:00"),
                        dtpFin.Value.ToString("yyyy-MM-dd 23:59:59"));
                }
                else
                {
                    if (cbFiltro.SelectedIndex >= 0)
                    {
                        string CB = cbFiltro.Text.ToString();
                        string TB = tbFiltro.Text.ToString();
                        ((DataTable)dgvConsultaEmpleados.DataSource).DefaultView.RowFilter = string.Format("CONVERT([{0}], System.String) LIKE '%{1}%'", CB, TB);
                    }
                }
            }
            catch (Exception ex) { LibAux.ErrorLog(ex); ((DataTable)dgvConsultaEmpleados.DataSource).DefaultView.RowFilter = ""; }
            rowCounting.Text = "Registros : " + dgvConsultaEmpleados.Rows.Count.ToString();
        }
        private int TomarDiasComboBox(ComboBox ComboBox)
        {
            switch (ComboBox.Text)
            {
                case "0 Año(s), 1 Mes(es)":
                    return 30;
                case "0 Año(s), 3 Mes(es)":
                    return 90;
                case "0 Año(s), 6 Mes(es)":
                    return 180;
                case "0 Año(s), 8 Mes(es)":
                    return 270;
                case "1 Año(s), 0 Mes(es)":
                    return 365;
                case "2 Año(s), 0 Mes(es)":
                    return 730;
                case "3 Año(s), 0 Mes(es)":
                    return 1095;
                case "4 Año(s), 0 Mes(es)":
                    return 1460;
                case "5 Año(s), 0 Mes(es)":
                    return 1920;
                case "99 Año(s), 0 Mes(es)":
                    return 999999;
                case "0 Año(s), 0 Mes(es)":
                    return 0;
                default:
                    return 0;
            }
        }
        public void esVisibleFiltroAntiguedad(bool @bool)
        {   
            ChBFechaFiltro.Visible = @bool;
            dtpFechaFiltro.Visible = @bool;
            lblMax.Visible = @bool;
            lblMin.Visible = @bool;
            cbInicio.Visible = @bool;
            cbFinal.Visible = @bool;
            tbFiltro.Enabled = !@bool;
        }

        public void esVisibleFiltroFechas(bool @bool)
        {
            lblFechaLabel.Visible = @bool;
            dtpInicio.Visible = @bool;
            dtpFin.Visible = @bool;         
        }
        #endregion
        #region EVENTOS        
        private void vConsulta_Load(object sender, EventArgs e)
        {
            CargarEmpleadosActivos();
            CargarColumnas();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnRecarga_Click(object sender, EventArgs e)
        {
            CargarEmpleadosActivos();
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            List<DataGridViewColumn> columns = new List<DataGridViewColumn>();
            foreach (DataGridViewColumn item in dgvConsultaEmpleados.Columns)
            {
                string id = item.HeaderText.Substring(0, 2);
                if (id != "id")
                {
                    if (!item.HeaderText.Contains("Activos"))
                    {
                        if (!item.HeaderText.Contains("."))
                        {
                            columns.Add(item);
                        }
                    }
                }
            }
            frmColumnasExportarEmpleados frmExcel = new frmColumnasExportarEmpleados();
            // Verificar si el diálogo fue cerrado o cancelado
            if (frmExcel.ShowDialog() == DialogResult.OK)
            {
                LibAux.ExportarAExcel(LibAux.DgvToDataTable(dgvConsultaEmpleados, frmExcel.ColumnasAExportar));
            }
        }
        private void tbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarInformacion();
        }
        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFiltro.Enabled = true;
            // -- ANTIGUEDAD --
            if (cbFiltro.Text == "Antiguedad")
            {
                esVisibleFiltroAntiguedad(true);
            }
            else
            {
                esVisibleFiltroAntiguedad(false);
            }

            // -- FILTRO NUEVO, EMPLADOS ACTIVOS POR FECHAS -- 20 ENERO

            if (cbFiltro.Text == "Empleados activos por fechas")
            {
                dtEmpledosActivos = MEmpleados.ObtenerEmpleadosActivosReporteSinBajas(dtpInicio.Value,dtpFin.Value);
                CalcularAntiguedad();
                dgvConsultaEmpleados.DataSource = dtEmpledosActivos;
                esVisibleFiltroFechas(true);
            }
            else
            {
                dtEmpledosActivos = MEmpleados.ObtenerEmpleadosActivosReporte();
                CalcularAntiguedad();
                dgvConsultaEmpleados.DataSource = dtEmpledosActivos;

                esVisibleFiltroFechas(false);

                // esVisibleFiltroAntiguedad(false);
            }



            if (cbFiltro.Text == "Empleados de Temporada")
            {
                tbFiltro.Enabled = false;
                string CB = "esEmpleadoTemp";
                string TB = "SI";
                ((DataTable)dgvConsultaEmpleados.DataSource).DefaultView.RowFilter = string.Format("CONVERT([{0}], System.String) LIKE '%{1}%'", CB, TB);
            }
            CalcularAntiguedad(); // CALCULA LA ANTIGUEDAD EN UN HILO APARTE
            rowCounting.Text = "Registros : " + dgvConsultaEmpleados.Rows.Count.ToString();
        }
        private void ChBFechaFiltro_CheckedChanged(object sender, EventArgs e)
        {
            //Tomar la fecha de hoy...
            if (ChBFechaFiltro.Checked)
            {
                dtpFechaFiltro.Value = DateTime.Now;
                dtpFechaFiltro.Enabled = false;
            }
            else
            {
                dtpFechaFiltro.Enabled = true;
            }
        }
        private void cbInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarInformacion();
        }
        private void cbFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarInformacion();
        }
        private void dtpFechaFiltro_ValueChanged(object sender, EventArgs e)
        {
            CargarEmpleadosActivos();
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {

            dtEmpledosActivos = MEmpleados.ObtenerEmpleadosActivosReporteSinBajas(dtpInicio.Value, dtpFin.Value);
            CalcularAntiguedad();
            dgvConsultaEmpleados.DataSource = dtEmpledosActivos;
            rowCounting.Text = "Registros : " + dgvConsultaEmpleados.Rows.Count.ToString();

            //FiltrarInformacion();
        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {
            dtEmpledosActivos = MEmpleados.ObtenerEmpleadosActivosReporteSinBajas(dtpInicio.Value, dtpFin.Value);
            CalcularAntiguedad();
            dgvConsultaEmpleados.DataSource = dtEmpledosActivos;
            rowCounting.Text = "Registros : " + dgvConsultaEmpleados.Rows.Count.ToString();

            //FiltrarInformacion();
        }

        private void dgvConsultaEmpleados_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
        }

        private void dgvConsultaEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idEmpleado = Convert.ToInt32(dgvConsultaEmpleados.CurrentRow.Cells["dgvConsultaEmpleados_idEmpleado"].Value);
            idPersona = Convert.ToInt32(dgvConsultaEmpleados.CurrentRow.Cells["dgvConsultaEmpleados_idPersona"].Value);
            MostrarInformacionEmpleado(EventArgs.Empty);
        }
        public virtual void MostrarInformacionEmpleado(EventArgs e)
        {
            DobleClickEmpleado?.Invoke(this, e);
        }
        #endregion
    }
}
