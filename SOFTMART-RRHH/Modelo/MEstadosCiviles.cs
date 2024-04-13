using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
