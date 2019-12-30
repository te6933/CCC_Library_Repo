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
    public partial class ClientReportForm : Form
    {
        public ClientReportForm()
        {
            InitializeComponent();
        }

        private void ClientReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ClientDataSet.ClientListTable' table. You can move, or remove it, as needed.
            this.ClientListTableTableAdapter.Fill(this.ClientDataSet.ClientListTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
