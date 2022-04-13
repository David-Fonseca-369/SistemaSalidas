using System;
using System.Windows.Forms;
using Domain;
using Common.Cache;
using System.Diagnostics;
using ConsultasSQL.Reportes;

namespace ConsultasSQL
{
    public partial class FrmSolicitudes : Form
    {

        private string directorio = "C:\\Sistema\\";
        public FrmSolicitudes()
        {
            InitializeComponent();
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
                  checkAuthorization= "Pendiente";
                }
                else if (cmbAutorizacion.Text.Equals("Autorizadas"))
                {
                    checkAuthorization = "Autorizada";
                }
                else if (cmbAutorizacion.Text.Equals("No autorizadas"))
                {
                    checkAuthorization = "No autorizadas";
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

        private void FrmSolicitudes_Load(object sender, EventArgs e)
        {
            ListRequestApplicant();
            rdbTexto.Checked = true;
            cmbAutorizacion.Text = "Todas";
            cmbVoBo.Text = "Todas";
        }

        private void SearchForDateApplicant()
        {
            try
            {
                dgvList.DataSource = DomainRequest.QueryDateApplicant(UserLogin.IdUsuario,Convert.ToDateTime(dtpFechaInicio.Value), Convert.ToDateTime(dtpFechaFin.Value));
                this.Format();
                lblRecords.Text = "Total registros: " + Convert.ToString(dgvList.Rows.Count);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void cmbOrdenarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
        ListRequestApplicant();
        }

        private void cmbVoBo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListRequestApplicant();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ListRequestApplicant();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ListRequestApplicant();
            pnlBuscarTexto.Visible = false;
            pnlBuscarFecha.Visible = true;
            cmbAutorizacion.Text = "Todas";
            cmbVoBo.Text = "Todas";
            cmbAutorizacion.Enabled = false;
            cmbVoBo.Enabled = false;
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pnlBuscarTexto.Visible = true;
            pnlBuscarFecha.Visible = false;
            cmbAutorizacion.Enabled = true;
            cmbVoBo.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SearchForDateApplicant();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlDetalleSolicitud.Visible = false;

        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try{
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
        private void MensjaeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de salidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensjaeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de salidas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
