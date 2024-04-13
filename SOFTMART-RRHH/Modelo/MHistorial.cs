using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFTMART_RRHH.Modelo
{
    internal class MHistorial
    {
        internal static DataTable ConsultarCambios()
        {
            return LibAux.EjecutarProcedimiento("SP_CONSULTAR_Historial");
        }
        internal static DataTable ConsultarCambios(int idPersona)
        {
            string FormatoNodo = "<idPersona>" + idPersona + "</idPersona>";
            List<Param> parametros = new List<Param> {
            new Param ("vNodoidPersona", FormatoNodo)
            };
            return LibAux.EjecutarProcedimiento("SP_CONSULTAR_HistorialPersona", parametros);
        }

        internal static DataTable ConsultarXML(object idHistorial)
        {
            List<Param> parametros = new List<Param> {
            new Param ("vidHistorial", idHistorial)
            };
            return LibAux.EjecutarProcedimiento("SP_CONSULTA_XMLHistorial", parametros);
        }
    }
}
