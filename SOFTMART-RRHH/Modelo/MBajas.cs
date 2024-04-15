using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFTMART_RRHH.Modelo
{
    internal class MBajas
    {
        internal static void InsertaBaja(DateTime fechaBaja, string patron, string finiquito, string comentario, int idEmpleado)
        {
            List<Param> @params = new List<Param> {
            new Param("vFechaTermino",fechaBaja),
            new Param("vUltimoPatron",patron),
            new Param("vFiniquito",finiquito),
            new Param("vComentarios",comentario),
            new Param("vIdEmpleado",idEmpleado),
            new Param("vidCurrentUser",Properties.Settings.Default.idUsuario)
            };
            LibAux.EjecutarProcedimiento("SP_INSERTA_Baja", @params);
        }

        internal static DataTable ObtenerPersonasDadasBaja()
        {
            return LibAux.EjecutarProcedimiento("SP_CONSULTAR_BajasEmpleados");
        }

    }
}
