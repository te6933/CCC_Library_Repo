namespace WindowsFormsApplication1
{
    partial class Client
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
            this.lblClientID = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblClientAdd = new System.Windows.Forms.Label();
            this.lblClientEmail = new System.Windows.Forms.Label();
            this.lblClientDOB = new System.Windows.Forms.Label();
            this.lblClientPhone = new System.Windows.Forms.Label();
            this.txtCardId = new System.Windows.Forms.TextBox();
            this.clientListTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamLibraryDatabaseDataSet2 = new WindowsFormsApplication1.TeamLibraryDatabaseDataSet2();
            this.txtPrfx = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtDob = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMi = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtSufx = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.stateCodeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamLibraryDatabaseDataSet1 = new WindowsFormsApplication1.TeamLibraryDatabaseDataSet1();
            this.stateCodeTableTableAdapter = new WindowsFormsApplication1.TeamLibraryDatabaseDataSet1TableAdapters.StateCodeTableTableAdapter();
            this.clientListTableTableAdapter = new WindowsFormsApplication1.TeamLibraryDatabaseDataSet2TableAdapters.ClientListTableTableAdapter();
            this.cbClientLookup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCardIssueDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientListTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateCodeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(23, 77);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(80, 13);
            this.lblClientID.TabIndex = 0;
            this.lblClientID.Text = "Library Card ID:";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(65, 119);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(38, 13);
            this.lblClientName.TabIndex = 1;
            this.lblClientName.Text = "Name:";
            // 
            // lblClientAdd
            // 
            this.lblClientAdd.AutoSize = true;
            this.lblClientAdd.Location = new System.Drawing.Point(55, 158);
            this.lblClientAdd.Name = "lblClientAdd";
            this.lblClientAdd.Size = new System.Drawing.Size(48, 13);
            this.lblClientAdd.TabIndex = 2;
            this.lblClientAdd.Text = "Address:";
            // 
            // lblClientEmail
            // 
            this.lblClientEmail.AutoSize = true;
            this.lblClientEmail.Location = new System.Drawing.Point(65, 311);
            this.lblClientEmail.Name = "lblClientEmail";
            this.lblClientEmail.Size = new System.Drawing.Size(38, 13);
            this.lblClientEmail.TabIndex = 3;
            this.lblClientEmail.Text = "E-mail:";
            // 
            // lblClientDOB
            // 
            this.lblClientDOB.AutoSize = true;
            this.lblClientDOB.Location = new System.Drawing.Point(260, 257);
            this.lblClientDOB.Name = "lblClientDOB";
            this.lblClientDOB.Size = new System.Drawing.Size(71, 13);
            this.lblClientDOB.TabIndex = 4;
            this.lblClientDOB.Text = "Date Of Birth:";
            // 
            // lblClientPhone
            // 
            this.lblClientPhone.AutoSize = true;
            this.lblClientPhone.Location = new System.Drawing.Point(65, 257);
            this.lblClientPhone.Name = "lblClientPhone";
            this.lblClientPhone.Size = new System.Drawing.Size(41, 13);
            this.lblClientPhone.TabIndex = 5;
            this.lblClientPhone.Text = "Phone:";
            // 
            // txtCardId
            // 
            this.txtCardId.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtCardId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientListTableBindingSource, "LibraryCardId", true));
            this.txtCardId.Enabled = false;
            this.txtCardId.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardId.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtCardId.Location = new System.Drawing.Point(119, 73);
            this.txtCardId.Name = "txtCardId";
            this.txtCardId.Size = new System.Drawing.Size(100, 23);
            this.txtCardId.TabIndex = 111;
            this.txtCardId.TextChanged += new System.EventHandler(this.txtCardId_TextChanged);
            // 
            // clientListTableBindingSource
            // 
            this.clientListTableBindingSource.DataMember = "ClientListTable";
            this.clientListTableBindingSource.DataSource = this.teamLibraryDatabaseDataSet2;
            // 
            // teamLibraryDatabaseDataSet2
            // 
            this.teamLibraryDatabaseDataSet2.DataSetName = "TeamLibraryDatabaseDataSet2";
            this.teamLibraryDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPrfx
            // 
            this.txtPrfx.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrfx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientListTableBindingSource, "CustomerPrefix", true));
            this.txtPrfx.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtPrfx.Location = new System.Drawing.Point(119, 117);
            this.txtPrfx.Name = "txtPrfx";
            this.txtPrfx.Size = new System.Drawing.Size(32, 20);
            this.txtPrfx.TabIndex = 2;
            // 
            // txtAddress1
            // 
            this.txtAddress1.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientListTableBindingSource, "CustomerAddress1", true));
            this.txtAddress1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtAddress1.Location = new System.Drawing.Point(119, 155);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(330, 20);
            this.txtAddress1.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientListTableBindingSource, "CustomerEMailAddress", true));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtEmail.Location = new System.Drawing.Point(119, 309);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(138, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientListTableBindingSource, "CustomerPhoneNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.txtPhone.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtPhone.Location = new System.Drawing.Point(119, 254);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 12;
            // 
            // txtDob
            // 
            this.txtDob.BackColor = System.Drawing.SystemColors.Window;
            this.txtDob.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientListTableBindingSource, "CustomerDateOfBirth", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.txtDob.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDob.Location = new System.Drawing.Point(349, 254);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(100, 20);
            this.txtDob.TabIndex = 13;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientListTableBindingSource, "CustomerFirstName", true));
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtFirstName.Location = new System.Drawing.Point(157, 117);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtMi
            // 
            this.txtMi.BackColor = System.Drawing.SystemColors.Window;
            this.txtMi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientListTableBindingSource, "CustomerMiddleInitial", true));
            this.txtMi.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtMi.Location = new System.Drawing.Point(263, 117);
            this.txtMi.Name = "txtMi";
            this.txtMi.Size = new System.Drawing.Size(33, 20);
            this.txtMi.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.Window;
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientListTableBindingSource, "CustomerLastName", true));
            this.txtLastName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtLastName.Location = new System.Drawing.Point(305, 117);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // txtSufx
            // 
            this.txtSufx.BackColor = System.Drawing.SystemColors.Window;
            this.txtSufx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientListTableBindingSource, "CustomerSuffix", true));
            this.txtSufx.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtSufx.Location = new System.Drawing.Point(411, 117);
            this.txtSufx.Name = "txtSufx";
            this.txtSufx.Size = new System.Drawing.Size(38, 20);
            this.txtSufx.TabIndex = 6;
            // 
            // txtAddress2
            // 
            this.txtAddress2.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.clientListTableBindingSource, "CustomerAddress2", true));
            this.txtAddress2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtAddress2.Location = new System.Drawing.Point(119, 182);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(330, 20);
            this.txtAddress2.TabIndex = 8;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.SystemColors.Window;
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientListTableBindingSource, "CustomerCity", true));
            this.txtCity.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtCity.Location = new System.Drawing.Point(119, 209);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(138, 20);
            this.txtCity.TabIndex = 9;
            // 
            // txtZip
            // 
            this.txtZip.BackColor = System.Drawing.SystemColors.Window;
            this.txtZip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientListTableBindingSource, "CustomerZip", true));
            this.txtZip.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtZip.Location = new System.Drawing.Point(450, 209);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(56, 20);
            this.txtZip.TabIndex = 11;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrevious.Location = new System.Drawing.Point(502, 357);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(112, 23);
            this.btnPrevious.TabIndex = 59;
            this.btnPrevious.Text = "Previous Screen";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(381, 357);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 23);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(263, 357);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 23);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(139, 357);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 23);
            this.btnAdd.TabIndex = 56;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Location = new System.Drawing.Point(18, 357);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 23);
            this.btnClear.TabIndex = 55;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(76, 211);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 60;
            this.lblCity.Text = "City:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(263, 211);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 61;
            this.lblState.Text = "State:";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(419, 211);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(25, 13);
            this.lblZip.TabIndex = 62;
            this.lblZip.Text = "Zip:";
            // 
            // cbState
            // 
            this.cbState.BackColor = System.Drawing.SystemColors.Window;
            this.cbState.DataSource = this.stateCodeTableBindingSource;
            this.cbState.DisplayMember = "StateDescription";
            this.cbState.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(301, 208);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(112, 21);
            this.cbState.TabIndex = 10;
            this.cbState.ValueMember = "StateCode";
            // 
            // stateCodeTableBindingSource
            // 
            this.stateCodeTableBindingSource.DataMember = "StateCodeTable";
            this.stateCodeTableBindingSource.DataSource = this.teamLibraryDatabaseDataSet1;
            // 
            // teamLibraryDatabaseDataSet1
            // 
            this.teamLibraryDatabaseDataSet1.DataSetName = "TeamLibraryDatabaseDataSet1";
            this.teamLibraryDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stateCodeTableTableAdapter
            // 
            this.stateCodeTableTableAdapter.ClearBeforeFill = true;
            // 
            // clientListTableTableAdapter
            // 
            this.clientListTableTableAdapter.ClearBeforeFill = true;
            // 
            // cbClientLookup
            // 
            this.cbClientLookup.DataBindings.Add(new System.Windows.Forms.Binding("Sorted", this.clientListTableBindingSource, "CustomerLastName", true));
            this.cbClientLookup.DataSource = this.clientListTableBindingSource;
            this.cbClientLookup.DisplayMember = "CustomerLastName";
            this.cbClientLookup.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cbClientLookup.FormattingEnabled = true;
            this.cbClientLookup.Location = new System.Drawing.Point(119, 28);
            this.cbClientLookup.Name = "cbClientLookup";
            this.cbClientLookup.Size = new System.Drawing.Size(426, 21);
            this.cbClientLookup.TabIndex = 1;
            this.cbClientLookup.ValueMember = "LibraryCardId";
            this.cbClientLookup.SelectedIndexChanged += new System.EventHandler(this.cbClientLookup_SelectedIndexChanged);
            this.cbClientLookup.Enter += new System.EventHandler(this.cbClientLookup_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Client Lookup:";
            // 
            // txtCardIssueDate
            // 
            this.txtCardIssueDate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtCardIssueDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientListTableBindingSource, "CardIssueDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.txtCardIssueDate.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtCardIssueDate.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtCardIssueDate.Location = new System.Drawing.Point(341, 73);
            this.txtCardIssueDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtCardIssueDate.Name = "txtCardIssueDate";
            this.txtCardIssueDate.Size = new System.Drawing.Size(103, 23);
            this.txtCardIssueDate.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Active Since:";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 432);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCardIssueDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbClientLookup);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtSufx);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMi);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtDob);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.txtPrfx);
            this.Controls.Add(this.txtCardId);
            this.Controls.Add(this.lblClientPhone);
            this.Controls.Add(this.lblClientDOB);
            this.Controls.Add(this.lblClientEmail);
            this.Controls.Add(this.lblClientAdd);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.lblClientID);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientListTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateCodeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblClientAdd;
        private System.Windows.Forms.Label lblClientEmail;
        private System.Windows.Forms.Label lblClientDOB;
        private System.Windows.Forms.Label lblClientPhone;
        private System.Windows.Forms.TextBox txtCardId;
        private System.Windows.Forms.TextBox txtPrfx;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtDob;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMi;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtSufx;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.ComboBox cbState;
        private TeamLibraryDatabaseDataSet1 teamLibraryDatabaseDataSet1;
        private System.Windows.Forms.BindingSource stateCodeTableBindingSource;
        private TeamLibraryDatabaseDataSet1TableAdapters.StateCodeTableTableAdapter stateCodeTableTableAdapter;
        private TeamLibraryDatabaseDataSet2 teamLibraryDatabaseDataSet2;
        private System.Windows.Forms.BindingSource clientListTableBindingSource;
        private TeamLibraryDatabaseDataSet2TableAdapters.ClientListTableTableAdapter clientListTableTableAdapter;
        private System.Windows.Forms.ComboBox cbClientLookup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCardIssueDate;
        private System.Windows.Forms.Label label2;
    }
}