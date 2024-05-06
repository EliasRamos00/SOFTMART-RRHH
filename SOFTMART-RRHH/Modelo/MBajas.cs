using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Controls;
namespace SOFTMART_RRHH.Modelo
{
    internal class MBajas
    {
        internal static void ActualizarBaja(object fecha, object finiquito, object comentario, object patron, int idBaja)
        {
            List<Param> @params = new List<Param> {

                new Param("vFechaTermino", fecha),
                new Param("vFiniquito", finiquito),
                new Param("vComentario", comentario),
                new Param("vPatron", patron),
                new Param("vidBaja", idBaja),

            };
            LibAux.EjecutarProcedimiento("SP_ACTUALIZAR_Baja", @params);
        }

        internal static void EliminarBaja(int idBaja)
        {
            List<Param> @params = new List<Param> {

                new Param("vidBaja", idBaja)
            };
            LibAux.EjecutarProcedimiento("SP_ELIMINAR_Baja", @params);
        }

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

        internal static int ObtenerIdEmpleadoByIdBaja(int idBaja)
        {
            List<Param> @params = new List<Param> {
            new Param("vidBaja",idBaja)
            };
            DataTable dt = new DataTable();
            dt = LibAux.EjecutarSentencia("SELECT idEmpleado FROM Bajas WHERE idBaja = @vidBaja ", @params);
            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }

        internal static DataTable ObtenerInformacionBaja(int idBaja)
        {
            List<Param> @params = new List<Param> {
            new Param("vidBaja",idBaja)
            };
            return LibAux.EjecutarSentencia("SELECT * FROM Bajas WHERE idBaja = @vidBaja;", @params);
        }

        internal static DataTable ObtenerPersonasDadasBaja()
        {
            return LibAux.EjecutarProcedimiento("SP_CONSULTAR_BajasEmpleados");
        }

    }
}
