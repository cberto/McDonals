using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;

namespace Mc_Donalds
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.ClientSize.Width / 2 - pnlLogin.Size.Width / 2, this.ClientSize.Height / 2 - pnlLogin.Size.Height / 2);
            Rol rol = new Rol("Cajero");
            Usuario usuario = new Usuario("Maria","Cuello","Maria123", "abc123", "maria@gmail.com", rol);
            Usuario.agregar(usuario);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
            }
            pnlUsuario.BackColor = Color.Yellow;
        }

        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.PasswordChar = '*';
            }
            pnlContraseña.BackColor = Color.Yellow;
        }

        private void TxtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.PasswordChar = '\0';
            }
            pnlContraseña.BackColor = Color.White;
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
            }
            pnlUsuario.BackColor = Color.White;
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if(Usuario.verificarInicioSesion(txtUsuario.Text, txtContraseña.Text))
            {
                if (Usuario.verificarRol(txtUsuario.Text).Nombre == "Cajero")
                {
                    FormVenta formVenta = new FormVenta();
                    formVenta.Show();
                    this.Visible = false;
                }
                if(Usuario.verificarRol(txtUsuario.Text).Nombre == "Administrador")
                {
                    FormAdministracion formAdministracion = new FormAdministracion();
                    formAdministracion.Show();
                    this.Visible = false;
                }
            }
            else
            {
                McDonaldsMessageBox msj = new McDonaldsMessageBox();
                msj.Mensaje("Usuario o contraseña incorrecto");
                msj.Show();
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
