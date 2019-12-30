namespace WindowsFormsApplication1
{
    partial class StatusCode
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbStatusLookup = new System.Windows.Forms.ComboBox();
            this.statusCodeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamLibraryStatusDatabaseDataSet = new WindowsFormsApplication1.TeamLibraryStatusDatabaseDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatusCode = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.statusCodeTableTableAdapter = new WindowsFormsApplication1.TeamLibraryStatusDatabaseDataSetTableAdapters.StatusCodeTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.statusCodeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryStatusDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(128, 149);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(127, 17);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Status Description:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(162, 98);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(89, 17);
            this.lblCode.TabIndex = 9;
            this.lblCode.Text = "Status Code:";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrevious.Location = new System.Drawing.Point(657, 348);
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
            this.btnSave.Location = new System.Drawing.Point(496, 348);
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
            this.btnDelete.Location = new System.Drawing.Point(335, 348);
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
            this.btnAdd.Location = new System.Drawing.Point(173, 348);
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
            this.btnClear.Location = new System.Drawing.Point(12, 348);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 28);
            this.btnClear.TabIndex = 55;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbStatusLookup
            // 
            this.cbStatusLookup.BackColor = System.Drawing.SystemColors.Window;
            this.cbStatusLookup.DataSource = this.statusCodeTableBindingSource;
            this.cbStatusLookup.DisplayMember = "StatusDescription";
            this.cbStatusLookup.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cbStatusLookup.FormattingEnabled = true;
            this.cbStatusLookup.Location = new System.Drawing.Point(287, 36);
            this.cbStatusLookup.Margin = new System.Windows.Forms.Padding(4);
            this.cbStatusLookup.Name = "cbStatusLookup";
            this.cbStatusLookup.Size = new System.Drawing.Size(408, 24);
            this.cbStatusLookup.TabIndex = 60;
            this.cbStatusLookup.ValueMember = "CurrentStatusCode";
            // 
            // statusCodeTableBindingSource
            // 
            this.statusCodeTableBindingSource.DataMember = "StatusCodeTable";
            this.statusCodeTableBindingSource.DataSource = this.teamLibraryStatusDatabaseDataSet;
            // 
            // teamLibraryStatusDatabaseDataSet
            // 
            this.teamLibraryStatusDatabaseDataSet.DataSetName = "TeamLibraryStatusDatabaseDataSet";
            this.teamLibraryStatusDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = "Status Lookup:";
            // 
            // txtStatusCode
            // 
            this.txtStatusCode.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtStatusCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusCodeTableBindingSource, "CurrentStatusCode", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
            this.txtStatusCode.Enabled = false;
            this.txtStatusCode.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusCode.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtStatusCode.Location = new System.Drawing.Point(287, 95);
            this.txtStatusCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatusCode.Name = "txtStatusCode";
            this.txtStatusCode.Size = new System.Drawing.Size(132, 27);
            this.txtStatusCode.TabIndex = 63;
            this.txtStatusCode.TextChanged += new System.EventHandler(this.txtType_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusCodeTableBindingSource, "StatusDescription", true));
            this.txtDescription.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDescription.Location = new System.Drawing.Point(287, 146);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(288, 126);
            this.txtDescription.TabIndex = 64;
            // 
            // statusCodeTableTableAdapter
            // 
            this.statusCodeTableTableAdapter.ClearBeforeFill = true;
            // 
            // StatusCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 438);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtStatusCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStatusLookup);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCode);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StatusCode";
            this.Text = "StatusCode";
            this.Load += new System.EventHandler(this.StatusCode_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.statusCodeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryStatusDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbStatusLookup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStatusCode;
        private System.Windows.Forms.TextBox txtDescription;
        private TeamLibraryStatusDatabaseDataSet teamLibraryStatusDatabaseDataSet;
        private System.Windows.Forms.BindingSource statusCodeTableBindingSource;
        private TeamLibraryStatusDatabaseDataSetTableAdapters.StatusCodeTableTableAdapter statusCodeTableTableAdapter;
    }
}