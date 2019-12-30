namespace WindowsFormsApplication1
{
    partial class StateForm
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
            this.StateDataSet = new WindowsFormsApplication1.StateDataSet();
            this.StateCodeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StateCodeTableTableAdapter = new WindowsFormsApplication1.StateDataSetTableAdapters.StateCodeTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StateCodeTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.StateCodeTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report9.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // StateDataSet
            // 
            this.StateDataSet.DataSetName = "StateDataSet";
            this.StateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StateCodeTableBindingSource
            // 
            this.StateCodeTableBindingSource.DataMember = "StateCodeTable";
            this.StateCodeTableBindingSource.DataSource = this.StateDataSet;
            // 
            // StateCodeTableTableAdapter
            // 
            this.StateCodeTableTableAdapter.ClearBeforeFill = true;
            // 
            // StateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "StateForm";
            this.Text = "StateForm";
            this.Load += new System.EventHandler(this.StateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StateCodeTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource StateCodeTableBindingSource;
        private StateDataSet StateDataSet;
        private StateDataSetTableAdapters.StateCodeTableTableAdapter StateCodeTableTableAdapter;
    }
}