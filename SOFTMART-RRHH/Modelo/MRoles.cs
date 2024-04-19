
using System.Data;


namespace SOFTMART_RRHH.Modelo
{
    internal class MRoles
    {
        internal static DataTable ConsultarPerAdmin()
        {
            return LibAux.EjecutarProcedimiento("SP_CONSULTAR_PersonasAdministrativas");
        }

        internal static DataTable ConsultarRoles()
        {
            return LibAux.EjecutarSentencia("SELECT Rol FROM Roles");
        }
    }
}
