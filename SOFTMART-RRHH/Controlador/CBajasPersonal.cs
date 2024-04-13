using SOFTMART_RRHH.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
