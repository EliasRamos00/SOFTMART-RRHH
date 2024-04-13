using SOFTMART_RRHH.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFTMART_RRHH.Controlador
{
    internal class MPuestos
    {
        internal static object ObtenerAreasPuestos()
        {
            return LibAux.EjecutarSentencia("SELECT DISTINCT Area FROM Puestos;");
        }

        internal static DataTable ObtenerPuestos(string Area, string SubArea)
        {
            List<Param> @params = new List<Param>
            {
                new Param("vArea",Area),
                new Param("vSubArea",SubArea)

            };
            return LibAux.EjecutarProcedimiento("SP_CONSULTAR_Puestos",@params);
        }

        internal static object ObtenerSubAreasPuestos(string Area)
        {
            List<Param> @params = new List<Param>
            {
                new Param("vArea",Area)

            };
            return LibAux.EjecutarSentencia("SELECT DISTINCT SubArea FROM Puestos WHERE Area = @vArea", @params);
        }
    }
}
