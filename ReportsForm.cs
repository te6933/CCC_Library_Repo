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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            ClientReportForm clientReport = new ClientReportForm();
            clientReport.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm empForm = new EmployeeForm();
            empForm.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventoryForm invForm = new InventoryForm();
            invForm.Show();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            ItemForm itmForm = new ItemForm();
            itmForm.Show();
        }

        private void btnAuthorPerItem_Click(object sender, EventArgs e)
        {
            AuthorsPerItemForm apiForm = new AuthorsPerItemForm();
            apiForm.Show();

        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            AuthorsForm authorForm = new AuthorsForm();
            authorForm.Show();
        }

        private void btnCondition_Click(object sender, EventArgs e)
        {
            ConditionForm condForm = new ConditionForm();
            condForm.Show();

        }

        private void btnType_Click(object sender, EventArgs e)
        {
            TypeForm typeForm = new TypeForm();
            typeForm.Show();
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            StateForm stateForm = new StateForm();
            stateForm.Show();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            StatusForm statusForm = new StatusForm();
            statusForm.Show();
        }

        private void btnPrevScrn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
