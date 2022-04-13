using System;
using System.Data;
using System.Windows.Forms;
using Common.Cache;
using Domain;


namespace ConsultasSQL
{
    public partial class FrmCorreo : Form
    {
        public FrmCorreo()
        {
            InitializeComponent();
        }
        

        private void FrmCorreo_Load(object sender, EventArgs e)
        {
            txtClave.UseSystemPasswordChar = true;
            txtClave.Enabled = false;
            this.LoadMail();
        }
        private void toHide()
        {
            pcCorreo.Visible = false;
            lblCorreo.Visible = false;
            lblContraseña.Visible = false;
            txtEmail.Visible = false;
            txtClave.Visible = false;
            btnGuardar.Visible = false;
            btnCancelar.Visible = false;
            lblHost.Visible = false;
            txtHost.Visible = false;
            lblPuerto.Visible = false;
            txtPort.Visible = false;
            lblSsl.Visible = false;
            cmbSsl.Visible = false;
            linkPassword.Visible = false;
            lblErrorMessagge.Visible = false;
            btnCambiar.Visible = true;

        }

        private void toShow()
        {
            pcCorreo.Visible = true;
            lblCorreo.Visible = true;
            lblContraseña.Visible = true;
            txtEmail.Visible = true;
            txtClave.Visible = true;
            btnGuardar.Visible = true;
            btnCancelar.Visible = true;
            lblHost.Visible = true;
            txtHost.Visible = true;
            lblPuerto.Visible = true;
            txtPort.Visible = true;
            lblSsl.Visible = true;
            cmbSsl.Visible = true;
            linkPassword.Visible = true;
            btnCambiar.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEmail.Text = lblCorreoA.Text.Trim();
            txtHost.Text = lblHostA.Text.Trim();
            txtPort.Text = lblPortA.Text.Trim();
            cmbSsl.Text = lblSslA.Text.Trim();
            MailData data = new MailData();
            txtClave.Text = MailCache.PasswordMail;
            


            this.toShow();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.toHide();
            this.ResetLink();

        }

        private string option = "sinClave";
        
        private void msgError(string msg)
        {
            lblErrorMessagge.Text = "     " + msg;
            lblErrorMessagge.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (option.Equals("sinClave"))
            {
                try
                {
                    string rpta = "";
                    if(txtEmail.Text == string.Empty || txtHost.Text == string.Empty || txtPort.Text == string.Empty || cmbSsl.Text == string.Empty || txtClave.Text == string.Empty)
                    {
                        msgError("Faltan ingresar algunos datos.");
                    }
                    else
                    {
                        if (cmbSsl.Text.Equals("Si"))  {
                            rpta = DomainMail.actualizar(1, txtEmail.Text.Trim(), txtClave.Text.Trim(), txtHost.Text.Trim(), Convert.ToInt32(txtPort.Text.Trim()), 1);
                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se actualizó de forma correcta el correo.");
                                this.LoadMail();
                                this.toHide();
                            }
                            else
                            {
                                this.ErrorMessagge(rpta);
                            }
                        }
                        else if (cmbSsl.Text.Equals("No"))
                        {
                            
                            rpta = DomainMail.actualizar(1, txtEmail.Text.Trim(), txtClave.Text.Trim(), txtHost.Text.Trim(), Convert.ToInt32(txtPort.Text.Trim()), 0);
                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se actualizó de forma correcta el correo.");
                                this.LoadMail();
                                this.toHide();
                            }
                            else
                            {
                                this.ErrorMessagge(rpta);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Error al seleccionar dato del ComboBox.");   
                        }
                        
                    }
                        
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            else if (option.Equals("conClave"))
            {
                try
                {
                    string rpta = "";
                    if (txtEmail.Text == string.Empty || txtHost.Text == string.Empty || txtPort.Text == string.Empty || cmbSsl.Text == string.Empty || txtClave.Text == string.Empty || txtConfirmar.Text == string.Empty)
                    {
                        msgError("Faltan ingresar algunos datos.");
                    }
                    else if (txtClave.Text.Trim() != txtConfirmar.Text.Trim())
                    {
                        msgError("Las contraseñas no coinciden");
                    }
                    else
                    {
                        if (cmbSsl.Text.Equals("Si"))
                        {
                            rpta = DomainMail.actualizar(1, txtEmail.Text.Trim(), txtClave.Text.Trim(), txtHost.Text.Trim(), Convert.ToInt32(txtPort.Text.Trim()), 1);
                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se actualizó de forma correcta el correo.");
                                this.LoadMail();
                                this.toHide();
                            }
                            else
                            {
                                this.ErrorMessagge(rpta);
                            }
                        }
                        else if (cmbSsl.Text.Equals("No"))
                        {

                            rpta = DomainMail.actualizar(1, txtEmail.Text.Trim(), txtClave.Text.Trim(), txtHost.Text.Trim(), Convert.ToInt32(txtPort.Text.Trim()), 0);
                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se actualizó de forma correcta el correo.");
                                this.LoadMail();
                                this.toHide();
                            }
                            else
                            {
                                this.ErrorMessagge(rpta);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Error al seleccionar dato del ComboBox.");
                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de salidas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void ErrorMessagge(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de salidas", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                    this.ErrorMessagge("No existe el id.");
                }
                else
                {
                    DataRow row = tabla.Rows[0];
                    
                    lblCorreoA.Text = Convert.ToString(row["senderMail"]);
                    lblHostA.Text = Convert.ToString(row["correo_host"]);
                    lblPortA.Text = Convert.ToString(row["correo_port"]);
                    if (Convert.ToString(row["correo_ssl"]).Equals("1"))
                    {
                        lblSslA.Text = "Si";
                    }
                    else
                    {
                        lblSslA.Text = "No";
                    }
                    //Caché
                    MailCache.PasswordMail = Convert.ToString(row["correo_password"]);

                }
            }
            catch (Exception ex)
            {
                ErrorMessagge(ex + " Error");
            }

        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblContraseña.Text = "Nueva contraseña:";
            txtClave.Enabled = true;
            txtClave.Clear();
            txtClave.Focus();
            linkPassword.Visible = false;
            lblConfirmar.Visible = true;
            txtConfirmar.Visible = true;
            txtConfirmar.UseSystemPasswordChar = true;
            option = "conClave";

        }
        private void ResetLink()
        {
            
            txtClave.Enabled = false;
            lblContraseña.Text = "Contraseña";
            txtConfirmar.Clear();
            txtConfirmar.Visible = false;
            lblConfirmar.Visible = false;
            option = "sinClave";
        }

        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
    }
}
