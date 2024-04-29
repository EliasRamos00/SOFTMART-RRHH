using MySqlConnector;
using SOFTMART_RRHH.Modelo;
using System;
using System.Collections.Generic;
using System.Data;


namespace SOFTMART_RRHH.Controlador
{
    internal class MPersonas
    {
        public static DataTable CInsertarPersona(object nombres, object apePat, object apeMat, object rFC, object cURP,
            object lugarNac, object genero, DateTime FechaNac, object fotografia, object idEscolaridad, object Especialidad, object edoCivil, object nSS, object infoEmer, object iNESourcePath, MySqlCommand cmd)
        {
            List<Param> parametros = new List<Param>
            {
                new Param("vNombres",nombres),
                new Param("vApellidoPaterno",apePat),
                new Param("vApellidoMaterno",apeMat),
                new Param("vRFC",rFC),
                new Param("vCURP",cURP),
                new Param("vGenero",genero),
                new Param("vFechaNac",FechaNac),
                new Param("vLugarNac",lugarNac),
                new Param("vFotografia",fotografia),
                new Param("vidEscolaridad",idEscolaridad),
                new Param("vEspecialidad",Especialidad),
                new Param("vEdoCivil",edoCivil),
                new Param("vNSS",nSS),
                new Param("vInfoEmerg",infoEmer),
                new Param("vINE",iNESourcePath),
                new Param("vidCurrentUserPerso",Properties.Settings.Default.idUsuario)
            };
            return LibAux.EjecutarProcedimiento("SP_INSERTA_Persona", cmd, parametros);
        }
        internal static void CModificarPersona(int idPersona, object nombres, object apePat, object apeMat, object rFC, object cURP, object lugarNac, object genero, DateTime fechaNac, object fotografia, object idEscolaridad, object especialidad, object edoCivil, object nSS, object infoEmer, object iNESourcePath, MySqlCommand cmd)
        {
            List<Param> parametros = new List<Param>
            {
                new Param("vidPersona",idPersona),
                new Param("vNombres",nombres),
                new Param("vApellidoPaterno",apePat),
                new Param("vApellidoMaterno",apeMat),
                new Param("vRFC",rFC),
                new Param("vCURP",cURP),
                new Param("vGenero",genero),
                new Param("vFechaNac",fechaNac),
                new Param("vLugarNac",lugarNac),
                new Param("vFotografia",fotografia),
                new Param("vidEscolaridad",idEscolaridad),
                new Param("vEspecialidad",especialidad),
                new Param("vEdoCivil",edoCivil),
                new Param("vNSS",nSS),
                new Param("vInfoEmerg",infoEmer),
                new Param("vINE",iNESourcePath),
                new Param("vidCurrentUserPerso",Properties.Settings.Default.idUsuario)


            };
            LibAux.EjecutarProcedimiento("SP_ACTUALIZAR_Persona", cmd, parametros);

        }
        internal static int ObtenerIdPersonaByIdEmpleado(int idEmpleado)
        {
            try
            {
                List<Param> parametros = new List<Param>
            {
                new Param("vidEmpleado",idEmpleado)
            };

                DataTable temp = LibAux.EjecutarSentencia("SELECT FN_IdPersonabyIdEmpleado(?vidEmpleado)", parametros);

                return Convert.ToInt16(temp.Rows[0][0].ToString());
            }
            catch (Exception ex) { LibAux.ErrorLog(ex); return 0; }
        }
        internal static DataTable ObtenerPersonaInformacionByCURP(string CURP)
        {
            List<Param> parametros = new List<Param>
            {
                new Param("vCURP",CURP)
            };
            return LibAux.EjecutarSentencia("SELECT * FROM  Personas p LEFT JOIN Escolaridades e ON e.idEscolaridad = p.idEscolaridad INNER JOIN Domicilios d ON p.idDomicilio = d.idDomicilio  INNER JOIN Contactos c ON c.idContacto = p.idContacto AND p.CURP LIKE @vCURP ;", parametros);
        }
        internal static DataTable ObtenerUltimoIDPersona()
        {
            return LibAux.EjecutarSentencia("SELECT FN_UltimoIdPersona()");
        }
    }
}
