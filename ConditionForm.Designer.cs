namespace WindowsFormsApplication1
{
    partial class ConditionForm
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
            this.ConditionDataSet = new WindowsFormsApplication1.ConditionDataSet();
            this.GeneralConditionTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GeneralConditionTableTableAdapter = new WindowsFormsApplication1.ConditionDataSetTableAdapters.GeneralConditionTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ConditionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralConditionTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GeneralConditionTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report7.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // ConditionDataSet
            // 
            this.ConditionDataSet.DataSetName = "ConditionDataSet";
            this.ConditionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GeneralConditionTableBindingSource
            // 
            this.GeneralConditionTableBindingSource.DataMember = "GeneralConditionTable";
            this.GeneralConditionTableBindingSource.DataSource = this.ConditionDataSet;
            // 
            // GeneralConditionTableTableAdapter
            // 
            this.GeneralConditionTableTableAdapter.ClearBeforeFill = true;
            // 
            // ConditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ConditionForm";
            this.Text = "ConditionForm";
            this.Load += new System.EventHandler(this.ConditionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConditionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralConditionTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GeneralConditionTableBindingSource;
        private ConditionDataSet ConditionDataSet;
        private ConditionDataSetTableAdapters.GeneralConditionTableTableAdapter GeneralConditionTableTableAdapter;
    }
}