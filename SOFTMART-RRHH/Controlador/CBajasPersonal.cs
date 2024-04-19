using SOFTMART_RRHH.Modelo;

using System.Windows.Forms;

namespace SOFTMART_RRHH.Controlador
{
    internal class CBajasPersonal
    {
        internal static void BajaPersonal(DateTimePicker dtpFechaBaja, string patron, TextBox tbFiniquito, TextBox tbComentarios, int idEmpleado)
        {
            MBajas.InsertaBaja(dtpFechaBaja.Value, patron, tbFiniquito.Text, tbComentarios.Text, idEmpleado);
        }
    }
}
