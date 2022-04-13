using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Domain;


namespace ConsultasSQL
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if(txtEmail.Text.Equals("EMAIL"))
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.LightGray;

            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals(""))
            {
                txtEmail.Text = "EMAIL";
                txtEmail.ForeColor = Color.DimGray;
            }
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text.Equals("CLAVE")){
                txtClave.Text = "";
                txtClave.ForeColor = Color.LightGray;
                txtClave.UseSystemPasswordChar = true;


            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text.Equals(""))
            {
                txtClave.Text = "CLAVE";
                txtClave.ForeColor = Color.DimGray;
                txtClave.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Logout (object sender, FormClosedEventArgs e)
        {
            txtClave.Text = "CLAVE";
            txtClave.UseSystemPasswordChar = false;
            txtEmail.Text = "EMAIL";
            lblErrorMessagge.Visible = false;
            this.Show();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if( txtEmail.Text != "EMAIL")
            {
                if(txtClave.Text != "CLAVE")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtEmail.Text, txtClave.Text);
                    if(validLogin == true)
                    {
                        if (Common.Cache.UserLogin.Estado == 0)
                        {
                            msgError(" Este usuario está desactivado. \n     Por favor, comunícate con TI.");
                        }
                        else if (Common.Cache.UserLogin.Estado == 1)
                        {
                            FrmPrincipal formPrincipal = new FrmPrincipal();
                            formPrincipal.Show();
                            formPrincipal.FormClosed += Logout;

                            this.Hide();
                        }
                        
                    }
                    else{
                        msgError(" El email de usuario o clave son incorrectos. \n     Por favor intente nuevamente.");
                        txtClave.Text = "CLAVE";
                        txtClave.UseSystemPasswordChar = false;
                        txtEmail.Focus();

                    }

                }
                else
                
                    msgError(" Por favor ingresa una clave.");
           }
            else
                msgError(" Por favor ingresa un email.");

        }
        private void msgError(string msg)
        {
            lblErrorMessagge.Text = "    " + msg;
            lblErrorMessagge.Visible = true;
        }

        private void linkClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoverPassword = new FrmRecoverPassword();
            recoverPassword.ShowDialog();
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
