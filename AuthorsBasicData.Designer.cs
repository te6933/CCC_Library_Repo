namespace WindowsFormsApplication1
{
    partial class AuthorsBasicData
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
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblAuthorID = new System.Windows.Forms.Label();
            this.lblAuthorFirst = new System.Windows.Forms.Label();
            this.lblAuthorLast = new System.Windows.Forms.Label();
            this.txtAuthID = new System.Windows.Forms.TextBox();
            this.authorsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamLibraryAuthorsDataSet = new WindowsFormsApplication1.TeamLibraryAuthorsDataSet();
            this.txtAuthLast = new System.Windows.Forms.TextBox();
            this.txtAuthorFirst = new System.Windows.Forms.TextBox();
            this.cbAuthorLookup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.authorsTableTableAdapter = new WindowsFormsApplication1.TeamLibraryAuthorsDataSetTableAdapters.AuthorsTableTableAdapter();
            this.authorsTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.authorsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryAuthorsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrevious.Location = new System.Drawing.Point(669, 319);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(149, 28);
            this.btnPrevious.TabIndex = 64;
            this.btnPrevious.Text = "Previous Screen";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(508, 319);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 28);
            this.btnSave.TabIndex = 63;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(347, 319);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 28);
            this.btnDelete.TabIndex = 62;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(185, 319);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 28);
            this.btnAdd.TabIndex = 61;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Location = new System.Drawing.Point(24, 319);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 28);
            this.btnClear.TabIndex = 60;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblAuthorID
            // 
            this.lblAuthorID.AutoSize = true;
            this.lblAuthorID.Location = new System.Drawing.Point(206, 93);
            this.lblAuthorID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthorID.Name = "lblAuthorID";
            this.lblAuthorID.Size = new System.Drawing.Size(71, 17);
            this.lblAuthorID.TabIndex = 65;
            this.lblAuthorID.Text = "Author ID:";
            // 
            // lblAuthorFirst
            // 
            this.lblAuthorFirst.AutoSize = true;
            this.lblAuthorFirst.Location = new System.Drawing.Point(141, 157);
            this.lblAuthorFirst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthorFirst.Name = "lblAuthorFirst";
            this.lblAuthorFirst.Size = new System.Drawing.Size(136, 17);
            this.lblAuthorFirst.TabIndex = 66;
            this.lblAuthorFirst.Text = "Author\'s First Name:";
            // 
            // lblAuthorLast
            // 
            this.lblAuthorLast.AutoSize = true;
            this.lblAuthorLast.Location = new System.Drawing.Point(141, 226);
            this.lblAuthorLast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthorLast.Name = "lblAuthorLast";
            this.lblAuthorLast.Size = new System.Drawing.Size(136, 17);
            this.lblAuthorLast.TabIndex = 67;
            this.lblAuthorLast.Text = "Author\'s Last Name:";
            // 
            // txtAuthID
            // 
            this.txtAuthID.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtAuthID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorsTableBindingSource, "AuthorID", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
            this.txtAuthID.Enabled = false;
            this.txtAuthID.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthID.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtAuthID.Location = new System.Drawing.Point(333, 93);
            this.txtAuthID.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthID.Name = "txtAuthID";
            this.txtAuthID.Size = new System.Drawing.Size(132, 27);
            this.txtAuthID.TabIndex = 68;
            this.txtAuthID.TextChanged += new System.EventHandler(this.txtAuthID_TextChanged);
            // 
            // authorsTableBindingSource
            // 
            this.authorsTableBindingSource.DataMember = "AuthorsTable";
            this.authorsTableBindingSource.DataSource = this.teamLibraryAuthorsDataSet;
            // 
            // teamLibraryAuthorsDataSet
            // 
            this.teamLibraryAuthorsDataSet.DataSetName = "TeamLibraryAuthorsDataSet";
            this.teamLibraryAuthorsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtAuthLast
            // 
            this.txtAuthLast.BackColor = System.Drawing.SystemColors.Window;
            this.txtAuthLast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorsTableBindingSource, "AuthorLastName", true));
            this.txtAuthLast.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtAuthLast.Location = new System.Drawing.Point(333, 226);
            this.txtAuthLast.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthLast.Name = "txtAuthLast";
            this.txtAuthLast.Size = new System.Drawing.Size(324, 22);
            this.txtAuthLast.TabIndex = 69;
            // 
            // txtAuthorFirst
            // 
            this.txtAuthorFirst.BackColor = System.Drawing.SystemColors.Window;
            this.txtAuthorFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAuthorFirst.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorsTableBindingSource, "AuthorFirstName", true));
            this.txtAuthorFirst.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtAuthorFirst.Location = new System.Drawing.Point(333, 157);
            this.txtAuthorFirst.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthorFirst.Name = "txtAuthorFirst";
            this.txtAuthorFirst.Size = new System.Drawing.Size(324, 22);
            this.txtAuthorFirst.TabIndex = 70;
            // 
            // cbAuthorLookup
            // 
            this.cbAuthorLookup.DataSource = this.authorsTableBindingSource1;
            this.cbAuthorLookup.DisplayMember = "AuthorLastName";
            this.cbAuthorLookup.FormattingEnabled = true;
            this.cbAuthorLookup.Location = new System.Drawing.Point(333, 35);
            this.cbAuthorLookup.Name = "cbAuthorLookup";
            this.cbAuthorLookup.Size = new System.Drawing.Size(324, 24);
            this.cbAuthorLookup.TabIndex = 71;
            this.cbAuthorLookup.ValueMember = "AuthorID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 72;
            this.label1.Text = "Author Lookup:";
            // 
            // authorsTableTableAdapter
            // 
            this.authorsTableTableAdapter.ClearBeforeFill = true;
            // 
            // authorsTableBindingSource1
            // 
            this.authorsTableBindingSource1.DataMember = "AuthorsTable";
            this.authorsTableBindingSource1.DataSource = this.teamLibraryAuthorsDataSet;
            // 
            // AuthorsBasicData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAuthorLookup);
            this.Controls.Add(this.txtAuthorFirst);
            this.Controls.Add(this.txtAuthLast);
            this.Controls.Add(this.txtAuthID);
            this.Controls.Add(this.lblAuthorLast);
            this.Controls.Add(this.lblAuthorFirst);
            this.Controls.Add(this.lblAuthorID);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AuthorsBasicData";
            this.Text = "AuthorsBasicData";
            this.Load += new System.EventHandler(this.AuthorsBasicData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.authorsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryAuthorsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsTableBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblAuthorID;
        private System.Windows.Forms.Label lblAuthorFirst;
        private System.Windows.Forms.Label lblAuthorLast;
        private System.Windows.Forms.TextBox txtAuthID;
        private System.Windows.Forms.TextBox txtAuthLast;
        private System.Windows.Forms.TextBox txtAuthorFirst;
        private System.Windows.Forms.ComboBox cbAuthorLookup;
        private System.Windows.Forms.Label label1;
        private TeamLibraryAuthorsDataSet teamLibraryAuthorsDataSet;
        private System.Windows.Forms.BindingSource authorsTableBindingSource;
        private TeamLibraryAuthorsDataSetTableAdapters.AuthorsTableTableAdapter authorsTableTableAdapter;
        private System.Windows.Forms.BindingSource authorsTableBindingSource1;
    }
}