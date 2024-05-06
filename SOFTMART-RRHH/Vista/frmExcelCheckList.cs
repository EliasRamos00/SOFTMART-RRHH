
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
        int horizontal = 10;
        int vertical = 60;
        bool columnON = false;
        Point lastPoint = new Point(10, 35);
        public frmExcelCheckList(List<DataGridViewColumn> columns)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.columns = columns;
        }
        private void frmExcelCheckList_Load(object sender, EventArgs e)
        {
            CheckBox box;
            foreach (DataGridViewColumn column in columns)
            {
                box = new CheckBox
                {
                    Appearance = Appearance.Normal,
                    Font = new Font("Microsoft Sans Serif", 14),
                    AutoSize = false,
                    Size = new Size(100, 100),
                    Text = column.HeaderText
                };
                box.AutoSize = true;
                box.Location = lastPoint; //vertical                                                   

                this.Controls.Add(box);
                vertical = box.Location.Y+30;
                lastPoint = new Point(horizontal, box.Location.Y+30);
                
                if (box.Location.Y >= 600)
                {
                    columnON = true;
                    horizontal = horizontal + 300;
                    this.Width = this.Width + 600;
                    lastPoint = new Point(horizontal, 35);
                }
            }
            if (columnON)
            {
                this.Size = new Size(horizontal + 160, 680);
            }
            else {
                this.Size = new Size(horizontal + 350, vertical+120);
            }
            btnExportar.Text = "Exportar";
            btnExportar.AutoSize = true;
            btnExportar.Location = lastPoint;
            btnExportar.Size = new Size(100, 38);
            

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
