
using System;
using System.Collections.Generic;
using System.Data;
using SOFTMART_RRHH.Controlador;



namespace SOFTMART_RRHH.Modelo
{
    internal class MEstadosCiviles
    {
        internal static void ActualizarEdoCivil(object edoCivilAnterior, object edoCivilNuevo)
        {
            List<Param> @params = new List<Param> {
                new Param("vEdoCivilAnterior",edoCivilAnterior),
                new Param("vEdoCivilNuevo",edoCivilNuevo)
            };
            LibAux.EjecutarProcedimiento("SP_ACTUALIZAR_EdoCivil", @params);
        }

        internal static void EliminarEdoCivil(object edoCivil)
        {
            List<Param> @params = new List<Param> {
                new Param("vEdoCivil",edoCivil)
            };
            LibAux.EjecutarProcedimiento("SP_ELIMINAR_EdoCivil", @params);
        }

        internal static void InsertarEstadoCivil(object edoCivil)
        {
            List<Param> @params = new List<Param> {
                new Param("vEdoCivil",edoCivil)
            };
            LibAux.EjecutarProcedimiento("SP_INSERTA_EdoCivil", @params);
        }

        internal static DataTable ObtenerEdosCiviles()
        {
            return LibAux.EjecutarProcedimiento("SP_CONSULTAR_EstadosCiviles");
        }

        internal static DataTable ObtenerEdosCivilesAjustes()
        {
            return LibAux.EjecutarSentencia("SELECT *, 0 as hasChanged FROM EstadoCiviles");
        }
    }
}
