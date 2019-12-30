namespace WindowsFormsApplication1
{
    partial class EmployeeForm
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
            this.EmployeeDataset = new WindowsFormsApplication1.EmployeeDataset();
            this.EmployeeListTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeListTableTableAdapter = new WindowsFormsApplication1.EmployeeDatasetTableAdapters.EmployeeListTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeListTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EmployeeListTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // EmployeeDataset
            // 
            this.EmployeeDataset.DataSetName = "EmployeeDataset";
            this.EmployeeDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmployeeListTableBindingSource
            // 
            this.EmployeeListTableBindingSource.DataMember = "EmployeeListTable";
            this.EmployeeListTableBindingSource.DataSource = this.EmployeeDataset;
            // 
            // EmployeeListTableTableAdapter
            // 
            this.EmployeeListTableTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeListTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EmployeeListTableBindingSource;
        private EmployeeDataset EmployeeDataset;
        private EmployeeDatasetTableAdapters.EmployeeListTableTableAdapter EmployeeListTableTableAdapter;
    }
}