using System;
using Domain;
using System.Windows.Forms;
using System.Drawing;
using Common.Cache;

namespace ConsultasSQL
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        { 
            InitializeComponent();
        }
         public void ListUsers()
        {
            try
            {
                dgvListUsers.DataSource = DomainUser.ListUsers();
                this.Format();
                lblRecords.Text = "Total registros: " + Convert.ToString(dgvListUsers.Rows.Count);
                

            }catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message + Ex.StackTrace);
            }
        }
        private void Format()
        {
            dgvListUsers.Columns[0].Visible = false;
            dgvListUsers.Columns[1].Visible = false;
            dgvListUsers.Columns[2].Visible = false;           
            dgvListUsers.Columns[8].Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            this.ListUsers();
           
        }

        private void Search()
        {
            try
            {
                dgvListUsers.DataSource = DomainUser.Search(txtBuscar.Text);
                this.Format();
                lblRecords.Text = "Total registros: " + Convert.ToString(dgvListUsers.Rows.Count);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ModifyUser.Check = 1;
            FrmMantUsuario frm = new FrmMantUsuario();
            frm.ShowDialog();
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals("Búscar por nombre o rol."))
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.LightGray;

            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals(""))
            {
                txtBuscar.Text = "Búscar por nombre o rol.";
                txtBuscar.ForeColor = Color.DimGray;
            }
        }

       

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvListUsers.SelectedRows.Count > 0)
            {

                if (dgvListUsers.CurrentRow.Cells[7].Value.ToString().Equals("Inactivo"))
                {
                    MensjaeOk("Este usuario ya está desactivado.");
                }
                else
                {
                    try
                    {
                        DialogResult option;
                        option = MessageBox.Show("¿Realmente deseas desactivar a " + Convert.ToString(dgvListUsers.CurrentRow.Cells[3].Value) + "?", "Sistema salidas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (option == DialogResult.OK)
                        {
                            string rpta = "";
                            int codigo;

                            codigo = Convert.ToInt32(dgvListUsers.CurrentRow.Cells[0].Value);
                            rpta = DomainUser.Desactivate(codigo);

                            if (rpta.Equals("OK"))
                            {
                                this.MensjaeOk("Se desactivó el registro de: " + Convert.ToString(dgvListUsers.CurrentRow.Cells[3].Value));
                            }
                            else
                            {
                                this.MensjaeError(rpta);
                            }

                            this.ListUsers();
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
                MensjaeError("Debe seleccionar una fila.");
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


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.ListUsers();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Search();
        }

        private void dgvListUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModifyUser.Check = 2;
            ModifyUser.ID = Convert.ToInt32(dgvListUsers.CurrentRow.Cells[0].Value);
            ModifyUser.Rol = Convert.ToString(dgvListUsers.CurrentRow.Cells[4].Value);
            ModifyUser.Area = Convert.ToString(dgvListUsers.CurrentRow.Cells[5].Value);
            ModifyUser.Nombre = Convert.ToString(dgvListUsers.CurrentRow.Cells[3].Value);
            ModifyUser.Email = Convert.ToString(dgvListUsers.CurrentRow.Cells[6].Value);
            ModifyUser.Clave = Convert.ToString(dgvListUsers.CurrentRow.Cells[8].Value);
            FrmMantUsuario frm = new FrmMantUsuario();
            frm.ShowDialog();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvListUsers.SelectedRows.Count > 0)
            {

                if (dgvListUsers.CurrentRow.Cells[7].Value.ToString().Equals("Activo"))
                {
                    MensjaeOk("Este usuario ya está activado.");
                }
                else
                {
                    try
                    {
                        DialogResult option;
                        option = MessageBox.Show("¿Realmente deseas activar a " + Convert.ToString(dgvListUsers.CurrentRow.Cells[3].Value) + "?", "Sistema salidas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (option == DialogResult.OK)
                        {
                            string rpta = "";
                            int codigo;

                            codigo = Convert.ToInt32(dgvListUsers.CurrentRow.Cells[0].Value);
                            rpta = DomainUser.Activate(codigo);

                            if (rpta.Equals("OK"))
                            {
                                this.MensjaeOk("Se activó el registro de: " + Convert.ToString(dgvListUsers.CurrentRow.Cells[3].Value));
                            }
                            else
                            {
                                this.MensjaeError(rpta);
                            }

                            this.ListUsers();
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

        private void timerDataBase_Tick(object sender, EventArgs e)
        {
            if(ModifyUser.UpdateDataBase == 1)
            {
                this.ListUsers();
                ModifyUser.UpdateDataBase = 0;
            }
            else
            {

            }
        }

        private void lblRecords_Click(object sender, EventArgs e)
        {

        }
    }
}
