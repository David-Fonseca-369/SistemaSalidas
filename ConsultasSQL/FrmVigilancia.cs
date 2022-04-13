using System;
using System.Linq;
using System.Windows.Forms;
using Domain;
using Common.Cache;
using System.Diagnostics;

namespace ConsultasSQL
{
    public partial class FrmVigilancia : Form
    {
        private string directorio = "C:\\Sistema\\";
        public FrmVigilancia()
        {
            InitializeComponent();
        }

        private void rdbTexto_CheckedChanged(object sender, EventArgs e)
        {
            pnlBuscarTexto.Visible = true;
            pnlBuscarFecha.Visible = false;
            cmbSolicitud.Enabled = true;
            cmbSolicitud.Text = "Todas";
            
        }

        private void rdbFecha_CheckedChanged(object sender, EventArgs e)
        {
            pnlBuscarTexto.Visible = false;
            pnlBuscarFecha.Visible = true;
            cmbSolicitud.Text = "Todas";
            cmbSolicitud.Enabled = false;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlDetalleSolicitud.Visible = false;
        }

        private void FrmVigilancia_Load(object sender, EventArgs e)
        {
            rdbTexto.Checked = true;
        }
        private void ListRequest()
        {
            try
            {
                string checkSolicitud = "";
                
                if (cmbSolicitud.Text.Equals("Todas"))
                {
                    checkSolicitud = "";
                }
                else if (cmbSolicitud.Text.Equals("Confirmadas"))
                {
                    checkSolicitud = "Confirmada por ";
                }
                else if (cmbSolicitud.Text.Equals("Pendientes"))
                {
                    checkSolicitud = "Pendiente";
                }


                dgvList.DataSource = DomainRequest.ListRequestSurveillance( checkSolicitud, txtBuscar.Text);

                lblRecords.Text = "Total registros: " + Convert.ToString(dgvList.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void cmbSolicitud_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListRequest();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ListRequest();
        }
        private void SearchForDate()
        {
            try
            {
                dgvList.DataSource = DomainRequest.QueryDateSurveillance(Convert.ToDateTime(dtpFechaInicio.Value), Convert.ToDateTime(dtpFechaFin.Value));
                lblRecords.Text = "Total registros: " + Convert.ToString(dgvList.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SearchForDate();
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
        private void MensjaeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de salidas", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void MensjaeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de salidas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count > 0)
            {

                if (!dgvList.CurrentRow.Cells[12].Value.ToString().Equals("Pendiente"))
                {
                    MensjaeOk("Esta solicitud ya está confirmada.");
                }
                else
                {
                    try
                    {
                        DialogResult option;
                        option = MessageBox.Show("¿Realmente deseas confirmar la solicitud de " + Convert.ToString(dgvList.CurrentRow.Cells[3].Value) + "?", "Sistema salidas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (option == DialogResult.OK)
                        {
                            string rpta = "";
                            int codigo;

                            codigo = Convert.ToInt32(dgvList.CurrentRow.Cells[0].Value);
                            rpta = DomainRequest.Confirm(codigo, "Confirmada por "+UserLogin.Nombre_Usuario );

                            if (rpta.Equals("OK"))
                            {
                                this.MensjaeOk("Se comfirmó la solicitud de: " + Convert.ToString(dgvList.CurrentRow.Cells[3].Value));
                            }
                            else
                            {
                                this.MensjaeError(rpta);
                            }

                            this.ListRequest();
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
    }
}
