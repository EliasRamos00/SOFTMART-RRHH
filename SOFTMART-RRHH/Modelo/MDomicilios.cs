using MySqlConnector;
using SOFTMART_RRHH.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFTMART_RRHH.Controlador
{
    internal class MDomicilios
    {
        internal static void CInsertarDomicilio(object estado, object ciudad, object colonia, object cP, object calleNum, MySqlCommand cmd)
        {
            List<Param> parametros = new List<Param>
            {
                new Param("vEstado",estado),
                new Param("vCiudad",ciudad),
                new Param("vColonia",colonia),
                new Param("vCP",cP),
                new Param("vCalleNum",calleNum)

            };
            LibAux.EjecutarProcedimiento("SP_INSERTA_Domicilio", cmd, parametros);
        }
        internal static void CModificarDomicilio(int idDomicilio, object estado, object ciudad, object colonia, object cP, object calleNum, MySqlCommand cmd)
        {
            List<Param> parametros = new List<Param>
            {
                new Param("vidDomicilio",idDomicilio),
                new Param("vEstado",estado),
                new Param("vCiudad",ciudad),
                new Param("vColonia",colonia),
                new Param("vCodigoPostal",cP),
                new Param("vCalleNum",calleNum)
            };
            LibAux.EjecutarProcedimiento("SP_ACTUALIZAR_Domicilio", cmd, parametros);
        }
        internal static int ObtenerIdDomicilioByIdPersona(int idPersona)
        {
            List<Param> parametros = new List<Param>
            {
                new Param("vidPersona",idPersona)
            };
            DataTable temp = LibAux.EjecutarSentencia("SELECT FN_IdDomicilioByIdPersona(?vidPersona)", parametros);
            return Convert.ToInt16(temp.Rows[0][0].ToString());
        }
    }
}
