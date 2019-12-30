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
    public partial class StatusCode : Form
    {
        public StatusCode()
        {
            InitializeComponent();
        }

        /* Clear Screen */
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear_method();
        }//end clear

        private void clear_method()
        {
            txtStatusCode.Clear();
            txtDescription.Clear();
        }//end clear button

        /* Add Status Code */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Set up and run stored procedure only if Customer Name is present.
            if (isDesc())
            {
                string cmdString = "INSERT INTO StatusCodeTable (StatusDescription) VALUES (@val1)";
                string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand comm = new SqlCommand(cmdString, conn);
                    comm.Parameters.AddWithValue("@val1", txtDescription.Text);

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
            }//end card id if
        }

        /* Delete Status Code */
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are You Sure You Want To Delete This Record?",
               "Important Question",
               MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                string cmdString = "DELETE FROM StatusCodeTable WHERE CurrentStatusCode = " + "@val1";
                string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand comm = new SqlCommand(cmdString, conn);
                    comm.Parameters.AddWithValue("@val1", txtStatusCode.Text);
                    string StatCode = txtStatusCode.Text;

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
                        MessageBox.Show("Product Type Code " + StatCode + " was deleted.");
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

        /* Save changes to Status Code */
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Save Changes?",
            "Important Question",
            MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                string cmdString = "UPDATE StatusCodeTable SET StatusDescription = @val1 " +
                                   " WHERE CurrentStatusCode = @val2";
                string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TeamLibraryDatabase.mdf;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand comm = new SqlCommand(cmdString, conn);
                    comm.Parameters.AddWithValue("@val1", txtDescription.Text);
                    comm.Parameters.AddWithValue("@val2", txtStatusCode.Text);
                    string StatCode = txtStatusCode.Text;

                    // try-catch-finally
                    try
                    {
                        //Open the connection.
                        conn.Open();
                        //Run the stored procedure.
                        comm.ExecuteNonQuery();
                        // Refill Lookup dropdown.
                        screen_Load();
                        MessageBox.Show("Product Type code " + StatCode + " has been saved.");
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

        /* Return to previous screen */
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StatusCode_Load_1(object sender, EventArgs e)
        {
            screen_Load();
        }

        private void screen_Load()
        {
            // TODO: This line of code loads data into the 'teamLibraryDatabaseDataSet3.StatusCodeTable' table. You can move, or remove it, as needed.
            this.statusCodeTableTableAdapter.Fill(this.teamLibraryStatusDatabaseDataSet.StatusCodeTable);
        }

        //Verify that a Description is present.
        private bool isDesc()
        {
            if (txtDescription.Text == "")
            {
                MessageBox.Show("Please enter a Descriptioin.");
                return false;
            }//end if
            else
            {
                return true;
            }//end else
        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
