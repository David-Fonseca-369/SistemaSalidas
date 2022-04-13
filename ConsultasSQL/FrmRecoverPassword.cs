using System;
using System.Data;
using System.Windows.Forms;
using Common.Cache;
using Domain;
using System.Runtime.InteropServices;


namespace ConsultasSQL
{
    public partial class FrmRecoverPassword : Form
    {
        public FrmRecoverPassword()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmRecoverPassword_Load(object sender, EventArgs e)
        {
            LoadMail();
        }
        private void LoadMail()
        {
            try
            {

                DataTable tabla = new DataTable();
                //id correo registrado.
                tabla = DomainMail.traerCorreo("1");
                if (tabla.Rows.Count <= 0)
                {
                    this.ErrorMessagge("No existe el id del correo.");
                }
                else
                {
                    DataRow row = tabla.Rows[0];
                    //Caché
                    MailCache.senderMail = Convert.ToString(row["senderMail"]);
                    MailCache.host = Convert.ToString(row["correo_host"]);
                    MailCache.port = Convert.ToInt32(row["correo_port"]);
                    MailCache.ssl = Convert.ToInt32(row["correo_ssl"]);
                    MailCache.PasswordMail = Convert.ToString(row["correo_password"]);

                }
            }
            catch (Exception ex)
            {
                ErrorMessagge(ex + " Error");
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ErrorMessagge(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de salidas", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var user = new UserModel();
            var result = user.recoverPassword(txtUserRequest.Text);
            lblAceptMessagge.Text = "     "+result;
            lblAceptMessagge.Visible = true;
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
}
   
}
