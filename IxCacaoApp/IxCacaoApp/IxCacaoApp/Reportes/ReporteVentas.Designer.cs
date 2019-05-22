namespace IxCacaoApp
{
    partial class ReporteVentas
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
            this.sp_Reportes_GenerarReporteVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPrincipal = new IxCacaoApp.DataSetPrincipal();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_Reportes_GenerarReporteVentaTableAdapter = new IxCacaoApp.DataSetPrincipalTableAdapters.sp_Reportes_GenerarReporteVentaTableAdapter();
            this.txt_idventa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Reportes_GenerarReporteVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_Reportes_GenerarReporteVentaBindingSource
            // 
            this.sp_Reportes_GenerarReporteVentaBindingSource.DataMember = "sp_Reportes_GenerarReporteVenta";
            this.sp_Reportes_GenerarReporteVentaBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // DataSetPrincipal
            // 
            this.DataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.DataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_Reportes_GenerarReporteVentaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "IxCacaoApp.Reportes.RptReporteVenta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // sp_Reportes_GenerarReporteVentaTableAdapter
            // 
            this.sp_Reportes_GenerarReporteVentaTableAdapter.ClearBeforeFill = true;
            // 
            // txt_idventa
            // 
            this.txt_idventa.Location = new System.Drawing.Point(508, 100);
            this.txt_idventa.Name = "txt_idventa";
            this.txt_idventa.Size = new System.Drawing.Size(100, 20);
            this.txt_idventa.TabIndex = 1;
            this.txt_idventa.Visible = false;
            // 
            // ReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_idventa);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteVentas";
            this.Text = "ReporteVentas";
            this.Load += new System.EventHandler(this.ReporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_Reportes_GenerarReporteVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_Reportes_GenerarReporteVentaBindingSource;
        private DataSetPrincipal DataSetPrincipal;
        private DataSetPrincipalTableAdapters.sp_Reportes_GenerarReporteVentaTableAdapter sp_Reportes_GenerarReporteVentaTableAdapter;
        private System.Windows.Forms.TextBox txt_idventa;
    }
}