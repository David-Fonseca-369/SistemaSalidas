using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Common.Cache;
using Domain;

namespace ConsultasSQL
{
    public partial class FrmMantUsuario : Form
    {
        public FrmMantUsuario()
        {
            InitializeComponent();
            
        }


        private void LoadRole()
        {
            try
            {
                cmbRol.DataSource = DomainRol.ListRole();
                cmbRol.ValueMember = "idrol";
                cmbRol.DisplayMember = "nombre_rol";

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message+ ex.StackTrace);
            }
        }
        private void LoadArea()
        {
            try
            {
                cmbArea.DataSource = DomainArea.ListArea();
                cmbArea.ValueMember = "idarea";
                cmbArea.DisplayMember = "nombre_area";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FormType()
        {

            if (ModifyUser.Check == 1)
            {
                lblTitulo.Text = "Nuevo usuario";
                linkPassword.Visible = false;
                btnActualizar.Visible = false;
            }
            else if (ModifyUser.Check == 2)
            {
                lblTitulo.Text = "Modificar usuario";
                lblId.Visible = true;
                txtId.Visible = true;
                txtId.Text = Convert.ToString(ModifyUser.ID);
                txtNombre.Text = ModifyUser.Nombre;
                cmbRol.Text = ModifyUser.Rol;
                cmbArea.Text = ModifyUser.Area;
                txtEmail.Text = ModifyUser.Email;
                txtClave.Text = ModifyUser.Clave;
                linkPassword.Visible = true;
                txtClave.Enabled = false;
                txtConfirmar.Visible = false;
                lblConfirmar.Visible = false;
                btnActualizar.Visible = true;
                btnGuardar.Visible = false;

            }
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMantUsuario_Load(object sender, EventArgs e)
        {
            txtClave.UseSystemPasswordChar = true;
            txtConfirmar.UseSystemPasswordChar = true;
            LoadRole();
            LoadArea();
            FormType();
            

        }

        private void MensjaeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema salidas", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void MensjaeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema salidas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if(txtNombre.Text == string.Empty || cmbRol.Text == string.Empty || cmbArea.Text == string.Empty || txtEmail.Text == string.Empty || txtClave.Text == string.Empty || txtConfirmar.Text == string.Empty)
                {
                    this.MensjaeError("Falta ingresar algunos datos, serán remarcados.");
                    errorIcono.SetError(txtNombre, "Ingrese un nombre");
                    errorIcono.SetError(cmbRol, "Seleccione un rol.");
                    errorIcono.SetError(cmbArea, "Seleccione un área.");
                    errorIcono.SetError(txtEmail, "Ingrese un email.");
                    errorIcono.SetError(txtClave, "Ingrese una clave");
                    errorIcono.SetError(txtConfirmar, "Confirme la clave.");
                }
                 else if(txtClave.Text != txtConfirmar.Text){
                    errorIcono.SetError(txtConfirmar, "Las claves no coinciden.");
                    txtConfirmar.Clear();
                    txtConfirmar.Focus();

                }
                else
                {
                    rpta = DomainUser.Insert(Convert.ToInt32(cmbRol.SelectedValue), Convert.ToInt32(cmbArea.SelectedValue), txtNombre.Text.Trim(), txtEmail.Text.Trim(), txtClave.Text.Trim(), 1);
                    if(rpta.Equals("OK")){
                        this.MensjaeOk("Se insertó de forma correcta el registro.");
                        this.Close();
                        ModifyUser.UpdateDataBase = 1;
                        //Aqui 

                    }
                    else
                    {
                        this.MensjaeError(rpta);
                    }

                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void linkPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkPassword.Visible = false;
            txtClave.Clear();
            txtClave.Enabled = true;
            txtClave.Focus();
            txtConfirmar.Visible = true;
            lblConfirmar.Visible = true;
            ModifyUser.CheckPassword = 1;

            
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals(ModifyUser.Email)) { 
            ////
            try
            {
                string rpta = "";

                if (ModifyUser.CheckPassword == 0)
                {
                    if (txtNombre.Text == string.Empty || txtEmail.Text == string.Empty)
                    {
                        this.MensjaeError("Falta ingresar algunos datos, serán remarcados.");
                        errorIcono.SetError(txtNombre, "Ingrese un nombre");
                        errorIcono.SetError(txtEmail, "Ingrese un email.");
                    }
                    else
                    {
                        rpta = DomainUser.Update(Convert.ToInt32(txtId.Text), Convert.ToInt32(cmbRol.SelectedValue), Convert.ToInt32(cmbArea.SelectedValue), txtNombre.Text.Trim(), txtEmail.Text.Trim(), txtClave.Text.Trim());
                        if (rpta.Equals("OK"))
                        {
                            this.MensjaeOk("Se actualizó de forma correcta el registro.");
                            ModifyUser.UpdateDataBase = 1;
                            this.Close();

                            }
                        else
                        {
                            this.MensjaeError(rpta);
                        }
                    }


                }
                else if (ModifyUser.CheckPassword == 1)
                {

                    if (txtNombre.Text == string.Empty || txtEmail.Text == string.Empty || txtClave.Text == string.Empty || txtConfirmar.Text == string.Empty)
                    {
                        this.MensjaeError("Falta ingresar algunos datos, serán remarcados.");
                        errorIcono.SetError(txtNombre, "Ingrese un nombre");
                        errorIcono.SetError(txtEmail, "Ingrese un email.");
                        errorIcono.SetError(txtClave, "Ingrese una clave.");
                        errorIcono.SetError(txtConfirmar, "Confirme la clave.1");

                    }
                    else if (txtClave.Text != txtConfirmar.Text)
                    {
                        errorIcono.SetError(txtConfirmar, "Las claves no coinciden.");
                        txtConfirmar.Clear();
                        txtConfirmar.Focus();
                    }

                    else
                    {
                        rpta = DomainUser.Update(Convert.ToInt32(txtId.Text), Convert.ToInt32(cmbRol.SelectedValue), Convert.ToInt32(cmbArea.SelectedValue), txtNombre.Text.Trim(), txtEmail.Text.Trim(), txtClave.Text.Trim());
                        if (rpta.Equals("OK"))
                        {
                            this.MensjaeOk("Se actualizó de forma correcta el registro.");
                            ModifyUser.UpdateDataBase = 1;
                            this.Close();

                            }
                        else
                        {
                            this.MensjaeError(rpta);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            ////
            ///
            /// 
            }
            else if (!txtEmail.Text.Equals(ModifyUser.Email))
            {
                try
                {
                    string rpta = "";

                    if (ModifyUser.CheckPassword == 0)
                    {
                        if (txtNombre.Text == string.Empty || txtEmail.Text == string.Empty)
                        {
                            this.MensjaeError("Falta ingresar algunos datos, serán remarcados.");
                            errorIcono.SetError(txtNombre, "Ingrese un nombre");
                            errorIcono.SetError(txtEmail, "Ingrese un email.");
                        }
                        else
                        {
                            rpta = DomainUser.UpdateEmail(Convert.ToInt32(txtId.Text), Convert.ToInt32(cmbRol.SelectedValue), Convert.ToInt32(cmbArea.SelectedValue), txtNombre.Text.Trim(), txtEmail.Text.Trim(), txtClave.Text.Trim());
                            if (rpta.Equals("OK"))
                            {
                                this.MensjaeOk("Se actualizó de forma correcta el registro.");
                                ModifyUser.UpdateDataBase = 1;
                                this.Close();

                            }
                            else
                            {
                                this.MensjaeError(rpta);
                            }
                        }


                    }
                    else if (ModifyUser.CheckPassword == 1)
                    {

                        if (txtNombre.Text == string.Empty || txtEmail.Text == string.Empty || txtClave.Text == string.Empty || txtConfirmar.Text == string.Empty)
                        {
                            this.MensjaeError("Falta ingresar algunos datos, serán remarcados.");
                            errorIcono.SetError(txtNombre, "Ingrese un nombre");
                            errorIcono.SetError(txtEmail, "Ingrese un email.");
                            errorIcono.SetError(txtClave, "Ingrese una clave.");
                            errorIcono.SetError(txtConfirmar, "Confirme la clave.2");

                        }
                        else if (txtClave.Text != txtConfirmar.Text)
                        {
                            errorIcono.SetError(txtConfirmar, "Las claves no coinciden.");
                            txtConfirmar.Clear();
                            txtConfirmar.Focus();
                        }

                        else
                        {
                            rpta = DomainUser.UpdateEmail(Convert.ToInt32(txtId.Text), Convert.ToInt32(cmbRol.SelectedValue), Convert.ToInt32(cmbArea.SelectedValue), txtNombre.Text.Trim(), txtEmail.Text.Trim(), txtClave.Text.Trim());
                            if (rpta.Equals("OK"))
                            {
                                this.MensjaeOk("Se actualizó de forma correcta el registro.");
                                ModifyUser.UpdateDataBase = 1;
                                this.Close();

                            }
                            else
                            {
                                this.MensjaeError(rpta);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }
    }
}
