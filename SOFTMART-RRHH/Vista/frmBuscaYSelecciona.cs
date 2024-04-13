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
    public partial class frmBuscaYSelecciona : Form
    {
        public string idSeleccionado = "0";
        public string nombre = "";
        public frmBuscaYSelecciona(DataTable dtSource)
        {
            InitializeComponent();
            dgvBuscar.DataSource = dtSource;
            dgvBuscar.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvBuscar.Columns["id"].Visible = false;
        }

        private void dgvBuscar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSeleccionado = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells["id"].Value.ToString();
            nombre = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[1].Value.ToString();
            this.Hide();
        }
    }
}
