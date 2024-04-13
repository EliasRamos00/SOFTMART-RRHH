using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
