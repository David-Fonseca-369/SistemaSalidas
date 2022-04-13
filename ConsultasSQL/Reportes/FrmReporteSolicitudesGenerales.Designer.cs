namespace ConsultasSQL.Reportes
{
    partial class FrmReporteSolicitudesGenerales
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.area_listarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsSistema = new ConsultasSQL.Reportes.DsSistema();
            this.reporte_general_documentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporte_general_documentoTableAdapter = new ConsultasSQL.Reportes.DsSistemaTableAdapters.reporte_general_documentoTableAdapter();
            this.area_listarTableAdapter = new ConsultasSQL.Reportes.DsSistemaTableAdapters.area_listarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.area_listarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_general_documentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsSolicitudes";
            reportDataSource1.Value = this.area_listarBindingSource;
            reportDataSource2.Name = "dsGeneral";
            reportDataSource2.Value = this.reporte_general_documentoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConsultasSQL.Reportes.RptSolicitudesGenerales.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
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
            // reporte_general_documentoTableAdapter
            // 
            this.reporte_general_documentoTableAdapter.ClearBeforeFill = true;
            // 
            // area_listarTableAdapter
            // 
            this.area_listarTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteSolicitudesGenerales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteSolicitudesGenerales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.FrmReporteSolicitudesGenerales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.area_listarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_general_documentoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DsSistemaTableAdapters.reporte_general_documentoTableAdapter reporte_general_documentoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource area_listarBindingSource;
        private DsSistema DsSistema;
        private System.Windows.Forms.BindingSource reporte_general_documentoBindingSource;
        private DsSistemaTableAdapters.area_listarTableAdapter area_listarTableAdapter;
    }
}