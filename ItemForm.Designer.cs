﻿namespace WindowsFormsApplication1
{
    partial class ItemForm
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
            this.ItemDataSet = new WindowsFormsApplication1.ItemDataSet();
            this.ItemDescriptionTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemDescriptionTableTableAdapter = new WindowsFormsApplication1.ItemDataSetTableAdapters.ItemDescriptionTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDescriptionTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ItemDescriptionTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // ItemDataSet
            // 
            this.ItemDataSet.DataSetName = "ItemDataSet";
            this.ItemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ItemDescriptionTableBindingSource
            // 
            this.ItemDescriptionTableBindingSource.DataMember = "ItemDescriptionTable";
            this.ItemDescriptionTableBindingSource.DataSource = this.ItemDataSet;
            // 
            // ItemDescriptionTableTableAdapter
            // 
            this.ItemDescriptionTableTableAdapter.ClearBeforeFill = true;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDescriptionTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ItemDescriptionTableBindingSource;
        private ItemDataSet ItemDataSet;
        private ItemDataSetTableAdapters.ItemDescriptionTableTableAdapter ItemDescriptionTableTableAdapter;
    }
}