using SOFTMART_RRHH.Modelo;
using System;
using System.Windows.Forms;

namespace SOFTMART_RRHH.Controlador
{
    internal class CBajasPersonal
    {
        internal static void BajaPersonal(DateTimePicker dtpFechaBaja, TextBox tbPatron, TextBox tbFiniquito, TextBox tbComentarios, int idEmpleado)
        {
            MBajas.InsertaBaja(dtpFechaBaja.Value, tbPatron.Text, tbFiniquito.Text, tbComentarios.Text, idEmpleado);
        }

        internal static void EliminarBaja(int idBaja)
        {
            MBajas.EliminarBaja(idBaja);
        }
    }
}
