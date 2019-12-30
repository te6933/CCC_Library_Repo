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
    public partial class StateForm : Form
    {
        public StateForm()
        {
            InitializeComponent();
        }

        private void StateForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'StateDataSet.StateCodeTable' table. You can move, or remove it, as needed.
            this.StateCodeTableTableAdapter.Fill(this.StateDataSet.StateCodeTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
