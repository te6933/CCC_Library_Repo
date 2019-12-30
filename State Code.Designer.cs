namespace WindowsFormsApplication1
{
    partial class State_Code
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
            this.cbStateLookup = new System.Windows.Forms.ComboBox();
            this.stateCodeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamLibraryDatabaseDataSet3 = new WindowsFormsApplication1.TeamLibraryDatabaseDataSet3();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStateCode = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.stateCodeTableTableAdapter = new WindowsFormsApplication1.TeamLibraryDatabaseDataSet3TableAdapters.StateCodeTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.stateCodeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryDatabaseDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(124, 147);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(120, 17);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "State Description:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(157, 95);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(82, 17);
            this.lblCode.TabIndex = 9;
            this.lblCode.Text = "State Code:";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrevious.Location = new System.Drawing.Point(664, 335);
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
            this.btnSave.Location = new System.Drawing.Point(503, 335);
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
            this.btnDelete.Location = new System.Drawing.Point(337, 335);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 28);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(180, 335);
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
            this.btnClear.Location = new System.Drawing.Point(19, 335);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 28);
            this.btnClear.TabIndex = 55;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbStateLookup
            // 
            this.cbStateLookup.BackColor = System.Drawing.SystemColors.Window;
            this.cbStateLookup.DataSource = this.stateCodeTableBindingSource;
            this.cbStateLookup.DisplayMember = "StateDescription";
            this.cbStateLookup.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cbStateLookup.FormattingEnabled = true;
            this.cbStateLookup.Location = new System.Drawing.Point(278, 37);
            this.cbStateLookup.Margin = new System.Windows.Forms.Padding(4);
            this.cbStateLookup.Name = "cbStateLookup";
            this.cbStateLookup.Size = new System.Drawing.Size(401, 24);
            this.cbStateLookup.TabIndex = 60;
            this.cbStateLookup.ValueMember = "StateCode";
            // 
            // stateCodeTableBindingSource
            // 
            this.stateCodeTableBindingSource.DataMember = "StateCodeTable";
            this.stateCodeTableBindingSource.DataSource = this.teamLibraryDatabaseDataSet3;
            // 
            // teamLibraryDatabaseDataSet3
            // 
            this.teamLibraryDatabaseDataSet3.DataSetName = "TeamLibraryDatabaseDataSet3";
            this.teamLibraryDatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = "State Lookup:";
            // 
            // txtStateCode
            // 
            this.txtStateCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtStateCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateCodeTableBindingSource, "StateCode", true));
            this.txtStateCode.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStateCode.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtStateCode.Location = new System.Drawing.Point(278, 91);
            this.txtStateCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtStateCode.Name = "txtStateCode";
            this.txtStateCode.Size = new System.Drawing.Size(132, 27);
            this.txtStateCode.TabIndex = 63;
            this.txtStateCode.TextChanged += new System.EventHandler(this.txtStateCode_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateCodeTableBindingSource, "StateDescription", true));
            this.txtDescription.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDescription.Location = new System.Drawing.Point(278, 144);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(288, 126);
            this.txtDescription.TabIndex = 64;
            // 
            // stateCodeTableTableAdapter
            // 
            this.stateCodeTableTableAdapter.ClearBeforeFill = true;
            // 
            // State_Code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 438);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtStateCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStateLookup);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCode);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "State_Code";
            this.Text = "State_Code";
            this.Load += new System.EventHandler(this.State_Code_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.stateCodeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryDatabaseDataSet3)).EndInit();
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
        private System.Windows.Forms.ComboBox cbStateLookup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStateCode;
        private System.Windows.Forms.TextBox txtDescription;
        private TeamLibraryDatabaseDataSet3 teamLibraryDatabaseDataSet3;
        private System.Windows.Forms.BindingSource stateCodeTableBindingSource;
        private TeamLibraryDatabaseDataSet3TableAdapters.StateCodeTableTableAdapter stateCodeTableTableAdapter;
    }
}