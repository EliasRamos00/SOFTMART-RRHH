using SOFTMART_RRHH.Controlador;
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
    public partial class vAjustes : UserControl
    {
        public vAjustes()
        {
            InitializeComponent();
        }

        private void vAjustes_Load(object sender, EventArgs e)
        {
            CargarPuestos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataTable dt = dgvPuestos.DataSource as DataTable;
            DataRow newRow;
            newRow = dt.NewRow();
            newRow["hasChanged"] = 2;
            dt.Rows.Add(newRow);
        }

        private void btnRecarga_Click(object sender, EventArgs e)
        {
            CargarPuestos();
        }

        private void dgvPuestos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt16(dgvPuestos.Rows[dgvPuestos.CurrentCell.RowIndex].Cells["dgvPuestos_hasChanged"].Value) == 0)
            {
                dgvPuestos.Rows[dgvPuestos.CurrentCell.RowIndex].Cells["dgvPuestos_hasChanged"].Value = 1;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgvPuestos.Rows)
            {
                try
                {
                    if (Convert.ToInt16(row.Cells["dgvPuestos_hasChanged"].Value) == 1) // MODIFICADO
                    {
                        object idPuesto = row.Cells["dgvPuestos_idPuesto"].Value;
                        object Area = row.Cells["dgvPuestos_Area"].Value;
                        object SubArea = row.Cells["dgvPuestos_Subarea"].Value;
                        object Puesto = row.Cells["dgvPuestos_Puesto"].Value;

                        MPuestos.ActualizarPuesto(idPuesto, Area, SubArea, Puesto);
                        LibAux.PopUp("¡Éxito!", "El puesto ha sido actualizado con éxito.", LibAux.TipoNotif.Success);
                    }
                    if (Convert.ToInt16(row.Cells["dgvPuestos_hasChanged"].Value) == 2) //INSERTADO
                    {
                        object Area = row.Cells["dgvPuestos_Area"].Value;
                        object SubArea = row.Cells["dgvPuestos_Subarea"].Value;
                        object Puesto = row.Cells["dgvPuestos_Puesto"].Value;

                        MPuestos.AgregarPuesto(Area, SubArea, Puesto);
                        LibAux.PopUp("¡Éxito!", "El puesto ha sido agregado con éxito.", LibAux.TipoNotif.Success);
                    }
                }
                catch (Exception ex)
                {
                    LibAux.PopUp("Error", "Hubo un error al intentar actualizar/agregar al puesto: " + row.Cells["dgvPuestos_Puesto"].Value.ToString() + ex.Message, LibAux.TipoNotif.Error);
                    LibAux.ErrorLog(ex);
                }
            }
            CargarPuestos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro de eliminar este puesto?", "¡Alto!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    int idPuesto = Convert.ToInt16(dgvPuestos.CurrentRow.Cells["dgvPuestos_idPuesto"].Value);
                    MPuestos.EliminarPuesto(idPuesto);
                    LibAux.PopUp("¡Éxito!", "El puesto ha sido eliminado con éxito.", LibAux.TipoNotif.Success);
                }
                catch (Exception ex)
                {
                    LibAux.PopUp("Error", "Ocurrió un error al intentar eliminar este usuario.", LibAux.TipoNotif.Error);
                    LibAux.ErrorLog(ex);
                }
                CargarPuestos();
            }
        }

        private void CargarPuestos()
        {
            dgvPuestos.DataSource = MPuestos.ObtenerTodosPuestos();
        }



    }
}
