using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;

namespace WindowsFormsApplication1
{
    public partial class AuthorsPerItem : Form
    {
        public AuthorsPerItem()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAuthPerItem.Clear();
            txtSerialID.Clear();
            txtCopyNum.Clear();
            txtProduct.Clear();
            txtAuthor.Clear();
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            frmLibraryEntry libEntFrm = new frmLibraryEntry();
            libEntFrm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
