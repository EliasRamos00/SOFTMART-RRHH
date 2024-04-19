
using System.Data;


namespace SOFTMART_RRHH.Modelo
{
    internal class MEstadosCiviles
    {
        internal static DataTable ObtenerEdosCiviles()
        {
            return LibAux.EjecutarProcedimiento("SP_CONSULTAR_EstadosCiviles");
        }
    }
}
