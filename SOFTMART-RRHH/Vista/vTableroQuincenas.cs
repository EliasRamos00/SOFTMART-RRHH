using SOFTMART_RRHH.Controlador;
using SOFTMART_RRHH.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
            //Set Double buffering on the Grid using reflection and the bindingflags enum.
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            dgvSueldos, new object[] { true });

            dgvSueldos.AutoGenerateColumns = false;
            // Metodo para decifrar la quincena actual y anterior
            SetQuincenaActualyAnterior();

            CargarSueldos();


        }

        private void SetQuincenaActualyAnterior()
        {
            // SE OBTIENE LA FECHA DE HOY
            DateTime hoy = DateTime.Now;
            dtpQuincenaActual.Value = hoy;

            // Si el dia de hoy es 16+ entonces es segunda quincena del mes.

            if (hoy.Day >= 16) // SEGUNDA QUINCENA
            {
                cbQuincenaActual.SelectedIndex = 1;
                cbQuincenaAnterior.SelectedIndex = 0;

                dtpQuincenaAnterior.Value = hoy; // SI ESTAMOS EN SEGUNDA QUINCENA, ENTONCES LA QUINCENA ANTERIOR ES LA PRIMERA DEL MISMO MES Y ANIO
            }
            else // ES PRIMERA QUINCENA
            {
                cbQuincenaActual.SelectedIndex = 0;
                cbQuincenaAnterior.SelectedIndex = 1;
                dtpQuincenaAnterior.Value = hoy.AddMonths(-1); // SI ESTAMOS EN PRIMERA QUINCENA, ENTONCES LA QUINCENA ANTERIOR ES LA *SEGUNDA* DEL MES ANTERIOR


            }
        }
        #endregion

        #region MÉTODOS
        private void CargarSueldos()
        {
            try
            {
                int currentScrollPosition = GetVerticalScrollPosition(dgvSueldos);

                sueldos = MSueldos.ObtenerSueldosEmpleados(dtpQuincenaActual.Value, dtpQuincenaAnterior.Value, cbQuincenaActual.Text, cbQuincenaAnterior.Text);
                dgvSueldos.DataSource = sueldos;

                SetVerticalScrollPosition(dgvSueldos, currentScrollPosition);
            }
            catch (Exception ex)
            {

            }


        }


        // Método para guardar la posición actual del scroll
        private int GetVerticalScrollPosition(DataGridView dgv)
        {
            return dgv.FirstDisplayedScrollingRowIndex;
        }

        // Método para restaurar la posición del scroll
        private void SetVerticalScrollPosition(DataGridView dgv, int scrollPosition)
        {
            dgv.FirstDisplayedScrollingRowIndex = scrollPosition;
        }


        #endregion

        #region Eventos
        private void btnCerrarQuincena_Click(object sender, EventArgs e)
        {

        }

        private void dgvSueldos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Verificar si estamos en una celda de la columna deseada.
            if (e.ColumnIndex == 2 && e.RowIndex >= 0) // Cambia el índice de columna según tu necesidad.
            {
                e.Handled = true; // Evitar el dibujo predeterminado de la celda.
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                using (var pen = new Pen(Color.Black, 3)) // Cambia el color y grosor del borde.
                {
                    // Dibujar la línea derecha de la celda con el grosor personalizado.
                    var x = e.CellBounds.Right - 1;
                    var y1 = e.CellBounds.Top;
                    var y2 = e.CellBounds.Bottom - 1;
                    e.Graphics.DrawLine(pen, x, y1, x, y2);
                }
            }

            if (e.ColumnIndex == 5 && e.RowIndex >= 0) // Cambia el índice de columna según tu necesidad.
            {
                e.Handled = true; // Evitar el dibujo predeterminado de la celda.
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                using (var pen = new Pen(Color.Black, 3)) // Cambia el color y grosor del borde.
                {
                    // Dibujar la línea derecha de la celda con el grosor personalizado.
                    var x = e.CellBounds.Right - 1;
                    var y1 = e.CellBounds.Top;
                    var y2 = e.CellBounds.Bottom - 1;
                    e.Graphics.DrawLine(pen, x, y1, x, y2);
                }
            }

            if (e.ColumnIndex == 8 && e.RowIndex >= 0) // Cambia el índice de columna según tu necesidad.
            {
                e.Handled = true; // Evitar el dibujo predeterminado de la celda.
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                using (var pen = new Pen(Color.Black, 3)) // Cambia el color y grosor del borde.
                {
                    // Dibujar la línea derecha de la celda con el grosor personalizado.
                    var x = e.CellBounds.Right - 1;
                    var y1 = e.CellBounds.Top;
                    var y2 = e.CellBounds.Bottom - 1;
                    e.Graphics.DrawLine(pen, x, y1, x, y2);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarSueldos();
        }

        private void dgvSueldos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSueldos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Comprobar que la celda que estamos editando es una de las columnas correctas
            if (e.ColumnIndex == dgvSueldos_Fiscal2.Index || e.ColumnIndex == dgvSueldos_Bonificacion2.Index || e.ColumnIndex == dgvSueldos_Fiscal1.Index || e.ColumnIndex == dgvSueldos_Bonificacion1.Index)
            {
                // Obtener la fecha seleccionada del DateTimePicker y el valor de la quincena seleccionada en el ComboBox

                DateTime quincenaSeleccionada = dtpQuincenaActual.Value;
                string quincenaSeleccionadaText = cbQuincenaActual.Text.ToLower();

                if (e.ColumnIndex == dgvSueldos_Fiscal1.Index || e.ColumnIndex == dgvSueldos_Bonificacion1.Index)
                {
                    quincenaSeleccionada = dtpQuincenaAnterior.Value;
                    quincenaSeleccionadaText = cbQuincenaAnterior.Text.ToLower();
                }


                // Verificar si la fecha seleccionada corresponde a la quincena actual o posterior
                if (quincenaSeleccionada.Month >= DateTime.Now.Month && quincenaSeleccionada.Year >= DateTime.Now.Year)
                {
                    if (quincenaSeleccionada.Year > DateTime.Now.Year)
                    {
                        return;
                    }

                    if (quincenaSeleccionada.Month == DateTime.Now.Month)
                    {
                        // Verificar que la quincena sea la correcta
                        if ((DateTime.Now.Day <= 15 && quincenaSeleccionadaText.Contains("1er")) ||
                            (DateTime.Now.Day > 15 && quincenaSeleccionadaText.Contains("2da")))
                        {
                            // Si todo es correcto, permitir la edición
                            return; // Deja que la edición continúe normalmente
                        }
                        else
                        {
                            // Si la quincena no es válida, cancelar la edición
                            e.Cancel = true;
                            MessageBox.Show("Solo puedes editar la quincena correspondiente a la fecha actual o posterior.", // CAMBIAR A POPUPS
                                            "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        return;

                    }

                }
                else
                {
                    // Si la quincena seleccionada es anterior a la actual, no permitir la edición
                    e.Cancel = true;
                    MessageBox.Show("No se puede editar un salario de una quincena pasada.",
                                    "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning); // CAMBIAR A POPUPS
                }
            }
            else
            {
                // Si la celda no es una de las que queremos editar, cancelar la edición
                e.Cancel = true;
            }
        }

        private void dgvSueldos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvSueldos.Rows[e.RowIndex].Cells[dgvSueldos_tieneCambios.Index].Value = 1;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvSueldos.Rows)
            {
                if (row.Cells[dgvSueldos_tieneCambios.Index].Value.ToString() == "1") // SI TIENE CAMBIOS SE BUSCA EL REGISTRO, SI EXISTE SE ACTUALIZA, SI NO , SE INSERTA.
                {
                    string quincena = cbQuincenaActual.Text;
                    int anio = dtpQuincenaActual.Value.Year;
                    int mes = dtpQuincenaActual.Value.Month;
                    string idEmpleado = row.Cells[dgvSueldos_idEmpleado.Index].Value.ToString();

                    decimal sueldoFiscal = Convert.ToDecimal(row.Cells[dgvSueldos_Fiscal2.Index].Value);
                    decimal sueldoBonificacion = Convert.ToDecimal(row.Cells[dgvSueldos_Bonificacion2.Index].Value);

                    try
                    {
                        if (MEmpleados.CObtenerSalarioEmpleadoByFechaQuincena(quincena, anio, mes, idEmpleado).Rows.Count > 0) // Ya tiene sueldo de esa quincena, modifica
                        {
                            MEmpleados.CModificarSalarioEmpleado(quincena, anio, mes, idEmpleado, sueldoFiscal, sueldoBonificacion);
                        }
                        else // No tiene, se inserta. 
                        {

                            MEmpleados.CInsertarSalarioEmpleado(quincena, anio, mes, idEmpleado, sueldoFiscal, sueldoBonificacion);

                        }

                    }

                    catch (Exception ex)
                    {
                    }



                }
            }
        }

        private void tbFiltroSueldos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string CB = "Nombre";
                string TB = tbFiltroSueldos.Text.ToString();
                ((DataTable)dgvSueldos.DataSource).DefaultView.RowFilter = string.Format("CONVERT([{0}], System.String) LIKE '%{1}%'", CB, TB);
            }
            catch (Exception ex)
            {
                ((DataTable)dgvSueldos.DataSource).DefaultView.RowFilter = string.Format("");

            }

        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            DataTable dtExport = new DataTable();

            // Añadir las columnas específicas
            dtExport.Columns.Add("idEmpleado", typeof(int)); // Columna con contenido
            dtExport.Columns.Add("Nombre", typeof(string));  // Columna con contenido
            dtExport.Columns.Add("SueldoFiscal", typeof(decimal)); // Columna vacía
            dtExport.Columns.Add("Bonificacion", typeof(decimal)); // Columna vacía

            // Iterar por las filas del DataGridView y añadir los datos
            foreach (DataGridViewRow row in dgvSueldos.Rows)
            {
                // Asegurarse de no incluir filas vacías
                if (!row.IsNewRow)
                {
                    // Obtener los valores de las columnas "idEmpleado" y "Nombre"
                    int idEmpleado = row.Cells["dgvSueldos_idEmpleado"]?.Value != null ? Convert.ToInt32(row.Cells["dgvSueldos_idEmpleado"].Value) : 0;
                    string nombre = row.Cells["dgvSueldos_Nombre"]?.Value?.ToString() ?? "";

                    // Crear una nueva fila con los datos de idEmpleado, Nombre y columnas vacías para SueldoFiscal y Bonificacion
                    DataRow newRow = dtExport.NewRow();
                    newRow["idEmpleado"] = idEmpleado;
                    newRow["Nombre"] = nombre;
                    newRow["SueldoFiscal"] = DBNull.Value; // Columna vacía
                    newRow["Bonificacion"] = DBNull.Value; // Columna vacía

                    // Añadir la fila al DataTable
                    dtExport.Rows.Add(newRow);
                }
            }
            LibAux.ExportarAExcel(dtExport);

        }

        private void btnImportarExcel_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                    Title = "Importar desde Excel"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    DataTable dtImport = LibAux.ImportarExcel(openFileDialog.FileName);

                    if (dtImport != null && dtImport.Rows.Count > 0)
                    {
                        foreach (DataRow importRow in dtImport.Rows)
                        {
                            int idEmpleado = importRow["idEmpleado"] != DBNull.Value ? Convert.ToInt32(importRow["idEmpleado"]) : 0;

                            foreach (DataGridViewRow dgvRow in dgvSueldos.Rows)
                            {
                                if (!dgvRow.IsNewRow && Convert.ToInt32(dgvRow.Cells["dgvSueldos_idEmpleado"].Value) == idEmpleado)
                                {
                                    decimal sueldoFiscal = 0, bonificacion = 0;

                                    bool sueldoValido = decimal.TryParse(importRow["SueldoFiscal"]?.ToString(), out sueldoFiscal);
                                    bool bonificacionValida = decimal.TryParse(importRow["Bonificacion"]?.ToString(), out bonificacion);

                                    bool sueldoCambio = sueldoValido && sueldoFiscal != Convert.ToDecimal(dgvRow.Cells["dgvSueldos_Fiscal1"].Value);
                                    bool bonificacionCambio = bonificacionValida && bonificacion != Convert.ToDecimal(dgvRow.Cells["dgvSueldos_Bonificacion1"].Value);

                                    if (sueldoCambio) dgvRow.Cells["dgvSueldos_Fiscal1"].Value = sueldoFiscal;
                                    if (bonificacionCambio) dgvRow.Cells["dgvSueldos_Bonificacion1"].Value = bonificacion;

                                    if (sueldoCambio || bonificacionCambio)
                                    {
                                        int tieneCambios = dgvRow.Cells["dgvSueldos_tieneCambios"].Value != null ? Convert.ToInt32(dgvRow.Cells["dgvSueldos_tieneCambios"].Value) : 0;
                                        dgvRow.Cells["dgvSueldos_tieneCambios"].Value = tieneCambios + 1;
                                    }

                                    break;
                                }
                            }
                        }

                        MessageBox.Show("Datos importados y actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El archivo de Excel no contiene datos válidos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("El archivo está abierto. Por favor, cierre el archivo y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        #endregion

    }
}
