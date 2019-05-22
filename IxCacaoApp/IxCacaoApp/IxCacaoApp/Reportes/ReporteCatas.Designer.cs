namespace IxCacaoApp
{
    partial class ReporteCatas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetPrincipal = new IxCacaoApp.DataSetPrincipal();
            this.sp_Reportes_GenerarReporteCataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_Reportes_GenerarReporteCataTableAdapter = new IxCacaoApp.DataSetPrincipalTableAdapters.sp_Reportes_GenerarReporteCataTableAdapter();
            this.tb_idcata = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Reportes_GenerarReporteCataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.sp_Reportes_GenerarReporteCataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "IxCacaoApp.Reportes.RprReporteCata.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(821, 378);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // DataSetPrincipal
            // 
            this.DataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.DataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_Reportes_GenerarReporteCataBindingSource
            // 
            this.sp_Reportes_GenerarReporteCataBindingSource.DataMember = "sp_Reportes_GenerarReporteCata";
            this.sp_Reportes_GenerarReporteCataBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // sp_Reportes_GenerarReporteCataTableAdapter
            // 
            this.sp_Reportes_GenerarReporteCataTableAdapter.ClearBeforeFill = true;
            // 
            // tb_idcata
            // 
            this.tb_idcata.Enabled = false;
            this.tb_idcata.Location = new System.Drawing.Point(576, 57);
            this.tb_idcata.Name = "tb_idcata";
            this.tb_idcata.Size = new System.Drawing.Size(100, 20);
            this.tb_idcata.TabIndex = 1;
            this.tb_idcata.Visible = false;
            // 
            // ReporteCatas
            // 
            this.ClientSize = new System.Drawing.Size(821, 378);
            this.Controls.Add(this.tb_idcata);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteCatas";
            this.Load += new System.EventHandler(this.ReporteCatas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Reportes_GenerarReporteCataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_Reportes_GenerarReporteCataBindingSource;
        private DataSetPrincipal DataSetPrincipal;
        private DataSetPrincipalTableAdapters.sp_Reportes_GenerarReporteCataTableAdapter sp_Reportes_GenerarReporteCataTableAdapter;
        private System.Windows.Forms.TextBox tb_idcata;
    }
}