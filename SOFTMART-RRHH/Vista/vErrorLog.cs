using SOFTMART_RRHH.Modelo;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SOFTMART_RRHH.Vista
{
    public partial class vErrorLog : UserControl
    {

        #region VARIABLES GLOBALES
        string vPath = Path.GetFullPath(Path.Combine(@Application.StartupPath, @"..\..\ErrorLog\"));
        #endregion
        #region CONSTRUCTORES
        public vErrorLog()
        {
            InitializeComponent();
            CargarArchivos();
        }
        #endregion
        #region METODOS
        public void CargarArchivos()
        {
            try
            {
                dgvErrorLog.Rows.Clear();
                if (!Directory.Exists(vPath))
                    Directory.CreateDirectory(vPath);

                string[] files = Directory.GetFiles(vPath);
                foreach (string file in files)
                {
                    dgvErrorLog.Rows.Add(Path.GetFileName(file), file);
                }
            }
            catch (Exception ex)
            {
                LibAux.ErrorLog(ex);
            }
        }
        #endregion
        #region EVENTOS        
        private void dgvErrorLog_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Toma la ruta del archivo y obtiene el texto.
                string rutaArchivo = dgvErrorLog.Rows[dgvErrorLog.CurrentRow.Index].Cells["dgvError_Path"].Value.ToString();
                txt.Text = File.ReadAllText(rutaArchivo);
            }
            catch (Exception ex)
            {
                LibAux.ErrorLog(ex);
            }
        }
        private void btnFolder_Click(object sender, EventArgs e)
        {
            Process.Start(vPath);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnRecarga_Click(object sender, EventArgs e)
        {
            CargarArchivos();
        }
        #endregion
    }

}
