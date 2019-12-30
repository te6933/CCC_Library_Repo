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
    public partial class ItemCheckout : Form
    {
        public ItemCheckout()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCardID.Clear();
            txtCheckIn.Clear();
            txtCheckOut.Clear();
            txtDayLate.Clear();
            txtFee.Clear();
            txtItemID.Clear();
            txtPaid.Clear();
            txtRenewal.Clear();
            txtSerialID.Clear();
        }//end clear button

        private void btnPrevious_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }//end previous button
    }
}
