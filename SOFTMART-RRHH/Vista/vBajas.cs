
using NPOI.SS.Formula.Functions;
using SOFTMART_RRHH.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Threading;

namespace SOFTMART_RRHH.Vista
{
    public partial class vBajas : System.Windows.Forms.UserControl
    {
        #region VARIABLES GLOBALES
        public DataTable info = new DataTable();
        #endregion
        #region CONSTRUCTORES
        public vBajas()
        {
            InitializeComponent();
            CargarCBFiltro();
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            dgvBajasEmpleados, new object[] { true });
        }
        #endregion
        #region MÉTODOS
        /// <summary>
        /// Método que calcula la diferencia en dos fechas. (resta dia por dia y hace conteo)
        /// </summary>
        /// <param name="FechaIni"></param>
        /// <param name="FechaFin"></param>
        /// <returns></returns>
        private void CalcularDiferencia()
        {
            DataRow RenglonSiguiente = info.NewRow();
            foreach (DataRow dr in info.Rows)
            {

                if (dr["isBeingCalculated"].ToString() == "0")
                {
                    dr["isBeingCalculated"] = "1";
                    RenglonSiguiente = dr;
                    break;
                }
            }

            if (RenglonSiguiente["FechaTermino"].ToString() == "")
            {
                return;
            }

            ////// CALCULA TIEMPO DE BAJA.
            DateTime FechaIni = Convert.ToDateTime(RenglonSiguiente["FechaTermino"].ToString());
            DateTime FechaFin = DateTime.Now;

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
            string result = anios.ToString() + " Año(s)" +
                                ", " + meses.ToString() + " Mes(es)" +
                                ", " + dias.ToString() + " Dia(s)";
            RenglonSiguiente["TiempoBaja"] = result;

            ///// CALCULA TIEMPO TRABAJADO.
            FechaIni = Convert.ToDateTime(RenglonSiguiente["FechaInicio"].ToString());
            FechaFin = Convert.ToDateTime(RenglonSiguiente["FechaTermino"].ToString());
            MesAnter = FechaFin.Month;
            while (MesAnter == FechaFin.Month)
            {
                FechaIni = FechaIni.AddDays(-1);
                FechaFin = FechaFin.AddDays(-1);
            }
            anios = 0;
            meses = 0;
            dias = 0;
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
            result = anios.ToString() + " Año(s)" +
                                ", " + meses.ToString() + " Mes(es)" +
                                ", " + dias.ToString() + " Dia(s)";
            RenglonSiguiente["TiempoTrabajado"] = result;
        }
        private async void CargarPersonasDadasBajas()
        {
            frmCarga carga = new frmCarga();
            carga.Show();
            btnRecarga.Enabled = false;
            info = MBajas.ObtenerPersonasDadasBaja();
            //Se crea una columna nueva para los calculos.
            DataColumn dataColumn = new DataColumn();
            dataColumn.ColumnName = "isBeingCalculated";
            dataColumn.DefaultValue = 0;
            info.Columns.Add(dataColumn);

            await Task.Run(() => CalcularTiempos());
            dgvBajasEmpleados.DataSource = info;
            DateTime fechaInicio, fechaTermino;

            foreach (DataGridViewRow row in dgvBajasEmpleados.Rows)
            {
                try { fechaInicio = Convert.ToDateTime(row.Cells["dgvBajasEmpleados_Inicio"].Value); } catch { }
                try { fechaTermino = Convert.ToDateTime(row.Cells["dgvBajasEmpleados_Termino"].Value); } catch { }
            }

            carga.Hide();
            btnRecarga.Enabled = true;
            rowCounting.Text = "Registros : " + dgvBajasEmpleados.Rows.Count.ToString();
        }
        private void CalcularTiempos()
        {
            try
            {
                for (int i = 0; i < info.Rows.Count / 3; i++)
                {
                    Thread Hilo1 = new Thread(CalcularDiferencia);
                    Hilo1.IsBackground = true;
                    Hilo1.Start();
                    Hilo1.Join();

                    Thread Hilo2 = new Thread(CalcularDiferencia);
                    Hilo2.IsBackground = true;
                    Hilo2.Start();
                    Hilo2.Join();

                    Thread Hilo3 = new Thread(CalcularDiferencia);
                    Hilo3.IsBackground = true;
                    Hilo3.Start();
                    Hilo3.Join();

                    Thread Hilo4 = new Thread(CalcularDiferencia);
                    Hilo4.IsBackground = true;
                    Hilo4.Start();
                    Hilo4.Join();

                }
            }
            catch { }
        }
        private void CargarCBFiltro()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

            foreach (DataGridViewColumn col in dgvBajasEmpleados.Columns)
            {
                if (col.HeaderText == "Nombre" || col.HeaderText == "Tienda" || col.HeaderText == "Patron" || col.HeaderText == "Finiquito" || col.HeaderText == "Comentarios")
                    keyValuePairs.Add(col.Name, col.HeaderText);
            }
            cbFiltro.DataSource = keyValuePairs.ToList();
            cbFiltro.DisplayMember = "Value";
            cbFiltro.ValueMember = "Key";
        }
        #endregion
        #region EVENTOS
        private void vBajas_Load(object sender, EventArgs e)
        {
            CargarPersonasDadasBajas();

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnRecarga_Click(object sender, EventArgs e)
        {
            CargarPersonasDadasBajas();

        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            List<DataGridViewColumn> columns = new List<DataGridViewColumn>();
            foreach (DataGridViewColumn item in dgvBajasEmpleados.Columns)
            {
                if (!item.HeaderText.Contains("id"))
                {
                    columns.Add(item);
                }

            }
            frmExcelCheckList frmExcel = new frmExcelCheckList(columns);

            if (frmExcel.ShowDialog() == DialogResult.OK)
            {
                LibAux.ExportarAExcel(LibAux.DgvToDataTable(dgvBajasEmpleados, frmExcel.ColumnasAExportar));
            }
        }
        private void tbFiltro_TextChanged(object sender, EventArgs e)
        {
            string CB = cbFiltro.Text.ToString();
            string TB = tbFiltro.Text.ToString();
            try
            {
                if (cbFiltro.SelectedIndex >= 0)
                {
                    ((DataTable)dgvBajasEmpleados.DataSource).DefaultView.RowFilter = string.Format("CONVERT([{0}], System.String) LIKE '%{1}%'", CB, TB);

                }
            }
            catch { ((DataTable)dgvBajasEmpleados.DataSource).DefaultView.RowFilter = ""; }
            rowCounting.Text = "Registros : " + dgvBajasEmpleados.Rows.Count.ToString();
        }
        #endregion

    }
}
