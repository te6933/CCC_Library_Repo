namespace WindowsFormsApplication1
{
    partial class ClientReportForm
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClientDataSet = new WindowsFormsApplication1.ClientDataSet();
            this.ClientListTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientListTableTableAdapter = new WindowsFormsApplication1.ClientDataSetTableAdapters.ClientListTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientListTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ClientListTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // ClientDataSet
            // 
            this.ClientDataSet.DataSetName = "ClientDataSet";
            this.ClientDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ClientListTableBindingSource
            // 
            this.ClientListTableBindingSource.DataMember = "ClientListTable";
            this.ClientListTableBindingSource.DataSource = this.ClientDataSet;
            // 
            // ClientListTableTableAdapter
            // 
            this.ClientListTableTableAdapter.ClearBeforeFill = true;
            // 
            // ClientReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ClientReportForm";
            this.Text = "ClientReportForm";
            this.Load += new System.EventHandler(this.ClientReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientListTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ClientListTableBindingSource;
        private ClientDataSet ClientDataSet;
        private ClientDataSetTableAdapters.ClientListTableTableAdapter ClientListTableTableAdapter;
    }
}