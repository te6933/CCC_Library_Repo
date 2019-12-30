using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class InventoryItemMaintenance : Form
    {
        public InventoryItemMaintenance()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear_method();
        }//end clear

        private void clear_method()
        {
            txtItemID.Clear();
            txtCopyNum.Clear();
            txtDays.Clear();  /* Lease Period */
            txtProdTitle.Clear();
            txtPub.Clear();
            txtDesc.Clear();
            txtCopyright.Clear();
            txtPurchDate.Clear();
            txtPurchPrice.Clear();
            txtAuthor.Clear();
            set_Default_Status("");
            set_Default_Prod_Type("");
            set_Default_Cond_code("");
            set_Default_Author("");
        }//end clear button

        // Return to previous screen.
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* Add Inventory Item record */
        private void btnAdd_Click(object sender, EventArgs e)
        {        
            //Set up and run stored procedure only if Serail Id & Copy # & Title are present.
            if (isTitle() && isSerialId() && isCopy())
            {
                string cmdString = "INSERT INTO ItemDescriptionTable (SerialId, CopyNumber, CurrentStatusCode, ProductTypeCode, GeneralConditionCode, ProductTitle, Publisher, BriefDescription, LeasePeriod, MaximumRenewals, CopyrightDate, PurchaseDate, PurchasePrice) VALUES (@val1, @val2, @val3, @val4, @val5, @val6, @val7, @val8, @val9, @val10, @val11, @val12, @val13)";
                string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand comm = new SqlCommand(cmdString, conn);
                    comm.Parameters.AddWithValue("@val1", txtItemID.Text);
                    comm.Parameters.AddWithValue("@val2", txtCopyNum.Text);
                    comm.Parameters.AddWithValue("@val3", cbStatus.SelectedValue.ToString());
                    comm.Parameters.AddWithValue("@val4", cbType.SelectedValue.ToString());
                    comm.Parameters.AddWithValue("@val5", cbCond.SelectedValue.ToString());
                    comm.Parameters.AddWithValue("@val6", txtProdTitle.Text);
                    comm.Parameters.AddWithValue("@val7", txtPub.Text);
                    comm.Parameters.AddWithValue("@val8", txtDesc.Text);
                    comm.Parameters.AddWithValue("@val9", txtDays.Text);
                    comm.Parameters.AddWithValue("@val10", "3");
                    comm.Parameters.AddWithValue("@val11", txtCopyright.Text);
                    comm.Parameters.AddWithValue("@val12", txtPurchDate.Text);
                    comm.Parameters.AddWithValue("@val13", txtPurchPrice.Text);

                    // try-catch-finally
                    //try
                    //{
                        //Open the connection.
                        conn.Open();
                        //Run the stored procedure.
                        comm.ExecuteNonQuery();
                        // Clear Screen Fields.
                        clear_method();
                        // Refill Lookup dropdown.
                        screen_Load();
                    //}//end try
                    //catch
                    //{
                    //    //A simple catch.
                    //    MessageBox.Show("Record could not be created. Please try again");
                    //}//end catch
                    //finally
                    //{
                    //    //Close the connection.
                    //    conn.Close();
                    //}//end finally
                }                    
            }
        }//end add

        /* Delete Item Record */
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are You Sure You Want To Delete This Record?",
            "Important Question",
            MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                string cmdString = "DELETE FROM ItemDescriptionTable WHERE SerialId = " + "@val1" + " and CopyNumber = " + "@val2";
                string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand comm = new SqlCommand(cmdString, conn);
                    comm.Parameters.AddWithValue("@val1", txtItemID.Text);
                    comm.Parameters.AddWithValue("@val2", txtCopyNum.Text);
                    string copyNumber = txtCopyNum.Text;
                    string itemNumber = txtItemID.Text;

                    // try-catch-finally
                    try
                    {
                        //Open the connection.
                        conn.Open();
                        //Run the stored procedure.
                        comm.ExecuteNonQuery();
                        // Clear Screen Fields.
                        clear_method();
                        // Refill Lookup dropdown.
                        screen_Load();
                        MessageBox.Show("Item " + itemNumber + " - " + copyNumber + " was deleted.");
                    }//end try
                    catch
                    {
                        //A simple catch.
                        MessageBox.Show("Record could not be deleted. Please try again");
                    } //end catch
                    finally
                    {
                        //Close the connection.
                        conn.Close();
                    } // end finally
                }
            } //end if
            else
            {
                MessageBox.Show("Record Not Deleted!");
            } //end else
        } //end Title boolean

        /* Save changes to Item Record. */
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Save Changes?",
            "Important Question",
            MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                string cmdString = "UPDATE ItemDescriptionTable SET CurrentStatusCode = @val1, ProductTypeCode = @val2, GeneralConditionCode = @val3, ProductTitle = @val4, Publisher = @val5, BriefDescription = @val6, LeasePeriod = @val7, MaximumRenewals = @val8, CopyrightDate = @val9, PurchaseDate = @val10, PurchasePrice = @val11 " +
                                   " WHERE SerialID = @val12 and CopyNumber = @val13";
                string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand comm = new SqlCommand(cmdString, conn);
                    comm.Parameters.AddWithValue("@val1", cbStatus.SelectedValue.ToString());
                    comm.Parameters.AddWithValue("@val2", cbType.SelectedValue.ToString());
                    comm.Parameters.AddWithValue("@val3", cbCond.SelectedValue.ToString());
                    comm.Parameters.AddWithValue("@val4", txtProdTitle.Text);
                    comm.Parameters.AddWithValue("@val5", txtPub.Text);
                    comm.Parameters.AddWithValue("@val6", txtDesc.Text);
                    comm.Parameters.AddWithValue("@val7", txtDays.Text);
                    comm.Parameters.AddWithValue("@val8", "3");
                    comm.Parameters.AddWithValue("@val9", txtCopyright.Text);
                    comm.Parameters.AddWithValue("@val10", txtPurchDate.Text);
                    comm.Parameters.AddWithValue("@val11", txtPurchPrice.Text);
                    comm.Parameters.AddWithValue("@val12", txtItemID.Text);
                    comm.Parameters.AddWithValue("@val13", txtCopyNum.Text);
                    string copyNumber = txtCopyNum.Text;
                    string itemNumber = txtItemID.Text;
                    // try-catch-finally
                    try
                    {
                        //Open the connection.
                        conn.Open();
                        //Run the stored procedure.
                        comm.ExecuteNonQuery();
                        // Refill Lookup dropdown.
                        screen_Load();
                        MessageBox.Show("Item " + itemNumber + " - " + copyNumber + " has been saved.");
                    }//end try
                    catch
                    {
                        //A simple catch.
                        MessageBox.Show("Record could not be saved. Please try again");
                    } //end catch
                    finally
                    {
                        //Close the connection.
                        conn.Close();
                    } // end finally
                }
            } //end if
            else
            {
                MessageBox.Show("Record Not Saved!");
            } //end else

        }

        private void InventoryItemMaintenance_Load(object sender, EventArgs e)
        {
            screen_Load();
        }

        private void screen_Load()
        {
            // TODO: This line of code loads data into the 'teamLibraryAuthorPerItemDatabaseDataSet.AuthorsPerItemTable' table. You can move, or remove it, as needed.
            //this.authorsPerItemTableTableAdapter.Fill(this.teamLibraryAuthorPerItemDatabaseDataSet.AuthorsPerItemTable);
            // TODO: This line of code loads data into the 'teamLibraryConditionDatabaseDataSet.GeneralConditionTable' table. You can move, or remove it, as needed.
            this.generalConditionTableTableAdapter.Fill(this.teamLibraryConditionDatabaseDataSet.GeneralConditionTable);
            // TODO: This line of code loads data into the 'teamLibraryDatabaseDataSet4.ProductTypeTable' table. You can move, or remove it, as needed.
            this.productTypeTableTableAdapter.Fill(this.teamLibraryProductTypeDataSet.ProductTypeTable);
            // TODO: This line of code loads data into the 'teamLibraryDatabaseDataSet3.StatusCodeTable' table. You can move, or remove it, as needed.
            this.statusCodeTableTableAdapter.Fill(this.teamLibraryStatCodeDataSet.StatusCodeTable);
            // TODO: This line of code loads data into the 'teamLibraryInvItemDataSet.ItemDescriptionTable' table. You can move, or remove it, as needed.
            this.itemDescriptionTableTableAdapter.Fill(this.teamLibraryInvItemDataSet1.ItemDescriptionTable);
            set_Default_Status("");
            set_Default_Prod_Type("");
            set_Default_Cond_code("");
            set_Default_Author("");
        }

        //Verify that SerialId is present.
        private bool isSerialId()
        {
            if (txtItemID.Text == "")
            {
                MessageBox.Show("Please enter a Serial Id.");
                return false;
            }//end if
            else
            {
                return true;
            }//end else
        }

        //Verify that Product Title is present.
        private bool isCopy()
        {
            if (txtCopyNum.Text == "")
            {
                MessageBox.Show("Please enter a CopyNumber");
                return false;
            }//end if
            else
            {
                return true;
            }//end else
        }

        //Verify that Product Title is present.
        private bool isTitle()
        {
            if (txtProdTitle.Text == "")
            {
                MessageBox.Show("Please enter a Product Title.");
                return false;
            }//end if
            else
            {
                return true;
            }//end else
        }

        // Make sure correct status is showing in the status selection drop down.
        private void set_Default_Status(string ValFld)
        {
            int @statusCode;

            if (string.IsNullOrEmpty(ValFld))
            {
                @statusCode = 1;
            }
            else
            {
                int @serial = ValFld.IndexOf('~',0);
                int @copy = ValFld.IndexOf('~',@serial+1);
                int @status = ValFld.IndexOf('~',@copy+1);
                int @prodType = ValFld.IndexOf('~',@status+1);
                @statusCode = Int16.Parse(ValFld.Substring(@copy + 1, (@status - @copy) - 1));
            }
            cbStatus.SelectedValue = @statusCode;
        }

        // Make sure Product Type is showing in the product type selection drop down.
        private void set_Default_Prod_Type(string ValFld)
        {
            int @prodTypeCode;

            if (string.IsNullOrEmpty(ValFld))
            {
                @prodTypeCode = 1;
            }
            else
            {
                int @serial = ValFld.IndexOf('~', 0);
                int @copy = ValFld.IndexOf('~', @serial + 1);
                int @status = ValFld.IndexOf('~', @copy + 1);
                int @prodType = ValFld.IndexOf('~', @status + 1);
                @prodTypeCode = Int16.Parse(ValFld.Substring(@status + 1, (@prodType - @status) - 1));
            }
            cbType.SelectedValue = @prodTypeCode;

        }

        // Make sure Condition Code is showing in condition selection drop down.
        private void set_Default_Cond_code(string ValFld)
        {
            int @conditionCode;

            if (string.IsNullOrEmpty(ValFld))
            {
                @conditionCode = 1;
            }
            else
            {
                int @serial = ValFld.IndexOf('~', 0);
                int @copy = ValFld.IndexOf('~', @serial + 1);
                int @status = ValFld.IndexOf('~', @copy + 1);
                int @prodType = ValFld.IndexOf('~', @status + 1);
                int @genCond = ValFld.Length;
                @conditionCode = Int16.Parse(ValFld.Substring(@prodType + 1, (@genCond - @prodType) - 1));
            }
            cbCond.SelectedValue = @conditionCode;
        }

        // Make sure the correct Author(s) is/are showing in Author field.
        private void set_Default_Author(string ValFld)
        {
            string @serialCode;
            int @copyCode;

            if (string.IsNullOrEmpty(ValFld))
            {
                @serialCode = "ABC";
                @copyCode = 1;
            }
            else
            {
                int @serial = ValFld.IndexOf('~', 0);
                int @copy = ValFld.IndexOf('~', @serial + 1);
                int @status = ValFld.IndexOf('~', @copy + 1);
                int @prodType = ValFld.IndexOf('~', @status + 1);
                int @genCond = ValFld.Length;
                @serialCode = ValFld.Substring(0, @serial);
                @copyCode = Int16.Parse(ValFld.Substring(@copy+1, (@status - @copy) - 1));
            }
            string cmdString = "SELECT  AuthorsTable.AuthorLastName + ', ' + AuthorsTable.AuthorFirstName AS AuthorName " +
                               "FROM ItemDescriptionTable " + 
                               "LEFT JOIN AuthorsPerItemTable " +
                               "  ON AuthorsPerItemTable.SerialId = ItemDescriptionTable.SerialId " + 
                               " AND AuthorsPerItemTable.CopyNumber = ItemDescriptionTable.CopyNumber " +
                               "LEFT JOIN AuthorsTable " + 
                               "  ON AuthorsTable.AuthorID = AuthorsPerItemTable.AuthorID " +
                               "WHERE ItemDescriptionTable.SerialId = @genCond " +
                               "  AND ItemDescriptionTable.CopyNumber = @copyCode";
           string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";
           string authorResult = " ";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand comm = new SqlCommand(cmdString, conn);

                // try-catch-finally
                try
                {
                    //Open the connection.
                    conn.Open();
                    //Run the stored procedure.
                    authorResult = ((string)comm.ExecuteScalar());
                }//end try
                catch
                {
                    // Default to Nebraska on error.
                    authorResult = "1";
                } //end catch
                finally
                {
                    //Close the connection.
                    conn.Close();
                } // end finally
            }

            txtAuthor.Text = authorResult;
        }

        private void cbInvLookup_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((cbInvLookup.SelectedValue != null) && !string.IsNullOrEmpty(cbInvLookup.SelectedValue.ToString()))
            {
                string ValFld = cbInvLookup.SelectedValue.ToString();
                set_Default_Status(ValFld);
                set_Default_Prod_Type(ValFld);
                set_Default_Cond_code(ValFld);
                set_Default_Author(ValFld);
            }
        }

        private void cbInvLookup_Enter(object sender, EventArgs e)
        {
            if ((cbInvLookup.SelectedValue != null) && !string.IsNullOrEmpty(cbInvLookup.SelectedValue.ToString()))
            {
                string ValFld = cbInvLookup.SelectedValue.ToString();
                set_Default_Status(ValFld);
                set_Default_Prod_Type(ValFld);
                set_Default_Cond_code(ValFld);
                set_Default_Author(ValFld);
            }
        }

    }
}

//        private void InventoryItemMaintenance_Load(object sender, EventArgs e)
//        {
//            // TODO: This line of code loads data into the 'teamLibraryConditionDatabaseDataSet.GeneralConditionTable' table. You can move, or remove it, as needed.
//            this.generalConditionTableTableAdapter.Fill(this.teamLibraryConditionDatabaseDataSet.GeneralConditionTable);
//            // TODO: This line of code loads data into the 'teamLibraryProductTypeDataSet.ProductTypeTable' table. You can move, or remove it, as needed.
//            this.productTypeTableTableAdapter.Fill(this.teamLibraryProductTypeDataSet.ProductTypeTable);
//            // TODO: This line of code loads data into the 'teamLibraryStatCodeDataSet.StatusCodeTable' table. You can move, or remove it, as needed.
//            this.statusCodeTableTableAdapter.Fill(this.teamLibraryStatCodeDataSet.StatusCodeTable);
//            // TODO: This line of code loads data into the 'teamLibraryInvItemDataSet1.ItemDescriptionTable' table. You can move, or remove it, as needed.
//            this.itemDescriptionTableTableAdapter.Fill(this.teamLibraryInvItemDataSet1.ItemDescriptionTable);
//        }//end previous
//    }
//}
