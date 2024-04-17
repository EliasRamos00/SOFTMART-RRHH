using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFTMART_RRHH.Modelo
{
    internal class MUsuarios
    {
        internal static void ActualizarUsuario(object usuario, object password, object rol, object idPersona, object idUsuario)
        {
            List<Param> @params = new List<Param> {
            new Param("vUsuario",usuario),
            new Param("vPassword",password),
            new Param("vRol",rol),
            new Param("vIdPersona",idPersona),
            new Param("vIdUsuario",idUsuario),
            new Param("vidCurrentUser",Properties.Settings.Default.idUsuario)
            };
            LibAux.EjecutarProcedimiento("SP_ACTUALIZAR_Usuario", @params);
        }

        internal static void AgregarUsuario(object usuario, object password, object rol, object idPersona)
        {
            List<Param> @params = new List<Param> {
            new Param("vUsuario",usuario),
            new Param("vPassword",password),
            new Param("vRol",rol),
            new Param("vIdPersona",idPersona),
            new Param("vidCurrentUser",Properties.Settings.Default.idUsuario)
            };
            LibAux.EjecutarProcedimiento("SP_INSERTAR_Usuario", @params);
        }

        internal static void EliminarUsuario(int idUsuario)
        {
            List<Param> @params = new List<Param> {
            new Param("vidUsuario",idUsuario),
            new Param("vidCurrentUser",Properties.Settings.Default.idUsuario)
            };
            LibAux.EjecutarProcedimiento("SP_ELIMINAR_Usuario", @params);
        }

        internal static string ObtenerNombrePersona(int idPersona)
        {
            List<Param> @params = new List<Param> {
            new Param("vidPersona",idPersona),
            };
            return (LibAux.EjecutarSentencia("SELECT CONCAT_WS(' ',Nombre,ApellPaterno,ApellMaterno) as Nombre FROM Personas WHERE idPersona = @vidPersona", @params)).Rows[0][0].ToString();
        }

        internal static object ObtenerUsuarios()
        {
            return LibAux.EjecutarProcedimiento("SP_CONSULTAR_Usuarios");
        }
    }
}
