using SOFTMART_RRHH.Modelo;
using System;
using System.Collections.Generic;
using System.Data;

namespace SOFTMART_RRHH.Controlador
{
    internal class MEscolaridades
    {
        internal static void ActualizarEscolaridad(object idEscolaridad, object escolaridad)
        {
            List<Param> @params = new List<Param> {
                new Param("vidEscolaridad",idEscolaridad),
                new Param("vEscolaridad",escolaridad)
            };
            LibAux.EjecutarProcedimiento("SP_ACTUALIZAR_Escolaridad", @params);
        }

        internal static void EliminarEscolaridad(object idEscolaridad)
        {
            List<Param> @params = new List<Param> {
                new Param("vidEscolaridad",idEscolaridad),
            };
            LibAux.EjecutarProcedimiento("SP_ELIMINAR_Escolaridad", @params);
        }

        internal static void InsertarEscolaridad(object escolaridad)
        {
            List<Param> @params = new List<Param> {
                new Param("vEscolaridad",escolaridad)
            };
            LibAux.EjecutarProcedimiento("SP_INSERTA_Escolaridad", @params);
        }

        internal static DataTable ObtenerEscolaridades()
        {
            return LibAux.EjecutarProcedimiento("SP_CONSULTAR_Escolaridades");
        }

        internal static DataTable ObtenerEscolaridadesAjustes()
        {
            return LibAux.EjecutarSentencia("SELECT *, 0 as hasChanged FROM Escolaridades;");
        }
    }
}
