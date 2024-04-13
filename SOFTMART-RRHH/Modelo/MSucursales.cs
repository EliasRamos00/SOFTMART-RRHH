using SOFTMART_RRHH.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFTMART_RRHH.Controlador
{
    internal class MSucursales
    {
        internal static DataTable ObtenerSucursales()
        {
            return LibAux.EjecutarProcedimiento("SP_CONSULTAR_Sucursales");
        }
    }
}
