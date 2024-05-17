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
        string EdoCivilAnterior;
        public vAjustes()
        {
            InitializeComponent();
        }
        private void vAjustes_Load(object sender, EventArgs e)
        {
            CargarPuestos();
            CargarEdosCiviles();
            CargarEscolaridades();
            CargarSucursales();
        }


        #region CRUD - PUESTOS
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
        #endregion

        #region CRUD - ESTADO CIVIL
        private void CargarEdosCiviles()
        {
            dgvEdosCiviles.DataSource = MEstadosCiviles.ObtenerEdosCivilesAjustes();
        }
        private void btnGuardarEdoCiv_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvEdosCiviles.Rows)
            {
                try
                {
                    object EdoCivil = row.Cells["dgvEdosCiviles_EstadoCivil"].Value;

                    if (Convert.ToInt16(row.Cells["dgvEdosCiviles_hasChanged"].Value) == 1) // MODIFICADO
                    {
                        MEstadosCiviles.ActualizarEdoCivil(EdoCivilAnterior, EdoCivil);
                        LibAux.PopUp("¡Éxito!", "El Estado Civil ha sido actualizado con éxito.", LibAux.TipoNotif.Success);
                    }
                    if (Convert.ToInt16(row.Cells["dgvEdosCiviles_hasChanged"].Value) == 2) //INSERTADO
                    {
                        MEstadosCiviles.InsertarEstadoCivil(EdoCivil);
                        LibAux.PopUp("¡Éxito!", "El puesto ha sido agregado con éxito.", LibAux.TipoNotif.Success);
                    }
                }
                catch (Exception ex)
                {
                    LibAux.PopUp("Error", "Hubo un error al intentar actualizar/agregar el estado civil: " + row.Cells["dgvEdosCiviles_EstadoCivil"].Value.ToString() + ex.Message, LibAux.TipoNotif.Error);
                    LibAux.ErrorLog(ex);
                }
            }
            CargarEdosCiviles();
        }
        private void dgvEdosCiviles_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt16(dgvEdosCiviles.Rows[dgvEdosCiviles.CurrentCell.RowIndex].Cells["dgvEdosCiviles_hasChanged"].Value) == 0)
            {
                dgvEdosCiviles.Rows[dgvEdosCiviles.CurrentCell.RowIndex].Cells["dgvEdosCiviles_hasChanged"].Value = 1;
            }
        }
        private void btnEliminarEdosCiviles_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro de eliminar este estado civil?", "¡Alto!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    object EdoCivil = dgvEdosCiviles.CurrentRow.Cells["dgvEdosCiviles_EstadoCivil"].Value.ToString();
                    MEstadosCiviles.EliminarEdoCivil(EdoCivil);
                    LibAux.PopUp("¡Éxito!", "El estado civil ha sido eliminado con éxito.", LibAux.TipoNotif.Success);
                }
                catch (Exception ex)
                {
                    LibAux.PopUp("Error", "Ocurrió un error al intentar eliminar este estado civil.", LibAux.TipoNotif.Error);
                    LibAux.ErrorLog(ex);
                }
                CargarEdosCiviles();
            }
        }
        private void btnAgregarEdoCivil_Click(object sender, EventArgs e)
        {
            DataTable dt = dgvEdosCiviles.DataSource as DataTable;
            DataRow newRow;
            newRow = dt.NewRow();
            newRow["hasChanged"] = 2;
            dt.Rows.Add(newRow);
        }
        private void btnRefreshEdoCiviles_Click(object sender, EventArgs e)
        {
            CargarEdosCiviles();
        }
        private void dgvEdosCiviles_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            EdoCivilAnterior = dgvEdosCiviles.CurrentRow.Cells["dgvEdosCiviles_EstadoCivil"].Value.ToString();
        }
        #endregion

        #region CRUD - ESCOLARIDADES
        private void CargarEscolaridades()
        {
            dgvEscolaridades.DataSource = MEscolaridades.ObtenerEscolaridadesAjustes();
        }
        private void dgvEscolaridades_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt16(dgvEscolaridades.Rows[dgvEscolaridades.CurrentCell.RowIndex].Cells["dgvEscolaridades_hasChanged"].Value) == 0)
            {
                dgvEscolaridades.Rows[dgvEscolaridades.CurrentCell.RowIndex].Cells["dgvEscolaridades_hasChanged"].Value = 1;
            }

        }
        private void btnRefreshEscola_Click(object sender, EventArgs e)
        {
            CargarEscolaridades();
        }
        private void btnGuardarEscola_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvEscolaridades.Rows)
            {
                try
                {
                    object idEscolaridad = row.Cells["dgvEscolaridades_idEscolaridad"].Value;
                    object Escolaridad = row.Cells["dgvEscolaridades_Escolaridad"].Value;

                    if (Convert.ToInt16(row.Cells["dgvEscolaridades_hasChanged"].Value) == 1) // MODIFICADO
                    {
                        MEscolaridades.ActualizarEscolaridad(idEscolaridad, Escolaridad);
                        LibAux.PopUp("¡Éxito!", "La escolaridad ha sido actualizado con éxito.", LibAux.TipoNotif.Success);
                    }
                    if (Convert.ToInt16(row.Cells["dgvEscolaridades_hasChanged"].Value) == 2) //INSERTADO
                    {
                        MEscolaridades.InsertarEscolaridad(Escolaridad);
                        LibAux.PopUp("¡Éxito!", "La escolaridad ha sido agregado con éxito.", LibAux.TipoNotif.Success);
                    }
                }
                catch (Exception ex)
                {
                    LibAux.PopUp("Error", "Hubo un error al intentar actualizar/agregar la escolaridad: " + row.Cells["dgvEscolaridades_Escolaridad"].Value.ToString() + ex.Message, LibAux.TipoNotif.Error);
                    LibAux.ErrorLog(ex);
                }
            }
        }
        private void btnEliminarEscola_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro de eliminar esta escolaridad?", "¡Alto!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    object idEscolaridad = dgvEscolaridades.CurrentRow.Cells["dgvEscolaridades_idEscolaridad"].Value.ToString();
                    MEscolaridades.EliminarEscolaridad(idEscolaridad);

                    LibAux.PopUp("¡Éxito!", "La escolaridad ha sido eliminada con éxito.", LibAux.TipoNotif.Success);
                }
                catch (Exception ex)
                {
                    LibAux.PopUp("Error", "Ocurrió un error al intentar eliminar esta escolaridad.", LibAux.TipoNotif.Error);
                    LibAux.ErrorLog(ex);
                }
                CargarEscolaridades();
            }
        }
        private void btnAgregarEscola_Click(object sender, EventArgs e)
        {
            DataTable dt = dgvEscolaridades.DataSource as DataTable;
            DataRow newRow;
            newRow = dt.NewRow();
            newRow["hasChanged"] = 2;
            dt.Rows.Add(newRow);
        }
        #endregion

        #region CRUD - SUCURSALES        
        private void CargarSucursales()
        {
            dgvTiendas.DataSource = MSucursales.ObtenerSucursalesAjustes();
        }
        private void dgvTiendas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt16(dgvTiendas.Rows[dgvTiendas.CurrentCell.RowIndex].Cells["dgvTiendas_hasChanged"].Value) == 0)
            {
                dgvTiendas.Rows[dgvTiendas.CurrentCell.RowIndex].Cells["dgvTiendas_hasChanged"].Value = 1;
            }
        }
        private void btnRefreshSucursales_Click(object sender, EventArgs e)
        {
            CargarSucursales();
        }
        private void btnGuardarSucursales_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgvTiendas.Rows)
            {
                try
                {
                    if (Convert.ToInt16(row.Cells["dgvTiendas_hasChanged"].Value) == 1) // MODIFICADO
                    {
                        object idSucursal = row.Cells["dgvTiendas_idSucursal"].Value;
                        object Sucursal = row.Cells["dgvTiendas_Sucursal"].Value;

                        MSucursales.ActualizarSucursal(idSucursal, Sucursal);

                        LibAux.PopUp("¡Éxito!", "La sucursal ha sido actualizada con éxito.", LibAux.TipoNotif.Success);
                    }
                    if (Convert.ToInt16(row.Cells["dgvTiendas_hasChanged"].Value) == 2) //INSERTADO
                    {
                        object Sucursal = row.Cells["dgvTiendas_Sucursal"].Value;

                        MSucursales.InsertarSucursal(Sucursal);
                        LibAux.PopUp("¡Éxito!", "La sucursal ha sido agregada con éxito.", LibAux.TipoNotif.Success);
                    }
                }
                catch (Exception ex)
                {
                    LibAux.PopUp("Error", "Hubo un error al intentar actualizar/agregar la sucursal: " + row.Cells["dgvTiendas_Sucursal"].Value.ToString() + ex.Message, LibAux.TipoNotif.Error);
                    LibAux.ErrorLog(ex);
                }
            }
            CargarSucursales();
        }
        private void btnBorrarSucursal_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro de eliminar esta sucursal?", "¡Alto!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    int idSucursal = Convert.ToInt16(dgvTiendas.CurrentRow.Cells["dgvTiendas_idSucursal"].Value);
                    MSucursales.EliminarSucursal(idSucursal);
                    LibAux.PopUp("¡Éxito!", "La sucursal ha sido eliminada con éxito.", LibAux.TipoNotif.Success);
                }
                catch (Exception ex)
                {
                    LibAux.PopUp("Error", "Ocurrió un error al intentar eliminar esta sucursal.", LibAux.TipoNotif.Error);
                    LibAux.ErrorLog(ex);
                }
                CargarSucursales();
            }
        }
        private void btnAgregarSucursal_Click(object sender, EventArgs e)
        {
            DataTable dt = dgvTiendas.DataSource as DataTable;
            DataRow newRow;
            newRow = dt.NewRow();
            newRow["hasChanged"] = 2;
            dt.Rows.Add(newRow);
        }
        #endregion
    }
}
