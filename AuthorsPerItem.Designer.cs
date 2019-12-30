namespace WindowsFormsApplication1
{
    partial class AuthorsPerItem
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
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblAuthorPerItem = new System.Windows.Forms.Label();
            this.lblSerialID = new System.Windows.Forms.Label();
            this.lblProdTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtSerialID = new System.Windows.Forms.TextBox();
            this.txtAuthPerItem = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtCopyNum = new System.Windows.Forms.TextBox();
            this.btnNewAuthor = new System.Windows.Forms.Button();
            this.lblCopy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrevious.Location = new System.Drawing.Point(543, 278);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(112, 23);
            this.btnPrevious.TabIndex = 59;
            this.btnPrevious.Text = "Previous Screen";
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(422, 278);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 23);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(301, 278);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 23);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(180, 278);
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
            this.btnClear.Location = new System.Drawing.Point(59, 278);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 23);
            this.btnClear.TabIndex = 55;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblAuthorPerItem
            // 
            this.lblAuthorPerItem.AutoSize = true;
            this.lblAuthorPerItem.Location = new System.Drawing.Point(85, 58);
            this.lblAuthorPerItem.Name = "lblAuthorPerItem";
            this.lblAuthorPerItem.Size = new System.Drawing.Size(97, 13);
            this.lblAuthorPerItem.TabIndex = 60;
            this.lblAuthorPerItem.Text = "Author Per Item ID:";
            // 
            // lblSerialID
            // 
            this.lblSerialID.AutoSize = true;
            this.lblSerialID.Location = new System.Drawing.Point(132, 96);
            this.lblSerialID.Name = "lblSerialID";
            this.lblSerialID.Size = new System.Drawing.Size(50, 13);
            this.lblSerialID.TabIndex = 61;
            this.lblSerialID.Text = "Serial ID:";
            // 
            // lblProdTitle
            // 
            this.lblProdTitle.AutoSize = true;
            this.lblProdTitle.Location = new System.Drawing.Point(112, 144);
            this.lblProdTitle.Name = "lblProdTitle";
            this.lblProdTitle.Size = new System.Drawing.Size(70, 13);
            this.lblProdTitle.TabIndex = 62;
            this.lblProdTitle.Text = "Product Title:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(141, 203);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblAuthor.TabIndex = 63;
            this.lblAuthor.Text = "Author:";
            // 
            // txtSerialID
            // 
            this.txtSerialID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSerialID.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSerialID.Location = new System.Drawing.Point(210, 96);
            this.txtSerialID.Name = "txtSerialID";
            this.txtSerialID.Size = new System.Drawing.Size(116, 20);
            this.txtSerialID.TabIndex = 65;
            // 
            // txtAuthPerItem
            // 
            this.txtAuthPerItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAuthPerItem.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAuthPerItem.Location = new System.Drawing.Point(210, 51);
            this.txtAuthPerItem.Name = "txtAuthPerItem";
            this.txtAuthPerItem.Size = new System.Drawing.Size(116, 20);
            this.txtAuthPerItem.TabIndex = 66;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAuthor.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAuthor.Location = new System.Drawing.Point(210, 203);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(223, 20);
            this.txtAuthor.TabIndex = 67;
            // 
            // txtProduct
            // 
            this.txtProduct.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtProduct.ForeColor = System.Drawing.SystemColors.Window;
            this.txtProduct.Location = new System.Drawing.Point(210, 144);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(375, 20);
            this.txtProduct.TabIndex = 68;
            // 
            // txtCopyNum
            // 
            this.txtCopyNum.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCopyNum.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCopyNum.Location = new System.Drawing.Point(411, 96);
            this.txtCopyNum.Name = "txtCopyNum";
            this.txtCopyNum.Size = new System.Drawing.Size(100, 20);
            this.txtCopyNum.TabIndex = 70;
            // 
            // btnNewAuthor
            // 
            this.btnNewAuthor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNewAuthor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewAuthor.Location = new System.Drawing.Point(459, 196);
            this.btnNewAuthor.Name = "btnNewAuthor";
            this.btnNewAuthor.Size = new System.Drawing.Size(194, 33);
            this.btnNewAuthor.TabIndex = 71;
            this.btnNewAuthor.Text = "Add new author into Authors Table";
            this.btnNewAuthor.UseVisualStyleBackColor = false;
            // 
            // lblCopy
            // 
            this.lblCopy.AutoSize = true;
            this.lblCopy.Location = new System.Drawing.Point(343, 96);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(41, 13);
            this.lblCopy.TabIndex = 72;
            this.lblCopy.Text = "Copy #";
            // 
            // AuthorsPerItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 347);
            this.Controls.Add(this.lblCopy);
            this.Controls.Add(this.btnNewAuthor);
            this.Controls.Add(this.txtCopyNum);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtAuthPerItem);
            this.Controls.Add(this.txtSerialID);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblProdTitle);
            this.Controls.Add(this.lblSerialID);
            this.Controls.Add(this.lblAuthorPerItem);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Name = "AuthorsPerItem";
            this.Text = "AuthorsPerItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblAuthorPerItem;
        private System.Windows.Forms.Label lblSerialID;
        private System.Windows.Forms.Label lblProdTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtSerialID;
        private System.Windows.Forms.TextBox txtAuthPerItem;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Button btnNewAuthor;
        private System.Windows.Forms.Label lblCopy;
        internal System.Windows.Forms.TextBox txtCopyNum;
    }
}