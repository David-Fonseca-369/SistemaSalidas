using System;
using System.Windows.Forms;
using Domain;
using Common.Cache;
using System.Data;


namespace ConsultasSQL
{
    public partial class FrmNuevaSolicitud : Form
    {
        public FrmNuevaSolicitud()
        {
            InitializeComponent();
        }


        private void MensjaeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema salidas", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void MensjaeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema salidas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
         private void SendToCaché()
        {
            Request.idSolicitante = UserLogin.IdUsuario;
            //Request.idSolicitante = 6;
            Request.idAutorizador = Convert.ToInt32(cmbSolicitarA.SelectedValue);
            Request.idVisto_bueno = Convert.ToInt32(cmbVistoBueno.SelectedValue);
            //Centro de costos ya está en caché.
            Request.idUso = Convert.ToInt32(cmbMaterialPara.SelectedValue);
            Request.idUbicacion = Convert.ToInt32(cmbMatDireccion.SelectedValue);
            //Tipo de salida ya está en caché.
            Request.entrega = txtEntrega.Text.Trim();
            Request.recibe = txtRecibe.Text.Trim();
            if(txtFolio.Text == string.Empty)
            {
                Request.vale_almacen = "N/A";
            }
            else
            {
                Request.vale_almacen = txtFolio.Text.Trim();
            }
            if (RichTxtDireccion.Text == string.Empty)
            {
                Request.dir_proveedor = "N/A";
            }
            else
            {
                Request.dir_proveedor = RichTxtDireccion.Text.Trim();
            }
        }

        private void FrmNuevaSolicitud_Load(object sender, EventArgs e)
        {
            this.DisableText();
            this.MensjaeOk("Selecciona el tipo de salida \nPor favor.");
            this.LoadMaterialFor();
            this.LoadMaterialLocation();
            this.LoadListFinance();
            this.LoadListCecO();
            cmbMaterialPara.Text = "Hola";
            
           
           // txtRecibe.Text = Convert.ToString(Common.Cache.UserLogin.IdUsuario);
        }
        private void ResetFrm()
        {
            picHand.Visible = true;
            this.DisableText();
            this.LoadMaterialFor();
            this.LoadMaterialLocation();
            this.LoadListFinance();
            this.LoadListCecO();
            txtCeCo.Clear();
            txtFolio.Clear();
            txtEntrega.Clear();
            txtRecibe.Clear();
            RichTxtDireccion.Clear();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SendRequest();
          
        }
        private void msgError(string msg)
        {
            lblErrorMessagge.Text = "     " + msg;
            lblErrorMessagge.Visible = true;
        }
        private void SendRequest()
        {
            if (txtCeCo.Text == string.Empty)
            {
                msgError("Debe ingresar un centro de costos.");
            }
            else if (cmbSolicitarA.Text == string.Empty)
            {
                msgError("Debe seleccionar a un solicitador.");
            }
            else if (cmbVistoBueno.Text == string.Empty)
            {
                msgError("Debe seleccionar a un usuario que de el visto bueno.");
            }
            else if (cmbMaterialPara.Text == string.Empty)
            {
                msgError("Debe seleccionar el uso del material.");
            }
            else if (cmbMatDireccion.Text == string.Empty)
            {
                msgError("Debe seleccionar la ubicación.");
            }
            else if (txtEntrega.Text == string.Empty)
            {
                msgError("Ingresa a la persona va que va ha entregar.");

            }
            else if (txtRecibe.Text == string.Empty)
            {
                msgError("Ingresa a la persona que va ha recibir.");
            }
            else {
                //Enviar solicitud a memoria caché.
                lblErrorMessagge.Visible = false;
                SendToCaché();
                FrmDetalleSolicitud frm = new FrmDetalleSolicitud();
                frm.ShowDialog();
            }


        }

        private void LoadListAuthorizersTI()
        {
            try
            {
                cmbSolicitarA.DataSource = DomainAuthorizers.ListAuthorizersTI();
                cmbSolicitarA.ValueMember = "idusuario";
                cmbSolicitarA.DisplayMember = "nombre_usuario";

            }
            catch (Exception ex)
            {
                MensjaeError(ex.Message + ex.StackTrace);
            }
        }

        private void LoadListAuthorizersMaterialForFacility()
        {
            try
            {
                cmbSolicitarA.DataSource = DomainAuthorizers.ListAuthorizersMaterialForFacility();
                cmbSolicitarA.ValueMember = "idusuario";
                cmbSolicitarA.DisplayMember = "nombre_usuario";

            }
            catch (Exception ex)
            {
                MensjaeError(ex.Message + ex.StackTrace);
            }
        }
        private void LoadListAuthorizersCLQProductionMaterial()
        {
            try
            {
                cmbSolicitarA.DataSource = DomainAuthorizers.ListAuthorizersCLQProductionMaterial();
                cmbSolicitarA.ValueMember = "idusuario";
                cmbSolicitarA.DisplayMember = "nombre_usuario";

            }
            catch (Exception ex)
            {
                MensjaeError(ex.Message + ex.StackTrace);
            }
        }

        private void LoadListAuthorizersSampleDeliveryByParcel()
        {
            try
            {
                cmbSolicitarA.DataSource = DomainAuthorizers.ListAuthorizersSampleDeliveryByParcel();
                cmbSolicitarA.ValueMember = "idusuario";
                cmbSolicitarA.DisplayMember = "nombre_usuario";

            }
            catch (Exception ex)
            {
                MensjaeError(ex.Message + ex.StackTrace);
            }
        }
        private void LoadListAuthorizersSecurity()
        {
            try
            {
                cmbSolicitarA.DataSource = DomainAuthorizers.ListAuthorizersSecurity();
                cmbSolicitarA.ValueMember = "idusuario";
                cmbSolicitarA.DisplayMember = "nombre_usuario";

            }
            catch (Exception ex)
            {
                MensjaeError(ex.Message + ex.StackTrace);
            }
        }

        private void LoadListAuthorizersRH()
        {
            try
            {
                cmbSolicitarA.DataSource = DomainAuthorizers.ListAuthorizersRH();
                cmbSolicitarA.ValueMember = "idusuario";
                cmbSolicitarA.DisplayMember = "nombre_usuario";

            }
            catch (Exception ex)
            {
                MensjaeError(ex.Message + ex.StackTrace);
            }
        }


        private void LoadMaterialFor()
        {
            try
            {
                cmbMaterialPara.DataSource = DomainNewRequest.ListMaterialFor();
                cmbMaterialPara.ValueMember = "iduso";
                cmbMaterialPara.DisplayMember = "uso";

            }
            catch (Exception ex)
            {
                MensjaeError(ex.Message + ex.StackTrace);
            }
        }

        private void LoadMaterialLocation()
        {
            try
            {
                cmbMatDireccion.DataSource = DomainNewRequest.ListMaterialLocation();
                cmbMatDireccion.ValueMember = "idubicacion";
                cmbMatDireccion.DisplayMember = "ubicacion";

            }
            catch (Exception ex)
            {
                MensjaeError(ex.Message + ex.StackTrace);
            }
        }

        private void LoadDataAuthorizer()
        {
            try
            {
                DataTable tabla = new DataTable();
                tabla = DRol.DataAuthorizer(UserAuthorizer.idAuthorizer);
                if (tabla.Rows.Count <= 0)
                {
                    MensjaeError("No existe el id.");
                }
                else
                {
                    DataRow row = tabla.Rows[0];
                    UserAuthorizer.nameAuthorizer = Convert.ToString(row["nombre_usuario"]);
                    UserAuthorizer.email = Convert.ToString(row["email"]);

                }
            }
            catch (Exception ex)
            {
                MensjaeError(ex + " Error");
            }
            

        }
        private void LoadListFinance()
        {
            try
            {
                cmbVistoBueno.DataSource = DomainNewRequest.ListFinance();
                cmbVistoBueno.ValueMember = "idusuario";
                cmbVistoBueno.DisplayMember = "nombre_usuario";

            }
            catch (Exception ex)
            {
                MensjaeError(ex.Message + ex.StackTrace);
            }
        }

        private void DisableText()
        {
            
            txtFolio.Enabled = false;
            cmbSolicitarA.Enabled = false;
            cmbVistoBueno.Enabled = false;
            cmbMaterialPara.Enabled = false;
            cmbMatDireccion.Enabled = false;
            txtRecibe.Enabled = false;
            btnCeCo.Enabled = false;
            RichTxtDireccion.Enabled = false;
            txtEntrega.Enabled = false;
            btnAgregarEquipo.Enabled = false;
        }

        private void EnabledText()
        {
            picHand.Visible = false;
            txtFolio.Enabled = true;
            cmbSolicitarA.Enabled = true;
            cmbVistoBueno.Enabled = true;
            cmbMaterialPara.Enabled = true;
            cmbMatDireccion.Enabled = true;
            txtRecibe.Enabled = true;
            btnCeCo.Enabled = true;
            RichTxtDireccion.Enabled = true;
            txtEntrega.Enabled = true;
            btnAgregarEquipo.Enabled = true;
        }

        public void LoadListCecO()
        {
            try
            {
                dgvList.DataSource = DomainNewRequest.ListCeCo();
                this.Format();
                lblRecords.Text = "Total registros: " + Convert.ToString(dgvList.Rows.Count);


            }
            catch (Exception ex)
            {
                MensjaeError(ex.Message + ex.StackTrace);
            }
        }
        private void Format()
        {
            dgvList.Columns[0].Visible = false;
            dgvList.Columns[1].HeaderText = "C. de costos";
            dgvList.Columns[1].Width = 300;
        }

        private void SearchCeCo()
        {
            try
            {
                dgvList.DataSource = DomainNewRequest.SearchCeCo(txtBuscar.Text);
                this.Format();
                lblRecords.Text = "Total registros: " + Convert.ToString(dgvList.Rows.Count);
            }
            catch (Exception ex)
            {
                MensjaeError(ex.Message + ex.StackTrace);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlCeCo.Visible = false;
        }

        private void btnCeCo_Click(object sender, EventArgs e)
        {
            pnlCeCo.Visible = true;
            txtBuscar.Focus();
               
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            SearchCeCo();
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCeCo.Text = Convert.ToString(dgvList.CurrentRow.Cells[1].Value);
            //Id centro costos
            Common.Cache.Request.idCeCo = Convert.ToInt32(dgvList.CurrentRow.Cells[0].Value);
            pnlCeCo.Visible = false;
            txtBuscar.Clear();
            LoadListCecO();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LoadListCecO();
        }

        private void herramientasParaServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Request.idTipo_salida = 9;
            LoadListAuthorizersTI();
            this.EnabledText();
            UserAuthorizer.idAuthorizer = Convert.ToInt32(cmbSolicitarA.SelectedValue);
            LoadDataAuthorizer();
           
        }

        private void salidaDeMaterialesParaInstalacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Envio de idTipo_solicitud de acuerdo a la BD.
            Request.idTipo_salida = 6;
            LoadListAuthorizersMaterialForFacility();
            EnabledText();
            UserAuthorizer.idAuthorizer = Convert.ToInt32(cmbSolicitarA.SelectedValue);
            LoadDataAuthorizer();
            
        }

        private void envíoDeMaterialAProducciónDelCLQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Request.idTipo_salida = 7;
            LoadListAuthorizersCLQProductionMaterial();
            EnabledText();
            UserAuthorizer.idAuthorizer = Convert.ToInt32(cmbSolicitarA.SelectedValue);
            LoadDataAuthorizer();
        }

        private void envíoDeMuestrasPorPaqueteríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Request.idTipo_salida = 8;
            LoadListAuthorizersSampleDeliveryByParcel();
            EnabledText();
            UserAuthorizer.idAuthorizer = Convert.ToInt32(cmbSolicitarA.SelectedValue);
            LoadDataAuthorizer();
        }

        private void herramientasParaServicioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Request.idTipo_salida = 10;
            LoadListAuthorizersSecurity();
            EnabledText();
            UserAuthorizer.idAuthorizer = Convert.ToInt32(cmbSolicitarA.SelectedValue);
            LoadDataAuthorizer();
        }

        private void recursosHumanosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void herramientasParaServicioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Request.idTipo_salida = 11;
            LoadListAuthorizersRH();
            EnabledText();
            UserAuthorizer.idAuthorizer = Convert.ToInt32(cmbSolicitarA.SelectedValue);
            LoadDataAuthorizer();
        }

        private void almacénToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timerRequest_Tick(object sender, EventArgs e)
        {
            if(Request.checkFrmRequest == 1)
            {
                Request.checkFrmRequest = 0;
                ResetFrm();
            }
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbSolicitarA_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //UserAuthorizer.idAuthorizer = Convert.ToInt32(cmbSolicitarA.SelectedValue);

            // LoadDataAuthorizer();
            /**if(Convert.ToInt32(cmbSolicitarA.SelectedIndex)== UserLogin.IdUsuario)
             {
                 MessageBox.Show("No puedes autorizarte tú mismo." +
                     "\nDebes pedir autorización a otro Autorizador.");
                 
             }
     **/
        }

        private void cmbVistoBueno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSolicitarA_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UserAuthorizer.idAuthorizer = Convert.ToInt32(cmbSolicitarA.SelectedValue);
            LoadDataAuthorizer();
            

        }

        private void RichTxtDireccion_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }
    }
}
