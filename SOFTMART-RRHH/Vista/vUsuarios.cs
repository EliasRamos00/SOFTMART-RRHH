using NPOI.SS.Formula.Functions;
using SOFTMART_RRHH.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace SOFTMART_RRHH.Vista
{
    public partial class vUsuarios : System.Windows.Forms.UserControl
    {
        int idPersona = 0;
        string nombre = "";
        string oldPass = "";

        public vUsuarios()
        {
            InitializeComponent();
        }

        private void vUsuarios_Load(object sender, EventArgs e)
        {
            dgvUsuarios_Nombre.ReadOnly = true;
            dgvUsuarios_RolCB.DataSource = MRoles.ConsultarRoles();
            dgvUsuarios_RolCB.ValueMember = "Rol";
            dgvUsuarios_RolCB.DisplayMember = "Rol";
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = MUsuarios.ObtenerUsuarios();
        }

        private void dgvUsuarios_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt16(dgvUsuarios.Rows[dgvUsuarios.CurrentCell.RowIndex].Cells["dgvUsuarios_hasChanged"].Value) == 0)
            {
                dgvUsuarios.Rows[dgvUsuarios.CurrentCell.RowIndex].Cells["dgvUsuarios_hasChanged"].Value = 1;
            }

        }

        private void dgvUsuarios_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvUsuarios.Rows)
            {
                try
                {
                    if (Convert.ToInt16(row.Cells["dgvUsuarios_hasChanged"].Value) == 1) // MODIFICADO
                    {
                        object idUsuario = row.Cells["dgvUsuarios_idUsuario"].Value;
                        object usuario = row.Cells["dgvUsuarios_Usuario"].Value;
                        object rol = row.Cells["dgvUsuarios_rol"].Value;
                        object idPersona = row.Cells["dgvUsuarios_idPersona"].Value;
                        object password = row.Cells["dgvUsuarios_password"].Value.ToString();

                        if (!LibAux.IsMD5(row.Cells["dgvUsuarios_password"].Value.ToString()))
                        {
                            password = LibAux.GenerateMD5(row.Cells["dgvUsuarios_password"].Value.ToString());
                        }
                        MUsuarios.ActualizarUsuario(usuario, password, rol, idPersona, idUsuario);
                        LibAux.PopUp("¡Éxito!", "El usuario ha sido actualizado con éxito.", LibAux.TipoNotif.Success);
                    }
                    if (Convert.ToInt16(row.Cells["dgvUsuarios_hasChanged"].Value) == 2) //INSERTADO
                    {
                        object usuario = row.Cells["dgvUsuarios_Usuario"].Value;
                        object rol = row.Cells["dgvUsuarios_rol"].Value;
                        object idPersona = row.Cells["dgvUsuarios_idPersona"].Value;
                        object password = LibAux.GenerateMD5(row.Cells["dgvUsuarios_password"].Value.ToString());

                        MUsuarios.AgregarUsuario(usuario, password, rol, idPersona);
                        LibAux.PopUp("¡Éxito!", "El usuario ha sido agregado con éxito.", LibAux.TipoNotif.Success);
                    }
                }
                catch (Exception ex)
                {
                    LibAux.PopUp("Error", "Hubo un error al intentar actualizar/agregar al usuario: " + row.Cells["dgvUsuarios_Usuario"].Value.ToString() + ex.Message, LibAux.TipoNotif.Error);
                    LibAux.ErrorLog(ex);
                }
            }
            CargarUsuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro de eliminar este usuario?", "¡Alto!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    int idUsuario = Convert.ToInt16(dgvUsuarios.CurrentRow.Cells["dgvUsuarios_idUsuario"].Value);
                    MUsuarios.EliminarUsuario(idUsuario);
                    LibAux.PopUp("¡Éxito!", "El usuario ha sido eliminado con éxito.", LibAux.TipoNotif.Success);
                }
                catch (Exception ex)
                {
                    LibAux.PopUp("Error", "Ocurrió un error al intentar eliminar este usuario.", LibAux.TipoNotif.Error);
                    LibAux.ErrorLog(ex);
                }
                CargarUsuarios();
            }
        }

        private void dgvUsuarios_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldPass = dgvUsuarios.CurrentRow.Cells["dgvUsuarios_password"].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataTable dt = dgvUsuarios.DataSource as DataTable;
            DataRow newRow;
            newRow = dt.NewRow();
            newRow["hasChanged"] = 2;
            dt.Rows.Add(newRow);

        }

        private void btnRecarga_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvUsuarios.Columns["dgvUsuarios_Nombre"].Index)
            {
                if (dgvUsuarios.CurrentRow.Cells["dgvUsuarios_hasChanged"].Value.ToString() == "2")
                {
                    int idPersona = 0;
                    string nombre = "";

                    frmBuscaYSelecciona frmBusca = new frmBuscaYSelecciona(MRoles.ConsultarPerAdmin());
                    frmBusca.ShowDialog();
                    idPersona = Convert.ToInt16(frmBusca.idSeleccionado);
                    nombre = frmBusca.nombre.ToString();

                    if (idPersona != 0)
                    {
                        dgvUsuarios.CurrentRow.Cells["dgvUsuarios_idPersona"].Value = idPersona;
                        dgvUsuarios_CellEndEdit(sender, e);
                    }
                    if (nombre != "")
                    {
                        dgvUsuarios.CurrentRow.Cells["dgvUsuarios_Nombre"].Value = nombre;
                        dgvUsuarios_CellEndEdit(sender, e);
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
