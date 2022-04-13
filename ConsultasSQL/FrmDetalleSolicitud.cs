using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Domain;
using System.IO;
using System.Data;
using Common.Cache;


namespace ConsultasSQL
{
    public partial class FrmDetalleSolicitud : Form
    {

        private string rutaOrigen;
        private string rutaDestino;
        private string directorio = "C:\\Sistema\\"; //Ruta  a guardar archivos.
        private DataTable dtDetalle = new DataTable();
        
        public FrmDetalleSolicitud()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que deseas salir?\nLos datos registrados se borrarán.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }



        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void CreateTable()
        {
            
            dtDetalle.Columns.Add("codigo", Type.GetType("System.String"));
            dtDetalle.Columns.Add("cantidad", Type.GetType("System.Int32"));
            dtDetalle.Columns.Add("unidad_medida", Type.GetType("System.String"));
            dtDetalle.Columns.Add("descripcion", Type.GetType("System.String"));
            dtDetalle.Columns.Add("observaciones", Type.GetType("System.String"));
            dgvList.DataSource = dtDetalle;

            dgvList.Columns[0].HeaderText = "Código";
            dgvList.Columns[1].HeaderText = "Cantidad";
            dgvList.Columns[2].HeaderText = "U. Medida";
            dgvList.Columns[3].HeaderText = "Descripción";
            dgvList.Columns[4].HeaderText = "Observaciones";
        }

        private void AddDetail(string codigo, int cantidad, string unidad_medida, string descripcion, string observaciones)
        {
                DataRow fila = dtDetalle.NewRow();
                fila["codigo"] = codigo;
                fila["cantidad"] = cantidad;
                fila["unidad_medida"] = unidad_medida;
                fila["descripcion"] = descripcion;
                fila["observaciones"] = observaciones;
                dtDetalle.Rows.Add(fila);
        }

        private void LoadListUnitOfMeasurement()
        {
            try
            {
                cmbUnidadMedida.DataSource = DomainDetailRequest.ListUnitOfMeasurement();
                cmbUnidadMedida.ValueMember = "idunidad";
                cmbUnidadMedida.DisplayMember = "unidad";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void msgError(string msg)
        {
            lblErrorMessagge.Text = "     " + msg;
            lblErrorMessagge.Visible = true;
        }
        

        private void FrmDetalleSolicitud_Load(object sender, EventArgs e)
        {
            LoadMail();
            CreateTable();
            LoadListUnitOfMeasurement();
            txtCodigo.Focus();
            lblRecords.Text = "Total registros: " + Convert.ToString(dgvList.Rows.Count);
        }

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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Solo archivos (*.docx, *xlsx, *.pdf) | *.docx; *xlsx; *.pdf;";
            if(file.ShowDialog()== DialogResult.OK)
            {
                this.rutaOrigen = file.FileName;
                SaveDocument();
                // txtRutaArchivo.Text = file.FileName.Substring(file.FileName.LastIndexOf("\\") + 1); //Obtener el nombre.
                //Request.archivo = file.FileName.Substring(file.FileName.LastIndexOf("\\") + 1); 

            }

        }

        private void SaveDocument()
        {
            try
            {

                this.rutaDestino = this.directorio + rutaOrigen.Substring(rutaOrigen.LastIndexOf("\\") + 1);
                File.Copy(rutaOrigen, rutaDestino);
                 txtRutaArchivo.Text = rutaOrigen.Substring(rutaOrigen.LastIndexOf("\\") + 1); //Obtener el nombre.
                Request.archivo = rutaOrigen.Substring(rutaOrigen.LastIndexOf("\\") + 1); 

            }
            catch (Exception ex)
            {
                MensjaeError("Error al agregar archivo.\n" +
                    "Posibles errores:\n" +
                    "- Hay un documento con el mismo nombre.\n"+
                    "- No existe una carpeta con el direcorio marcado.\n" +
                    "- Archivo no compatible.\n" +
                    "- No tienes acceso a la red.");
            }
        }

        private void btnEnivarSolicitud_Click(object sender, EventArgs e)
        {
            if (txtRutaArchivo.Text != string.Empty)
            {

                SendRequestToDB();
                Request.checkFrmRequest = 1;
                this.Close();
            }
            else if (Convert.ToInt32(dgvList.Rows.Count) == 0)
            {
                MensjaeError("Debes agregar por lo menos un artículo o un archivo.");
            }
            else{

                Request.archivo = "N/A";
                SendRequestToDB();
                
                Request.checkFrmRequest = 1;
                this.Close();
            }
            
        }

        private void SendMailAuthorizer(string email, string nombreSolicitante, string nombreAutorizador)
        {
            var user = new UserModel();
            var result = user.sendMailAuthorizerForApplicant(email, nombreSolicitante, nombreAutorizador);
            if (!result.Equals("OK"))
            {
                MensjaeError("Lo sentimos, no se pudo envíar el correo de\n" +
                    "notificación a " + nombreAutorizador + ".");
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
        private void SendRequestToDB()
        {
            try
            {
                string rpta = "";
                rpta = DomainNewRequest.InsertRequest(Request.idSolicitante, Request.idAutorizador, Request.idVisto_bueno, Request.idCeCo, Request.idUso, Request.idUbicacion, Request.idTipo_salida, Request.entrega, Request.recibe, Request.vale_almacen, Request.dir_proveedor, Request.archivo, dtDetalle);
                if (rpta.Equals("OK"))
                {
                    MensjaeOk("Se ha envíado la solicitud correctamente.");
                    SendMailAuthorizer(UserAuthorizer.email, UserLogin.Nombre_Usuario, UserAuthorizer.nameAuthorizer);
                }
                else
                {
                    MensjaeError(rpta);
                }
            }
            catch (Exception ex)
            {
                MensjaeError(ex.Message + ex.StackTrace);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            
            if (txtCantidad.Text == string.Empty)
            {
                msgError("Debes ingresar una cantidad.");
            }
            else if (txtDescripcion.Text == string.Empty)
            {
                msgError("Debes agregar una descripción.");
            }
            else if (txtObservaciones.Text == string.Empty)
            {
                msgError("Debes agregar una observación.");
            }

            else
            {
                try
                {
                    string codigo = "";
                    if (txtCodigo.Text == string.Empty)
                    {
                        codigo = "N/A";
                    }
                    else
                    {
                        codigo = txtCodigo.Text.Trim();
                    }

                    AddDetail(codigo, Convert.ToInt32(txtCantidad.Text.Trim()), cmbUnidadMedida.Text.Trim(), txtDescripcion.Text.Trim(), txtObservaciones.Text.Trim());
                    CleanBoxes();
                    lblRecords.Text = "Total registros: " + Convert.ToString(dgvList.Rows.Count);
                    lblErrorMessagge.Visible = false;
                }
                catch (Exception ex)
                {
                    MensjaeError(ex.Message + ex.StackTrace);
                }
            }
        }
        private void CleanBoxes()
        {
            txtCodigo.Clear();
            txtCodigo.Focus();
            txtCantidad.Clear();
            txtDescripcion.Clear();
            txtObservaciones.Clear();
        }


        private void MensjaeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema salidas", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void MensjaeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema salidas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que deseas salir?\nLos datos registrados se borrarán.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridView data = new DataGridView();
                    int selectedrowindex = dgvList.SelectedCells[0].RowIndex;
                    dgvList.Rows.RemoveAt(selectedrowindex);
                    lblRecords.Text = "Total registros: " + Convert.ToString(dgvList.Rows.Count);

                }
                catch(Exception ex)
                {
                    MensjaeError("Error " + ex);
                }
            }
            else
            {
                MensjaeError("Debe seleccionar una fila.");
            }
        }
    }
}
