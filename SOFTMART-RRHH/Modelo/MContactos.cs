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
    internal class MContactos
    {
        internal static void CInsertarContacto(string medio, string valor, MySqlCommand cmd)
        {
            List<Param> parametros = new List<Param>
            {
                new Param("vMedio",medio),
                new Param("vValor",valor),
                new Param("vidCurrentUserContact",Properties.Settings.Default.idUsuario)
            };
            LibAux.EjecutarProcedimiento("SP_INSERTA_Contacto", cmd, parametros);
        }
        internal static void CModificarContacto(int idContacto, string medio, object valor, MySqlCommand cmd)
        {
            List<Param> parametros = new List<Param>
            {
                new Param("vidContacto",idContacto),
                new Param("vMedio",medio),
                new Param("vValor",valor),
                new Param("vidCurrentUserContact",Properties.Settings.Default.idUsuario)
            };
            LibAux.EjecutarProcedimiento("SP_ACTUALIZAR_Contacto", cmd, parametros);
        }
        internal static int ObtenerIdContactoByIdPersona(int idPersona)
        {
            List<Param> parametros = new List<Param>
            {
                new Param("vidPersona",idPersona)
            };
            DataTable temp = LibAux.EjecutarSentencia("SELECT FN_IdContactoByIdPersona(?vidPersona)", parametros);
            return Convert.ToInt16(temp.Rows[0][0].ToString());
        }
    }
}
