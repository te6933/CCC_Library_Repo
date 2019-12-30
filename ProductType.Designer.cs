namespace WindowsFormsApplication1
{
    partial class ProductType
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
            this.lblType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbProductLookup = new System.Windows.Forms.ComboBox();
            this.productTypeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamLibraryProductTypeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamLibraryProductTypeDataSet = new WindowsFormsApplication1.TeamLibraryProductTypeDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.productTypeTableTableAdapter = new WindowsFormsApplication1.TeamLibraryProductTypeDataSetTableAdapters.ProductTypeTableTableAdapter();
            this.txtDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryProductTypeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryProductTypeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(80, 96);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(134, 17);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Product Type Code:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(80, 147);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(136, 17);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Product Description:";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrevious.Location = new System.Drawing.Point(653, 329);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(149, 28);
            this.btnPrevious.TabIndex = 59;
            this.btnPrevious.Text = "Previous Screen";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(492, 329);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 28);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(331, 329);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 28);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(173, 329);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 28);
            this.btnAdd.TabIndex = 56;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Location = new System.Drawing.Point(8, 329);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 28);
            this.btnClear.TabIndex = 55;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbProductLookup
            // 
            this.cbProductLookup.DataSource = this.productTypeTableBindingSource;
            this.cbProductLookup.DisplayMember = "ProductTypeDescription";
            this.cbProductLookup.FormattingEnabled = true;
            this.cbProductLookup.Location = new System.Drawing.Point(284, 40);
            this.cbProductLookup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProductLookup.Name = "cbProductLookup";
            this.cbProductLookup.Size = new System.Drawing.Size(379, 24);
            this.cbProductLookup.TabIndex = 60;
            this.cbProductLookup.ValueMember = "ProductTypeCode";
            // 
            // productTypeTableBindingSource
            // 
            this.productTypeTableBindingSource.DataMember = "ProductTypeTable";
            this.productTypeTableBindingSource.DataSource = this.teamLibraryProductTypeDataSetBindingSource;
            // 
            // teamLibraryProductTypeDataSetBindingSource
            // 
            this.teamLibraryProductTypeDataSetBindingSource.DataSource = this.teamLibraryProductTypeDataSet;
            this.teamLibraryProductTypeDataSetBindingSource.Position = 0;
            // 
            // teamLibraryProductTypeDataSet
            // 
            this.teamLibraryProductTypeDataSet.DataSetName = "TeamLibraryProductTypeDataSet";
            this.teamLibraryProductTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 61;
            this.label1.Text = "Product Lookup:";
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productTypeTableBindingSource, "ProductTypeCode", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
            this.txtType.Enabled = false;
            this.txtType.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtType.Location = new System.Drawing.Point(284, 91);
            this.txtType.Margin = new System.Windows.Forms.Padding(4);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(247, 27);
            this.txtType.TabIndex = 62;
            // 
            // productTypeTableTableAdapter
            // 
            this.productTypeTableTableAdapter.ClearBeforeFill = true;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productTypeTableBindingSource, "ProductTypeDescription", true));
            this.txtDescription.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDescription.Location = new System.Drawing.Point(284, 144);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(288, 126);
            this.txtDescription.TabIndex = 63;
            // 
            // ProductType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 426);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProductLookup);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblType);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductType";
            this.Text = "ProductType";
            this.Load += new System.EventHandler(this.ProductType_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.productTypeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryProductTypeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryProductTypeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbProductLookup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.BindingSource teamLibraryProductTypeDataSetBindingSource;
        private TeamLibraryProductTypeDataSet teamLibraryProductTypeDataSet;
        private System.Windows.Forms.BindingSource productTypeTableBindingSource;
        private TeamLibraryProductTypeDataSetTableAdapters.ProductTypeTableTableAdapter productTypeTableTableAdapter;
        private System.Windows.Forms.TextBox txtDescription;
    }
}