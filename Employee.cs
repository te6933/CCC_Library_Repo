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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear_method();
        }//end clear

        private void clear_method()
        {
            txtEmpAdd1.Clear();
            txtEmpAdd2.Clear();
            txtEmpCity.Clear();
            txtEmpDOB.Clear();
            txtEmpEmail.Clear();
            txtEmpFirstName.Clear();
            txtEmpLastName.Clear();
            txtEmployeeID.Clear();
            txtEmpMI.Clear();
            txtEmpPhone.Clear();
            txtEmpPrefix.Clear();
            txtEmpSuffix.Clear();
            txtEmpZip.Clear();
            set_Default_State("");
        }//end clear button

        private void Employee_Load(object sender, EventArgs e)
        {
            screen_Load();
        }

        private void screen_Load()
        {
            // TODO: This line of code loads data into the 'teamLibraryDatabaseDataSet1.StateCodeTable' table. You can move, or remove it, as needed.
            this.stateCodeTableTableAdapter.Fill(this.teamLibraryDatabaseDataSet1.StateCodeTable);
            // TODO: This line of code loads data into the 'teamLibraryEmployeeDataSet.EmployeeListTable' table. You can move, or remove it, as needed.
            this.employeeListTableTableAdapter.Fill(this.teamLibraryEmployeeDataSet.EmployeeListTable);
            // Set State Dropdown to appropriate value for displayed field.
            set_Default_State("");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Set up and run stored procedure only if Customer Name is present.
            if (isNotCardId())
            {
                if (isFirstName())
                {
                    if (isLastName())
                    {
                        string cmdString = "INSERT INTO EmployeeListTable (EmployeePrefix, EmployeeFirstName, EmployeeMiddleInitial, EmployeeLastName, EmployeeSuffix, EmployeeAddress1, EmployeeAddress2, EmployeeCity, EmployeeState, EmployeeZip, EmployeePhoneNumber, EmployeeEMailAddress, EmployeeDateOfBirth) VALUES (@val1, @val2, @val3, @val4, @val5, @val6, @val7, @val8, @val9, @val10, @val11, @val12, @val13)";
                        //string connString = "Data Source=6DC09V1\\SQLEXPRESS;Initial Catalog=TeamLibrary;Integrated Security=True";
                        string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";
                        //string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";

                        using (SqlConnection conn = new SqlConnection(connString))
                        {
                            SqlCommand comm = new SqlCommand(cmdString, conn);
                            comm.Parameters.AddWithValue("@val1", txtEmpPrefix.Text);
                            comm.Parameters.AddWithValue("@val2", txtEmpFirstName.Text);
                            comm.Parameters.AddWithValue("@val3", txtEmpMI.Text);
                            comm.Parameters.AddWithValue("@val4", txtEmpLastName.Text);
                            comm.Parameters.AddWithValue("@val5", txtEmpSuffix.Text);
                            comm.Parameters.AddWithValue("@val6", txtEmpAdd1.Text);
                            comm.Parameters.AddWithValue("@val7", txtEmpAdd2.Text);
                            comm.Parameters.AddWithValue("@val8", txtEmpCity.Text);
                            comm.Parameters.AddWithValue("@val9", cbState.SelectedValue.ToString());
                            comm.Parameters.AddWithValue("@val10", txtEmpZip.Text);
                            comm.Parameters.AddWithValue("@val11", txtEmpPhone.Text);
                            comm.Parameters.AddWithValue("@val12", txtEmpEmail.Text);
                            comm.Parameters.AddWithValue("@val13", txtEmpDOB.Text);

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are You Sure You Want To Delete This Record?",
            "Important Question",
            MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                string cmdString = "DELETE FROM EmployeeListTable WHERE EmployeeId = " + "@val1";
                //string connString = "Data Source=6DC09V1\\SQLEXPRESS;Initial Catalog=TeamLibrary;Integrated Security=True";
                string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";
                //string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand comm = new SqlCommand(cmdString, conn);
                    comm.Parameters.AddWithValue("@val1", txtEmployeeID.Text);
                    string employeeNumber = txtEmployeeID.Text;

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
                        MessageBox.Show("Employee # " + employeeNumber + " was deleted.");
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Save Changes?",
            "Important Question",
            MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                string cmdString = "UPDATE EmployeeListTable SET EmployeePrefix = @val1, EmployeeFirstName = @val2, " +
                                   " EmployeeMiddleInitial = @val3, EmployeeLastName = @val4, EmployeeSuffix = @val5, " +
                                   " EmployeeAddress1 = @val6, EmployeeAddress2 = @val7, EmployeeCity = @val8, " +
                                   " EmployeeState = @val9, EmployeeZip = @val10, EmployeePhoneNumber = @val11, " +
                                   " EmployeeEMailAddress = @val12, EmployeeDateOfBirth = @val13 WHERE EmployeeId = @val14";
                //string connString = "Data Source=6DC09V1\\SQLEXPRESS;Initial Catalog=TeamLibrary;Integrated Security=True";
                string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";
                //string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand comm = new SqlCommand(cmdString, conn);
                    comm.Parameters.AddWithValue("@val1", txtEmpPrefix.Text);
                    comm.Parameters.AddWithValue("@val2", txtEmpFirstName.Text);
                    comm.Parameters.AddWithValue("@val3", txtEmpMI.Text);
                    comm.Parameters.AddWithValue("@val4", txtEmpLastName.Text);
                    comm.Parameters.AddWithValue("@val5", txtEmpSuffix.Text);
                    comm.Parameters.AddWithValue("@val6", txtEmpAdd1.Text);
                    comm.Parameters.AddWithValue("@val7", txtEmpAdd2.Text);
                    comm.Parameters.AddWithValue("@val8", txtEmpCity.Text);
                    comm.Parameters.AddWithValue("@val9", cbState.SelectedValue.ToString());
                    comm.Parameters.AddWithValue("@val10", txtEmpZip.Text);
                    comm.Parameters.AddWithValue("@val11", txtEmpPhone.Text);
                    comm.Parameters.AddWithValue("@val12", txtEmpEmail.Text);
                    comm.Parameters.AddWithValue("@val13", txtEmpDOB.Text);
                    comm.Parameters.AddWithValue("@val14", txtEmployeeID.Text);
                    string employeeNumber = txtEmployeeID.Text;

                    // try-catch-finally
                    try
                    {
                        //Open the connection.
                        conn.Open();
                        //Run the stored procedure.
                        comm.ExecuteNonQuery();
                        // Refill Lookup dropdown.
                        screen_Load();
                        MessageBox.Show("Employee # " + employeeNumber + " has been saved.");
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

        // Return to main menu.
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
        }//end previous

        private void cbClientLookup_Enter(object sender, EventArgs e)
        {
            if ((cbEmployeeLookup.SelectedValue != null) && !string.IsNullOrEmpty(cbEmployeeLookup.SelectedValue.ToString()))
            {
                string EmployeeId = cbEmployeeLookup.SelectedValue.ToString();
                set_Default_State(EmployeeId);
            }
        }

        private void cbClientLookup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbEmployeeLookup.SelectedValue != null) && !string.IsNullOrEmpty(cbEmployeeLookup.SelectedValue.ToString()))
            {
                string EmployeeId = cbEmployeeLookup.SelectedValue.ToString();
                set_Default_State(EmployeeId);
            }
        }

        // Make sure correct state is showing in state selection drop down.
        private void set_Default_State(string EmployeeId)
        {
            if (string.IsNullOrEmpty(EmployeeId))
            {
                EmployeeId = "1";
            }
            string cmdString = "SELECT EmployeeState FROM EmployeeListTable WHERE EmployeeId = " + EmployeeId; //@val1";
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

        //Verify card ID is blank
        private bool isNotCardId()
        {
            if (txtEmployeeID.Text != "")
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
            if (txtEmployeeID.Text == "")
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
            if (txtEmpFirstName.Text == "")
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
            if (txtEmpLastName.Text == "")
            {
                MessageBox.Show("Please enter a last name.");
                return false;
            }//end if
            else
            {
                return true;
            }//end else
        }//end lastName boolean

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text == "")
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
