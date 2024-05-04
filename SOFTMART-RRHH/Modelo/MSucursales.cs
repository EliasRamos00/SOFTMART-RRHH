using SOFTMART_RRHH.Modelo;
using System;
using System.Collections.Generic;
using System.Data;


namespace SOFTMART_RRHH.Controlador
{
    internal class MSucursales
    {
        internal static void ActualizarSucursal(object idSucursal, object sucursal)
        {
            List<Param> @params = new List<Param> {
                new Param("vidSucursal",idSucursal),
                new Param("vSucursal",sucursal)
            };
            LibAux.EjecutarProcedimiento("SP_ACTUALIZAR_Sucursal", @params);
        }

        internal static void EliminarSucursal(int idSucursal)
        {
            List<Param> @params = new List<Param> {
                new Param("vidSucursal",idSucursal)
            };
            LibAux.EjecutarProcedimiento("SP_ELIMINAR_Sucursal", @params);
        }

        internal static void InsertarSucursal(object sucursal)
        {
            List<Param> @params = new List<Param> {
                new Param("vSucursal",sucursal)
            };
            LibAux.EjecutarProcedimiento("SP_INSERTA_Sucursal", @params);
        }

        internal static DataTable ObtenerSucursales()
        {
            return LibAux.EjecutarProcedimiento("SP_CONSULTAR_Sucursales");
        }

        internal static DataTable ObtenerSucursalesAjustes()
        {
            return LibAux.EjecutarSentencia("SELECT *, 0 as hasChanged FROM Sucursales");
        }
    }
}
