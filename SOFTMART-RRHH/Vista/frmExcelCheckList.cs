
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SOFTMART_RRHH.Vista
{
    public partial class frmExcelCheckList : Form
    {
        public List<string> ColumnasAExportar = new List<string>();
        List<DataGridViewColumn> columns;        
        Point lastPoint = new Point(10, 35);
        public frmExcelCheckList(List<DataGridViewColumn> columns)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.columns = columns;            
        }
        private void frmExcelCheckList_Load(object sender, EventArgs e)
        {
            CheckBox box = new CheckBox();
            foreach (DataGridViewColumn column in columns)
            {
                box = new CheckBox();
                box.Appearance = Appearance.Normal;
                box.Font = new Font("Microsoft Sans Serif", 14);
                box.AutoSize = false;
                box.Size = new Size(100, 100);
                
                box.Text = column.HeaderText;
                box.AutoSize = true;
                box.Location = lastPoint; //vertical                                                   

                this.Controls.Add(box);
                lastPoint = new Point(10, box.Location.Y + 30);
            }

            btnExportar.Text = "Exportar";
            btnExportar.AutoSize = true;
            btnExportar.Location = lastPoint;
            btnExportar.Size = new Size(100, 38);
            this.Size = new Size(300, lastPoint.Y + 110);

        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            // Itera sobre los controles del formulario para encontrar los CheckBoxes marcados
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    ColumnasAExportar.Add(checkBox.Text);
                }
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
