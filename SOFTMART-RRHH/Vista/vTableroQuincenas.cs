using SOFTMART_RRHH.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFTMART_RRHH.Vista
{
    public partial class vTableroQuincenas : UserControl
    {
        #region VARIABLES GLOBALES
        public DataTable sueldos = new DataTable();
        #endregion

        #region CONSTRUCTORES
        public vTableroQuincenas()
        {
            InitializeComponent();
            CargarSueldos();

        }
        #endregion

        #region MÉTODOS
        private async void CargarSueldos()
        {
            dgvSueldos.AutoGenerateColumns = false;
            dgvSueldos.Columns["Nombre"].DataPropertyName = "Nombre";
            dgvSueldos.Columns["Fiscal1"].DataPropertyName = "SueldoFiscal";
            dgvSueldos.Columns["Bonificacion1"].DataPropertyName = "SueldoBonificacion";
            dgvSueldos.Columns["Total1"].DataPropertyName = "SueldoTotal";
            sueldos = MSueldos.ObtenerSueldosEmpleados();
            dgvSueldos.DataSource = sueldos;
        }
     

        #endregion
    }
}
