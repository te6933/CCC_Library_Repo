﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ConditionForm : Form
    {
        public ConditionForm()
        {
            InitializeComponent();
        }

        private void ConditionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ConditionDataSet.GeneralConditionTable' table. You can move, or remove it, as needed.
            this.GeneralConditionTableTableAdapter.Fill(this.ConditionDataSet.GeneralConditionTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
