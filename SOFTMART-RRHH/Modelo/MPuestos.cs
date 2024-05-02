using SOFTMART_RRHH.Modelo;
using System;
using System.Collections.Generic;
using System.Data;


namespace SOFTMART_RRHH.Controlador
{
    internal class MPuestos
    {
        internal static void ActualizarPuesto(object idPuesto, object area, object subArea, object puesto)
        {
            List<Param> @params = new List<Param>
            {
                new Param("vidPuesto",idPuesto),
                new Param("varea",area),
                new Param("vsubArea",subArea),
                new Param("vpuesto",puesto)
            };
            LibAux.EjecutarProcedimiento("SP_ACTUALIZAR_Puesto", @params);
        }

        internal static void AgregarPuesto(object area, object subArea, object puesto)
        {
            List<Param> @params = new List<Param>
            {
                new Param("varea",area),
                new Param("vsubArea",subArea),
                new Param("vpuesto",puesto)
            };
            LibAux.EjecutarProcedimiento("SP_INSERTA_Puesto", @params);
        }
        internal static void EliminarPuesto(object idPuesto)
        {
            List<Param> @params = new List<Param>
            {
                new Param("vidPuesto",idPuesto),
            };
            LibAux.EjecutarProcedimiento("SP_ELIMINAR_Puesto", @params);
        }


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
            return LibAux.EjecutarProcedimiento("SP_CONSULTAR_Puestos", @params);
        }

        internal static object ObtenerSubAreasPuestos(string Area)
        {
            List<Param> @params = new List<Param>
            {
                new Param("vArea",Area)

            };
            return LibAux.EjecutarSentencia("SELECT DISTINCT SubArea FROM Puestos WHERE Area = @vArea", @params);
        }

        internal static DataTable ObtenerTodosPuestos()
        {
            return LibAux.EjecutarSentencia("SELECT *, 0 as hasChanged FROM Puestos");
        }
    }
}
