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
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            CambiarNombresCB();

            // Itera sobre los controles del formulario para encontrar los CheckBoxes marcados
            foreach (Control control in this.tlpPersonal.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    _ColumnasAExportar.Add(checkBox.Text);
                }
            }
            foreach (Control control in this.tlpDomiciliar.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    _ColumnasAExportar.Add(checkBox.Text);
                }
            }
            foreach (Control control in this.tlpLaboral.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    _ColumnasAExportar.Add(checkBox.Text);
                }
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
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
    }
}
