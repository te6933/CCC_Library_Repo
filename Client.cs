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
    
    public partial class Client : Form
    {
        //Declare a string connection
        string connstr = WindowsFormsApplication1.Utility.GetConnectionString();

        //Declare a client constructor
        public Client()
        {
            InitializeComponent();
        }//end constructor

        //Clear Button click
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear_method();
        }//end clear button

        private void clear_method()
        {
            txtCardId.Clear();
            txtPrfx.Clear();
            txtFirstName.Clear();
            txtSufx.Clear();
            txtLastName.Clear();
            txtMi.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtCity.Clear();
            txtZip.Clear();
            txtDob.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtCardIssueDate.Clear();
            set_Default_State("");
        }//end clear button
        
        //Add button click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Set up and run stored procedure only if Customer Name is present.
            if (isNotCardId())
            {
                if (isFirstName())
                {
                    if (isLastName())
                    {
                        string cmdString = "INSERT INTO ClientListTable (CustomerPrefix, CustomerFirstName, CustomerMiddleInitial, CustomerLastName, CustomerSuffix, CustomerAddress1, CustomerAddress2, CustomerCity, CustomerState, CustomerZip, CustomerPhoneNumber, CustomerEMailAddress, CustomerDateOfBirth, CardIssueDate) VALUES (@val1, @val2, @val3, @val4, @val5, @val6, @val7, @val8, @val9, @val10, @val11, @val12, @val13, @val14)";
                        //string connString = "Data Source=6DC09V1\\SQLEXPRESS;Initial Catalog=TeamLibrary;Integrated Security=True";
                        string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";
                        //string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";

                        using (SqlConnection conn = new SqlConnection(connString))
                        {
                            SqlCommand comm = new SqlCommand(cmdString, conn);
                            comm.Parameters.AddWithValue("@val1", txtPrfx.Text);
                            comm.Parameters.AddWithValue("@val2", txtFirstName.Text);
                            comm.Parameters.AddWithValue("@val3", txtMi.Text);
                            comm.Parameters.AddWithValue("@val4", txtLastName.Text);
                            comm.Parameters.AddWithValue("@val5", txtSufx.Text);
                            comm.Parameters.AddWithValue("@val6", txtAddress1.Text);
                            comm.Parameters.AddWithValue("@val7", txtAddress2.Text);
                            comm.Parameters.AddWithValue("@val8", txtCity.Text);
                            comm.Parameters.AddWithValue("@val9", cbState.SelectedValue.ToString());
                            comm.Parameters.AddWithValue("@val10", txtZip.Text);
                            comm.Parameters.AddWithValue("@val11", txtPhone.Text);
                            comm.Parameters.AddWithValue("@val12", txtEmail.Text);
                            comm.Parameters.AddWithValue("@val13", txtDob.Text);
                            comm.Parameters.AddWithValue("@val14", DateTime.Now.Date);

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
                            }//end try
                            catch
                            {
                                //A simple catch.
                                MessageBox.Show("Record could not be created. Please try again");
                            }//end catch
                            finally
                            {
                                //Close the connection.
                                conn.Close();
                            }//end finally
                        }
                    }//end last name if
                }//end first name if
            }//end card id if
        }//end add button click

        //Verify card ID is blank
        private bool isNotCardId()
        {
            if (txtCardId.Text != "")
            {
                MessageBox.Show("Client ID will be automoatically generated, please leave this field blank.");
                return false;
            }//end if
            else
            {
                return true;
            }//end else
        }//end card id boolean

        //Verify that Client ID and name is present.
        private bool isCardId()
        {
            if (txtCardId.Text == "")
            {
                MessageBox.Show("Please enter a card id.");
                return false;
            }//end if
            else
            {
                return true;
            }//end else
        }//end card id boolean

        private bool isFirstName()
        {
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("Please enter a first name.");
                return false;
            }//end if
            else
            {
                return true;
            }//end else
        }//end firstName boolean

        private bool isLastName()
        {
            if (txtLastName.Text == "")
            {
                MessageBox.Show("Please enter a last name.");
                return false;
            }//end if
            else
            {
                return true;
            }//end else
        }//end lastName boolean

        // Return to main menu.
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            screen_Load();
        }

        private void screen_Load()
        {// TODO: This line of code loads data into the 'teamLibraryDatabaseDataSet2.ClientListTable' table. You can move, or remove it, as needed.
            this.clientListTableTableAdapter.Fill(this.teamLibraryDatabaseDataSet2.ClientListTable);
            // TODO: This line of code loads data into the 'teamLibraryDatabaseDataSet1.StateCodeTable' table. You can move, or remove it, as needed.
            this.stateCodeTableTableAdapter.Fill(this.teamLibraryDatabaseDataSet1.StateCodeTable);
            // Set State Dropdown to appropriate value for displayed field.
            set_Default_State("");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are You Sure You Want To Delete This Record?",
            "Important Question",
            MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                string cmdString = "DELETE FROM ClientListTable WHERE LibraryCardId = " + "@val1";
                //string connString = "Data Source=6DC09V1\\SQLEXPRESS;Initial Catalog=TeamLibrary;Integrated Security=True";
                string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";
                //string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand comm = new SqlCommand(cmdString, conn);
                    comm.Parameters.AddWithValue("@val1", txtCardId.Text);
                    string cardNumber = txtCardId.Text;

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
                        MessageBox.Show("Library Card # " + cardNumber + " was deleted.");
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

        }

        private void cbClientLookup_Enter(object sender, EventArgs e)
        {
            if ((cbClientLookup.SelectedValue != null) && !string.IsNullOrEmpty(cbClientLookup.SelectedValue.ToString()))  
            {
                string CardId = cbClientLookup.SelectedValue.ToString();
                set_Default_State(CardId);
            }
        }

        private void cbClientLookup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbClientLookup.SelectedValue != null) && !string.IsNullOrEmpty(cbClientLookup.SelectedValue.ToString()))  
            {
                string CardId = cbClientLookup.SelectedValue.ToString();
                set_Default_State(CardId);
            }
        }

        // Make sure correct state is showing in state selection drop down.
        private void set_Default_State(string CardId)
        {
            if (string.IsNullOrEmpty(CardId))
            {
                CardId = "1";
            }
            string cmdString = "SELECT CustomerState FROM ClientListTable WHERE LibraryCardId = " + CardId; //@val1";
            //string connString = "Data Source=6DC09V1\\SQLEXPRESS;Initial Catalog=TeamLibrary;Integrated Security=True";
            string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";
            //string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";
            string stateResult = " ";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand comm = new SqlCommand(cmdString, conn);
                //comm.Parameters.AddWithValue("@val1", CardId);
                // try-catch-finally
                try
                {
                    //Open the connection.
                    conn.Open();
                    //Run the stored procedure.
                    stateResult = ((string)comm.ExecuteScalar());
                }//end try
                catch
                {
                    // Default to Nebraska on error.
                    stateResult = "NE";
                } //end catch
                finally
                {
                    //Close the connection.
                    conn.Close();
                } // end finally
            }

            cbState.SelectedValue = stateResult;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Save Changes?",
            "Important Question",
            MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                string cmdString = "UPDATE ClientListTable SET CustomerPrefix = @val1, CustomerFirstName = @val2, " +
                                   " CustomerMiddleInitial = @val3, CustomerLastName = @val4, CustomerSuffix = @val5, " +
                                   " CustomerAddress1 = @val6, CustomerAddress2 = @val7, CustomerCity = @val8, " +
                                   " CustomerState = @val9, CustomerZip = @val10, CustomerPhoneNumber = @val11, " +
                                   " CustomerEMailAddress = @val12, CustomerDateOfBirth = @val13 WHERE LibraryCardID = @val14";
                //string connString = "Data Source=6DC09V1\\SQLEXPRESS;Initial Catalog=TeamLibrary;Integrated Security=True";
                string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";
                        //string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand comm = new SqlCommand(cmdString, conn);
                    comm.Parameters.AddWithValue("@val1", txtPrfx.Text);
                    comm.Parameters.AddWithValue("@val2", txtFirstName.Text);
                    comm.Parameters.AddWithValue("@val3", txtMi.Text);
                    comm.Parameters.AddWithValue("@val4", txtLastName.Text);
                    comm.Parameters.AddWithValue("@val5", txtSufx.Text);
                    comm.Parameters.AddWithValue("@val6", txtAddress1.Text);
                    comm.Parameters.AddWithValue("@val7", txtAddress2.Text);
                    comm.Parameters.AddWithValue("@val8", txtCity.Text);
                    comm.Parameters.AddWithValue("@val9", cbState.SelectedValue.ToString());
                    comm.Parameters.AddWithValue("@val10", txtZip.Text);
                    comm.Parameters.AddWithValue("@val11", txtPhone.Text);
                    comm.Parameters.AddWithValue("@val12", txtEmail.Text);
                    comm.Parameters.AddWithValue("@val13", txtDob.Text);
                    comm.Parameters.AddWithValue("@val14", txtCardId.Text);
                    string cardNumber = txtCardId.Text;

                    // try-catch-finally
                    try
                    {
                        //Open the connection.
                        conn.Open();
                        //Run the stored procedure.
                        comm.ExecuteNonQuery();
                        // Refill Lookup dropdown.
                        screen_Load();
                        MessageBox.Show("Library Card # " + cardNumber + " has been saved.");
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
        
        private void txtCardId_TextChanged(object sender, EventArgs e)
        {
            if (txtCardId.Text == "")
            {
                btnDelete.Enabled = false;
                btnSave.Enabled = false;
                btnAdd.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = true;
                btnSave.Enabled = true;
                btnAdd.Enabled = false;
            }
        }
    }
}
