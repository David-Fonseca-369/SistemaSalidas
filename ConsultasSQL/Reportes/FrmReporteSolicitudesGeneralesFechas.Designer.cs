namespace ConsultasSQL.Reportes
{
    partial class FrmReporteSolicitudesGeneralesFechas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.area_listarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsSistema = new ConsultasSQL.Reportes.DsSistema();
            this.reporte_general_documentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporte_general_documento_fechasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.area_listarTableAdapter = new ConsultasSQL.Reportes.DsSistemaTableAdapters.area_listarTableAdapter();
            this.reporte_general_documentoTableAdapter = new ConsultasSQL.Reportes.DsSistemaTableAdapters.reporte_general_documentoTableAdapter();
            this.reporte_general_documento_fechasTableAdapter = new ConsultasSQL.Reportes.DsSistemaTableAdapters.reporte_general_documento_fechasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.area_listarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_general_documentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_general_documento_fechasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // area_listarBindingSource
            // 
            this.area_listarBindingSource.DataMember = "area_listar";
            this.area_listarBindingSource.DataSource = this.DsSistema;
            // 
            // DsSistema
            // 
            this.DsSistema.DataSetName = "DsSistema";
            this.DsSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporte_general_documentoBindingSource
            // 
            this.reporte_general_documentoBindingSource.DataMember = "reporte_general_documento";
            this.reporte_general_documentoBindingSource.DataSource = this.DsSistema;
            // 
            // reporte_general_documento_fechasBindingSource
            // 
            this.reporte_general_documento_fechasBindingSource.DataMember = "reporte_general_documento_fechas";
            this.reporte_general_documento_fechasBindingSource.DataSource = this.DsSistema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "dsSolicitudes";
            reportDataSource4.Value = this.area_listarBindingSource;
            reportDataSource5.Name = "dsGeneral";
            reportDataSource5.Value = this.reporte_general_documentoBindingSource;
            reportDataSource6.Name = "dsGeneralFechas";
            reportDataSource6.Value = this.reporte_general_documento_fechasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConsultasSQL.Reportes.RptSolicitudesGeneralesFechas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // area_listarTableAdapter
            // 
            this.area_listarTableAdapter.ClearBeforeFill = true;
            // 
            // reporte_general_documentoTableAdapter
            // 
            this.reporte_general_documentoTableAdapter.ClearBeforeFill = true;
            // 
            // reporte_general_documento_fechasTableAdapter
            // 
            this.reporte_general_documento_fechasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteSolicitudesGeneralesFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteSolicitudesGeneralesFechas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte por fechas";
            this.Load += new System.EventHandler(this.FrmReporteSolicitudesGeneralesFechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.area_listarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_general_documentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_general_documento_fechasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource area_listarBindingSource;
        private DsSistema DsSistema;
        private System.Windows.Forms.BindingSource reporte_general_documentoBindingSource;
        private System.Windows.Forms.BindingSource reporte_general_documento_fechasBindingSource;
        private DsSistemaTableAdapters.area_listarTableAdapter area_listarTableAdapter;
        private DsSistemaTableAdapters.reporte_general_documentoTableAdapter reporte_general_documentoTableAdapter;
        private DsSistemaTableAdapters.reporte_general_documento_fechasTableAdapter reporte_general_documento_fechasTableAdapter;
    }
}