namespace WindowsFormsApplication1
{
    partial class GeneralCondition
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.generalConditionTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamLibraryConditionDatabaseDataSet = new WindowsFormsApplication1.TeamLibraryConditionDatabaseDataSet();
            this.txtCondCode = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.generalConditionTableTableAdapter = new WindowsFormsApplication1.TeamLibraryConditionDatabaseDataSetTableAdapters.GeneralConditionTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.generalConditionTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryConditionDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(56, 143);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(201, 17);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "General Condition Description:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(91, 92);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(163, 17);
            this.lblCode.TabIndex = 9;
            this.lblCode.Text = "General Condition Code:";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrevious.Location = new System.Drawing.Point(667, 314);
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
            this.btnSave.Location = new System.Drawing.Point(505, 314);
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
            this.btnDelete.Location = new System.Drawing.Point(344, 314);
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
            this.btnAdd.Location = new System.Drawing.Point(183, 314);
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
            this.btnClear.Location = new System.Drawing.Point(21, 314);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 28);
            this.btnClear.TabIndex = 55;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "Condition Lookup:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.generalConditionTableBindingSource;
            this.comboBox1.DisplayMember = "ConditionDescription";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(295, 34);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(397, 24);
            this.comboBox1.TabIndex = 62;
            this.comboBox1.ValueMember = "GeneralConditionCode";
            // 
            // generalConditionTableBindingSource
            // 
            this.generalConditionTableBindingSource.DataMember = "GeneralConditionTable";
            this.generalConditionTableBindingSource.DataSource = this.teamLibraryConditionDatabaseDataSet;
            // 
            // teamLibraryConditionDatabaseDataSet
            // 
            this.teamLibraryConditionDatabaseDataSet.DataSetName = "TeamLibraryConditionDatabaseDataSet";
            this.teamLibraryConditionDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCondCode
            // 
            this.txtCondCode.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtCondCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.generalConditionTableBindingSource, "GeneralConditionCode", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.txtCondCode.Enabled = false;
            this.txtCondCode.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondCode.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtCondCode.Location = new System.Drawing.Point(295, 89);
            this.txtCondCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCondCode.Name = "txtCondCode";
            this.txtCondCode.Size = new System.Drawing.Size(160, 27);
            this.txtCondCode.TabIndex = 65;
            this.txtCondCode.TextChanged += new System.EventHandler(this.txtCondCode_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.generalConditionTableBindingSource, "ConditionDescription", true));
            this.txtDescription.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDescription.Location = new System.Drawing.Point(295, 140);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(288, 126);
            this.txtDescription.TabIndex = 64;
            // 
            // generalConditionTableTableAdapter
            // 
            this.generalConditionTableTableAdapter.ClearBeforeFill = true;
            // 
            // GeneralCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 410);
            this.Controls.Add(this.txtCondCode);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCode);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GeneralCondition";
            this.Text = "GeneralCondition";
            this.Load += new System.EventHandler(this.GeneralCondition_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.generalConditionTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamLibraryConditionDatabaseDataSet)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtCondCode;
        private System.Windows.Forms.TextBox txtDescription;
        private TeamLibraryConditionDatabaseDataSet teamLibraryConditionDatabaseDataSet;
        private System.Windows.Forms.BindingSource generalConditionTableBindingSource;
        private TeamLibraryConditionDatabaseDataSetTableAdapters.GeneralConditionTableTableAdapter generalConditionTableTableAdapter;
    }
}