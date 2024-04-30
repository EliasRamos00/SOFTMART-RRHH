using MySqlConnector;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

using System.IO;

using static SOFTMART_RRHH.Modelo.LibAux;

namespace SOFTMART_RRHH.Controlador
{
    internal class CAltaPersonal
    {
        internal static void CInsertarPersonal(string medio, string valor, object estado, object ciudad, object colonia, object cP, object calleNum,
            object nombres, object apePat, object apeMat, object rFC, object cURP, object lugarNac, object genero, DateTime fechaNac,
            object fotografiaDestino, object idEscolaridad, object especialidad, object numContrato, object idSucursal, object idPuesto, DateTime fechaingreso,
            object EdoCivil, object esTemp, object sueldo, bool existioPersona, object NSS, object InfoEmer, object fotografiaOrigen, object iNEOrigen, object iNE_Destino, object comentarios)
        {
            //------  SE INICIA LA TRANSACCIÓN Y SE ENVIA LA INFORMACIÓN AL MODELO -------
            MySqlConnection conn = new MySqlConnection(CadenaConexion());
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            MySqlTransaction transact;
            transact = conn.BeginTransaction();
            cmd.Transaction = transact;
            try
            {
                if (!existioPersona) // SI LA PERSONA nunca habia sido registrada antes entonces...
                {
                    MContactos.CInsertarContacto(medio, valor, cmd);
                    MDomicilios.CInsertarDomicilio(estado, ciudad, colonia, cP, calleNum, cmd);
                    DataTable dtemp = MPersonas.CInsertarPersona(nombres, apePat, apeMat, rFC, cURP, lugarNac, genero, fechaNac, fotografiaDestino, idEscolaridad, especialidad, EdoCivil, NSS, InfoEmer, iNE_Destino, cmd);

                    object idPersona = dtemp.Rows[0]["idPersona"].ToString();
                    MEmpleados.CInsertarEmpleado(idPersona, numContrato, idSucursal, idPuesto, fechaingreso, esTemp, sueldo, comentarios, cmd);
                }
                else //Si la persona ya existia en la tabla personas entonces... solo se inserta al empleado con su nuevo num. de contrato.
                {
                    DataTable dtemp = MPersonas.ObtenerPersonaInformacionByCURP(cURP.ToString());
                    object idPersona = dtemp.Rows[0]["idPersona"].ToString();
                    MEmpleados.CInsertarEmpleado(idPersona, numContrato, idSucursal, idPuesto, fechaingreso, esTemp, sueldo, comentarios, cmd);
                }


                fotografiaDestino = "\\\\" + Properties.Settings.Default.Ip + "" + fotografiaDestino.ToString();
                iNE_Destino = "\\\\" + Properties.Settings.Default.Ip + "\\" + iNE_Destino.ToString();

                if (fotografiaOrigen.ToString() != "" && fotografiaDestino.ToString() != "")
                { //GUARDA LA FOTO PERO EN EL SERVIDOR (Foto personal e INE)
                    File.Copy(fotografiaOrigen.ToString(), fotografiaDestino.ToString(), true);
                    File.SetAttributes(fotografiaDestino.ToString(), FileAttributes.Normal);
                }
                if (iNEOrigen.ToString() != "" && iNE_Destino.ToString() != "")
                {
                    File.Copy(iNEOrigen.ToString(), iNE_Destino.ToString(), true);
                    File.SetAttributes(iNE_Destino.ToString(), FileAttributes.Normal);
                }

                transact.Commit();
                PopUp("Registro terminado", "Empleado dado de alta con éxito.", TipoNotif.Success);
            }
            catch (Exception ex)
            {
                ErrorLog(ex);
                transact.Rollback();
                bool err = false;
                Dictionary<string, string> errorMessages = new Dictionary<string, string>
                {
                    {"'CURP' cannot be null", "Ingresa la CURP."},
                    {"'RFC' cannot be null", "Ingresa el RFC."},
                    {"'idSucursal' cannot be null", "Selecciona una sucursal."},
                    {"'idPuesto' cannot be null", "Selecciona un puesto."},
                    {"'NumContrato' cannot be null", "Ingresa el numero de contrato."},
                    {"Valor", "Ingresa un telefono."},
                    {"Estado", "Ingresa un estado."},
                    {"Nombre", "Ingresa un nombre."},
                    {"Paterno", "Ingresa un Apellido paterno."},
                    {"UK_CURP", "Esta CURP ya existe. Verifica la información."},
                    {"UK_NumContrato", "Este numero de contrato ya existe."},
                    {"integer value", "Ingresa un numero valido en numero de contrato."}

                };

                foreach (var errorMessage in errorMessages)
                {
                    if (ex.Message.Contains(errorMessage.Key) && ex.Message.Contains("null"))
                    {
                        ShowNotification(errorMessage.Value, TipoNotif.Info);
                        err = true;
                        break;
                    }
                    else
                    if (ex.Message.Contains(errorMessage.Key) && ex.Message.Contains("UK"))
                    {
                        ShowNotification(errorMessage.Value, TipoNotif.Error);
                        err = true;
                        break;
                    }
                    else
                    if (ex.Message.Contains(errorMessage.Key) && ex.Message.Contains("integer"))
                    {
                        ShowNotification(errorMessage.Value, TipoNotif.Error);
                        err = true;
                        break;
                    }
                }
                if (!err)
                    ShowNotification("Error desconocido - " + ex.Message, TipoNotif.Error);
            }
        }

        internal static bool CModificarPersonal(string medio, object valor, object estado, object ciudad, object colonia, object cP, object calleNum,
            object nombres, object apePat, object apeMat, object rFC, object cURP, object lugarNac, object genero,
            DateTime fechaNac, object fotografiaDestino, object idEscolaridad, object especialidad, object numContrato,
            object idSucursal, object idPuesto, DateTime fechaingreso, object edoCivil, object esTemp, object sueldo, int idEmpleado, int idPersona, object NSS, object InfoEmer, object fotografiaOrigen, object iNEOrigen, object iNE_Destino, object comentarios)
        {
            int idContacto = MContactos.ObtenerIdContactoByIdPersona(idPersona);
            int idDomicilio = MDomicilios.ObtenerIdDomicilioByIdPersona(idPersona);

            //------  SE INICIA LA TRANSACCIÓN Y SE ENVIA LA INFORMACIÓN AL MODELO -------
            MySqlConnection conn = new MySqlConnection(CadenaConexion());
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            MySqlTransaction transact;
            transact = conn.BeginTransaction();
            cmd.Transaction = transact;
            try
            {
                MContactos.CModificarContacto(idContacto, medio, valor, cmd);
                MDomicilios.CModificarDomicilio(idDomicilio, estado, ciudad, colonia, cP, calleNum, cmd);
                MPersonas.CModificarPersona(idPersona, nombres, apePat, apeMat, rFC, cURP, lugarNac, genero, fechaNac, fotografiaDestino, idEscolaridad, especialidad, edoCivil, NSS, InfoEmer, iNE_Destino, cmd);
                MEmpleados.CModificarEmpleado(idEmpleado, numContrato, idSucursal, idPuesto, fechaingreso, esTemp, sueldo, comentarios, cmd);

                fotografiaDestino = "\\\\" + Properties.Settings.Default.Ip + "" + fotografiaDestino.ToString();
                iNE_Destino = "\\\\" + Properties.Settings.Default.Ip + "\\" + iNE_Destino.ToString();

                if (fotografiaOrigen.ToString() != "" && fotografiaDestino.ToString() != "")
                {
                    File.Copy(fotografiaOrigen.ToString(), fotografiaDestino.ToString(), true);
                    File.SetAttributes(fotografiaDestino.ToString(), FileAttributes.Normal);
                }

                if (iNEOrigen.ToString() != "" && iNE_Destino.ToString() != "")
                {
                    File.Copy(iNEOrigen.ToString(), iNE_Destino.ToString(), true);
                    File.SetAttributes(iNE_Destino.ToString(), FileAttributes.Normal);
                }
                transact.Commit();
                PopUp("Registro actualizado", "Empleado modificado con éxito.", TipoNotif.Success);
                return true;
            }
            catch (Exception ex)
            {
                ErrorLog(ex);
                transact.Rollback();
                bool err = false;
                Dictionary<string, string> errorMessages = new Dictionary<string, string>
                {
                    {"'CURP' cannot be null", "Ingresa la CURP."},
                    {"'RFC' cannot be null", "Ingresa el RFC."},
                    {"'idSucursal' cannot be null", "Selecciona una sucursal."},
                    {"'idPuesto' cannot be null", "Selecciona un puesto."},
                    {"'NumContrato' cannot be null", "Ingresa el numero de contrato."},
                    {"Valor", "Ingresa un telefono."},
                    {"Estado", "Ingresa un estado."},
                    {"Nombre", "Ingresa un nombre."},
                    {"Paterno", "Ingresa un Apellido paterno."},
                    {"UK_CURP", "Esta CURP ya existe. Verifica la información."},
                    {"UK_NumContrato", "Este numero de contrato ya existe."},
                    {"integer value", "Ingresa un numero valido en numero de contrato."}

                };

                foreach (var errorMessage in errorMessages)
                {
                    if (ex.Message.Contains(errorMessage.Key) && ex.Message.Contains("null"))
                    {
                        ShowNotification(errorMessage.Value, TipoNotif.Info);
                        err = true;
                        break;
                    }
                    else
                    if (ex.Message.Contains(errorMessage.Key) && ex.Message.Contains("UK"))
                    {
                        ShowNotification(errorMessage.Value, TipoNotif.Error);
                        err = true;
                        break;
                    }
                    else
                    if (ex.Message.Contains(errorMessage.Key) && ex.Message.Contains("integer"))
                    {
                        ShowNotification(errorMessage.Value, TipoNotif.Error);
                        err = true;
                        break;
                    }
                }
                if (!err)
                    ShowNotification("Error desconocido - " + ex.Message, TipoNotif.Error);
                return false;
            }
        }

        // Método para mostrar la notificación
        static void ShowNotification(string message, TipoNotif type)
        {
            PopUp("¡ATENCIÓN!", message, type);
        }
    }
}
