using MySqlConnector;
using SOFTMART_RRHH.Modelo;
using System;
using System.Collections.Generic;
using System.Data;

namespace SOFTMART_RRHH.Controlador
{
    internal class MEmpleados
    {

        internal static DataTable CObtenerSalarioEmpleadoByFechaQuincena(string quincena, int anio, int mes, string idEmpleado)
        {
            List<Param> parametros = new List<Param>
            {
                new Param("vQuincena",quincena),
                new Param("vAnio",anio),
                new Param("vMes",mes),
                new Param("vIdEmpleado",idEmpleado),
              
            };
            return LibAux.EjecutarProcedimiento("SP_CONSULTA_SueldoEmpleadoByQuincenaAnioMes", parametros);
        }


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

        internal static void CInsertarSalarioEmpleado(string quincena, int anio, int mes, int dia, string idEmpleado, decimal sueldoFiscal, decimal sueldoBonificacion)
        {
            DateTime fecha = new DateTime(anio, mes, dia);


            List<Param> parametros = new List<Param>
            {
                new Param("vQuincena", quincena),
                new Param("vIdEmpleado", idEmpleado),
                new Param("vSFiscal", sueldoFiscal),
                new Param("vSBonificacion", sueldoBonificacion),
                new Param("vFecha", fecha)
            };

            // Ejecuta el procedimiento almacenado SP_INSERTA_Sueldo
            LibAux.EjecutarProcedimiento("SP_INSERTA_Sueldo", parametros);
        }

        internal static void CModificarSalarioEmpleado(string quincena, int anio, int mes,int dia, string idEmpleado, decimal sueldoFiscal, decimal sueldoBonificacion)
        {
            DateTime fecha = new DateTime(anio, mes, dia);

            List<Param> parametros = new List<Param>
            {
                new Param("vQuincena", quincena),
                new Param("vIdEmpleado", idEmpleado),
                new Param("vSFiscal", sueldoFiscal),
                new Param("vSBonificacion", sueldoBonificacion),
                new Param("vFecha", fecha)
            };

            // Ejecuta el procedimiento almacenado SP_ACTUALIZA_Sueldo
            LibAux.EjecutarProcedimiento("SP_ACTUALIZA_Sueldo", parametros);
        }

       
            internal static string ObtenerUltimoEmpleadoInsertado()
            {
                string query = "SELECT idEmpleado FROM empleados ORDER BY idEmpleado DESC LIMIT 1;";
                DataTable resultado = LibAux.EjecutarSentencia(query);

                if (resultado.Rows.Count > 0)
                {
                    return resultado.Rows[0]["idEmpleado"].ToString();
                }
                return string.Empty; // Retorna cadena vacía si no hay registros
            }

        internal static string ObtenerSiguienteSueldoProgramado()
        {
            string query = @"
            SELECT CONCAT(fecha, ' - ', SFiscal + SBonificacion) AS resultado
            FROM sueldoHistorial 
            WHERE fecha > NOW() 
            ORDER BY fecha ASC 
            ";

            DataTable dt = LibAux.EjecutarSentencia(query);

            if (dt.Rows.Count == 0)
                return string.Empty; // Si no hay registros futuros, retorna una cadena vacía

            List<string> resultados = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                resultados.Add(row["resultado"].ToString());
            }

            return string.Join(Environment.NewLine, resultados);
        }
    }
}
