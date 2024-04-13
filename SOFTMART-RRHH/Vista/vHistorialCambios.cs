using SOFTMART_RRHH.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using NPOI.XWPF.UserModel;
//using ScintillaNET;

namespace SOFTMART_RRHH.Vista
{
    public partial class vHistorialCambios : System.Windows.Forms.UserControl
    {
        int idPersona = -1;
        public vHistorialCambios()
        {
            InitializeComponent();
        }

        public vHistorialCambios(int idPersona)
        {
            this.idPersona = idPersona;
            InitializeComponent();
        }

        private void tlpPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vHistorialCambios_Load(object sender, EventArgs e)
        {
            CargarCambios();
            //SetUpScintillas(txtAntes);
            //SetUpScintillas(txtDespues);
        }

        private void dgvHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void dgvHistorial_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //txtAntes.Text = "";
            //txtDespues.Text = "";
            //try
            //{
            //    DataTable dtTemp = MHistorial.ConsultarXML(dgvHistorial.CurrentRow.Cells["dgvHistorial_idHistorial"].Value);
            //    if (dtTemp.Rows.Count >= 1)
            //    {
            //        string xmlAntes = dtTemp.Rows[0]["XMLAntes"].ToString();
            //        string xmlDespues = dtTemp.Rows[0]["XMLDespues"].ToString();

            //        if (xmlAntes != "" && xmlDespues != "")
            //        {
            //            XDocument xDocumentAntes = XDocument.Parse(xmlAntes);
            //            XDocument xDocumentDespues = XDocument.Parse(xmlDespues);
            //            RemoverNodosDuplicados(xDocumentAntes.Root, xDocumentDespues.Root);
            //            txtAntes.Text = xDocumentAntes.ToString();//ToString will format xml string with indent
            //            txtDespues.Text = xDocumentDespues.ToString();//ToString will format xml string with indent
            //        }
            //        else if (xmlAntes == "" && xmlDespues != "")
            //        {
            //            XDocument xDocument = XDocument.Parse(xmlDespues);
            //            txtAntes.Text = xDocument.ToString();//ToString will format xml string with indent
            //        }
            //    }


            //}
            //catch (Exception ex)
            //{
            //    LibAux.PopUp("atención", ex.Message, LibAux.TipoNotif.Error);
            //}
        }

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

        //private void SetUpScintillas(ScintillaNET.Scintilla scintilla1)
        //{
        //    // Set up Scintilla control
        //    scintilla1.LexerName = "xml";

        //    // Set XML styles
        //    scintilla1.Styles[Style.Xml.Default].ForeColor = Color.FromArgb(34, 34, 34); // Default text color (gris oscuro)
        //    scintilla1.Styles[Style.Xml.Tag].ForeColor = Color.FromArgb(0, 102, 204);    // XML tag (azul)
        //    scintilla1.Styles[Style.Xml.TagEnd].ForeColor = Color.FromArgb(0, 102, 204); // XML closing tag (azul)
        //    scintilla1.Styles[Style.Xml.Attribute].ForeColor = Color.FromArgb(163, 21, 21); // XML attribute name (rojo oscuro)            
        //    scintilla1.Styles[Style.Xml.Default].Bold = true;


        //}


        private void btnRecarga_Click(object sender, EventArgs e)
        {
            CargarCambios();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtDespues_Click(object sender, EventArgs e)
        {

        }

        private void txtAntes_Click(object sender, EventArgs e)
        {

        }
    }
}
