using SOFTMART_RRHH.Controlador;
using SOFTMART_RRHH.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFTMART_RRHH.Vista
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
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
                button1_Click(sender, e);
            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = tbUsuario;
        }
    }
}
