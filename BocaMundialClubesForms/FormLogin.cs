using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BocaMundialClubesForms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin; 
            btnLogin.Click += btnLogin_Click;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text;

            if (usuario == "admin" && contrasena == "1234")
            {
                FormEntradasDisponibles form = new FormEntradasDisponibles();
                form.Show();
                this.Hide(); // Oculta el login
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContrasena.Clear();
            }
        }
    }
}
