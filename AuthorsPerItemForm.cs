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
    public partial class AuthorsPerItemForm : Form
    {
        public AuthorsPerItemForm()
        {
            InitializeComponent();
        }

        private void AuthorsPerItemForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'APIDataSet.AuthorsPerItemTable' table. You can move, or remove it, as needed.
            this.AuthorsPerItemTableTableAdapter.Fill(this.APIDataSet.AuthorsPerItemTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
