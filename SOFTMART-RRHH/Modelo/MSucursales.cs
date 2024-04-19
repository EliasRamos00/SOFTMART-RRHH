using SOFTMART_RRHH.Modelo;
using System.Data;


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
