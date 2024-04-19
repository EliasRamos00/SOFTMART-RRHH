using SOFTMART_RRHH.Modelo;
using System.Data;

namespace SOFTMART_RRHH.Controlador
{
    internal class MEscolaridades
    {
        internal static DataTable ObtenerEscolaridades()
        {
            return LibAux.EjecutarProcedimiento("SP_CONSULTAR_Escolaridades");
        }
    }
}
