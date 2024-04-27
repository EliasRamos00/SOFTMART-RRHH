using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySqlConnector;
using Tulpep.NotificationWindow;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NPOI.XSSF.UserModel;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Configuration;


namespace SOFTMART_RRHH.Modelo
{
    public class LibAux
    {
        static string IP = ConfigurationManager.AppSettings["IP"];
        static string BD = ConfigurationManager.AppSettings["BD"];        
        static string User = ConfigurationManager.AppSettings["user"];
        static string Pass = ConfigurationManager.AppSettings["pass"];
        static string Port = ConfigurationManager.AppSettings["port"];

        static string produccion_IP = ConfigurationManager.AppSettings["produccion_IP"];
        static string produccion_BD = ConfigurationManager.AppSettings["produccion_BD"];
        static string produccion_User = ConfigurationManager.AppSettings["produccion_user"];
        static string produccion_Pass = ConfigurationManager.AppSettings["produccion_pass"];
        static string produccion_Port = ConfigurationManager.AppSettings["produccion_port"];
        

        public LibAux() { }
        public enum CRUD
        {
            SELECT,
            INSERT,
            UPDATE,
            DELETE
        }
        public enum TipoNotif
        {
            Success,
            Info,
            Error,
            Notif
        }
        public enum eColores
        {
            Alta,
            Baja,
            Modificacion,
            Consulta
        }
        public static Dictionary<eColores, Color> libColores = new Dictionary<eColores, Color>
        {
            {eColores.Alta, ColorTranslator.FromHtml("#457B9D")},
            {eColores.Baja, ColorTranslator.FromHtml("#C0392B")},
            {eColores.Modificacion, ColorTranslator.FromHtml("#FFA020")},
            {eColores.Consulta, ColorTranslator.FromHtml("#457B9D")}
        };

        /// <summary>
        /// Hace la construcción de la cadena de conexion, dependiendo si es desarrollo o producción.
        /// </summary>
        /// <returns></returns>
        public static string CadenaConexion()
        {
                    //-------------- ¡ ¡ ¡  I M P O R T A N T E ! ! ! ------------
                    //-------------- ¡ ¡ ¡  I M P O R T A N T E ! ! ! ------------
                    //-------------- ¡ ¡ ¡  I M P O R T A N T E ! ! ! ------------
          
                    //-------------- CADENA DE CONEXION A BASE DE DATOS DE DESARROLLO--------
            return  $"Server={IP};Database={BD};Port={Port};User ID={User};Password={Pass};Allow User Variables=True";

            //-------------- CADENA DE CONEXION A BASE DE DATOS REAL-----------------
            //return $"Server={produccion_IP};Database={produccion_BD};Port={produccion_Port};User ID={produccion_User};Password={produccion_Pass};Allow User Variables=True";
        }
        public static DataTable EjecutarProcedimiento(string nombreProcedimiento, List<Param> Parametros = null)
        {

            MySqlConnection conn = new MySqlConnection(CadenaConexion());
            conn.Open();
            if (conn == null)
            {
                conn = new MySqlConnection(CadenaConexion());
            }
            MySqlCommand cmd = new MySqlCommand(nombreProcedimiento, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            if (Parametros != null)
            {
                if (Parametros.Count > 0)
                {
                    foreach (Param item in Parametros)
                    {
                        if (item.Valor.ToString() == "")
                        {
                            item.Valor = DBNull.Value;
                        }
                    }
                    foreach (Param param in Parametros)
                    {
                        cmd.Parameters.AddWithValue(param.Atributo, param.Valor);
                    }
                }
            }
            MySqlDataReader dr = cmd.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dtTemp = new DataTable();
            ds.Tables.Add(dtTemp);
            ds.EnforceConstraints = false;
            dtTemp.Load(dr);
            conn.Close();
            return dtTemp;
        }
        /// <summary>
        /// Se hizo esta sobrecarga para poder hacer manejo de transacciones mandando por parametro el mysqlCommand.
        /// </summary>
        /// <param name="nombreProcedimiento"></param>
        /// <param name="cmd"></param>
        /// <param name="Parametros"></param>
        /// <returns></returns>
        public static DataTable EjecutarProcedimiento(string nombreProcedimiento, MySqlCommand cmd, List<Param> Parametros = null)
        {

            cmd.CommandText = nombreProcedimiento;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            if (Parametros != null)
            {
                if (Parametros.Count > 0)
                {
                    foreach (Param item in Parametros)
                    {
                        if (item.Valor.ToString() == "")
                        {
                            item.Valor = DBNull.Value;
                        }
                    }
                    foreach (Param param in Parametros)
                    {
                        cmd.Parameters.AddWithValue(param.Atributo, param.Valor);
                    }
                }
            }
            MySqlDataReader dr = cmd.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dtTemp = new DataTable();
            ds.Tables.Add(dtTemp);
            ds.EnforceConstraints = false;
            dtTemp.Load(dr);
            return dtTemp;
        }
        /// <summary>
        /// Método para ejecutar una sentencia, comunmente usado para realizar CONSULTAS en sicar, 
        /// usar '...WHERE nome = @nome' para los parametros y el WHERE.
        /// </summary>
        /// <param name="Sentencia"></param>
        /// <param name="con"></param>
        /// <param name="Parametros"></param>
        /// <returns></returns>
        public static DataTable EjecutarSentencia(string Sentencia, List<Param> Parametros = null)
        {
            MySqlConnection conn = new MySqlConnection(CadenaConexion());
            MySqlCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandText = Sentencia;
            if (Parametros != null)
            {
                if (Parametros.Count > 0)
                {
                    foreach (Param item in Parametros)
                    {
                        if (item.Valor.ToString() == "")
                        {
                            item.Valor = DBNull.Value;
                        }
                    }

                    foreach (Param param in Parametros)
                    {
                        cmd.Parameters.AddWithValue(param.Atributo, param.Valor);
                    }
                }
            }
            MySqlDataReader dr = cmd.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dtTemp = new DataTable();
            ds.Tables.Add(dtTemp);
            ds.EnforceConstraints = false;
            dtTemp.Load(dr);
            conn.Close();
            return dtTemp;
        }
        public static void PopUp(string titulo, string msg, TipoNotif tipo)
        {
            PopupNotifier up = new PopupNotifier();
            up.TitleColor = Color.White;
            up.ContentColor = Color.White;
            up.TitleText = titulo;
            up.ContentText = msg;

            switch (tipo)
            {
                case TipoNotif.Success:
                    up.Image = Properties.Resources.icoSuccess;
                    up.BodyColor = LibAux.libColores[eColores.Alta];
                    break;
                case TipoNotif.Info:
                    up.Image = Properties.Resources.icoInfo;
                    up.BodyColor = LibAux.libColores[eColores.Modificacion];
                    break;
                case TipoNotif.Error:
                    up.Image = Properties.Resources.icoError;
                    up.BodyColor = LibAux.libColores[eColores.Baja];
                    break;
                case TipoNotif.Notif:
                    up.Image = Properties.Resources.icoInfo;
                    up.BodyColor = LibAux.libColores[eColores.Modificacion];
                    break;
                default:
                    up.Image = Properties.Resources.icoInfo;
                    up.BodyColor = LibAux.libColores[eColores.Consulta];
                    break;
            }
            up.TitleFont = new Font("Arial", 18);
            up.ContentFont = new Font("Arial", 13);
            up.Popup();

        }
        internal static void ExportarAExcel(DataTable dt)
        {
            using (var workbook = new XSSFWorkbook())
            {
                var sheet = workbook.CreateSheet("Sheet1");

                // Agregar encabezados
                var headerRow = sheet.CreateRow(0);
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    headerRow.CreateCell(i).SetCellValue(dt.Columns[i].ColumnName);
                }

                // Agregar datos
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var dataRow = sheet.CreateRow(i + 1);
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        dataRow.CreateCell(j).SetCellValue(dt.Rows[i][j]?.ToString() ?? "");
                    }
                }

                // Guardar el archivo
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog.Title = "Export to Excel";
                saveFileDialog.FileName = "ExportedData.xlsx"; // Nombre predeterminado del archivo
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        workbook.Write(fileStream);
                    }
                    PopUp("¡Éxito!", "Exportación a Excel realizada con éxito.", TipoNotif.Success);
                }
            }

        }
        public static DataTable DgvToDataTable(DataGridView dgv, List<string> columns)
        {
            DataTable dt = new DataTable();

            // Agregar las columnas especificadas al DataTable
            foreach (string columnName in columns)
            {
                dt.Columns.Add(columnName); // Assuming columnName is the header text
            }

            // Pasar los datos del DataGridView al DataTable
            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow dataRow = dt.NewRow();
                foreach (string columnName in columns)
                {
                    string columnHeader = dgv.Columns.Cast<DataGridViewColumn>()
                                                .First(c => c.HeaderText == columnName)
                                                .Name;
                    dataRow[columnName] = row.Cells[columnHeader].Value;
                }
                dt.Rows.Add(dataRow);
            }

            return dt;
        }
        public static void ErrorLog(Exception ex)
        {
            var line = Environment.NewLine;
            string extype, ErrorMessage;
            extype = ex.GetType().ToString();
            ErrorMessage = ex.Message.ToString();

            try
            {
                string filepath = Application.StartupPath;
                string ProyectPathPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(filepath, @"..\..\"));
                string newPath = System.IO.Path.Combine(ProyectPathPath, "ErrorLog\\");
                if (!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(System.IO.Path.Combine(newPath));
                }
                filepath = newPath + DateTime.Today.ToString("dd-MMM-yyyy") + ".txt";
                if (!File.Exists(filepath))
                {
                    File.Create(filepath).Dispose();

                }
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    string error = "Fecha:" + " " + DateTime.Now.ToString() + line + "Exception Type:" + " " + extype + line + "Mensaje de Error :" + " " + ErrorMessage + line + "Usuario: " + Properties.Settings.Default.User;
                    sw.WriteLine("----------Detalles del error en: " + " " + DateTime.Now.ToString() + "----------");
                    sw.WriteLine("-----------------------------------------------");
                    sw.WriteLine(error);
                    sw.WriteLine("-----------------------------------------------");
                    sw.Flush();
                    sw.Close();
                }
            }
            catch{}
        }
        public static string GenerateMD5(string cadena)
        {
            return string.Join("", MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(cadena)).Select(s => s.ToString("x2")));
        }
        public static bool IsMD5(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return false;
            }

            return Regex.IsMatch(input, "^[0-9a-fA-F]{32}$", RegexOptions.Compiled);
        }

    }
}
