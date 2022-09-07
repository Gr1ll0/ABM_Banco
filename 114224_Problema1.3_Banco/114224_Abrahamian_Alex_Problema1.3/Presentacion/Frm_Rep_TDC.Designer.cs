namespace _114224_Abrahamian_Alex_Problema1._3.Presentacion
{
    partial class Frm_Rep_TDC
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
            this.paTipoCuentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banco_114224DataSet = new _114224_Abrahamian_Alex_Problema1._3.Banco_114224DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pa_TipoCuentaTableAdapter = new _114224_Abrahamian_Alex_Problema1._3.Banco_114224DataSetTableAdapters.pa_TipoCuentaTableAdapter();
            this.pa_TipoCuentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.paTipoCuentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_114224DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pa_TipoCuentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // paTipoCuentaBindingSource
            // 
            this.paTipoCuentaBindingSource.DataMember = "pa_TipoCuenta";
            this.paTipoCuentaBindingSource.DataSource = this.banco_114224DataSet;
            // 
            // banco_114224DataSet
            // 
            this.banco_114224DataSet.DataSetName = "Banco_114224DataSet";
            this.banco_114224DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.pa_TipoCuentaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "_114224_Abrahamian_Alex_Problema1._3.Presentacion.Reporte.Rpt_TipoDeCuenta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(853, 510);
            this.reportViewer1.TabIndex = 0;
            // 
            // pa_TipoCuentaTableAdapter
            // 
            this.pa_TipoCuentaTableAdapter.ClearBeforeFill = true;
            // 
            // pa_TipoCuentaBindingSource
            // 
            this.pa_TipoCuentaBindingSource.DataMember = "pa_TipoCuenta";
            this.pa_TipoCuentaBindingSource.DataSource = this.banco_114224DataSet;
            // 
            // Frm_Rep_TDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 510);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rep_TDC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Rep_TDC";
            this.Load += new System.EventHandler(this.Frm_Rep_TDC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paTipoCuentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_114224DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pa_TipoCuentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Banco_114224DataSet banco_114224DataSet;
        private System.Windows.Forms.BindingSource paTipoCuentaBindingSource;
        private Banco_114224DataSetTableAdapters.pa_TipoCuentaTableAdapter pa_TipoCuentaTableAdapter;
        private System.Windows.Forms.BindingSource pa_TipoCuentaBindingSource;
    }
}