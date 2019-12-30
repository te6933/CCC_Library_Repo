namespace WindowsFormsApplication1
{
    partial class ReportsForm
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
            this.btnClient = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            this.btnAuthorPerItem = new System.Windows.Forms.Button();
            this.btnCondition = new System.Windows.Forms.Button();
            this.btnState = new System.Windows.Forms.Button();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnType = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnPrevScrn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClient.Location = new System.Drawing.Point(123, 63);
            this.btnClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(152, 44);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "Client List ";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Location = new System.Drawing.Point(123, 139);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(4);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(152, 41);
            this.btnInventory.TabIndex = 1;
            this.btnInventory.Text = "Inventory List";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Location = new System.Drawing.Point(401, 62);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(152, 46);
            this.btnEmployee.TabIndex = 4;
            this.btnEmployee.Text = "Employee List";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnItem
            // 
            this.btnItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItem.Location = new System.Drawing.Point(401, 139);
            this.btnItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(152, 41);
            this.btnItem.TabIndex = 5;
            this.btnItem.Text = "Item List";
            this.btnItem.UseVisualStyleBackColor = false;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnAuthorPerItem
            // 
            this.btnAuthorPerItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAuthorPerItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthorPerItem.Location = new System.Drawing.Point(123, 212);
            this.btnAuthorPerItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAuthorPerItem.Name = "btnAuthorPerItem";
            this.btnAuthorPerItem.Size = new System.Drawing.Size(152, 41);
            this.btnAuthorPerItem.TabIndex = 12;
            this.btnAuthorPerItem.Text = "Authors Per Item";
            this.btnAuthorPerItem.UseVisualStyleBackColor = false;
            this.btnAuthorPerItem.Click += new System.EventHandler(this.btnAuthorPerItem_Click);
            // 
            // btnCondition
            // 
            this.btnCondition.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCondition.Location = new System.Drawing.Point(123, 284);
            this.btnCondition.Margin = new System.Windows.Forms.Padding(4);
            this.btnCondition.Name = "btnCondition";
            this.btnCondition.Size = new System.Drawing.Size(152, 41);
            this.btnCondition.TabIndex = 13;
            this.btnCondition.Text = "Condition List";
            this.btnCondition.UseVisualStyleBackColor = false;
            this.btnCondition.Click += new System.EventHandler(this.btnCondition_Click);
            // 
            // btnState
            // 
            this.btnState.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnState.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnState.Location = new System.Drawing.Point(123, 357);
            this.btnState.Margin = new System.Windows.Forms.Padding(4);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(152, 41);
            this.btnState.TabIndex = 14;
            this.btnState.Text = "State List";
            this.btnState.UseVisualStyleBackColor = false;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // btnAuthor
            // 
            this.btnAuthor.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthor.Location = new System.Drawing.Point(401, 212);
            this.btnAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(152, 41);
            this.btnAuthor.TabIndex = 15;
            this.btnAuthor.Text = "Authors List";
            this.btnAuthor.UseVisualStyleBackColor = false;
            this.btnAuthor.Click += new System.EventHandler(this.btnAuthor_Click);
            // 
            // btnType
            // 
            this.btnType.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnType.Location = new System.Drawing.Point(401, 284);
            this.btnType.Margin = new System.Windows.Forms.Padding(4);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(152, 41);
            this.btnType.TabIndex = 16;
            this.btnType.Text = "Type List";
            this.btnType.UseVisualStyleBackColor = false;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.Location = new System.Drawing.Point(401, 357);
            this.btnStatus.Margin = new System.Windows.Forms.Padding(4);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(152, 41);
            this.btnStatus.TabIndex = 17;
            this.btnStatus.Text = "Status Code";
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnPrevScrn
            // 
            this.btnPrevScrn.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPrevScrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevScrn.Location = new System.Drawing.Point(263, 444);
            this.btnPrevScrn.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevScrn.Name = "btnPrevScrn";
            this.btnPrevScrn.Size = new System.Drawing.Size(152, 41);
            this.btnPrevScrn.TabIndex = 18;
            this.btnPrevScrn.Text = "Previous Screen";
            this.btnPrevScrn.UseVisualStyleBackColor = false;
            this.btnPrevScrn.Click += new System.EventHandler(this.btnPrevScrn_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 529);
            this.Controls.Add(this.btnPrevScrn);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnType);
            this.Controls.Add(this.btnAuthor);
            this.Controls.Add(this.btnState);
            this.Controls.Add(this.btnCondition);
            this.Controls.Add(this.btnAuthorPerItem);
            this.Controls.Add(this.btnItem);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnClient);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btnAuthorPerItem;
        private System.Windows.Forms.Button btnCondition;
        private System.Windows.Forms.Button btnState;
        private System.Windows.Forms.Button btnAuthor;
        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnPrevScrn;
    }
}