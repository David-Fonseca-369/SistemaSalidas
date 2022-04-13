using System;
using Domain;
using Common.Cache;
using System.Diagnostics;
using System.Data;

using System.Windows.Forms;

namespace ConsultasSQL
{
    public partial class FrmSolicitudesAutorizador : Form
    {
        private string directorio = "C:\\Sistema\\";
        public FrmSolicitudesAutorizador()
        {
            InitializeComponent();
        }

        private void toolStrip_Click(object sender, EventArgs e)
        {

        }

        private void producciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MyRequest();
            ListRequestApplicant();
            rdbTexto.Checked = true;
            cmbAutorizacion.Text = "Todas";
            cmbVoBo.Text = "Todas";
            txtBuscar.Clear();
        }
        private void ListAuthorizer()
        {
            try
            {
                string checkAuthorization = "";
                string checkVoBo = "";
                if (cmbAutorizacion.Text.Equals("Todas"))
                {
                    checkAuthorization = "";
                }
                else if (cmbAutorizacion.Text.Equals("Pendientes"))
                {
                    checkAuthorization = "Pendiente";
                }
                else if (cmbAutorizacion.Text.Equals("Autorizadas"))
                {
                    checkAuthorization = "Autorizada";
                }
                else if (cmbAutorizacion.Text.Equals("No autorizadas"))
                {
                    checkAuthorization = "Rechazada";
                }
                ///
                 if (cmbVoBo.Text.Equals("Todas"))
                {
                    checkVoBo = "";
                }
                else if (cmbVoBo.Text.Equals("Pendientes"))
                {
                    checkVoBo = "Pendiente";
                }
                else if (cmbVoBo.Text.Equals("Vo. Bo."))
                {
                    checkVoBo = "Visto bueno";
                }
                else if (cmbVoBo.Text.Equals("Anuladas"))
                {
                    checkVoBo = "Anuladas";
                }

                dgvListAutorizador.DataSource = DomainRequest.ListRequestUserAuthorizer(UserLogin.IdUsuario, checkAuthorization, checkVoBo, txtBuscar.Text);
                
                lblRecords.Text = "Total registros: " + Convert.ToString(dgvListAutorizador.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        public void ListRequestApplicant()
        {
            try
            {
                string checkAuthorization = "";
                string checkVoBo = "";
                if (cmbAutorizacion.Text.Equals("Todas"))
                {
                    checkAuthorization = "";
                }
                else if (cmbAutorizacion.Text.Equals("Pendientes"))
                {
                    checkAuthorization = "Pendiente";
                }
                else if (cmbAutorizacion.Text.Equals("Autorizadas"))
                {
                    checkAuthorization = "Autorizada";
                }
                else if (cmbAutorizacion.Text.Equals("No autorizadas"))
                {
                    checkAuthorization = "Rechazada";
                }
                ///
                 if (cmbVoBo.Text.Equals("Todas"))
                {
                    checkVoBo = "";
                }
                else if (cmbVoBo.Text.Equals("Pendientes"))
                {
                    checkVoBo = "Pendiente";
                }
                else if (cmbVoBo.Text.Equals("Vo. Bo."))
                {
                    checkVoBo = "Visto bueno";
                }
                else if (cmbVoBo.Text.Equals("Anuladas"))
                {
                    checkVoBo = "Anuladas";
                }



                dgvList.DataSource = DomainRequest.ListRequestUserApplicant(UserLogin.IdUsuario, checkAuthorization, checkVoBo, txtBuscar.Text);
                this.Format();
                lblRecords.Text = "Total registros: " + Convert.ToString(dgvList.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Format()
        {
            dgvList.Columns[1].HeaderText = "Folio/Vale almacén";
            dgvList.Columns[2].HeaderText = "Tipo de salida";
            dgvList.Columns[5].HeaderText = "Salida para";
            dgvList.Columns[6].HeaderText = "Ubicación";
            dgvList.Columns[7].HeaderText = "Dir. Proveedor";
            dgvList.Columns[9].HeaderText = "Sólicito a";
            dgvList.Columns[10].HeaderText = "Autorización";
            dgvList.Columns[11].HeaderText = "Vo. Bo. Finanzas";
            dgvList.Columns[12].HeaderText = "Vo. Bo";
            dgvList.Columns[13].Visible = false;
        }
        private void almacénToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rdbTexto.Checked = true;
            cmbAutorizacion.Text = "Todas";
            RequestsOfsUsers();
            ListAuthorizer();
            
        }

        private void FrmSolicitudesAutorizador_Load(object sender, EventArgs e)
        {
            RequestsOfsUsers();
            rdbTexto.Checked = true;
            cmbAutorizacion.Text = "Todas";
            LoadMail();
            
        }

        private void cmbAutorizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (UserAuthorizer.checkTypeRequest == 0)
            {
                ListAuthorizer();
            }
            else if (UserAuthorizer.checkTypeRequest == 1)
            {
                ListRequestApplicant();
            }
        }

        private void cmbVoBo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListRequestApplicant();
        }

        private void rdbTexto_CheckedChanged(object sender, EventArgs e)
        {
            pnlBuscarTexto.Visible = true;
            pnlBuscarFecha.Visible = false;
            cmbAutorizacion.Enabled = true;
            cmbVoBo.Enabled = true;
        }

        private void rdbFecha_CheckedChanged(object sender, EventArgs e)
        {
            ListRequestApplicant();
            pnlBuscarTexto.Visible = false;
            pnlBuscarFecha.Visible = true;
            cmbAutorizacion.Text = "Todas";
            cmbVoBo.Text = "Todas";
            cmbAutorizacion.Enabled = false;
            cmbVoBo.Enabled = false;
        }
        private void SearchForDateApplicant()
        {
            try
            {
                dgvList.DataSource = DomainRequest.QueryDateApplicant(UserLogin.IdUsuario, Convert.ToDateTime(dtpFechaInicio.Value), Convert.ToDateTime(dtpFechaFin.Value));
                this.Format();
                lblRecords.Text = "Total registros: " + Convert.ToString(dgvList.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void SearchForDateAuthorizer()
        {
            try
            {
                dgvListAutorizador.DataSource = DomainRequest.QueryDateAuthorizer(UserLogin.IdUsuario, Convert.ToDateTime(dtpFechaInicio.Value), Convert.ToDateTime(dtpFechaFin.Value));
                lblRecords.Text = "Total registros: " + Convert.ToString(dgvListAutorizador.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (UserAuthorizer.checkTypeRequest == 0)
            {
                SearchForDateAuthorizer();
            }
            else if (UserAuthorizer.checkTypeRequest == 1)
            {
                SearchForDateApplicant();
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ListRequestApplicant();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlDetalleSolicitud.Visible = false;
        }


        private void OpenDocument()
        {
            if (!txtNombreArchivo.Text.Equals("N/A"))
            {
                try
                {
                    Process p = new Process();
                    p.StartInfo.FileName = directorio + txtNombreArchivo.Text;
                    p.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            else
            {
                MessageBox.Show("No agregó archivo.");
            }

        }
        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvListDetail.DataSource = DomainRequest.ListDetail(Convert.ToInt32(dgvList.CurrentRow.Cells["Folio"].Value));
                txtNombreArchivo.Text = Convert.ToString(dgvList.CurrentRow.Cells["archivo"].Value);
                lblRecordsDeatils.Text = "Total registros: " + Convert.ToString(dgvListDetail.Rows.Count);
                pnlDetalleSolicitud.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenDocument();
        }

        private void txtBuscar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ListRequestApplicant();
        }

        private void txtBuscar_KeyPress_2(object sender, KeyPressEventArgs e)
        {
       
            if (UserAuthorizer.checkTypeRequest == 0)
            {
                ListAuthorizer();
            }
            else if (UserAuthorizer.checkTypeRequest == 1)
            {
                ListRequestApplicant();
            }
        }

        private void MyRequest() {
            UserAuthorizer.checkTypeRequest = 1;
            lblTitulo.Text = "Mis solicitudes";
            btnAutorizar.Visible = false;
            btnRechazar.Visible = false;
            cmbVoBo.Visible = true;
            lblVtoBno.Visible = true;
            dgvList.Visible = true;
            dgvListAutorizador.Visible = false;
            txtBuscar.Clear();

        }
        private void RequestsOfsUsers()
        {
            UserAuthorizer.checkTypeRequest = 0;
            lblTitulo.Text = "Solicitudes de usuarios";
            btnAutorizar.Visible = true;
            btnRechazar.Visible = true;
            cmbVoBo.Visible = false;
            lblVtoBno.Visible = false;
            dgvList.Visible = false;
            dgvListAutorizador.Visible = true;
            txtBuscar.Clear();
        }
        private void MensjaeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de salidas", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void MensjaeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de salidas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void SendMailApplicant(string email, string nombreSolicitante, string estatusSolicitud, string nombreAutorizador, string folio)
        {
            var user = new UserModel();
            var result = user.sendMailApplicant(email, nombreSolicitante, estatusSolicitud, nombreAutorizador, folio);
            if (!result.Equals("OK")) {
                MensjaeError("Lo sentimos, no se pudo envíar el correo de\n" +
                    "notificación a " + nombreSolicitante+".");
            }
        }
        private void SendMailAuthorizer(string email,string nombreFinanzas, string nombreSolicitante, string nombreAutorizador, string folio)
        {
            var user = new UserModel();
            var result = user.sendMailAuthorizer(email, nombreFinanzas, nombreSolicitante, nombreAutorizador, folio);
            if (!result.Equals("OK"))
            {
                MensjaeError("Lo sentimos, no se pudo envíar el correo de\n" +
                    "notificación a " + nombreAutorizador + ".");
            }
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            if (dgvListAutorizador.SelectedRows.Count > 0)
            {

                if (dgvListAutorizador.CurrentRow.Cells[10].Value.ToString().Equals("Autorizada"))
                {
                    MensjaeOk("Esta solicitud ya está autorizada.");
                }
                else
                {
                    try
                    {
                        DialogResult option;
                        option = MessageBox.Show("¿Realmente deseas autorizar la solicitud de " + Convert.ToString(dgvListAutorizador.CurrentRow.Cells[3].Value) + "?", "Sistema salidas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (option == DialogResult.OK)
                        {
                            string rpta = "";
                            int codigo;

                            codigo = Convert.ToInt32(dgvListAutorizador.CurrentRow.Cells[0].Value);
                            rpta = DomainRequest.Authorize(codigo);

                            if (rpta.Equals("OK"))
                            {
                                this.MensjaeOk("Se autorizó la solicitud de: " + Convert.ToString(dgvListAutorizador.CurrentRow.Cells[3].Value));
                                SendMailApplicant(Convert.ToString(dgvListAutorizador.CurrentRow.Cells[12].Value), Convert.ToString(dgvListAutorizador.CurrentRow.Cells[3].Value), "autorizada", UserLogin.Nombre_Usuario, Convert.ToString(dgvListAutorizador.CurrentRow.Cells[0].Value));
                                SendMailAuthorizer(Convert.ToString(dgvListAutorizador.CurrentRow.Cells[13].Value), Convert.ToString(dgvListAutorizador.CurrentRow.Cells[14].Value),Convert.ToString(dgvListAutorizador.CurrentRow.Cells[3].Value),
                                UserLogin.Nombre_Usuario, Convert.ToString(dgvListAutorizador.CurrentRow.Cells[0].Value));
                            }
                            else
                            {
                                this.MensjaeError(rpta);
                            }

                            this.ListAuthorizer();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
            }
            else
            {
                MensjaeError("Debes seleccionar una fila.");
            }
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            if (dgvListAutorizador.SelectedRows.Count > 0)
            {

                if (dgvListAutorizador.CurrentRow.Cells[10].Value.ToString().Equals("Rechazada"))
                {
                    MensjaeOk("Esta solicitud ya está rechazada.");
                }
                else if (dgvListAutorizador.CurrentRow.Cells[10].Value.ToString().Equals("Autorizada"))
                {
                    MensjaeOk("Esta solicitud ya ha sido autorizada,\ny no se pueden efectuar cambios.\nya que afectaría a futuros usuarios.");
                }
                else
                {
                    try
                    {
                        DialogResult option;
                        option = MessageBox.Show("¿Realmente deseas rechazar la solicitud de " + Convert.ToString(dgvListAutorizador.CurrentRow.Cells[3].Value) + "?", "Sistema salidas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (option == DialogResult.OK)
                        {
                            string rpta = "";
                            int codigo;

                            codigo = Convert.ToInt32(dgvListAutorizador.CurrentRow.Cells[0].Value);
                            rpta = DomainRequest.ToRefuse(codigo);

                            if (rpta.Equals("OK"))
                            {
                                this.MensjaeOk("Se rechazó la solicitud de: " + Convert.ToString(dgvListAutorizador.CurrentRow.Cells[3].Value));
                                SendMailApplicant(Convert.ToString(dgvListAutorizador.CurrentRow.Cells[12].Value), Convert.ToString(dgvListAutorizador.CurrentRow.Cells[3].Value), "rechazada", UserLogin.Nombre_Usuario, Convert.ToString(dgvListAutorizador.CurrentRow.Cells[0].Value));
                            }
                            else
                            {
                                this.MensjaeError(rpta);
                            }

                            this.ListAuthorizer();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
            }
            else
            {
                MensjaeError("Debes seleccionar una fila.");
            }
        }

        private void dgvListAutorizador_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvListDetail.DataSource = DomainRequest.ListDetail(Convert.ToInt32(dgvListAutorizador.CurrentRow.Cells["Folio"].Value));
                txtNombreArchivo.Text = Convert.ToString(dgvListAutorizador.CurrentRow.Cells["archivo"].Value);
                lblRecordsDeatils.Text = "Total registros: " + Convert.ToString(dgvListDetail.Rows.Count);
                pnlDetalleSolicitud.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    MessageBox.Show("No existe el id del correo.");
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
                MessageBox.Show(ex + " Error");
            }

        }

    }
}
    

    