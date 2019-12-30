using System;
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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'EmployeeDataset.EmployeeListTable' table. You can move, or remove it, as needed.
            this.EmployeeListTableTableAdapter.Fill(this.EmployeeDataset.EmployeeListTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
