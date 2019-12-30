namespace WindowsFormsApplication1
{
    partial class ItemCheckout
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
            this.lblCheckID = new System.Windows.Forms.Label();
            this.lblSerialID = new System.Windows.Forms.Label();
            this.lblCardID = new System.Windows.Forms.Label();
            this.lblCheckoutDate = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.lblRenewalNum = new System.Windows.Forms.Label();
            this.lblDaysLate = new System.Windows.Forms.Label();
            this.lblLateFee = new System.Windows.Forms.Label();
            this.lblAmmPaid = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.txtRenewal = new System.Windows.Forms.TextBox();
            this.txtCheckIn = new System.Windows.Forms.TextBox();
            this.txtCheckOut = new System.Windows.Forms.TextBox();
            this.txtCardID = new System.Windows.Forms.TextBox();
            this.txtSerialID = new System.Windows.Forms.TextBox();
            this.txtDayLate = new System.Windows.Forms.TextBox();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrevious.Location = new System.Drawing.Point(536, 383);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(112, 23);
            this.btnPrevious.TabIndex = 69;
            this.btnPrevious.Text = "Previous Screen";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(415, 383);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 23);
            this.btnSave.TabIndex = 68;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(294, 383);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 23);
            this.btnDelete.TabIndex = 67;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(173, 383);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 23);
            this.btnAdd.TabIndex = 66;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Location = new System.Drawing.Point(52, 383);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 23);
            this.btnClear.TabIndex = 65;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCheckID
            // 
            this.lblCheckID.AutoSize = true;
            this.lblCheckID.Location = new System.Drawing.Point(94, 56);
            this.lblCheckID.Name = "lblCheckID";
            this.lblCheckID.Size = new System.Drawing.Size(70, 13);
            this.lblCheckID.TabIndex = 70;
            this.lblCheckID.Text = "Checkout ID:";
            // 
            // lblSerialID
            // 
            this.lblSerialID.AutoSize = true;
            this.lblSerialID.Location = new System.Drawing.Point(114, 105);
            this.lblSerialID.Name = "lblSerialID";
            this.lblSerialID.Size = new System.Drawing.Size(50, 13);
            this.lblSerialID.TabIndex = 71;
            this.lblSerialID.Text = "Serial ID:";
            // 
            // lblCardID
            // 
            this.lblCardID.AutoSize = true;
            this.lblCardID.Location = new System.Drawing.Point(84, 154);
            this.lblCardID.Name = "lblCardID";
            this.lblCardID.Size = new System.Drawing.Size(80, 13);
            this.lblCardID.TabIndex = 72;
            this.lblCardID.Text = "Library Card ID:";
            // 
            // lblCheckoutDate
            // 
            this.lblCheckoutDate.AutoSize = true;
            this.lblCheckoutDate.Location = new System.Drawing.Point(82, 203);
            this.lblCheckoutDate.Name = "lblCheckoutDate";
            this.lblCheckoutDate.Size = new System.Drawing.Size(82, 13);
            this.lblCheckoutDate.TabIndex = 73;
            this.lblCheckoutDate.Text = "Checkout Date:";
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Location = new System.Drawing.Point(85, 252);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(79, 13);
            this.lblCheckInDate.TabIndex = 74;
            this.lblCheckInDate.Text = "Check In Date:";
            // 
            // lblRenewalNum
            // 
            this.lblRenewalNum.AutoSize = true;
            this.lblRenewalNum.Location = new System.Drawing.Point(304, 257);
            this.lblRenewalNum.Name = "lblRenewalNum";
            this.lblRenewalNum.Size = new System.Drawing.Size(92, 13);
            this.lblRenewalNum.TabIndex = 75;
            this.lblRenewalNum.Text = "Renewal Number:";
            // 
            // lblDaysLate
            // 
            this.lblDaysLate.AutoSize = true;
            this.lblDaysLate.Location = new System.Drawing.Point(338, 288);
            this.lblDaysLate.Name = "lblDaysLate";
            this.lblDaysLate.Size = new System.Drawing.Size(58, 13);
            this.lblDaysLate.TabIndex = 76;
            this.lblDaysLate.Text = "Days Late:";
            // 
            // lblLateFee
            // 
            this.lblLateFee.AutoSize = true;
            this.lblLateFee.Location = new System.Drawing.Point(500, 293);
            this.lblLateFee.Name = "lblLateFee";
            this.lblLateFee.Size = new System.Drawing.Size(52, 13);
            this.lblLateFee.TabIndex = 77;
            this.lblLateFee.Text = "Late Fee:";
            // 
            // lblAmmPaid
            // 
            this.lblAmmPaid.AutoSize = true;
            this.lblAmmPaid.Location = new System.Drawing.Point(474, 331);
            this.lblAmmPaid.Name = "lblAmmPaid";
            this.lblAmmPaid.Size = new System.Drawing.Size(78, 13);
            this.lblAmmPaid.TabIndex = 78;
            this.lblAmmPaid.Text = "Ammount Paid:";
            // 
            // txtItemID
            // 
            this.txtItemID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtItemID.ForeColor = System.Drawing.SystemColors.Window;
            this.txtItemID.Location = new System.Drawing.Point(185, 56);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(134, 20);
            this.txtItemID.TabIndex = 79;
            // 
            // txtRenewal
            // 
            this.txtRenewal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRenewal.ForeColor = System.Drawing.SystemColors.Window;
            this.txtRenewal.Location = new System.Drawing.Point(402, 254);
            this.txtRenewal.Name = "txtRenewal";
            this.txtRenewal.Size = new System.Drawing.Size(42, 20);
            this.txtRenewal.TabIndex = 80;
            // 
            // txtCheckIn
            // 
            this.txtCheckIn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCheckIn.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCheckIn.Location = new System.Drawing.Point(185, 252);
            this.txtCheckIn.Name = "txtCheckIn";
            this.txtCheckIn.Size = new System.Drawing.Size(100, 20);
            this.txtCheckIn.TabIndex = 81;
            // 
            // txtCheckOut
            // 
            this.txtCheckOut.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCheckOut.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCheckOut.Location = new System.Drawing.Point(185, 203);
            this.txtCheckOut.Name = "txtCheckOut";
            this.txtCheckOut.Size = new System.Drawing.Size(100, 20);
            this.txtCheckOut.TabIndex = 82;
            // 
            // txtCardID
            // 
            this.txtCardID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCardID.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCardID.Location = new System.Drawing.Point(185, 154);
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.Size = new System.Drawing.Size(134, 20);
            this.txtCardID.TabIndex = 83;
            // 
            // txtSerialID
            // 
            this.txtSerialID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSerialID.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSerialID.Location = new System.Drawing.Point(185, 105);
            this.txtSerialID.Name = "txtSerialID";
            this.txtSerialID.Size = new System.Drawing.Size(134, 20);
            this.txtSerialID.TabIndex = 84;
            // 
            // txtDayLate
            // 
            this.txtDayLate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDayLate.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDayLate.Location = new System.Drawing.Point(402, 288);
            this.txtDayLate.Name = "txtDayLate";
            this.txtDayLate.Size = new System.Drawing.Size(42, 20);
            this.txtDayLate.TabIndex = 85;
            // 
            // txtPaid
            // 
            this.txtPaid.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPaid.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPaid.Location = new System.Drawing.Point(561, 328);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(76, 20);
            this.txtPaid.TabIndex = 86;
            // 
            // txtFee
            // 
            this.txtFee.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtFee.ForeColor = System.Drawing.SystemColors.Window;
            this.txtFee.Location = new System.Drawing.Point(561, 293);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(76, 20);
            this.txtFee.TabIndex = 87;
            // 
            // ItemCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 446);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.txtDayLate);
            this.Controls.Add(this.txtSerialID);
            this.Controls.Add(this.txtCardID);
            this.Controls.Add(this.txtCheckOut);
            this.Controls.Add(this.txtCheckIn);
            this.Controls.Add(this.txtRenewal);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.lblAmmPaid);
            this.Controls.Add(this.lblLateFee);
            this.Controls.Add(this.lblDaysLate);
            this.Controls.Add(this.lblRenewalNum);
            this.Controls.Add(this.lblCheckInDate);
            this.Controls.Add(this.lblCheckoutDate);
            this.Controls.Add(this.lblCardID);
            this.Controls.Add(this.lblSerialID);
            this.Controls.Add(this.lblCheckID);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Name = "ItemCheckout";
            this.Text = "ItemCheckout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCheckID;
        private System.Windows.Forms.Label lblSerialID;
        private System.Windows.Forms.Label lblCardID;
        private System.Windows.Forms.Label lblCheckoutDate;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.Label lblRenewalNum;
        private System.Windows.Forms.Label lblDaysLate;
        private System.Windows.Forms.Label lblLateFee;
        private System.Windows.Forms.Label lblAmmPaid;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.TextBox txtRenewal;
        private System.Windows.Forms.TextBox txtCheckIn;
        private System.Windows.Forms.TextBox txtCheckOut;
        private System.Windows.Forms.TextBox txtCardID;
        private System.Windows.Forms.TextBox txtSerialID;
        private System.Windows.Forms.TextBox txtDayLate;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.TextBox txtFee;
    }
}