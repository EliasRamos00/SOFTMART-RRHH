using SOFTMART_RRHH.Modelo;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace SOFTMART_RRHH.Vista
{
    public partial class vHistorialCambios : System.Windows.Forms.UserControl
    {
        #region VARIABLES GLOBALES
        int idPersona = -1;
        #endregion
        #region CONSTRUCTORES
        public vHistorialCambios()
        {
            InitializeComponent();
        }
        public vHistorialCambios(int idPersona)
        {
            InitializeComponent();
            this.idPersona = idPersona;
            lblGeneral.Text = MUsuarios.ObtenerNombrePersona(idPersona);
        }
        #endregion
        #region METODOS        
        static void RemoverNodosDuplicados(XElement node1, XElement node2)
        {
            // Get the names of child nodes in each XML
            var names1 = node1.Elements().Select(e => e.Name).ToList();
            var names2 = node2.Elements().Select(e => e.Name).ToList();

            // Get the names of nodes present in both XMLs
            var commonNames = names1.Intersect(names2).ToList();

            // Remove nodes with identical values in both XMLs
            foreach (var name in commonNames)
            {
                var nodes1 = node1.Elements(name).ToList();
                var nodes2 = node2.Elements(name).ToList();

                foreach (var n1 in nodes1.ToList())
                {
                    foreach (var n2 in nodes2.ToList())
                    {
                        if (XNode.DeepEquals(n1, n2) && !n1.Name.ToString().Substring(0, 2).Equals("id"))
                        {
                            n1.Remove();
                            n2.Remove();
                        }
                    }
                }
            }

        }
        private void CargarCambios()
        {
            if (idPersona >= 1)
            {
                dgvHistorial.DataSource = MHistorial.ConsultarCambios(idPersona);
            }
            else
            {
                dgvHistorial.DataSource = MHistorial.ConsultarCambios();
            }

        }
        private void HighlightSyntax(System.Windows.Forms.RichTextBox richTextBox1)
        {
            // Guardar la posición actual del cursor
            int selectionStart = richTextBox1.SelectionStart;
            int selectionLength = richTextBox1.SelectionLength;

            // Guardar la configuración actual de selección
            Color defaultColor = Color.Black;
            richTextBox1.SelectionColor = defaultColor;

            // Expresiones regulares para detectar etiquetas, atributos y comentarios XML
            string patternTags = @"<([^!>][^>]*)>";
            string patternAttributes = @"\s(.*?)\=";

            // Resaltar etiquetas
            Regex regexTags = new Regex(patternTags);
            MatchCollection matchesTags = regexTags.Matches(richTextBox1.Text);
            foreach (Match match in matchesTags)
            {
                richTextBox1.Select(match.Index, match.Length);
                richTextBox1.SelectionColor = Color.Blue;
            }

            // Resaltar atributos
            Regex regexAttributes = new Regex(patternAttributes);
            MatchCollection matchesAttributes = regexAttributes.Matches(richTextBox1.Text);
            foreach (Match match in matchesAttributes)
            {
                richTextBox1.Select(match.Index, match.Length);
                richTextBox1.SelectionColor = Color.Red;
            }

            // Restaurar la posición y longitud de la selección original
            richTextBox1.Select(selectionStart, selectionLength);
            richTextBox1.SelectionColor = defaultColor;

            // Devolver el enfoque al control RichTextBox 
            richTextBox1.Focus();
        }
        #endregion
        #region EVENTOS        
        private void vHistorialCambios_Load(object sender, EventArgs e)
        {
            CargarCambios();
        }
        private void btnRecarga_Click(object sender, EventArgs e)
        {
            CargarCambios();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void dgvHistorial_SelectionChanged(object sender, EventArgs e)
        {
            txtAntes.Text = "";
            txtDespues.Text = "";
            if (dgvHistorial.CurrentRow != null)
            {
                try
                {
                    DataTable dtTemp = MHistorial.ConsultarXML(dgvHistorial.CurrentRow.Cells["dgvHistorial_idHistorial"].Value);
                    if (dtTemp.Rows.Count >= 1)
                    {
                        string xmlAntes = dtTemp.Rows[0]["XMLAntes"].ToString();
                        string xmlDespues = dtTemp.Rows[0]["XMLDespues"].ToString();

                        if (xmlAntes != "" && xmlDespues != "")
                        {
                            XDocument xDocumentAntes = XDocument.Parse(xmlAntes);
                            XDocument xDocumentDespues = XDocument.Parse(xmlDespues);
                            RemoverNodosDuplicados(xDocumentAntes.Root, xDocumentDespues.Root);
                            txtAntes.Text = xDocumentAntes.ToString();//ToString will format xml string with indent
                            txtDespues.Text = xDocumentDespues.ToString();//ToString will format xml string with indent
                            HighlightSyntax(txtAntes);
                            HighlightSyntax(txtDespues);
                        }
                        else if (xmlAntes == "" && xmlDespues != "")
                        {
                            XDocument xDocument = XDocument.Parse(xmlDespues);
                            txtDespues.Text = xDocument.ToString();//ToString will format xml string with indent
                            HighlightSyntax(txtDespues);
                        }
                    }
                }
                catch (Exception ex)
                {
                    LibAux.PopUp("atención", ex.Message, LibAux.TipoNotif.Error);
                    LibAux.ErrorLog(ex);
                }
            }

            dgvHistorial.Focus();
        }
        #endregion
    }
}
