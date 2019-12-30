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

    public partial class AuthorsBasicData : Form
    {

        public AuthorsBasicData()
        {
            InitializeComponent();
        }

        // Clear screen to allow data to be entered for add. 
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear_method();
        }//end clear

        private void clear_method()
        {
            txtAuthID.Clear();
            txtAuthorFirst.Clear();
            txtAuthLast.Clear();
        }

        // Add Author Record
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Set up and run stored procedure only if Customer Name is present.
            if (isNotCardId())
            {
                if (isFirstName())
                {
                    if (isLastName())
                    {
                        string cmdString = "INSERT INTO AuthorsTable (AuthorFirstName, AuthorLastName) VALUES (@val1, @val2)";
                        string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";

                        using (SqlConnection conn = new SqlConnection(connString))
                        {
                            SqlCommand comm = new SqlCommand(cmdString, conn);
                            comm.Parameters.AddWithValue("@val1", txtAuthorFirst.Text);
                            comm.Parameters.AddWithValue("@val2", txtAuthLast.Text);

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

        // Delete Employee Record.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are You Sure You Want To Delete This Record?",
            "Important Question",
            MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                string cmdString = "DELETE FROM AuthorsTable WHERE AuthorId = " + "@val1";
                string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand comm = new SqlCommand(cmdString, conn);
                    comm.Parameters.AddWithValue("@val1", txtAuthID.Text);
                    string authorNumber = txtAuthID.Text;

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
                        MessageBox.Show("Author # " + authorNumber + " was deleted.");
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

        // Save changes to Author record.
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Save Changes?",
            "Important Question",
            MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                string cmdString = "UPDATE AuthorsTable SET AuthorFirstName = @val1, AuthorLastName = @val2 " +
                                   " WHERE AuthorID = @val3";
                string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand comm = new SqlCommand(cmdString, conn);
                    comm.Parameters.AddWithValue("@val1", txtAuthorFirst.Text);
                    comm.Parameters.AddWithValue("@val2", txtAuthLast.Text);
                    comm.Parameters.AddWithValue("@val3", txtAuthID.Text);
                    string AuthorNumber = txtAuthID.Text;

                    // try-catch-finally
                    try
                    {
                        //Open the connection.
                        conn.Open();
                        //Run the stored procedure.
                        comm.ExecuteNonQuery();
                        // Refill Lookup dropdown.
                        screen_Load();
                        MessageBox.Show("Author # " + AuthorNumber + " has been saved.");
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
        }

        private void AuthorsBasicData_Load(object sender, EventArgs e)
        {
            screen_Load();
        }

        private void screen_Load()
        {
            // TODO: This line of code loads data into the 'teamLibraryAuthorsDataSet.AuthorsTable' table. You can move, or remove it, as needed.
            this.authorsTableTableAdapter.Fill(this.teamLibraryAuthorsDataSet.AuthorsTable);
        }

        //Verify card ID is blank
        private bool isNotCardId()
        {
            if (txtAuthID.Text != "")
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
            if (txtAuthID.Text == "")
            {
                MessageBox.Show("Please enter an Author id.");
                return false;
            }//end if
            else
            {
                return true;
            }//end else
        }//end card id boolean

        private bool isFirstName()
        {
            if (txtAuthorFirst.Text == "")
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
            if (txtAuthLast.Text == "")
            {
                MessageBox.Show("Please enter a last name.");
                return false;
            }//end if
            else
            {
                return true;
            }//end else
        }//end lastName boolean

        private void txtAuthID_TextChanged(object sender, EventArgs e)
        {
            if (txtAuthID.Text == "")
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