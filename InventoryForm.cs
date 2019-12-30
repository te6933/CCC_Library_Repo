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
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ItemDataSet.ItemDescriptionTable' table. You can move, or remove it, as needed.
            this.ItemDescriptionTableTableAdapter.Fill(this.ItemDataSet.ItemDescriptionTable);
            // TODO: This line of code loads data into the 'InventoryDataSet.InventoryCheckOut' table. You can move, or remove it, as needed.
            this.InventoryCheckOutTableAdapter.Fill(this.InventoryDataSet.InventoryCheckOut);

            this.reportViewer1.RefreshReport();
        }
    }
}
