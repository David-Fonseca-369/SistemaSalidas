using System;
using Common.Cache;
using System.Windows.Forms;
using Domain;
using System.Diagnostics;
using System.Data;


namespace ConsultasSQL
{
    public partial class FrmSolicitudesFinanzas : Form
    {
        private string directorio = "C:\\Sistema\\";
        public FrmSolicitudesFinanzas()
        {
            InitializeComponent();
        }

        private void ListVoBo() {
            
            try
            {

            string checkVoBo = "";
                
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
                    checkVoBo = "Anulada";
                }

                dgvListFinance.DataSource = DomainRequest.ListRequestUserFinance(UserLogin.IdUsuario, checkVoBo, txtBuscar.Text);
                
                lblRecords.Text = "Total registros: " + Convert.ToString(dgvListFinance.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void ListGeneral()
        {
            
            try
            {
                string checkAuthorization = "";
                string checkVoBo = "";
                string checkStatus = "";
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
                    checkVoBo = "Anulada";
                }
                if (cmbEstatus.Text.Equals("Todas"))
                {
                    checkStatus = "";
                }
                else if (cmbEstatus.Text.Equals("Activadas"))
                {
                    checkStatus = "1";
                }
                if (cmbEstatus.Text.Equals("Canceladas"))
                {
                    checkStatus = "0";
                }


                dgvListGeneral.DataSource = DomainRequest.ListRequestUserFinanceGeneral(checkAuthorization, checkVoBo, txtBuscar.Text, checkStatus);

                lblRecords.Text = "Total registros: " + Convert.ToString(dgvListGeneral.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void MyList()
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
                    checkVoBo = "Anulada";
                }

                dgvList.DataSource = DomainRequest.ListRequestUserApplicant(UserLogin.IdUsuario,checkAuthorization, checkVoBo, txtBuscar.Text);

                lblRecords.Text = "Total registros: " + Convert.ToString(dgvList.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void MyRequest()
        {
            UserFinance.checkTypeRequest = 2;
            rdbTexto.Checked = true;
            lblTitulo.Text = "Mis solicitudes";
            dgvList.Visible = true;
            dgvListGeneral.Visible = false;
            dgvListFinance.Visible = false;
            cmbAutorizacion.Visible = true;
            lblAutroizacion.Visible = true;
            cmbVoBo.Visible = true;
            btnAnular.Visible = false;
            cmbEstatus.Visible = false;
            lblEstatus.Visible = false;
            btnRestablecer.Visible = false;
            btnCancelar.Visible = false;
            btnDarVtoBno.Visible = false;
            txtBuscar.Clear();
        }
        private void RequestVoBo()
        {
            UserFinance.checkTypeRequest = 0;
            lblTitulo.Text = "Solictudes para Visto Bueno";
            rdbTexto.Checked = true;
            dgvList.Visible = false;
            dgvListGeneral.Visible = false;
            dgvListFinance.Visible = true;
            cmbAutorizacion.Visible = false;
            lblAutroizacion.Visible = false;
            cmbVoBo.Visible = true;
            btnAnular.Visible = true;
            cmbEstatus.Visible = false;
            lblEstatus.Visible = false;
            btnDarVtoBno.Visible = true;
            btnRestablecer.Visible = false;
            btnCancelar.Visible = false;
            txtBuscar.Clear();

        }
        private void RequestGeneral()
        {
            UserFinance.checkTypeRequest = 1;
            lblTitulo.Text = "Solicitudes generales";
            rdbTexto.Checked = true;
            dgvList.Visible = false;
            dgvListGeneral.Visible = true;
            dgvListFinance.Visible = false;
            cmbAutorizacion.Visible = true;
            lblAutroizacion.Visible = true;
            cmbVoBo.Visible = true;
            cmbEstatus.Visible = true;
            lblEstatus.Visible = true;
            btnAnular.Visible = false;
            btnDarVtoBno.Visible = false;
            btnRestablecer.Visible = true;
            btnCancelar.Visible = true;
            txtBuscar.Clear();
        }

        private void ne(object sender, EventArgs e)
        {

        }

        private void tb(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAutorizacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void rdbFecha_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbTexto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbVoBo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void almacénToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void solicitudesGeneralesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void producciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void almacénToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RequestVoBo();
            ListVoBo();
        }

        private void solicitudesGeneralesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RequestGeneral();
            ListGeneral();
        }

        private void producciónToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MyRequest();
            MyList();
        }

        private void rdbTexto_CheckedChanged_1(object sender, EventArgs e)
        {
            pnlBuscarTexto.Visible = true;
            pnlBuscarFecha.Visible = false;
            cmbAutorizacion.Enabled = true;
            cmbVoBo.Enabled = true;
            cmbEstatus.Enabled = true;
            cmbAutorizacion.Text = "Todas";
            cmbVoBo.Text = "Todas";
            cmbEstatus.Text = "Todas";
            txtBuscar.Text = "";
        }

        private void rdbFecha_CheckedChanged_1(object sender, EventArgs e)
        {
            pnlBuscarTexto.Visible = false;
            pnlBuscarFecha.Visible = true;
            cmbAutorizacion.Text = "Todas";
            cmbVoBo.Text = "Todas";
            cmbEstatus.Text ="Todas";
            cmbAutorizacion.Enabled = false;
            cmbVoBo.Enabled = false;
            cmbEstatus.Enabled = false;
        }

        private void cmbVoBo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(UserFinance.checkTypeRequest == 0)
            {
                ListVoBo();
            }
            else if (UserFinance.checkTypeRequest == 1)
            {
                ListGeneral();
            }
            else if (UserFinance.checkTypeRequest == 2)
            {
                MyList();
            }
        }

        private void cmbAutorizacion_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (UserFinance.checkTypeRequest == 0)
            {
             //   ListVoBo();
            }
            else if (UserFinance.checkTypeRequest == 1)
            {
                ListGeneral();
            }
            else if (UserFinance.checkTypeRequest == 2)
            {
                MyList();
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

        private void FrmSolicitudesFinanzas_Load(object sender, EventArgs e)
        {
            LoadMail();
            RequestVoBo();
            ListVoBo();
        }

        private void txtBuscar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (UserFinance.checkTypeRequest == 0)
            {
                ListVoBo();
            }
            else if (UserFinance.checkTypeRequest == 1)
            {
                ListGeneral();
            }
            else if (UserFinance.checkTypeRequest == 2)
            {
                MyList();
            }
        }

        private void cmbEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(UserFinance.checkTypeRequest == 1)
            {
                ListGeneral();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (UserFinance.checkTypeRequest == 0)
            {
                SearchForDateFinance(); 
            }
           else if (UserFinance.checkTypeRequest == 1)
            {
                SearchForDateFinanceGeneral();
            }
            else if (UserFinance.checkTypeRequest == 2)
            {
                SearchForDateMyRequest();
            }

        }
        private void SearchForDateMyRequest()
        {
            try
            {
                dgvList.DataSource = DomainRequest.QueryDateApplicant(UserLogin.IdUsuario, Convert.ToDateTime(dtpFechaInicio.Value), Convert.ToDateTime(dtpFechaFin.Value));
                lblRecords.Text = "Total registros: " + Convert.ToString(dgvList.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void SearchForDateFinance()
        {
            try
            {
                dgvListFinance.DataSource = DomainRequest.QueryDateFinance(UserLogin.IdUsuario, Convert.ToDateTime(dtpFechaInicio.Value), Convert.ToDateTime(dtpFechaFin.Value));
                lblRecords.Text = "Total registros: " + Convert.ToString(dgvListFinance.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void SearchForDateFinanceGeneral()
        {
            try
            {
                dgvListGeneral.DataSource = DomainRequest.QueryDateFinanceGeneral(Convert.ToDateTime(dtpFechaInicio.Value), Convert.ToDateTime(dtpFechaFin.Value));
                lblRecords.Text = "Total registros: " + Convert.ToString(dgvListGeneral.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenDocument();
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

        private void dgvListFinance_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvListDetail.DataSource = DomainRequest.ListDetail(Convert.ToInt32(dgvListFinance.CurrentRow.Cells["Folio"].Value));
                txtNombreArchivo.Text = Convert.ToString(dgvListFinance.CurrentRow.Cells["archivo"].Value);
                lblRecordsDeatils.Text = "Total registros: " + Convert.ToString(dgvListDetail.Rows.Count);
                pnlDetalleSolicitud.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvListGeneral_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvListDetail.DataSource = DomainRequest.ListDetail(Convert.ToInt32(dgvListGeneral.CurrentRow.Cells["Folio"].Value));
                txtNombreArchivo.Text = Convert.ToString(dgvListGeneral.CurrentRow.Cells["archivo"].Value);
                lblRecordsDeatils.Text = "Total registros: " + Convert.ToString(dgvListDetail.Rows.Count);
                pnlDetalleSolicitud.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlDetalleSolicitud.Visible = false;
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            if (dgvListGeneral.SelectedRows.Count > 0)
            {

                if (dgvListGeneral.CurrentRow.Cells[15].Value.ToString().Equals("Activa"))
                {
                    MensjaeOk("Esta solicitud ya está activa.");
                }
                else
                {
                    try
                    {
                        DialogResult option;
                        option = MessageBox.Show("¿Realmente deseas activar la solicitud de " + Convert.ToString(dgvListGeneral.CurrentRow.Cells[3].Value) + "?", "Sistema salidas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (option == DialogResult.OK)
                        {
                            string rpta = "";
                            int codigo;

                            codigo = Convert.ToInt32(dgvListGeneral.CurrentRow.Cells[0].Value);
                            rpta = DomainRequest.Activate(codigo);

                            if (rpta.Equals("OK"))
                            {
                                this.MensjaeOk("Se activó la solicitud de: " + Convert.ToString(dgvListGeneral.CurrentRow.Cells[3].Value));
                                SendMailApplicant(Convert.ToString(dgvListGeneral.CurrentRow.Cells[17].Value), Convert.ToString(dgvListGeneral.CurrentRow.Cells[3].Value), "reactivada", UserLogin.Nombre_Usuario, Convert.ToString(dgvListGeneral.CurrentRow.Cells[0].Value));
                            }
                            else
                            {
                                this.MensjaeError(rpta);
                            }

                            this.ListGeneral();
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
        private void MensjaeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de salidas", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void MensjaeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de salidas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btnDarVtoBno_Click(object sender, EventArgs e)
        {
            if (dgvListFinance.SelectedRows.Count > 0)
            {

                if (dgvListFinance.CurrentRow.Cells[11].Value.ToString().Equals("Visto Bueno"))
                {
                    MensjaeOk("Esta solicitud ya tiene el visto bueno.");
                }
                else
                {
                    try
                    {
                        DialogResult option;
                        option = MessageBox.Show("¿Realmente deseas darle el Vº. Bº. a la solicitud de " + Convert.ToString(dgvListFinance.CurrentRow.Cells[3].Value) + "?", "Sistema salidas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (option == DialogResult.OK)
                        {
                            string rpta = "";
                            int codigo;

                            codigo = Convert.ToInt32(dgvListFinance.CurrentRow.Cells[0].Value);
                            rpta = DomainRequest.VoBo(codigo);

                            if (rpta.Equals("OK"))
                            {
                                this.MensjaeOk("Se dió el Vº. Bº. a la solicitud de: " + Convert.ToString(dgvListFinance.CurrentRow.Cells[3].Value));
                                SendMailApplicantVoBo(Convert.ToString(dgvListFinance.CurrentRow.Cells[13].Value), Convert.ToString(dgvListFinance.CurrentRow.Cells[3].Value), "visto bueno", UserLogin.Nombre_Usuario, Convert.ToString(dgvListFinance.CurrentRow.Cells[0].Value));
                                
                            }
                            else
                            {
                                this.MensjaeError(rpta);
                            }

                            this.ListVoBo();
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

        private void btnAnular_Click(object sender, EventArgs e)
        {
            
            if (dgvListFinance.SelectedRows.Count > 0)
            {

                if (dgvListFinance.CurrentRow.Cells[11].Value.ToString().Equals("Anulada"))
                {
                    MensjaeOk("Esta solicitud ya está anulada.");
                }
                else if (dgvListFinance.CurrentRow.Cells[11].Value.ToString().Equals("Visto Bueno"))
                {
                    MensjaeOk("Esta solicitud ya tiene el Vº. Bº.\nY no se pueden efectuar cambios.\nya que afectaría a futuros usuarios.");
                }
                else
                {
                    try
                    {
                        DialogResult option;
                        option = MessageBox.Show("¿Realmente deseas anular la solicitud de " + Convert.ToString(dgvListFinance.CurrentRow.Cells[3].Value) + "?", "Sistema salidas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (option == DialogResult.OK)
                        {
                            string rpta = "";
                            int codigo;

                            codigo = Convert.ToInt32(dgvListFinance.CurrentRow.Cells[0].Value);
                            rpta = DomainRequest.ToCancel(codigo);

                            if (rpta.Equals("OK"))
                            {
                                this.MensjaeOk("Se anuló la solicitud de: " + Convert.ToString(dgvListFinance.CurrentRow.Cells[3].Value));
                                SendMailApplicant(Convert.ToString(dgvListFinance.CurrentRow.Cells[13].Value), Convert.ToString(dgvListFinance.CurrentRow.Cells[3].Value), "anulada", UserLogin.Nombre_Usuario, Convert.ToString(dgvListFinance.CurrentRow.Cells[0].Value));
                            }
                            else
                            {
                                this.MensjaeError(rpta);
                            }

                            this.ListVoBo();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvListGeneral.SelectedRows.Count > 0)
            {

                if (dgvListGeneral.CurrentRow.Cells[15].Value.ToString().Equals("Cancelada"))
                {
                    MensjaeOk("Esta solicitud ya está cancelada.");
                }
                else
                {
                    try
                    {
                        DialogResult option;
                        option = MessageBox.Show("¿Realmente deseas cancelar la solicitud de " + Convert.ToString(dgvListGeneral.CurrentRow.Cells[3].Value) + "?", "Sistema salidas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (option == DialogResult.OK)
                        {
                            string rpta = "";
                            int codigo;

                            codigo = Convert.ToInt32(dgvListGeneral.CurrentRow.Cells[0].Value);
                            rpta = DomainRequest.CancelGeneral(codigo);

                            if (rpta.Equals("OK"))
                            {
                                this.MensjaeOk("Se canceló la solicitud de: " + Convert.ToString(dgvListGeneral.CurrentRow.Cells[3].Value));
                                SendMailApplicant(Convert.ToString(dgvListGeneral.CurrentRow.Cells[17].Value), Convert.ToString(dgvListGeneral.CurrentRow.Cells[3].Value), "cancelada", UserLogin.Nombre_Usuario, Convert.ToString(dgvListGeneral.CurrentRow.Cells[0].Value));
                            }
                            else
                            {
                                this.MensjaeError(rpta);
                            }

                            this.ListGeneral();
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
        private void SendMailApplicant(string email, string nombreSolicitante, string estatusSolicitud, string nombreFinanzas, string folio)
        {
            var user = new UserModel();
            var result = user.sendMailApplicant(email, nombreSolicitante, estatusSolicitud, nombreFinanzas, folio);
            if (!result.Equals("OK"))
            {
                MensjaeError("Lo sentimos, no se pudo envíar el correo de\n" +
                    "notificación a " + nombreSolicitante + ".");
            }
        }
        private void SendMailApplicantVoBo(string email, string nombreSolicitante, string estatusSolicitud, string nombreFinanzas, string folio)
        {
            var user = new UserModel();
            var result = user.sendMailApplicantForFinance(email, nombreSolicitante, estatusSolicitud, nombreFinanzas, folio);
            if (!result.Equals("OK"))
            {
                MensjaeError("Lo sentimos, no se pudo envíar el correo de\n" +
                    "notificación a " + nombreSolicitante + ".");
            }
        }
    }
}
