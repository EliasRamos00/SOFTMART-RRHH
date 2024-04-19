using MySqlConnector;
using SOFTMART_RRHH.Modelo;
using System;
using System.Security.Cryptography;
using System.Text;

namespace SOFTMART_RRHH.Controlador
{
    class CLogin
    {
        public static bool CAutenticarUsuario(string usuario, string password)
        {
            MLogin User = new MLogin();
            User.User = usuario;
            User.Password = GeneraHashMD5(password);
            User.Conex = new MySqlConnection(LibAux.CadenaConexion());

            return MLogin.MAutenticarUsuario(User);
        }

        static string GeneraHashMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convierte el hash en una cadena hexadecimal
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
    }
}
