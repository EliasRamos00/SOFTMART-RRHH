using MySqlConnector;
using SOFTMART_RRHH.Modelo;
using System;
using System.Collections.Generic;
using System.Data;

namespace SOFTMART_RRHH.Controlador
{
    internal class MEmpleados
    {
        internal static void CInsertarEmpleado(object idPersona, object numContrato, object idSucursal, object idPuesto, DateTime FechaInicio, object esTemp, object sueldo, object comentarios, MySqlCommand cmd)
        {
            List<Param> parametros = new List<Param>
            {
                new Param("vNumContrato",numContrato),
                new Param("vFechaInicio",FechaInicio),
                new Param("vFechaTermino",""),
                new Param("vidSucursal",idSucursal),
                new Param("vidPuesto",idPuesto),
                new Param("vSueldo",sueldo),
                new Param("vEsTemp",esTemp),
                new Param("vidPersona",idPersona),
                new Param("vComentarios",comentarios),
                new Param("vidCurrentUserEmple",Properties.Settings.Default.idUsuario)

            };
            LibAux.EjecutarProcedimiento("SP_INSERTA_Empleado", cmd, parametros);
        }
        internal static DataTable ObtenerEmpleadosReporte()
        {
            return LibAux.EjecutarProcedimiento("SP_CONSULTAR_EmpleadosReporte");
        }
        internal static DataTable ObtenerEmpleadosActivosReporte()
        {
            return LibAux.EjecutarProcedimiento("SP_CONSULTAR_EmpleadosActivosReporte");
        }
        internal static DataTable ObtenerEmpleadosActivosReporteSinBajas(DateTime Inicio, DateTime Fin)
        {
            List<Param> @params = new List<Param>{
                new Param("vInicio", Inicio),
                new Param("vFinal", Fin)

            };
            return LibAux.EjecutarProcedimiento("SP_CONSULTAR_EmpleadosActivosSinBajas",@params);
        }

        /// <summary>
        /// Obtiene toda la información relacionada al empleado, como la informacion personal, de contacto, domiciliar, escolaridad sucursal etc...
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <returns>DataTable con la información.</returns>
        internal static DataTable ObtenerEmpleadoInformacionById(int idEmpleado)
        {
            List<Param> parametros = new List<Param>
            {
                new Param("vIdEmpleado",idEmpleado)
            };
            return LibAux.EjecutarProcedimiento("SP_CONSULTAR_EmpleadoInfoByID", parametros);
        }
        internal static void CModificarEmpleado(int idEmpleado, object numContrato, object idSucursal, object idPuesto, DateTime fechaingreso, object esTemp, object sueldo, object comentarios, MySqlCommand cmd)
        {
            List<Param> parametros = new List<Param>
            {
                new Param("vIdEmpleado",idEmpleado),
                new Param("vNumContrato",numContrato),
                new Param("vFechaInicio",fechaingreso),
                new Param("vidSucursal",idSucursal),
                new Param("vidPuesto",idPuesto),
                new Param("vSueldo",sueldo),
                new Param("vEsTemp",esTemp),
                new Param("vComentarios",comentarios),
                new Param("vidCurrentUserEmple",Properties.Settings.Default.idUsuario)
            };
            LibAux.EjecutarProcedimiento("SP_ACTUALIZAR_Empleado", cmd, parametros);
        }
    }
}
