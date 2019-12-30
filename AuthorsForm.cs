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
    public partial class AuthorsForm : Form
    {
        public AuthorsForm()
        {
            InitializeComponent();
        }

        private void AuthorsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AuthosDataSet.AuthorsTable' table. You can move, or remove it, as needed.
            this.AuthorsTableTableAdapter.Fill(this.AuthosDataSet.AuthorsTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
