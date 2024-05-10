using SOFTMART_RRHH.Controlador;
using SOFTMART_RRHH.Modelo;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SOFTMART_RRHH.Vista
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            string filepath = System.Windows.Forms.Application.StartupPath;
            string ProyectPathPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(filepath, @"..\..\"));
            string newPath = System.IO.Path.Combine(ProyectPathPath, "Dev\\");
            if (!Directory.Exists(newPath)) // Si no |existe... Es produccion
            {
                Properties.Settings.Default.Ip = ConfigurationManager.AppSettings["produccion_IP"];
                Properties.Settings.Default.Usuario = ConfigurationManager.AppSettings["produccion_User"];
                Properties.Settings.Default.Contrasenia = ConfigurationManager.AppSettings["produccion_Pass"];
                Properties.Settings.Default.BD = ConfigurationManager.AppSettings["produccion_BD"];
                Properties.Settings.Default.Port = ConfigurationManager.AppSettings["produccion_Port"];
            }
            else
            { //Es Entorno de Desarrollo
                Properties.Settings.Default.Ip = ConfigurationManager.AppSettings["IP"];
                Properties.Settings.Default.Usuario = ConfigurationManager.AppSettings["User"];
                Properties.Settings.Default.Contrasenia = ConfigurationManager.AppSettings["Pass"];
                Properties.Settings.Default.BD = ConfigurationManager.AppSettings["BD"];
                Properties.Settings.Default.Port = ConfigurationManager.AppSettings["Port"];
            }
        }

        private void btnIniciar(object sender, EventArgs e)
        {
            string usuario = tbUsuario.Text;
            string password = tbPassword.Text;
            if (CLogin.CAutenticarUsuario(usuario, password))
            {
                this.Hide();
                frmPrincipal FormularioPrincipal = new frmPrincipal();
                FormularioPrincipal.Show();
            }
            else
            {
                LibAux.PopUp("¡ATENCIÓN!", "Usuario o Contraseña incorrectos.", LibAux.TipoNotif.Info);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "Usuario")
            {
                tbUsuario.Text = "";
                tbUsuario.ForeColor = Color.LightGray;
            }
        }

        private void tbUsuario_Leave(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "")
            {
                tbUsuario.Text = "Usuario";
                tbUsuario.ForeColor = Color.DarkGray;
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Contraseña")
            {
                tbPassword.Text = "";
                tbPassword.ForeColor = Color.LightGray;
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "Contraseña";
                tbPassword.ForeColor = Color.DarkGray;
                tbPassword.UseSystemPasswordChar = false;
            }
        }
        private void frm_Login_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void tbPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnIniciar(sender, e);
            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = tbUsuario;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
