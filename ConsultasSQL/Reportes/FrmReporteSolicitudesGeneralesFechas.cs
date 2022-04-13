using System;
using System.Windows.Forms;
using Common.Cache;

namespace ConsultasSQL.Reportes
{
    public partial class FrmReporteSolicitudesGeneralesFechas : Form
    {
        public FrmReporteSolicitudesGeneralesFechas()
        {
            InitializeComponent();
        }

        private void FrmReporteSolicitudesGeneralesFechas_Load(object sender, EventArgs e)
        {
            
            
            this.reporte_general_documento_fechasTableAdapter.Fill(this.DsSistema.reporte_general_documento_fechas, ReportGeneral.fechaInicio, ReportGeneral.fechaFinal);

            this.reportViewer1.RefreshReport();
        }
    }
}
