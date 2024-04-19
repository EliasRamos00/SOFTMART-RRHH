using SOFTMART_RRHH.Controlador;
using SOFTMART_RRHH.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace SOFTMART_RRHH.Vista
{
    public partial class vTodos : UserControl
    {
        #region VARIABLES GLOBALES
        public int idEmpleado { get; private set; }
        public int idPersona { get; private set; }
        public event EventHandler DobleClickEmpleado;
        #endregion
        #region CONSTRUCTORES
        public vTodos()
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
        public virtual void MostrarInformacionEmpleado(EventArgs e)
        {
            DobleClickEmpleado?.Invoke(this, e);
        }
        private void LlenarGrid()
        {
            dgvConsultaEmpleados.DataSource = MEmpleados.ObtenerEmpleadosReporte();
        }
        private void CargarColumnas()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

            foreach (DataGridViewColumn col in dgvConsultaEmpleados.Columns)
            {
                if (col.HeaderText == "Nombre" || col.HeaderText == "NumContrato" || col.HeaderText == "Sucursal" || col.HeaderText == "Puesto" || col.HeaderText == "Edad")
                    keyValuePairs.Add(col.Name, col.HeaderText);

            }
            cbFiltro.DataSource = keyValuePairs.ToList();
            cbFiltro.DisplayMember = "Value";
            cbFiltro.ValueMember = "Key";
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            List<DataGridViewColumn> columns = new List<DataGridViewColumn>();
            foreach (DataGridViewColumn item in dgvConsultaEmpleados.Columns)
            {
                if (!item.HeaderText.Contains("id"))
                {
                    columns.Add(item);
                }
            }
            frmExcelCheckList frmExcel = new frmExcelCheckList(columns);
            // Verificar si el diálogo fue cerrado o cancelado
            if (frmExcel.ShowDialog() == DialogResult.OK)
            {
                LibAux.ExportarAExcel(LibAux.DgvToDataTable(dgvConsultaEmpleados, frmExcel.ColumnasAExportar));
            }
        }
        #endregion
        #region EVENTOS   
        private void vTodos_Load(object sender, EventArgs e)
        {
            LlenarGrid();
            CargarColumnas();
        }
        private void tbFiltro_TextChanged(object sender, EventArgs e)
        {
            string CB = cbFiltro.Text.ToString();
            string TB = tbFiltro.Text.ToString();
            try
            {
                if (cbFiltro.SelectedIndex >= 0)
                {
                    ((DataTable)dgvConsultaEmpleados.DataSource).DefaultView.RowFilter = string.Format("CONVERT([{0}], System.String) LIKE '%{1}%'", CB, TB);

                }
            }
            catch { ((DataTable)dgvConsultaEmpleados.DataSource).DefaultView.RowFilter = ""; }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnRecarga_Click(object sender, EventArgs e)
        {
            LlenarGrid();
        }
        private void dgvConsultaEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idEmpleado = Convert.ToInt32(dgvConsultaEmpleados.CurrentRow.Cells["dgvConsultaEmpleados_idEmpleado"].Value);
            idPersona = Convert.ToInt32(dgvConsultaEmpleados.CurrentRow.Cells["dgvConsultaEmpleados_idPersona"].Value);
            MostrarInformacionEmpleado(EventArgs.Empty);
        }
        #endregion
    }
}
