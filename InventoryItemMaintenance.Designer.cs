namespace WindowsFormsApplication1
{
    partial class InventoryItemMaintenance
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
            this.lblSerial = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPurchPrice = new System.Windows.Forms.Label();
            this.lblPurchDate = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPub = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCond = new System.Windows.Forms.Label();
            this.lblLease = new System.Windows.Forms.Label();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCopy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbInvLookup = new System.Windows.Forms.ComboBox();
            this.itemDescriptionTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.teamLibraryInvItemDataSet1 = new WindowsFormsApplication1.TeamLibraryInvItemDataSet();
            this.itemDescriptionTableTableAdapter = new WindowsFormsApplication1.TeamLibraryInvItemDataSetTableAdapters.ItemDescriptionTableTableAdapter();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.txtCopyNum = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.statusCodeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamLibraryStatCodeDataSet = new WindowsFormsApplication1.TeamLibraryStatCodeDataSet();
            this.statusCodeTableTableAdapter = new WindowsFormsApplication1.TeamLibraryStatCodeDataSetTableAdapters.StatusCodeTableTableAdapter();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.productTypeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamLibraryProductTypeDataSet = new WindowsFormsApplication1.TeamLibraryProductTypeDataSet();
            this.productTypeTableTableAdapter = new WindowsFormsApplication1.TeamLibraryProductTypeDataSetTableAdapters.ProductTypeTableTableAdapter();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.cbCond = new System.Windows.Forms.ComboBox();
            this.generalConditionTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamLibraryConditionDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamLibraryConditionDatabaseDataSet = new WindowsFormsApplication1.TeamLibraryConditionDatabaseDataSet();
            this.generalConditionTableTableAdapter = new WindowsFormsApplication1.TeamLibraryConditionDatabaseDataSetTableAdapters.GeneralConditionTableTableAdapter();
            this.txtProdTitle = new System.Windows.Forms.TextBox();
            this.txtPub = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtCopyright = new System.Windows.Forms.TextBox();
            this.txtPurchDate = new System.Windows.Forms.TextBox();
            this.txtPurchPrice = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemDescriptionTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryInvItemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusCodeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryStatCodeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryProductTypeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalConditionTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryConditionDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryConditionDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Location = new System.Drawing.Point(68, 70);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(50, 13);
            this.lblSerial.TabIndex = 0;
            this.lblSerial.Text = "Serial ID:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(425, 70);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status:";
            // 
            // lblPurchPrice
            // 
            this.lblPurchPrice.AutoSize = true;
            this.lblPurchPrice.Location = new System.Drawing.Point(428, 314);
            this.lblPurchPrice.Name = "lblPurchPrice";
            this.lblPurchPrice.Size = new System.Drawing.Size(82, 13);
            this.lblPurchPrice.TabIndex = 2;
            this.lblPurchPrice.Text = "Purchase Price:";
            // 
            // lblPurchDate
            // 
            this.lblPurchDate.AutoSize = true;
            this.lblPurchDate.Location = new System.Drawing.Point(242, 314);
            this.lblPurchDate.Name = "lblPurchDate";
            this.lblPurchDate.Size = new System.Drawing.Size(81, 13);
            this.lblPurchDate.TabIndex = 3;
            this.lblPurchDate.Text = "Purchase Date:";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(37, 314);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(80, 13);
            this.lblCopyright.TabIndex = 4;
            this.lblCopyright.Text = "Copyright Date:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(54, 228);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(63, 13);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "Description:";
            // 
            // lblPub
            // 
            this.lblPub.AutoSize = true;
            this.lblPub.Location = new System.Drawing.Point(63, 193);
            this.lblPub.Name = "lblPub";
            this.lblPub.Size = new System.Drawing.Size(53, 13);
            this.lblPub.TabIndex = 6;
            this.lblPub.Text = "Publisher:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(47, 158);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(70, 13);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Product Title:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(44, 117);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(74, 13);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Product Type:";
            // 
            // lblCond
            // 
            this.lblCond.AutoSize = true;
            this.lblCond.Location = new System.Drawing.Point(411, 118);
            this.lblCond.Name = "lblCond";
            this.lblCond.Size = new System.Drawing.Size(54, 13);
            this.lblCond.TabIndex = 9;
            this.lblCond.Text = "Condition:";
            // 
            // lblLease
            // 
            this.lblLease.AutoSize = true;
            this.lblLease.Location = new System.Drawing.Point(252, 124);
            this.lblLease.Name = "lblLease";
            this.lblLease.Size = new System.Drawing.Size(72, 13);
            this.lblLease.TabIndex = 10;
            this.lblLease.Text = "Lease Period:";
            // 
            // btnAuthor
            // 
            this.btnAuthor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAuthor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAuthor.Location = new System.Drawing.Point(71, 353);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(92, 23);
            this.btnAuthor.TabIndex = 27;
            this.btnAuthor.Text = "Set Author(s)";
            this.btnAuthor.UseVisualStyleBackColor = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrevious.Location = new System.Drawing.Point(530, 406);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(112, 23);
            this.btnPrevious.TabIndex = 54;
            this.btnPrevious.Text = "Previous Screen";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(409, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 23);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(288, 406);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 23);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(167, 406);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 23);
            this.btnAdd.TabIndex = 51;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Location = new System.Drawing.Point(46, 406);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 23);
            this.btnClear.TabIndex = 50;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCopy
            // 
            this.lblCopy.AutoSize = true;
            this.lblCopy.Location = new System.Drawing.Point(260, 70);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(41, 13);
            this.lblCopy.TabIndex = 55;
            this.lblCopy.Text = "Copy #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Item Lookup:";
            // 
            // cbInvLookup
            // 
            this.cbInvLookup.DataSource = this.itemDescriptionTableBindingSource1;
            this.cbInvLookup.DisplayMember = "DispFld";
            this.cbInvLookup.FormattingEnabled = true;
            this.cbInvLookup.Location = new System.Drawing.Point(140, 28);
            this.cbInvLookup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbInvLookup.Name = "cbInvLookup";
            this.cbInvLookup.Size = new System.Drawing.Size(461, 21);
            this.cbInvLookup.TabIndex = 58;
            this.cbInvLookup.ValueMember = "ValFld";
            // 
            // itemDescriptionTableBindingSource1
            // 
            this.itemDescriptionTableBindingSource1.DataMember = "ItemDescriptionTable";
            this.itemDescriptionTableBindingSource1.DataSource = this.teamLibraryInvItemDataSet1;
            // 
            // teamLibraryInvItemDataSet1
            // 
            this.teamLibraryInvItemDataSet1.DataSetName = "TeamLibraryInvItemDataSet";
            this.teamLibraryInvItemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemDescriptionTableTableAdapter
            // 
            this.itemDescriptionTableTableAdapter.ClearBeforeFill = true;
            // 
            // txtItemID
            // 
            this.txtItemID.BackColor = System.Drawing.SystemColors.Window;
            this.txtItemID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemDescriptionTableBindingSource1, "SerialId", true));
            this.txtItemID.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemID.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtItemID.Location = new System.Drawing.Point(140, 66);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(100, 23);
            this.txtItemID.TabIndex = 60;
            // 
            // txtCopyNum
            // 
            this.txtCopyNum.BackColor = System.Drawing.SystemColors.Window;
            this.txtCopyNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemDescriptionTableBindingSource1, "CopyNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
            this.txtCopyNum.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCopyNum.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtCopyNum.Location = new System.Drawing.Point(322, 66);
            this.txtCopyNum.Name = "txtCopyNum";
            this.txtCopyNum.Size = new System.Drawing.Size(70, 23);
            this.txtCopyNum.TabIndex = 61;
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.SystemColors.Window;
            this.cbStatus.DataSource = this.statusCodeTableBindingSource;
            this.cbStatus.DisplayMember = "StatusDescription";
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(480, 67);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStatus.TabIndex = 62;
            this.cbStatus.ValueMember = "CurrentStatusCode";
            // 
            // statusCodeTableBindingSource
            // 
            this.statusCodeTableBindingSource.DataMember = "StatusCodeTable";
            this.statusCodeTableBindingSource.DataSource = this.teamLibraryStatCodeDataSet;
            // 
            // teamLibraryStatCodeDataSet
            // 
            this.teamLibraryStatCodeDataSet.DataSetName = "TeamLibraryStatCodeDataSet";
            this.teamLibraryStatCodeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusCodeTableTableAdapter
            // 
            this.statusCodeTableTableAdapter.ClearBeforeFill = true;
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.SystemColors.Window;
            this.cbType.DataSource = this.productTypeTableBindingSource;
            this.cbType.DisplayMember = "ProductTypeDescription";
            this.cbType.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(140, 115);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(106, 21);
            this.cbType.TabIndex = 63;
            this.cbType.ValueMember = "ProductTypeCode";
            // 
            // productTypeTableBindingSource
            // 
            this.productTypeTableBindingSource.DataMember = "ProductTypeTable";
            this.productTypeTableBindingSource.DataSource = this.teamLibraryProductTypeDataSet;
            // 
            // teamLibraryProductTypeDataSet
            // 
            this.teamLibraryProductTypeDataSet.DataSetName = "TeamLibraryProductTypeDataSet";
            this.teamLibraryProductTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTypeTableTableAdapter
            // 
            this.productTypeTableTableAdapter.ClearBeforeFill = true;
            // 
            // txtDays
            // 
            this.txtDays.BackColor = System.Drawing.SystemColors.Window;
            this.txtDays.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemDescriptionTableBindingSource1, "LeasePeriod", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
            this.txtDays.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDays.Location = new System.Drawing.Point(330, 118);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(58, 20);
            this.txtDays.TabIndex = 64;
            // 
            // cbCond
            // 
            this.cbCond.BackColor = System.Drawing.SystemColors.Window;
            this.cbCond.DataSource = this.generalConditionTableBindingSource;
            this.cbCond.DisplayMember = "ConditionDescription";
            this.cbCond.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cbCond.FormattingEnabled = true;
            this.cbCond.Location = new System.Drawing.Point(480, 115);
            this.cbCond.Name = "cbCond";
            this.cbCond.Size = new System.Drawing.Size(121, 21);
            this.cbCond.TabIndex = 65;
            this.cbCond.ValueMember = "GeneralConditionCode";
            // 
            // generalConditionTableBindingSource
            // 
            this.generalConditionTableBindingSource.DataMember = "GeneralConditionTable";
            this.generalConditionTableBindingSource.DataSource = this.teamLibraryConditionDatabaseDataSetBindingSource;
            // 
            // teamLibraryConditionDatabaseDataSetBindingSource
            // 
            this.teamLibraryConditionDatabaseDataSetBindingSource.DataSource = this.teamLibraryConditionDatabaseDataSet;
            this.teamLibraryConditionDatabaseDataSetBindingSource.Position = 0;
            // 
            // teamLibraryConditionDatabaseDataSet
            // 
            this.teamLibraryConditionDatabaseDataSet.DataSetName = "TeamLibraryConditionDatabaseDataSet";
            this.teamLibraryConditionDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generalConditionTableTableAdapter
            // 
            this.generalConditionTableTableAdapter.ClearBeforeFill = true;
            // 
            // txtProdTitle
            // 
            this.txtProdTitle.BackColor = System.Drawing.SystemColors.Window;
            this.txtProdTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemDescriptionTableBindingSource1, "ProductTitle", true));
            this.txtProdTitle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtProdTitle.Location = new System.Drawing.Point(140, 156);
            this.txtProdTitle.Name = "txtProdTitle";
            this.txtProdTitle.Size = new System.Drawing.Size(461, 20);
            this.txtProdTitle.TabIndex = 66;
            // 
            // txtPub
            // 
            this.txtPub.BackColor = System.Drawing.SystemColors.Window;
            this.txtPub.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemDescriptionTableBindingSource1, "Publisher", true));
            this.txtPub.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtPub.Location = new System.Drawing.Point(140, 191);
            this.txtPub.Name = "txtPub";
            this.txtPub.Size = new System.Drawing.Size(461, 20);
            this.txtPub.TabIndex = 67;
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.SystemColors.Window;
            this.txtDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemDescriptionTableBindingSource1, "BriefDescription", true));
            this.txtDesc.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDesc.Location = new System.Drawing.Point(140, 226);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(461, 73);
            this.txtDesc.TabIndex = 68;
            // 
            // txtCopyright
            // 
            this.txtCopyright.BackColor = System.Drawing.SystemColors.Window;
            this.txtCopyright.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemDescriptionTableBindingSource1, "CopyrightDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "01/01/2000", "d"));
            this.txtCopyright.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtCopyright.Location = new System.Drawing.Point(140, 314);
            this.txtCopyright.Name = "txtCopyright";
            this.txtCopyright.Size = new System.Drawing.Size(84, 20);
            this.txtCopyright.TabIndex = 69;
            // 
            // txtPurchDate
            // 
            this.txtPurchDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtPurchDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemDescriptionTableBindingSource1, "PurchaseDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "01/01/2000", "d"));
            this.txtPurchDate.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtPurchDate.Location = new System.Drawing.Point(328, 314);
            this.txtPurchDate.Name = "txtPurchDate";
            this.txtPurchDate.Size = new System.Drawing.Size(83, 20);
            this.txtPurchDate.TabIndex = 70;
            // 
            // txtPurchPrice
            // 
            this.txtPurchPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtPurchPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemDescriptionTableBindingSource1, "PurchasePrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"));
            this.txtPurchPrice.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtPurchPrice.Location = new System.Drawing.Point(515, 314);
            this.txtPurchPrice.Name = "txtPurchPrice";
            this.txtPurchPrice.Size = new System.Drawing.Size(85, 20);
            this.txtPurchPrice.TabIndex = 71;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.SystemColors.Window;
            this.txtAuthor.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtAuthor.Location = new System.Drawing.Point(201, 354);
            this.txtAuthor.Multiline = true;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(264, 20);
            this.txtAuthor.TabIndex = 72;
            // 
            // InventoryItemMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 448);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtPurchPrice);
            this.Controls.Add(this.txtPurchDate);
            this.Controls.Add(this.txtCopyright);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtPub);
            this.Controls.Add(this.txtProdTitle);
            this.Controls.Add(this.cbCond);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.txtCopyNum);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbInvLookup);
            this.Controls.Add(this.lblCopy);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAuthor);
            this.Controls.Add(this.lblLease);
            this.Controls.Add(this.lblCond);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPub);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblPurchDate);
            this.Controls.Add(this.lblPurchPrice);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblSerial);
            this.Name = "InventoryItemMaintenance";
            this.Text = "InventoryItemMaintenance";
            this.Load += new System.EventHandler(this.InventoryItemMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemDescriptionTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryInvItemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusCodeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryStatCodeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryProductTypeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalConditionTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryConditionDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryConditionDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPurchPrice;
        private System.Windows.Forms.Label lblPurchDate;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblPub;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCond;
        private System.Windows.Forms.Label lblLease;
        private System.Windows.Forms.Button btnAuthor;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCopy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbInvLookup;
        private TeamLibraryInvItemDataSetTableAdapters.ItemDescriptionTableTableAdapter itemDescriptionTableTableAdapter;
        private TeamLibraryInvItemDataSet teamLibraryInvItemDataSet1;
        private System.Windows.Forms.BindingSource itemDescriptionTableBindingSource1;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.TextBox txtCopyNum;
        private System.Windows.Forms.ComboBox cbStatus;
        private TeamLibraryStatCodeDataSet teamLibraryStatCodeDataSet;
        private System.Windows.Forms.BindingSource statusCodeTableBindingSource;
        private TeamLibraryStatCodeDataSetTableAdapters.StatusCodeTableTableAdapter statusCodeTableTableAdapter;
        private System.Windows.Forms.ComboBox cbType;
        private TeamLibraryProductTypeDataSet teamLibraryProductTypeDataSet;
        private System.Windows.Forms.BindingSource productTypeTableBindingSource;
        private TeamLibraryProductTypeDataSetTableAdapters.ProductTypeTableTableAdapter productTypeTableTableAdapter;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.ComboBox cbCond;
        private System.Windows.Forms.BindingSource teamLibraryConditionDatabaseDataSetBindingSource;
        private TeamLibraryConditionDatabaseDataSet teamLibraryConditionDatabaseDataSet;
        private System.Windows.Forms.BindingSource generalConditionTableBindingSource;
        private TeamLibraryConditionDatabaseDataSetTableAdapters.GeneralConditionTableTableAdapter generalConditionTableTableAdapter;
        private System.Windows.Forms.TextBox txtProdTitle;
        private System.Windows.Forms.TextBox txtPub;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtCopyright;
        private System.Windows.Forms.TextBox txtPurchDate;
        private System.Windows.Forms.TextBox txtPurchPrice;
        private System.Windows.Forms.TextBox txtAuthor;
    }
}