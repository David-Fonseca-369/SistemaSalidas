using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices; //Arrrastrar formulario
using Common.Cache;
using Domain;

  
namespace ConsultasSQL
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;

     
    }
        //private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        //Metodo para arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panelContenedorForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que deseas salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        int lx, ly;
        int sw, sh;

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if( panelMenu.Width == 230)
            {
                this.tmContraerMenu.Start();

            }
            else if(panelMenu.Width == 40)
            {
                this.tmExpandirMenu.Start();

            }
        }

        private void tmExpandirMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width >= 230)
                this.tmExpandirMenu.Stop();
            else
                panelMenu.Width = panelMenu.Width + 5;

            
        }

        private void tmContraerMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width <= 40)
                this.tmContraerMenu.Stop();
            else
                panelMenu.Width = panelMenu.Width - 5;

        }

        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");

        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnNormal.Visible = false;
            btnMaximizar.Visible = true;

        }

        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmNuevaSolicitud());
        
        }

        private void PanelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadUserData()
        {
            lblNombre.Text = UserLogin.Nombre_Usuario;
           
            //Para el rol
            try
            { 
                DataTable tabla = new DataTable();
                tabla = DRol.buscarId(Convert.ToString(UserLogin.IdRol));
                if(tabla.Rows.Count <= 0)
                {
                    this.ErrorMessagge("No existe el id.");
                }
                else
                {
                    DataRow row = tabla.Rows[0];
                    lblTipoUsuario.Text = Convert.ToString(row["nombre_rol"]);   
                    }
            }catch(Exception ex)
            {
                ErrorMessagge(ex +" Error");
            }
            //para el área
            try
            {
                DataTable tabla = new DataTable();
                tabla = DRol.buscarArea(Convert.ToString(UserLogin.IdArea));
                if (tabla.Rows.Count <= 0)
                {
                    this.ErrorMessagge("No existe el id.");
                }
                else
                {
                    DataRow row = tabla.Rows[0];
                    lblArea.Text = Convert.ToString(row["nombre_area"]);
                    UserLogin.Area = Convert.ToString(row["nombre_area"]);
                }
            }
            catch (Exception ex)
            {
                ErrorMessagge(ex + " Error");
            }

        }

        

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            LoadUserData();
            VerifyUser();
        }

        private void VerifyUser()


        {
            if (Convert.ToString(UserLogin.IdRol).Equals(Positions.Administrador))
            {
                btnNuevaSolicitud.Enabled = false;
                btnSolicitudes.Enabled = false;
                btnUsuarios.Enabled = true;
                btnReportes.Enabled = false;
                btnCorreo.Enabled = true;
            }
            else if (Convert.ToString(UserLogin.IdRol).Equals(Positions.Autorizador))
            {
                btnNuevaSolicitud.Enabled = true;
                btnSolicitudes.Enabled = true;
                btnUsuarios.Enabled = false;
                btnReportes.Enabled = false;
                btnCorreo.Enabled = false;

            }
            else if (Convert.ToString(UserLogin.IdRol).Equals(Positions.Finanzas))
            {
                btnNuevaSolicitud.Enabled = true;
                btnSolicitudes.Enabled = true;
                btnUsuarios.Enabled = false;
                btnReportes.Enabled = true;
                btnCorreo.Enabled = false;

            }
            else if (Convert.ToString(UserLogin.IdRol).Equals(Positions.Seguridad))
            {
                btnNuevaSolicitud.Enabled = true;
                btnSolicitudes.Enabled = true;
                btnUsuarios.Enabled = false;
                btnReportes.Enabled = false;
                btnCorreo.Enabled = false;

            }
            else if (Convert.ToString(UserLogin.IdRol).Equals(Positions.Vigilancia))
            {
                btnNuevaSolicitud.Enabled = false;
                btnSolicitudes.Enabled = true;
                btnUsuarios.Enabled = false;
                btnReportes.Enabled = false;
                btnCorreo.Enabled = false;

            }
            else if (Convert.ToString(UserLogin.IdRol).Equals(Positions.Embarques))
            {
                btnNuevaSolicitud.Enabled = false;
                btnSolicitudes.Enabled = true;
                btnUsuarios.Enabled = false;
                btnReportes.Enabled = false;
                btnCorreo.Enabled = false;

            }
            else if (Convert.ToString(UserLogin.IdRol).Equals(Positions.Solicitador))
            {
                btnNuevaSolicitud.Enabled = true;
                btnSolicitudes.Enabled = true;
                btnUsuarios.Enabled = false;
                btnReportes.Enabled = false;
                btnCorreo.Enabled = false;

            }
            else
            {
                btnNuevaSolicitud.Enabled = false;
                btnSolicitudes.Enabled = false;
                btnUsuarios.Enabled = false;
                btnReportes.Enabled = false;
                btnCorreo.Enabled = false;
            }


        }

        private void ErrorMessagge(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de salidas", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmUsuarios());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmCorreo());
        }

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAcercaDe_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnSolicitudes_Click(object sender, EventArgs e)
        {

            if (Convert.ToString(UserLogin.IdRol).Equals(Positions.Solicitador))
            {
                AbrirFormEnPanel(new FrmSolicitudes());
            }
            else if (Convert.ToString(UserLogin.IdRol).Equals(Positions.Autorizador))
            {
                AbrirFormEnPanel(new FrmSolicitudesAutorizador());
            }
            else if (Convert.ToString(UserLogin.IdRol).Equals(Positions.Finanzas))
            {
                AbrirFormEnPanel(new FrmSolicitudesFinanzas());
            }
            else if (Convert.ToString(UserLogin.IdRol).Equals(Positions.Vigilancia))
            {
                AbrirFormEnPanel(new FrmVigilancia());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(UserLogin.IdRol).Equals(Positions.Finanzas))
            {
                AbrirFormEnPanel(new FrmReportesFinanzas());
            }
            else if (Convert.ToString(UserLogin.IdRol).Equals(Positions.Seguridad))
            {
               //
            }
            else if (Convert.ToString(UserLogin.IdRol).Equals(Positions.Vigilancia))
            {
               //
            }
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            btnNormal.Visible = true;

        }

        private void AbrirFormEnPanel(object formHijo)
        {
            if (this.panelContenedorForm.Controls.Count > 0)
                this.panelContenedorForm.Controls.RemoveAt(0);

            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorForm.Controls.Add(fh);
            this.panelContenedorForm.Tag = fh;
            fh.Show();


        }
    }
}
