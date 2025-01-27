using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFTMART_RRHH.Modelo
{
    internal class MSueldos
    {
        internal static DataTable ObtenerSueldosEmpleados(DateTime MesAnioActual, DateTime MesAnioAnterior, string QuincenaActual, string QuincenaAnterior) // Se envia la fecha para obtener a los empleados activos en la quincena
        {
            List<Param> @params = new List<Param>();


            if (QuincenaActual.ToLower().Contains("1er"))
            {

                @params.Add(new Param("vInicio", new DateTime(MesAnioActual.Year, MesAnioActual.Month, 1))); // Se manda el 16 como fecha inicial del mes
                @params.Add(new Param("vFinal", new DateTime(MesAnioActual.Year, MesAnioActual.Month, 15))); // Y la fecha maxima del mes en concreto.


            }
            else if(QuincenaActual.ToLower().Contains("2da"))
            {

                int ultimoDia = DateTime.DaysInMonth(MesAnioActual.Year, MesAnioActual.Month); // Obtiene el último día del mes
                DateTime fechaMaxima = new DateTime(MesAnioActual.Year, MesAnioActual.Month, ultimoDia); // Crea la fecha máxima

                @params.Add(new Param("vInicio", new DateTime(MesAnioActual.Year, MesAnioActual.Month, 16))); // Se manda el 16 como fecha inicial del mes
                @params.Add(new Param("vFinal", fechaMaxima)); // Y la fecha maxima del mes en concreto.

            }

            // SE ENVIAN POR PARAMETROS LAS FECHAS POR SEPARADO, ENTRE LA QUINCENA ACTUAL Y LA ANTERIOR.

            if (QuincenaAnterior.ToLower().Contains("1er"))
            {

                @params.Add(new Param("vInicioAux", new DateTime(MesAnioAnterior.Year, MesAnioAnterior.Month, 1))); // Se manda el 16 como fecha inicial del mes
                @params.Add(new Param("vFinalAux", new DateTime(MesAnioAnterior.Year, MesAnioAnterior.Month, 15))); // Y la fecha maxima del mes en concreto.


            }
            else if (QuincenaAnterior.ToLower().Contains("2da"))
            {

                int ultimoDia = DateTime.DaysInMonth(MesAnioAnterior.Year, MesAnioAnterior.Month); // Obtiene el último día del mes
                DateTime fechaMaxima = new DateTime(MesAnioAnterior.Year, MesAnioAnterior.Month, ultimoDia); // Crea la fecha máxima

                @params.Add(new Param("vInicioAux", new DateTime(MesAnioAnterior.Year, MesAnioAnterior.Month, 16))); // Se manda el 16 como fecha inicial del mes
                @params.Add(new Param("vFinalAux", fechaMaxima)); // Y la fecha maxima del mes en concreto.

            }




            //if (MesAnioActual.Day >= 16) // ES SEGUNDA QUINCENA
            //{
               
            //    int ultimoDia = DateTime.DaysInMonth(MesAnioActual.Year, MesAnioActual.Month); // Obtiene el último día del mes
            //    DateTime fechaMaxima = new DateTime(MesAnioActual.Year, MesAnioActual.Month, ultimoDia); // Crea la fecha máxima
               
            //    @params.Add(new Param("vInicio", new DateTime(MesAnioActual.Year, MesAnioActual.Month, 16))); // Se manda el 16 como fecha inicial del mes
            //    @params.Add(new Param("vFinal", fechaMaxima)); // Y la fecha maxima del mes en concreto.

            //    @params.Add(new Param("vInicioAux", new DateTime(MesAnioAnterior.Year, MesAnioAnterior.Month, 1))); // 
            //    @params.Add(new Param("vFinalAux", new DateTime(MesAnioAnterior.Year, MesAnioAnterior.Month, 15))); // 
            //}
            //else // PRIMER QUINCENA
            //{
            //    @params.Add(new Param("vInicio", new DateTime(MesAnioActual.Year, MesAnioActual.Month, 1))); // Se manda el 1 como fecha inicial del mes
            //    @params.Add(new Param("vFinal", new DateTime(MesAnioActual.Year, MesAnioActual.Month, 15))); // Y la fecha maxima del mes en concreto.

            //    DateTime FechaAux = MesAnioAnterior; // Se tiene que tomar el mes anterior.

            //    int ultimoDia = DateTime.DaysInMonth(FechaAux.Year, FechaAux.Month); // Obtiene el último día del mes
            //    DateTime fechaMaxima = new DateTime(FechaAux.Year, FechaAux.Month, ultimoDia); // Crea la fecha máxima


            //    @params.Add(new Param("vInicioAux", new DateTime(fechaMaxima.Year, fechaMaxima.Month, 16))); // 
            //    @params.Add(new Param("vFinalAux", fechaMaxima)); // 

            //}


            

            return LibAux.EjecutarProcedimiento("SP_CONSULTAR_SueldosEmpleados", @params);
        }
    }
}
