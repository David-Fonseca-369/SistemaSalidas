using System;
using System.Windows.Forms;
using ConsultasSQL.Reportes;
using Domain;
using Common.Cache;
using System.Diagnostics;

namespace ConsultasSQL
{
    public partial class FrmReportesFinanzas : Form
    {
        private string directorio = "C:\\Sistema\\";
        public FrmReportesFinanzas()
        {
            InitializeComponent();
        }

        private void FrmReportesFinanzas_Load(object sender, EventArgs e)
        {
            rdbTexto.Checked = true;

            
        }
        private void SearchForDateGeneral()
        {
            try
            {
                dgvList.DataSource = DomainRequest.QueryDateGeneral(Convert.ToDateTime(dtpFechaInicio.Value), Convert.ToDateTime(dtpFechaFin.Value));
                lblRecords.Text = "Total registros: " + Convert.ToString(dgvList.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void cmbEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListGeneral();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
                    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdbTexto_CheckedChanged(object sender, EventArgs e)
        {
            ReportGeneral.checkTypeReport = 0;
            pnlBuscarTexto.Visible = true;
            pnlBuscarFecha.Visible = false;
            cmbAutorizacion.Enabled = true;
            cmbVoBo.Enabled = true;
            cmbEstatus.Enabled = true;
            cmbTipo.Enabled = true;
            cmbSalida.Enabled = true;
            cmbAutorizacion.Text = "Todas";
            cmbVoBo.Text = "Todas";
            cmbEstatus.Text = "Todas";
            cmbSalida.Text = "Todas";
            cmbTipo.Text = "Todas";
            txtBuscar.Text = "";
            ListGeneral();
        }
        private void ListGeneral()
        {
            try
            {
                string checkAuthorization = "";
                string checkVoBo = "";
                string checkStatus = "";
                string checkConfirm ="";
                string checkType = "";
                if (cmbAutorizacion.Text.Equals("Todas"))
                {
                    checkAuthorization = "";
                    ReportGeneral.autorizacion = checkAuthorization;
                }
                else if (cmbAutorizacion.Text.Equals("Pendientes"))
                {
                    checkAuthorization = "Pendiente";
                    ReportGeneral.autorizacion = checkAuthorization;
                }
                else if (cmbAutorizacion.Text.Equals("Autorizadas"))
                {
                    checkAuthorization = "Autorizada";
                    ReportGeneral.autorizacion = checkAuthorization;
                }
                else if (cmbAutorizacion.Text.Equals("No autorizadas"))
                {
                    checkAuthorization = "Rechazada";
                    ReportGeneral.autorizacion = checkAuthorization;
                }
                
                if (cmbVoBo.Text.Equals("Todas"))
                {
                    checkVoBo = "";
                    ReportGeneral.vistoBueno = checkVoBo;
                }
                else if (cmbVoBo.Text.Equals("Pendientes"))
                {
                    checkVoBo = "Pendiente";
                    ReportGeneral.vistoBueno = checkVoBo;
                }
                else if (cmbVoBo.Text.Equals("Vo. Bo."))
                {
                    checkVoBo = "Visto bueno";
                    ReportGeneral.vistoBueno = checkVoBo;
                }
                else if (cmbVoBo.Text.Equals("Anuladas"))
                {
                    checkVoBo = "Anulada";
                    ReportGeneral.vistoBueno = checkVoBo;
                }


                if (cmbEstatus.Text.Equals("Todas"))
                {
                    checkStatus = "";
                    ReportGeneral.estatus = checkStatus;
                }
                else if (cmbEstatus.Text.Equals("Activadas"))
                {
                    checkStatus = "1";
                    ReportGeneral.estatus = checkStatus;
                }
                else if (cmbEstatus.Text.Equals("Canceladas"))
                {
                    checkStatus = "0";
                    ReportGeneral.estatus = checkStatus;
                }

                if (cmbSalida.Text.Equals("Todas"))
                {
                    checkConfirm = "";
                    ReportGeneral.salida = checkConfirm;
                }
                else if (cmbSalida.Text.Equals("Confirmadas"))
                {
                    checkConfirm = "Confirmada por";
                    ReportGeneral.salida = checkConfirm;
                }
                else if (cmbSalida.Text.Equals("Pendientes"))
                {
                    checkConfirm = "Pendiente";
                    ReportGeneral.salida = checkConfirm;
                }

                if (cmbTipo.Text.Equals("Todas"))
                {
                    checkType = "";
                    ReportGeneral.tipo = checkType;
                }
                else if (cmbTipo.Text.Equals("Instalaciones")){
                    checkType = "Instalaciones";
                    ReportGeneral.tipo = checkType;
                }
                else if (cmbTipo.Text.Equals("Producción CLQ"))
                {
                    checkType = "Producción CLQ";
                    ReportGeneral.tipo = checkType;
                }
                else if (cmbTipo.Text.Equals("Muestras"))
                {
                    checkType = "Muestras";
                    ReportGeneral.tipo = checkType;
                }
                else if (cmbTipo.Text.Equals("TI"))
                {
                    checkType = "TI";
                    ReportGeneral.tipo = checkType;
                }
                else if (cmbTipo.Text.Equals("Seguridad"))
                {
                    checkType = "Seguridad";
                    ReportGeneral.tipo = checkType;
                }
                else if (cmbTipo.Text.Equals("RH"))
                {
                    checkType = "RH";
                    ReportGeneral.tipo = checkType;
                }


                dgvList.DataSource = DomainRequest.ListRequestGeneralReport(checkAuthorization, checkVoBo, txtBuscar.Text.Trim(), checkStatus, checkConfirm, checkType);

                lblRecords.Text = "Total registros: " + Convert.ToString(dgvList.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (ReportGeneral.checkTypeReport == 0) { 
            FrmReporteSolicitudesGenerales ventana = new FrmReporteSolicitudesGenerales();
            ventana.ShowDialog();
        }
            else if (ReportGeneral.checkTypeReport == 1)
            {
                FrmReporteSolicitudesGeneralesFechas ventana = new FrmReporteSolicitudesGeneralesFechas();
                ventana.ShowDialog();
            }
        }

        private void rdbFecha_CheckedChanged(object sender, EventArgs e)
        {
            ReportGeneral.checkTypeReport = 1;
            pnlBuscarTexto.Visible = false;
            pnlBuscarFecha.Visible = true;
            cmbAutorizacion.Text = "Todas";
            cmbVoBo.Text = "Todas";
            cmbEstatus.Text = "Todas";
            cmbSalida.Text = "Todas";
            cmbTipo.Text = "Todas";
            cmbAutorizacion.Enabled = false;
            cmbVoBo.Enabled = false;
            cmbEstatus.Enabled = false;
            cmbSalida.Enabled = false;
            cmbTipo.Enabled = false;
        }

        private void cmbVoBo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListGeneral();
        }

        private void cmbAutorizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListGeneral();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ListGeneral();
            ReportGeneral.texto = txtBuscar.Text.Trim();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListGeneral();
        }

        private void cmbSalida_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListGeneral();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SearchForDateGeneral();
            ReportGeneral.fechaInicio = dtpFechaInicio.Value;
            ReportGeneral.fechaFinal = dtpFechaFin.Value;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlDetalleSolicitud.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenDocument();
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
    }
}
