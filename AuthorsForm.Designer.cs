namespace WindowsFormsApplication1
{
    partial class AuthorsForm
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
            this.AuthosDataSet = new WindowsFormsApplication1.AuthosDataSet();
            this.AuthorsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AuthorsTableTableAdapter = new WindowsFormsApplication1.AuthosDataSetTableAdapters.AuthorsTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AuthosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AuthorsTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // AuthosDataSet
            // 
            this.AuthosDataSet.DataSetName = "AuthosDataSet";
            this.AuthosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AuthorsTableBindingSource
            // 
            this.AuthorsTableBindingSource.DataMember = "AuthorsTable";
            this.AuthorsTableBindingSource.DataSource = this.AuthosDataSet;
            // 
            // AuthorsTableTableAdapter
            // 
            this.AuthorsTableTableAdapter.ClearBeforeFill = true;
            // 
            // AuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "AuthorsForm";
            this.Text = "AuthorsForm";
            this.Load += new System.EventHandler(this.AuthorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AuthosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AuthorsTableBindingSource;
        private AuthosDataSet AuthosDataSet;
        private AuthosDataSetTableAdapters.AuthorsTableTableAdapter AuthorsTableTableAdapter;
    }
}