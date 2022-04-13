using System;
using System.Windows.Forms;
using Common.Cache;

namespace ConsultasSQL.Reportes
{
    public partial class FrmReporteSolicitudesGenerales : Form
    {
        public FrmReporteSolicitudesGenerales()
        {
            InitializeComponent();
        }

        private void FrmReporteSolicitudesGenerales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DsSistema.area_listar' table. You can move, or remove it, as needed.
            this.area_listarTableAdapter.Fill(this.DsSistema.area_listar);
            // TODO: This line of code loads data into the 'DsSistema.reporte_general_documento' table. You can move, or remove it, as needed.
            this.reporte_general_documentoTableAdapter.Fill(this.DsSistema.reporte_general_documento, ReportGeneral.vistoBueno, ReportGeneral.texto, ReportGeneral.autorizacion, ReportGeneral.estatus, ReportGeneral.salida, ReportGeneral.tipo);
            // TODO: This line of code loads data into the 'DsSistema.area_listar' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        
    }
}
