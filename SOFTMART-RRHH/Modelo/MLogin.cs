using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Documents;

namespace SOFTMART_RRHH.Modelo
{
    public class MLogin
    {


        private string _User;
        private string _Username;
        private string _Password;
        private int _Status;
        private string _Rolid;
        public MySqlConnection _Conex;

        public string User { get => _User; set => _User = value; }
        public string UserName { get => _Username; set => _Username = value; }
        public string Password { get => _Password; set => _Password = value; }
        public int Status { get => _Status; set => _Status = value; }
        public string _RolId { get => _Rolid; set => _Rolid = value; }
        public MySqlConnection Conex { get => _Conex; set => _Conex = value; }


        public static bool MAutenticarUsuario(MLogin ObjUser)
        {
            try
            {
                List<Param> parametros = new List<Param>
                {
                    new Param("usuario",ObjUser.User),
                    new Param("password",ObjUser.Password)
                };

                DataTable dtExiste = LibAux.EjecutarSentencia("SELECT Nombre,ApellPaterno,Rol FROM usuarios u, personas p WHERE usuario=@usuario AND password=@password AND p.idPersona = u.idPersona", parametros);
                if (dtExiste.Rows.Count >= 1)
                {
                    Properties.Settings.Default.User = dtExiste.Rows[0]["Nombre"].ToString() +" "+ dtExiste.Rows[0]["ApellPaterno"].ToString();
                    Properties.Settings.Default.Password = ObjUser.Password;
                    Properties.Settings.Default.Rol = dtExiste.Rows[0]["Rol"].ToString();
                    LibAux.PopUp("Sesión iniciada", "¡Bienvenido/a de vuelta: " + Properties.Settings.Default.User + "!", LibAux.TipoNotif.Success);
                    return true;
                }
            }
            catch { }
            return false;
        }
    }
}
