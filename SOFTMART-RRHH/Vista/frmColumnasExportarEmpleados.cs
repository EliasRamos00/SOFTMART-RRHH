using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SOFTMART_RRHH.Vista
{
    public partial class frmColumnasExportarEmpleados : Form
    {
        private List<string> _ColumnasAExportar = new List<string>();

        public List<string> ColumnasAExportar
        {
            get { return _ColumnasAExportar; }
            set { _ColumnasAExportar = value; }
        }
        public frmColumnasExportarEmpleados()
        {
            InitializeComponent();
            LlenarListboxOrden();
            AsociarEventosCheckboxes();
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            foreach (var item in listboxOrden.Items)
            {
                _ColumnasAExportar.Add(item.ToString());
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void LlenarListboxOrden()
        {
            CambiarNombresCB();

            // Itera sobre los controles del formulario para encontrar los CheckBoxes marcados
            foreach (Control control in this.tlpLaboral.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked && checkBox.Text == "NumContrato")
                {
                    listboxOrden.Items.Add(checkBox.Text);
                }
            }

            foreach (Control control in this.tlpPersonal.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    listboxOrden.Items.Add(checkBox.Text);
                }
            }
            foreach (Control control in this.tlpDomiciliar.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    listboxOrden.Items.Add(checkBox.Text);
                }
            }
            foreach (Control control in this.tlpLaboral.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked && checkBox.Text != "NumContrato")
                {
                    listboxOrden.Items.Add(checkBox.Text);
                }
            }

        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox.Checked)
                {
                    // Agrega el texto al ListBox si no está presente
                    if (!listboxOrden.Items.Contains(checkBox.Text))
                    {
                        listboxOrden.Items.Add(checkBox.Text);
                    }
                }
                else
                {
                    // Elimina el texto del ListBox si se desmarca
                    listboxOrden.Items.Remove(checkBox.Text);
                }
            }
        }

        private void AsociarEventosCheckboxes()
        {
            // Asocia el evento CheckedChanged a todos los CheckBoxes
            foreach (Control control in tlpPersonal.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.CheckedChanged += CheckBox_CheckedChanged;
                }
            }

            foreach (Control control in tlpDomiciliar.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.CheckedChanged += CheckBox_CheckedChanged;
                }
            }

            foreach (Control control in tlpLaboral.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.CheckedChanged += CheckBox_CheckedChanged;
                }
            }
        }


        private void CambiarNombresCB()
        {
            cbNombre.Text = "Nombre";
            cbNumContrato.Text = "NumContrato";
            cbTienda.Text = "Sucursal";
            cbFechaNac.Text = "Fecha Nacimiento";
            cbFechaIngreso.Text = "Fecha Inicio";
            cbApeMat.Text = "Apellido Materno";
            cbApePat.Text = "Apellido Paterno";
            cbLugarNac.Text = "Lugar de Nacimiento";
            cbEdoCivil.Text = "Estado civil";
            cbNumSegSocial.Text = "Numero de seguro social";
            cbInfoEmerg.Text = "Informacion de emergencia";
            cbCalleNum.Text = "Calle y Numero";
            cbCodigoPostal.Text = "Codigo Postal";

            cbAntiguedad.Text = "Antiguedad";
            cbFoto.Text = "tieneFoto";
            cbINE.Text = "tieneINE";
            cbEmpleadoTemporada.Text = "esEmpleadoTemp";
            cbNombreCompleto.Text = "NombreCompleto";

        }

      
        private void ListBoxColumnas_KeyDown(object sender, KeyEventArgs e)
        {
            if (listboxOrden.SelectedItem == null) return;

            int index = listboxOrden.SelectedIndex;

            if (e.KeyCode == Keys.Up && index > 0) // Mueve hacia arriba
            {
                SwapItems(index, index - 1);
                listboxOrden.SelectedIndex = index; // Mueve el selector junto al item
            }
            else if (e.KeyCode == Keys.Down && index < listboxOrden.Items.Count - 1) // Mueve hacia abajo
            {
                SwapItems(index, index + 1);
                listboxOrden.SelectedIndex = index; // Mueve el selector junto al item
            }
        }

        private void SwapItems(int index1, int index2)
        {
            var item = listboxOrden.Items[index1];
            listboxOrden.Items[index1] = listboxOrden.Items[index2];
            listboxOrden.Items[index2] = item;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (listboxOrden.SelectedItem == null) return;

            int index = listboxOrden.SelectedIndex;

            if (index > 0) // Mover hacia arriba
            {
                SwapItems(index, index - 1);
                listboxOrden.SelectedIndex = index - 1; // Mueve el selector junto con el ítem
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (listboxOrden.SelectedItem == null) return;

            int index = listboxOrden.SelectedIndex;

            if (index < listboxOrden.Items.Count - 1) // Mover hacia abajo
            {
                SwapItems(index, index + 1);
                listboxOrden.SelectedIndex = index + 1; // Mueve el selector junto con el ítem
            }
        }


    }
}