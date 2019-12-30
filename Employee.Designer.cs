namespace WindowsFormsApplication1
{
    partial class Employee
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
            this.txtEmpZip = new System.Windows.Forms.TextBox();
            this.employeeListTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamLibraryEmployeeDataSet = new WindowsFormsApplication1.TeamLibraryEmployeeDataSet();
            this.txtEmpCity = new System.Windows.Forms.TextBox();
            this.txtEmpAdd2 = new System.Windows.Forms.TextBox();
            this.txtEmpSuffix = new System.Windows.Forms.TextBox();
            this.txtEmpLastName = new System.Windows.Forms.TextBox();
            this.txtEmpMI = new System.Windows.Forms.TextBox();
            this.txtEmpFirstName = new System.Windows.Forms.TextBox();
            this.txtEmpDOB = new System.Windows.Forms.TextBox();
            this.txtEmpPhone = new System.Windows.Forms.TextBox();
            this.txtEmpEmail = new System.Windows.Forms.TextBox();
            this.txtEmpAdd1 = new System.Windows.Forms.TextBox();
            this.txtEmpPrefix = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblClientPhone = new System.Windows.Forms.Label();
            this.lblClientDOB = new System.Windows.Forms.Label();
            this.lblClientEmail = new System.Windows.Forms.Label();
            this.lblClientAdd = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbEmployeeLookup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.stateCodeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamLibraryDatabaseDataSet1 = new WindowsFormsApplication1.TeamLibraryDatabaseDataSet1();
            this.employeeListTableTableAdapter = new WindowsFormsApplication1.TeamLibraryEmployeeDataSetTableAdapters.EmployeeListTableTableAdapter();
            this.stateCodeTableTableAdapter = new WindowsFormsApplication1.TeamLibraryDatabaseDataSet1TableAdapters.StateCodeTableTableAdapter();
            this.lblCity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryEmployeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateCodeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmpZip
            // 
            this.txtEmpZip.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmpZip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeListTableBindingSource, "EmployeeZip", true));
            this.txtEmpZip.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtEmpZip.Location = new System.Drawing.Point(410, 201);
            this.txtEmpZip.Name = "txtEmpZip";
            this.txtEmpZip.Size = new System.Drawing.Size(121, 20);
            this.txtEmpZip.TabIndex = 11;
            this.txtEmpZip.Text = "Zip Code";
            // 
            // employeeListTableBindingSource
            // 
            this.employeeListTableBindingSource.DataMember = "EmployeeListTable";
            this.employeeListTableBindingSource.DataSource = this.teamLibraryEmployeeDataSet;
            // 
            // teamLibraryEmployeeDataSet
            // 
            this.teamLibraryEmployeeDataSet.DataSetName = "TeamLibraryEmployeeDataSet";
            this.teamLibraryEmployeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtEmpCity
            // 
            this.txtEmpCity.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmpCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeListTableBindingSource, "EmployeeCity", true));
            this.txtEmpCity.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtEmpCity.Location = new System.Drawing.Point(125, 201);
            this.txtEmpCity.Name = "txtEmpCity";
            this.txtEmpCity.Size = new System.Drawing.Size(150, 20);
            this.txtEmpCity.TabIndex = 9;
            this.txtEmpCity.Text = "City";
            // 
            // txtEmpAdd2
            // 
            this.txtEmpAdd2.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmpAdd2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeListTableBindingSource, "EmployeeAddress2", true));
            this.txtEmpAdd2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtEmpAdd2.Location = new System.Drawing.Point(125, 173);
            this.txtEmpAdd2.Name = "txtEmpAdd2";
            this.txtEmpAdd2.Size = new System.Drawing.Size(330, 20);
            this.txtEmpAdd2.TabIndex = 8;
            this.txtEmpAdd2.Text = "Address 2";
            // 
            // txtEmpSuffix
            // 
            this.txtEmpSuffix.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmpSuffix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeListTableBindingSource, "EmployeeSuffix", true));
            this.txtEmpSuffix.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtEmpSuffix.Location = new System.Drawing.Point(417, 108);
            this.txtEmpSuffix.Name = "txtEmpSuffix";
            this.txtEmpSuffix.Size = new System.Drawing.Size(38, 20);
            this.txtEmpSuffix.TabIndex = 6;
            this.txtEmpSuffix.Text = "Sufx.";
            // 
            // txtEmpLastName
            // 
            this.txtEmpLastName.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmpLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeListTableBindingSource, "EmployeeLastName", true));
            this.txtEmpLastName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtEmpLastName.Location = new System.Drawing.Point(311, 108);
            this.txtEmpLastName.Name = "txtEmpLastName";
            this.txtEmpLastName.Size = new System.Drawing.Size(100, 20);
            this.txtEmpLastName.TabIndex = 5;
            this.txtEmpLastName.Text = "Last Name";
            // 
            // txtEmpMI
            // 
            this.txtEmpMI.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmpMI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeListTableBindingSource, "EmployeeMiddleInitial", true));
            this.txtEmpMI.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtEmpMI.Location = new System.Drawing.Point(269, 108);
            this.txtEmpMI.Name = "txtEmpMI";
            this.txtEmpMI.Size = new System.Drawing.Size(33, 20);
            this.txtEmpMI.TabIndex = 4;
            this.txtEmpMI.Text = "Mi.";
            // 
            // txtEmpFirstName
            // 
            this.txtEmpFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmpFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeListTableBindingSource, "EmployeeFirstName", true));
            this.txtEmpFirstName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtEmpFirstName.Location = new System.Drawing.Point(163, 108);
            this.txtEmpFirstName.Name = "txtEmpFirstName";
            this.txtEmpFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtEmpFirstName.TabIndex = 3;
            this.txtEmpFirstName.Text = "First Name";
            // 
            // txtEmpDOB
            // 
            this.txtEmpDOB.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmpDOB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeListTableBindingSource, "EmployeeDateOfBirth", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.txtEmpDOB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtEmpDOB.Location = new System.Drawing.Point(355, 245);
            this.txtEmpDOB.Name = "txtEmpDOB";
            this.txtEmpDOB.Size = new System.Drawing.Size(100, 20);
            this.txtEmpDOB.TabIndex = 13;
            this.txtEmpDOB.Text = "01/01/2000";
            // 
            // txtEmpPhone
            // 
            this.txtEmpPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmpPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeListTableBindingSource, "EmployeePhoneNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
            this.txtEmpPhone.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtEmpPhone.Location = new System.Drawing.Point(125, 245);
            this.txtEmpPhone.Name = "txtEmpPhone";
            this.txtEmpPhone.Size = new System.Drawing.Size(100, 20);
            this.txtEmpPhone.TabIndex = 12;
            this.txtEmpPhone.Text = "(999) 999-9999";
            // 
            // txtEmpEmail
            // 
            this.txtEmpEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmpEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeListTableBindingSource, "EmployeeEMailAddress", true));
            this.txtEmpEmail.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtEmpEmail.Location = new System.Drawing.Point(125, 300);
            this.txtEmpEmail.Name = "txtEmpEmail";
            this.txtEmpEmail.Size = new System.Drawing.Size(138, 20);
            this.txtEmpEmail.TabIndex = 14;
            this.txtEmpEmail.Text = "name@mail.com";
            // 
            // txtEmpAdd1
            // 
            this.txtEmpAdd1.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmpAdd1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeListTableBindingSource, "EmployeeAddress1", true));
            this.txtEmpAdd1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtEmpAdd1.Location = new System.Drawing.Point(125, 146);
            this.txtEmpAdd1.Name = "txtEmpAdd1";
            this.txtEmpAdd1.Size = new System.Drawing.Size(330, 20);
            this.txtEmpAdd1.TabIndex = 7;
            this.txtEmpAdd1.Text = "Address 1";
            // 
            // txtEmpPrefix
            // 
            this.txtEmpPrefix.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmpPrefix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeListTableBindingSource, "EmployeePrefix", true));
            this.txtEmpPrefix.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtEmpPrefix.Location = new System.Drawing.Point(125, 108);
            this.txtEmpPrefix.Name = "txtEmpPrefix";
            this.txtEmpPrefix.Size = new System.Drawing.Size(32, 20);
            this.txtEmpPrefix.TabIndex = 2;
            this.txtEmpPrefix.Text = "Prfx.";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtEmployeeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeListTableBindingSource, "EmployeeId", true));
            this.txtEmployeeID.Enabled = false;
            this.txtEmployeeID.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtEmployeeID.Location = new System.Drawing.Point(125, 59);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(100, 23);
            this.txtEmployeeID.TabIndex = 31;
            this.txtEmployeeID.Text = "Employee ID";
            this.txtEmployeeID.TextChanged += new System.EventHandler(this.txtEmployeeID_TextChanged);
            // 
            // lblClientPhone
            // 
            this.lblClientPhone.AutoSize = true;
            this.lblClientPhone.Location = new System.Drawing.Point(70, 249);
            this.lblClientPhone.Name = "lblClientPhone";
            this.lblClientPhone.Size = new System.Drawing.Size(41, 13);
            this.lblClientPhone.TabIndex = 30;
            this.lblClientPhone.Text = "Phone:";
            // 
            // lblClientDOB
            // 
            this.lblClientDOB.AutoSize = true;
            this.lblClientDOB.Location = new System.Drawing.Point(266, 249);
            this.lblClientDOB.Name = "lblClientDOB";
            this.lblClientDOB.Size = new System.Drawing.Size(71, 13);
            this.lblClientDOB.TabIndex = 29;
            this.lblClientDOB.Text = "Date Of Birth:";
            // 
            // lblClientEmail
            // 
            this.lblClientEmail.AutoSize = true;
            this.lblClientEmail.Location = new System.Drawing.Point(73, 304);
            this.lblClientEmail.Name = "lblClientEmail";
            this.lblClientEmail.Size = new System.Drawing.Size(38, 13);
            this.lblClientEmail.TabIndex = 28;
            this.lblClientEmail.Text = "E-mail:";
            // 
            // lblClientAdd
            // 
            this.lblClientAdd.AutoSize = true;
            this.lblClientAdd.Location = new System.Drawing.Point(63, 150);
            this.lblClientAdd.Name = "lblClientAdd";
            this.lblClientAdd.Size = new System.Drawing.Size(48, 13);
            this.lblClientAdd.TabIndex = 27;
            this.lblClientAdd.Text = "Address:";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(73, 112);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(38, 13);
            this.lblClientName.TabIndex = 26;
            this.lblClientName.Text = "Name:";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(41, 63);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(70, 13);
            this.lblEmployeeID.TabIndex = 25;
            this.lblEmployeeID.Text = "Employee ID:";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrevious.Location = new System.Drawing.Point(497, 344);
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
            this.btnSave.Location = new System.Drawing.Point(376, 344);
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
            this.btnDelete.Location = new System.Drawing.Point(252, 344);
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
            this.btnAdd.Location = new System.Drawing.Point(134, 344);
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
            this.btnClear.Location = new System.Drawing.Point(13, 344);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 23);
            this.btnClear.TabIndex = 55;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbEmployeeLookup
            // 
            this.cbEmployeeLookup.DataSource = this.employeeListTableBindingSource;
            this.cbEmployeeLookup.DisplayMember = "EmployeeLastName";
            this.cbEmployeeLookup.FormattingEnabled = true;
            this.cbEmployeeLookup.Location = new System.Drawing.Point(125, 20);
            this.cbEmployeeLookup.Name = "cbEmployeeLookup";
            this.cbEmployeeLookup.Size = new System.Drawing.Size(330, 21);
            this.cbEmployeeLookup.TabIndex = 1;
            this.cbEmployeeLookup.ValueMember = "EmployeeId";
            this.cbEmployeeLookup.SelectedIndexChanged += new System.EventHandler(this.cbClientLookup_SelectedIndexChanged);
            this.cbEmployeeLookup.Enter += new System.EventHandler(this.cbClientLookup_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Employee Lookup:";
            // 
            // cbState
            // 
            this.cbState.DataSource = this.stateCodeTableBindingSource;
            this.cbState.DisplayMember = "StateDescription";
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(281, 201);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(121, 21);
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
            // employeeListTableTableAdapter
            // 
            this.employeeListTableTableAdapter.ClearBeforeFill = true;
            // 
            // stateCodeTableTableAdapter
            // 
            this.stateCodeTableTableAdapter.ClearBeforeFill = true;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(83, 205);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 62;
            this.lblCity.Text = "City:";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 414);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEmployeeLookup);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtEmpZip);
            this.Controls.Add(this.txtEmpCity);
            this.Controls.Add(this.txtEmpAdd2);
            this.Controls.Add(this.txtEmpSuffix);
            this.Controls.Add(this.txtEmpLastName);
            this.Controls.Add(this.txtEmpMI);
            this.Controls.Add(this.txtEmpFirstName);
            this.Controls.Add(this.txtEmpDOB);
            this.Controls.Add(this.txtEmpPhone);
            this.Controls.Add(this.txtEmpEmail);
            this.Controls.Add(this.txtEmpAdd1);
            this.Controls.Add(this.txtEmpPrefix);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.lblClientPhone);
            this.Controls.Add(this.lblClientDOB);
            this.Controls.Add(this.lblClientEmail);
            this.Controls.Add(this.lblClientAdd);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.lblEmployeeID);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeListTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryEmployeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateCodeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmpZip;
        private System.Windows.Forms.TextBox txtEmpCity;
        private System.Windows.Forms.TextBox txtEmpAdd2;
        private System.Windows.Forms.TextBox txtEmpSuffix;
        private System.Windows.Forms.TextBox txtEmpLastName;
        private System.Windows.Forms.TextBox txtEmpMI;
        private System.Windows.Forms.TextBox txtEmpFirstName;
        private System.Windows.Forms.TextBox txtEmpDOB;
        private System.Windows.Forms.TextBox txtEmpPhone;
        private System.Windows.Forms.TextBox txtEmpEmail;
        private System.Windows.Forms.TextBox txtEmpAdd1;
        private System.Windows.Forms.TextBox txtEmpPrefix;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblClientPhone;
        private System.Windows.Forms.Label lblClientDOB;
        private System.Windows.Forms.Label lblClientEmail;
        private System.Windows.Forms.Label lblClientAdd;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbEmployeeLookup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbState;
        private TeamLibraryEmployeeDataSet teamLibraryEmployeeDataSet;
        private System.Windows.Forms.BindingSource employeeListTableBindingSource;
        private TeamLibraryEmployeeDataSetTableAdapters.EmployeeListTableTableAdapter employeeListTableTableAdapter;
        private TeamLibraryDatabaseDataSet1 teamLibraryDatabaseDataSet1;
        private System.Windows.Forms.BindingSource stateCodeTableBindingSource;
        private TeamLibraryDatabaseDataSet1TableAdapters.StateCodeTableTableAdapter stateCodeTableTableAdapter;
        private System.Windows.Forms.Label lblCity;
    }
}