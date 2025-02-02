﻿using SOFTMART_RRHH.Controlador;
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
using static SOFTMART_RRHH.Modelo.LibAux;

namespace SOFTMART_RRHH.Vista
{
    public partial class vTableroQuincenas : UserControl
    {
        #region VARIABLES GLOBALES
        public DataTable sueldos = new DataTable();
        public DateTime quincena1 = new DateTime();
        public DateTime quincena2 = new DateTime();
        private int indiceAnteriorQuincena1 = -1;
        private int indiceAnteriorQuincena2 = -1;
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
            dgvSueldos.CellFormatting += dgvSueldos_CellFormatting;



        }

        private void SetQuincenaActualyAnterior()
        {
            // SE OBTIENE LA FECHA DE HOY
            DateTime hoy = DateTime.Now;

            // Si el día es mayor a 26, se establece en 26
            if (hoy.Day > 26)
            {
                hoy = new DateTime(hoy.Year, hoy.Month, 26);
            }

            dtpQuincenaActual.Value = hoy;

            if (hoy.Day >= 16) // SEGUNDA QUINCENA
            {
                cbQuincenaActual.SelectedIndex = 1;
                cbQuincenaAnterior.SelectedIndex = 0;

                // Si estamos en segunda quincena, la anterior es la primera del mismo mes
                dtpQuincenaAnterior.Value = new DateTime(hoy.Year, hoy.Month, 1);
            }
            else // PRIMERA QUINCENA
            {
                cbQuincenaActual.SelectedIndex = 0;
                cbQuincenaAnterior.SelectedIndex = 1;

                // Si estamos en primera quincena, la anterior es la segunda quincena del mes anterior
                DateTime mesAnterior = hoy.AddMonths(-1);
                int diaSeguro = Math.Min(17, DateTime.DaysInMonth(mesAnterior.Year, mesAnterior.Month));
                dtpQuincenaAnterior.Value = new DateTime(mesAnterior.Year, mesAnterior.Month, diaSeguro);
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

        private bool VerificarCambiosSinGuardar(DataGridView dgvSueldos, DateTime quincena2, DateTimePicker dtpQuincenaActual)
        {
            foreach (DataGridViewRow fila in dgvSueldos.Rows)
            {
                if (Convert.ToInt32(fila.Cells["dgvSueldos_tieneCambios"].Value) != 0)
                {
                    DialogResult resultado = MessageBox.Show("Tienes datos sin guardar. ¿Deseas continuar?",
                                                             "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.No)
                    {
                        return false;
                    }
                    break;
                }
            }
            return true;
        }

        private void dgvSueldos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verificar si la celda pertenece a la columna "dgvSueldos_Diferencia"
            if (dgvSueldos.Columns[e.ColumnIndex].Name == "dgvSueldos_Diferencia")
            {
                // Obtener el valor de la celda
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal diferencia))
                {
                    // Asignar color según el valor
                    if (diferencia > 0)
                    {
                        //e.CellStyle.BackColor = Color.LightGreen;
                        e.CellStyle.ForeColor = Color.Green;
                    }
                    else if (diferencia < 0)
                    {
                        //e.CellStyle.BackColor = Color.LightCoral;
                        e.CellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.White;

                    }



                    
                }
            }
        }
        #endregion

        #region Eventos
        private void btnCerrarQuincena_Click(object sender, EventArgs e)
        {

            if (!VerificarCambiosSinGuardar(dgvSueldos, quincena2, dtpQuincenaActual))
            {
                return; // Sale del método si hay cambios sin guardar
            }      
            //SE DEBE PROGRAMAR CERRAR LA QUINCENA, LITERAL SOLO ES ITERAR ENTRE LOS QUE TENGAN 0 EN SUELDO BONIFICACION Y FISCAL Y PONER LO QUE YA LES EXISTE EN LA QUINCENA ANTERIOR.

            foreach (DataGridViewRow row in dgvSueldos.Rows)
            {
                if (row.IsNewRow) continue; // Evita la fila vacía al final del DGV

                // Obtener valores actuales de Fiscal2 y Bonificación2
                // Obtener valores actuales de Fiscal2 y Bonificación2
                decimal fiscal2 = row.Cells[dgvSueldos_Fiscal2.Index].Value is DBNull ? 0 : Convert.ToDecimal(row.Cells[dgvSueldos_Fiscal2.Index].Value ?? 0);
                decimal bonificacion2 = row.Cells[dgvSueldos_Bonificacion2.Index].Value is DBNull ? 0 : Convert.ToDecimal(row.Cells[dgvSueldos_Bonificacion2.Index].Value ?? 0);

                // Si ambos son 0, asignar los valores de Fiscal1 y Bonificación1
                if (fiscal2 == 0 && bonificacion2 == 0)
                {
                    row.Cells[dgvSueldos_Fiscal2.Index].Value = row.Cells[dgvSueldos_Fiscal1.Index].Value;
                    row.Cells[dgvSueldos_Bonificacion2.Index].Value = row.Cells[dgvSueldos_Bonificacion1.Index].Value;
                    row.Cells[dgvSueldos_tieneCambios.Index].Value = 1;


                }
            }

        }

        private void dgvSueldos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Verificar si estamos en una celda de la columna deseada.
            if (e.ColumnIndex == 2 && e.RowIndex >= 0) 
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

            if (e.ColumnIndex == 5 && e.RowIndex >= 0) 
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

            if (e.ColumnIndex == 8 && e.RowIndex >= 0) 
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
            

            // Verificar si la celda pertenece a una de las columnas editables
            if (!(e.ColumnIndex == dgvSueldos_Fiscal2.Index || e.ColumnIndex == dgvSueldos_Bonificacion2.Index ||
                  e.ColumnIndex == dgvSueldos_Fiscal1.Index || e.ColumnIndex == dgvSueldos_Bonificacion1.Index))
            {
                e.Cancel = true;
                return;
            }

            // Obtener la fecha seleccionada y la quincena del ComboBox
            DateTime quincenaSeleccionada = dtpQuincenaActual.Value;
            string quincenaSeleccionadaText = cbQuincenaActual.Text.ToLower();

            if (e.ColumnIndex == dgvSueldos_Fiscal1.Index || e.ColumnIndex == dgvSueldos_Bonificacion1.Index)
            {
                quincenaSeleccionada = dtpQuincenaAnterior.Value;
                quincenaSeleccionadaText = cbQuincenaAnterior.Text.ToLower();
            }

            // Validar si la quincena seleccionada es actual o futura
            if (quincenaSeleccionada.Year < DateTime.Now.Year ||
                (quincenaSeleccionada.Year == DateTime.Now.Year && quincenaSeleccionada.Month < DateTime.Now.Month))
            {
                e.Cancel = true;
                MessageBox.Show("No se puede editar un salario de una quincena pasada.", "Acción no permitida",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si la quincena es del mes actual, verificar que corresponda a la primera o segunda quincena correctamente
            if (quincenaSeleccionada.Month == DateTime.Now.Month)
            {
                bool esPrimeraQuincena = DateTime.Now.Day <= 15;
                if ((esPrimeraQuincena && !quincenaSeleccionadaText.Contains("1er")) ||
                    (!esPrimeraQuincena && !quincenaSeleccionadaText.Contains("2da")))
                {
                    e.Cancel = true;
                    MessageBox.Show("Solo puedes editar la quincena correspondiente a la fecha actual o posterior.",
                                    "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                    int dia = 1;
                    if (quincena.Contains("2"))
                    {
                        dia = 17;
                    }

                    try
                    {
                        if (MEmpleados.CObtenerSalarioEmpleadoByFechaQuincena(quincena, anio, mes, idEmpleado).Rows.Count > 0) // Ya tiene sueldo de esa quincena, modifica
                        {
                            MEmpleados.CModificarSalarioEmpleado(quincena, anio, mes,dia, idEmpleado, sueldoFiscal, sueldoBonificacion);
                        }
                        else // No tiene, se inserta. 
                        {

                            MEmpleados.CInsertarSalarioEmpleado(quincena, anio, mes,dia, idEmpleado, sueldoFiscal, sueldoBonificacion);

                        }

                    }

                    catch (Exception ex)
                    {

                    }



                }
            }
            // AGREGAR POPUP DE EXITO
            LibAux.PopUp("¡Éxito!", "Información guardada con éxito.", TipoNotif.Success);
            CargarSueldos();
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
            dtExport.Columns.Add("SueldoFiscal", typeof(decimal)); // Columna con contenido
            dtExport.Columns.Add("Bonificacion", typeof(decimal)); // Columna con contenido

            // Iterar por las filas del DataGridView y añadir los datos
            foreach (DataGridViewRow row in dgvSueldos.Rows)
            {
                // Asegurarse de no incluir filas vacías
                if (!row.IsNewRow)
                {
                    // Obtener los valores de las columnas "idEmpleado" y "Nombre"
                    int idEmpleado = row.Cells["dgvSueldos_idEmpleado"]?.Value != null ? Convert.ToInt32(row.Cells["dgvSueldos_idEmpleado"].Value) : 0;
                    string nombre = row.Cells["dgvSueldos_Nombre"]?.Value?.ToString() ?? "";

                    // Obtener los valores de las columnas "SueldoFiscal" y "Bonificacion"
                    decimal sueldoFiscal = row.Cells["dgvSueldos_Fiscal2"]?.Value != null ? Convert.ToDecimal(row.Cells["dgvSueldos_Fiscal2"].Value) : 0;
                    decimal bonificacion = row.Cells["dgvSueldos_Bonificacion2"]?.Value != null ? Convert.ToDecimal(row.Cells["dgvSueldos_Bonificacion2"].Value) : 0;

                    // Crear una nueva fila con los datos de idEmpleado, Nombre, SueldoFiscal y Bonificacion
                    DataRow newRow = dtExport.NewRow();
                    newRow["idEmpleado"] = idEmpleado;
                    newRow["Nombre"] = nombre;
                    newRow["SueldoFiscal"] = sueldoFiscal; // Columna con el valor
                    newRow["Bonificacion"] = bonificacion; // Columna con el valor

                    // Añadir la fila al DataTable
                    dtExport.Rows.Add(newRow);
                }
            }
            LibAux.ExportarAExcel(dtExport);
        }

        private void btnImportarExcel_Click(object sender, EventArgs e)
        {     
                // Obtener la fecha seleccionada del DateTimePicker y el valor de la quincena seleccionada en el ComboBox

                DateTime quincenaSeleccionada = dtpQuincenaActual.Value;
                string quincenaSeleccionadaText = cbQuincenaActual.Text.ToLower();

                // Verificar si la fecha seleccionada corresponde a la quincena actual o posterior
                if (quincenaSeleccionada.Month >= DateTime.Now.Month && quincenaSeleccionada.Year >= DateTime.Now.Year)
                {
                    //if (quincenaSeleccionada.Year > DateTime.Now.Year)
                    //{
                    //    return;
                    //}

                    if (quincenaSeleccionada.Month >= DateTime.Now.Month)
                    {
                        // Verificar que la quincena sea la correcta
                        if ((DateTime.Now.Day <= 15 && quincenaSeleccionadaText.Contains("1er")) ||
                            (DateTime.Now.Day > 15 && quincenaSeleccionadaText.Contains("2da")))
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

                                                bool sueldoCambio = sueldoValido && sueldoFiscal != Convert.ToDecimal(dgvRow.Cells["dgvSueldos_Fiscal2"].Value);
                                                bool bonificacionCambio = bonificacionValida && bonificacion != Convert.ToDecimal(dgvRow.Cells["dgvSueldos_Bonificacion2"].Value);

                                                if (sueldoCambio) dgvRow.Cells["dgvSueldos_Fiscal2"].Value = sueldoFiscal;
                                                if (bonificacionCambio) dgvRow.Cells["dgvSueldos_Bonificacion2"].Value = bonificacion;

                                                dgvRow.Cells["dgvSueldos_Total2"].Value = bonificacion + sueldoFiscal;


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
                                    // POPUP
                                }
                                else
                                {
                                    MessageBox.Show("El archivo de Excel no contiene datos válidos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    // POPUP

                                }
                            }
                        }
                        catch (IOException ex)
                        {
                            MessageBox.Show("El archivo está abierto. Por favor, cierre el archivo y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                        else
                        {
                            // Si la quincena no es válida, cancelar la edición
                            MessageBox.Show("Solo puedes editar la quincena correspondiente a la fecha actual o posterior.", // CAMBIAR A POPUPS
                                            "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                        }

                    }

                }
                else
                {
                    // Si la quincena seleccionada es anterior a la actual, no permitir la edición
                    MessageBox.Show("No se puede editar un salario de una quincena pasada.",
                                    "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning); // CAMBIAR A POPUPS
                return;
                }
            

        }

        private void dtpQuincenaAnterior_ValueChanged(object sender, EventArgs e)
        {

            dtpQuincenaAnterior.ValueChanged -= dtpQuincenaAnterior_ValueChanged;

            if (!VerificarCambiosSinGuardar(dgvSueldos, quincena1, dtpQuincenaAnterior))
            {
                dtpQuincenaAnterior.Value = quincena1; // Restaurar la fecha anterior
            }
            else
            {
                quincena1 = dtpQuincenaAnterior.Value;
                CargarSueldos();
            }

            // Volver a habilitar el evento después de realizar los cambios
            dtpQuincenaAnterior.ValueChanged += dtpQuincenaAnterior_ValueChanged;
        }

        private void cbQuincenaAnterior_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Si la variable aún no tiene un valor válido, asignar el índice actual
            if (indiceAnteriorQuincena1 == -1)
                indiceAnteriorQuincena1 = cbQuincenaAnterior.SelectedIndex;

            // Deshabilitar temporalmente el evento
            cbQuincenaAnterior.SelectedIndexChanged -= cbQuincenaAnterior_SelectedIndexChanged;

            if (!VerificarCambiosSinGuardar(dgvSueldos, quincena1, dtpQuincenaAnterior))
            {
                cbQuincenaAnterior.SelectedIndex = indiceAnteriorQuincena1;
            }
            else
            {
                CargarSueldos();
                indiceAnteriorQuincena1 = cbQuincenaAnterior.SelectedIndex;
            }

            // Rehabilitar el evento
            cbQuincenaAnterior.SelectedIndexChanged += cbQuincenaAnterior_SelectedIndexChanged;
        }

        private void dtpQuincenaActual_ValueChanged(object sender, EventArgs e)
        {
            dtpQuincenaActual.ValueChanged -= dtpQuincenaActual_ValueChanged;

            if (!VerificarCambiosSinGuardar(dgvSueldos, quincena2, dtpQuincenaActual))
            {
                dtpQuincenaActual.Value = quincena2; // Restaurar la fecha anterior
            }
            else
            {
                quincena2 = dtpQuincenaActual.Value;
                CargarSueldos();
            }

            // Volver a habilitar el evento después de realizar los cambios
            dtpQuincenaActual.ValueChanged += dtpQuincenaActual_ValueChanged;
        }

        private void cbQuincenaActual_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si la variable aún no tiene un valor válido, asignar el índice actual
            if (indiceAnteriorQuincena2 == -1)
                indiceAnteriorQuincena2 = cbQuincenaActual.SelectedIndex;

            // Deshabilitar temporalmente el evento
            cbQuincenaActual.SelectedIndexChanged -= cbQuincenaActual_SelectedIndexChanged;

            if (!VerificarCambiosSinGuardar(dgvSueldos, quincena2, dtpQuincenaActual))
            {
                cbQuincenaActual.SelectedIndex = indiceAnteriorQuincena2;
            }
            else
            {
                quincena2 = dtpQuincenaActual.Value;
                CargarSueldos();
                indiceAnteriorQuincena2 = cbQuincenaActual.SelectedIndex;
            }

            // Rehabilitar el evento
            cbQuincenaActual.SelectedIndexChanged += cbQuincenaActual_SelectedIndexChanged;
        }


        private void dgvSueldos_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //// Verificar que no sea una fila de encabezado y que esté en la columna deseada
            //if (e.RowIndex >= 0 && e.ColumnIndex == dgvSueldos_QuincenaFutura.Index)
            //{
            //    string mensaje = MEmpleados.ObtenerSiguienteSueldoProgramado();
            //    // Obtener el valor de la celda

            //    // Mostrar el tooltip
            //    toolTip1.SetToolTip(dgvSueldos, $"Quincena futura: {mensaje}");
            //}
        }

        private void dgvSueldos_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            //toolTip1.SetToolTip(dgvSueldos, ""); // Limpia el tooltip
        }

        private void dgvSueldos_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            // Verificar que no sea una fila de encabezado y que esté en la columna deseada
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvSueldos_QuincenaFutura.Index)
            {
                string mensaje = MEmpleados.ObtenerSiguienteSueldoProgramado();
                e.ToolTipText = $"Quincena futura: {mensaje}";
            }
        }

        private void dtpQuincenaActual_Enter(object sender, EventArgs e)
        {
            quincena2 = dtpQuincenaActual.Value;
        }

        private void lblExpExc_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseSueldos_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
    #endregion
}
